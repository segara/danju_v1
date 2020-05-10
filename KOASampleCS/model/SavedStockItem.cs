using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOASampleCS.model
{
    public class MyStockItem
    {
        public Dictionary<string, SavedStockItem> myStockItemDic; //key: itemcode, value : 체결정보
        public MyStockItem()
        {
            myStockItemDic = new Dictionary<string, SavedStockItem>();
        }
    }
    public class SavedStockItem
    {
        public string itemName;
        public double gapPercentage;
        public int gapPrice;
        public double curPrice;
        public double curVolume;
        /// <summary>
        /// 총단주량
        /// </summary>
        public double allDanjuCnt; 
        public double allTradeMoney; //총거래금

        public SavedStockItem(string _itemName, double _gapPercentage, int _gapPrice, double _curPrice, double _curVolume)
        {
            this.itemName = _itemName;
            this.gapPercentage = _gapPercentage;
            this.gapPrice = _gapPrice;
            this.curPrice = _curPrice;
            this.curVolume = _curVolume;
            this.allTradeMoney = 0;
        }
    }
}
