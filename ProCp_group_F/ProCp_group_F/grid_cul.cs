using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace ProCp_group_F
{
    public class grid_cul : grid_element
    {

        public int Id { get; set; }
        public bool Filled { get; set; }

        public grid_cul()
        {
            Id = 7;
            Filled = false;
        }
        public string imagePath()
        {
            if (Filled)
            {
                return "./images/cul_filled.jpg";
            }
            else
            {
                return "./images/cul.jpg";
            }
        }

    }
}
