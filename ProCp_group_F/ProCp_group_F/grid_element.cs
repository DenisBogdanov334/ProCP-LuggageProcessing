using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCp_group_F
{
    public interface grid_element
    {
        int Id {get; set; }

        bool Filled { get; set; }

        string imagePath();

       
    }
}
