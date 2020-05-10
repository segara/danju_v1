using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOASampleCS.model
{
    class TradeData
    {
        public string itemCode;
        public double curPrice;
        public int time;
        public double volume;

        public TradeData(string _itemCode, double _curPrice, int _time, double _volume)
        {
            this.itemCode = _itemCode;
            this.curPrice = _curPrice;
            this.time = _time;
            this.volume = _volume;
        }
    }
}
