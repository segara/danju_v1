using System;

namespace KOASampleCS.model
{
    public class MonitorStockOdd : EventArgs
    {
        public string itemCode;

        public MonitorStockOdd(string itemCode)
        {
            this.itemCode = itemCode;
        }
    }
}