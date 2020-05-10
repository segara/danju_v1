using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AxKHOpenAPILib;
using KOASampleCS.model;

namespace sunsin.controller
{
    class DataController
    {
        private const int VOLUME_UP_BUY = 10;
        private const int VOLUME_UP_SELL = -10;
        private AxKHOpenAPI axKHOpenAPI;
        MyStockItem myStockItem;
        public event EventHandler<StockEventArgs> OnReceiveRealDataHandler;
        StockItemElementMgr stockItemElementMgr;
        public List<double> exceptList;

        public DataController()
        {
            MyStockItem myStockItem = new MyStockItem();
            stockItemElementMgr = StockItemElementMgr.GetInstance();
            exceptList = new List<double>();
        }

        public void SetOpenAPI(AxKHOpenAPI _axKHOpenAPI)
        {
            this.axKHOpenAPI = _axKHOpenAPI;
            this.axKHOpenAPI.OnReceiveRealData += AxKHOpenAPI_OnReceiveRealData;
        }

        public void DisconnectReceiveRealData()
        {
            this.axKHOpenAPI.OnReceiveRealData -= AxKHOpenAPI_OnReceiveRealData;
        }

        public void ReconnectReceiveRealData()
        {
            this.axKHOpenAPI.OnReceiveRealData += AxKHOpenAPI_OnReceiveRealData;
        }

        private void AxKHOpenAPI_OnReceiveRealData(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveRealDataEvent e)
        {
            if(e.sRealType == "주식체결")
            {

                double conclusionVolume = double.Parse(axKHOpenAPI.GetCommRealData(e.sRealType, 15));

                if(exceptList.Contains(conclusionVolume))
                {
                    return;
                }
                int conclusionTime = Int32.Parse(axKHOpenAPI.GetCommRealData(e.sRealType, 20));
                double curPrice = double.Parse(axKHOpenAPI.GetCommRealData(e.sRealType, 10));
                if(curPrice<0)
                {
                    curPrice *= -1;
                }
                int gapPrice = Int32.Parse(axKHOpenAPI.GetCommRealData(e.sRealType, 11));
                double gapPercentage = double.Parse(axKHOpenAPI.GetCommRealData(e.sRealType, 12));
                double allConclusionVolume = double.Parse(axKHOpenAPI.GetCommRealData(e.sRealType, 13));

                int hour = conclusionTime / 10000;
                int minutes = conclusionTime / 100 % 100;
                int second = conclusionTime % 100;
                int realTime = hour * 3600 + minutes * 60 + second;

                if(allConclusionVolume >= VOLUME_UP_BUY || allConclusionVolume <= VOLUME_UP_SELL)
                {
                    ThreadPool.QueueUserWorkItem(StockItemElementMgr.GetInstance().ThreadPoolCallBack, new TradeData(e.sRealKey, curPrice, realTime, conclusionVolume));
                }

                if(myStockItem.myStockItemDic.ContainsKey(e.sRealKey))
                {
                    myStockItem.myStockItemDic[e.sRealKey].curPrice = curPrice;
                    myStockItem.myStockItemDic[e.sRealKey].curVolume = conclusionVolume;
                    myStockItem.myStockItemDic[e.sRealKey].gapPercentage = gapPercentage;
                    myStockItem.myStockItemDic[e.sRealKey].gapPrice = gapPrice;

                }
                else
                {
                    SavedStockItem savedStockItme = new SavedStockItem(axKHOpenAPI.GetMasterCodeName(e.sRealKey), gapPercentage, gapPrice, curPrice, conclusionVolume);
                    myStockItem.myStockItemDic.Add(e.sRealKey, savedStockItme);
                }

                OnReceiveRealDataHandler?.Invoke(this, new StockEventArgs(myStockItem));
            }
        }

        public void ChangeExceptList(int num)
        {
            if(!exceptList.Contains(num))
            {
                exceptList.Add(num);
            }
            else
            {
                exceptList.Remove(num);
            }
        }
    }
}
