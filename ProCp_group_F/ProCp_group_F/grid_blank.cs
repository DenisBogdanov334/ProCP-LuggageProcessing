using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCp_group_F
{
    public class grid_blank: grid_element
    { 

        public int Id { get; set; }
        public bool Filled { get; set; }

        public grid_blank()
        {
            Id = 0;
            Filled = false;
        }
        public string imagePath()
        {
            if (Filled)
            {
                return "./images/blank.jpg";
            }
            else
            {
                return "./images/blank.jpg";
            }
        }
    }
}
