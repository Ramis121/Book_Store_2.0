using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_WPF_Stap
{
    public class Subcat_Table
    {
        public int subcat_id { get; set; } // Категория id
        public int parent_id { get; set; }
        public string subcat_nm { get; set; } // Название категории 
    }
}
