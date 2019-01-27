using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_LeahWestern
{
    class Desk
    {
        #region desk description
        public int width { get; set; }
        public int depth { get; set; }
        public int numberOfDrawers { get; set; }
        public Material deskMaterial { get; set; }
        public int productionTime { get; set; }
        public int area { get; set; }
        #endregion

        #region constraints
        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;
        public const int MINDEPTH = 12;
        public const int MAXDEPTH = 48;
        #endregion

        //materials
        public enum Material
        {
            Oak = 200,
            Laminate = 100,
            Pine = 50,
            Rosewood = 300,
            Veneer = 125
        }
    }
}
