using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOASampleCS.model
{
    class StockEventArgs : EventArgs
    {
        public MyStockItem myStockItem;
        public StockEventArgs(MyStockItem myStockItem)
        {
            this.myStockItem = myStockItem;
        }
    }
}
