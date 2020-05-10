using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOASampleCS.model
{
    class StockItemElementMgr
    {
        private static StockItemElementMgr stockItemElement;
        private static object lockObject = new object();

        public Dictionary<string, Dictionary<double, ConclusionInfo>> stockDictionary; //<종목코드,<거래량, 체결정보>>
        public Dictionary<double, ConclusionInfo> conclusionDictionary; //<거래량, 체결정보>>

        public string selectedStockCode; //현재 그리드 뷰에 보여지고 있는 종목코드

        public event EventHandler<MonitorStockOdd> OnReceiveStockOddHandler;
        public event EventHandler<MonitorStockOdd> OnReceiveStockOddColoringHandler; //관심종목의 단주포착 색깔변경

        public static StockItemElementMgr GetInstance()
        {
            lock(lockObject)
            {
                if(stockItemElement == null)
                {

                    stockItemElement = new StockItemElementMgr();


                }
                return stockItemElement;
            }
        }
        private StockItemElementMgr()
        {
            stockDictionary = new Dictionary<string, Dictionary<double, ConclusionInfo>>();
        }

        public void ThreadPoolCallBack(object data)
        {
            TradeData tradeData = (TradeData)data;
            AddInfo(tradeData.itemCode, tradeData.curPrice, tradeData.volume, tradeData.time);
        }

        public void AddInfo(string itemcode, double price, double volume, int time)
        {
            try
            {
                lock (lockObject)
                {
                    if (stockDictionary.ContainsKey(itemcode))
                    {
                        if (stockDictionary.ContainsKey(itemcode))
                        {
                            stockDictionary[itemcode][volume].AddTransaction(price, volume, time);
                        }
                        else
                        {
                            ConclusionInfo transactionInfo = new ConclusionInfo(itemcode, price, volume, time);
                            stockDictionary[itemcode].Add(volume, transactionInfo);
                        }
                    }
                    else
                    {
                        ConclusionInfo transactionInfo = new ConclusionInfo(itemcode, price, volume, time);
                        conclusionDictionary = new Dictionary<double, ConclusionInfo>();
                        conclusionDictionary.Add(volume, transactionInfo);
                        stockDictionary.Add(itemcode, conclusionDictionary);

                    }
                }
            } catch (Exception e)
            {
                Console.WriteLine("exception : " + e);
            }
            
        }

        public class ConclusionInfo
        {
            private const int DANJU_COUNT_CHECKER = 3;
            private const int TIME_GAP_MIN = 30; //second
            private const int TIME_GAP_MAX = 900;//second
            public int idx;
            public string itemCode;
            public double volume;
            public double time;
            private double priceSum;
            public List<int> conclusionTimeList;

            public Dictionary<int, StockOddLotInfo> continuosInfoDic; //단주주기사전
            public Dictionary<int, int> continuosTempDic; //단주주기 임시사전 //키:주기 , 값:반복횟수
            private StockItemElementMgr stockItemElementMgr = StockItemElementMgr.GetInstance();

            public ConclusionInfo(string _itemcode, double _price, double _volume, int _time)
            {
                idx = 0;
                itemCode = _itemcode;
                this.priceSum = _price * _volume;
                this.volume = _volume;
                this.time = _time;
                conclusionTimeList = new List<int>();
                conclusionTimeList.Add(_time);
                continuosInfoDic = new Dictionary<int, StockOddLotInfo>();
                continuosTempDic = new Dictionary<int, int>();
                continuosTempDic.Add(0, 1);

            }

            public void AddTransaction(double price, double volume, int time)
            {
                if (conclusionTimeList.Contains(time))
                {
                    return;
                }
                idx++;
                this.priceSum = price * volume;
                conclusionTimeList.Add(time);
                CalculatePeriod();
            }

            private void CalculatePeriod()
            {
                int middle_time_conclusion = (conclusionTimeList[idx] + conclusionTimeList[0]) / 2;
                for (int i = idx - 1; i >= 0 && conclusionTimeList[i] >= middle_time_conclusion; --i)
                {
                    int time_gap = conclusionTimeList[idx] - conclusionTimeList[i];
                    if (time_gap >= TIME_GAP_MIN && time_gap <= TIME_GAP_MAX)
                    {
                        int expectTime = conclusionTimeList[i] - time_gap;
                        if (conclusionTimeList.Contains(expectTime))
                        {
                            IncrementTransectionData(time_gap, time_gap, conclusionTimeList[idx], conclusionTimeList[i]);
                            break;
                        }
                        else if (conclusionTimeList.Contains(expectTime - 1))
                        {
                            IncrementTransectionData(time_gap, time_gap + 1, conclusionTimeList[idx], conclusionTimeList[i]);
                            break;
                        }
                        else if (conclusionTimeList.Contains(expectTime + 1))
                        {
                            IncrementTransectionData(time_gap, time_gap - 1, conclusionTimeList[idx], conclusionTimeList[i]);
                            break;
                        }
                    }
                }
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="time_gap">시차</param>
            /// <param name="time_gap_updownValue">비슷한시차</param>
            /// <param name="lastConclusionTimeValue">최근체결시간</param>
            /// <param name="beforeConclusionTimeValue">바로직전체결시간</param>
            private void IncrementTransectionData(int time_gap, int time_gap_updownValue, int lastConclusionTimeValue, int beforeConclusionTimeValue)
            {
                int cycle; //주기
                //시차(time_gap)와 비슷한 시차를 비교
                if (time_gap != time_gap_updownValue) 
                {
                    Console.WriteLine("시차 != 비슷한 시차");
                    if (continuosTempDic.ContainsKey(time_gap) && !continuosTempDic.ContainsKey(time_gap_updownValue)) //전달받은 시차는 존재, 비슷한 시차는 없음
                    {
                        cycle = time_gap;
                        continuosTempDic[cycle] += 1;
                    }
                    else if (!continuosTempDic.ContainsKey(time_gap) && continuosTempDic.ContainsKey(time_gap_updownValue))//전달받은 시차 없음, 비슷한 시차는 존재
                    {
                        cycle = time_gap_updownValue;
                        continuosTempDic[cycle] += 1;
                    }
                    else if (continuosTempDic.ContainsKey(time_gap) && continuosTempDic.ContainsKey(time_gap_updownValue))//전달받은 시차 존재, 비슷한 시차 존재
                    {
                        cycle = time_gap;
                        continuosTempDic[cycle] += 1;
                    }
                    else
                    {
                        //전달받은 시차 없음, 비슷한 시차 없음
                        cycle = time_gap;
                        continuosTempDic.Add(cycle, 2);
                    }
                }
                else
                {
                    if (continuosTempDic.ContainsKey(time_gap) == false)
                    {
                        if (continuosTempDic.ContainsKey(time_gap - 1))
                        {
                            cycle = time_gap - 1;
                            continuosTempDic[cycle] += 1;
                        }
                        else
                        {
                            cycle = time_gap;
                            continuosTempDic.Add(cycle, 2);
                        }
                    }
                    else
                    {
                        cycle = time_gap;
                        continuosTempDic[cycle] += 1;
                    }
                }
                //반복이 3회 이상인 경우 단주로 진단
                if (continuosTempDic[cycle] > DANJU_COUNT_CHECKER)
                {
                    Console.WriteLine("단주 3회 이상 포착 : " + itemCode);
                    //처음 등록일 경우
                    if (!continuosInfoDic.ContainsKey(cycle))
                    {
                        int firstConclusionTime = lastConclusionTimeValue - (cycle * 3); //최근체결시간 - (주기*3)
                        double sumPriceSumAll = priceSum * 4; //누적거래대금
                        StockOddLotInfo stockOddLotInfo = new StockOddLotInfo(continuosTempDic[cycle], lastConclusionTimeValue, firstConclusionTime, sumPriceSumAll);
                        continuosInfoDic.Add(cycle, stockOddLotInfo);
                    }
                    else //추가되는 경우
                    {
                        if(continuosInfoDic[cycle].lastConclusionTime <= beforeConclusionTimeValue)
                        {
                            continuosInfoDic[cycle].repeatCnt += 1;
                            continuosInfoDic[cycle].lastConclusionTime = lastConclusionTimeValue;
                            continuosInfoDic[cycle].sumConclusionQnt += priceSum;
                        }
                        
                    }
                    if(stockItemElement.selectedStockCode != null && stockItemElement.selectedStockCode.Equals(itemCode))
                    {
                        stockItemElementMgr.OnReceiveStockOddHandler?.Invoke(this, new MonitorStockOdd(itemCode));
                    }
                    stockItemElement.OnReceiveStockOddColoringHandler?.Invoke(this, new MonitorStockOdd(itemCode));

                }
            }
        }
    }
    
}
