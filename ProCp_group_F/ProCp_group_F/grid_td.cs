using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCp_group_F
{
   public class grid_td : grid_element
    {

        public int Id { get; set; }
        public bool Filled { get; set; }

        public grid_td()
        {
            Id = 8;
            Filled = false;
        }
        public string imagePath()
        {
            if (Filled)
            {
                return "./images/td_filled.jpg";
            }
            else
            {
                return "./images/td.jpg";
            }
        }
    }
}
