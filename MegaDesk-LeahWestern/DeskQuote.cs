using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_LeahWestern
{
    class DeskQuote
    {
        #region quote description
        private string customerName { get; set; }
        private DateTime quoteDate { get; set; }
        private Desk Desk = new Desk();
        public int rushDays { get; set; }
        private int quoteAmount;
        #endregion

        #region constants
        private const int PRICE_BASE = 200;
        private const int SIZE_LIMIT = 1000;
        private const int PRICE_PER_DRAWER = 50;
        private const int PRICE_PER_AREA = 1;
        private const int RUSH_ADD = 2000;
        #endregion

        public DeskQuote(string customerName, DateTime quoteDate, int width, int depth, int drawers, Desk.Material material, int rushDay)
        {
            customerName = customerName;
            quoteDate = quoteDate;
            Desk.width = width;
            Desk.depth = depth;
            Desk.numberOfDrawers = drawers;
            Desk.deskMaterial = material;
            rushDays = rushDays;

            //calc area and store
            Desk.area = Desk.width * Desk.depth;
        }

        public int CalcQuote()
        {
            return quoteAmount = PRICE_BASE + AreaCost() + DrawerCost() + (int)Desk.deskMaterial + RushCost();
        }

        private int AreaCost()
        {
            //check if area is bigger than size_limit
            if (Desk.area > SIZE_LIMIT)
            {
                return (Desk.area - SIZE_LIMIT) * PRICE_PER_AREA;
            }
            else
            {
                return 0;
            }
        }

        private int DrawerCost()
        {
            int DrawerCost = Desk.numberOfDrawers * PRICE_PER_DRAWER;
            return DrawerCost;
        }

        private int RushCost()
        {
            int rushCost = 0;
            //crazy switch statement for rushday thing
            return rushCost;
        }
    }
}
