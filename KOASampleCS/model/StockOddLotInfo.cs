using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOASampleCS.model
{
    public class StockOddLotInfo
    {
        public int repeatCnt;
        public int lastConclusionTime;
        public int firstConclusionTime;
        /// <summary>
        /// 누적거래대금
        /// </summary>
        public double sumConclusionQnt;

        public StockOddLotInfo()
        {

        }

        public StockOddLotInfo(int repeatCnt, int lastConclusionTime, int firstConclusionTime, double sumConclusionQnt)
        {
            this.repeatCnt = repeatCnt;
            this.lastConclusionTime = lastConclusionTime;
            this.firstConclusionTime = firstConclusionTime;
            this.sumConclusionQnt = sumConclusionQnt;
        }
    }
}
