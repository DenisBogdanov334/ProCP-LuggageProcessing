using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCp_group_F
{
    public class grid_cur : grid_element
    {

        public int Id { get; set; }
        public bool Filled { get; set; }

        public grid_cur()
        {
            Id = 6;
            Filled = false;
        }
        public string imagePath()
        {
            if (Filled)
            {
                return "./images/cur_filled.jpg";
            }
            else
            {
                return "./images/cur.jpg";
            }
        }
    }
}
