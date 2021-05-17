using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_WPF_Stap
{
    public class Book_Table
    {
        public int id { get; set; }
        public string b_subcat { get; set; } //Категория
        public string b_desc { get; set; } //Описания
        public string b_publisher { get; set; } //Издатель
        public string b_isbn { get; set; } // ?
        public string b_page { get; set; } // Страниц
        public string b_price { get; set; } // Сколько стоит
        public string b_img { get; set; } // Image
        public string b_pdf { get; set; } // PDF
    }
}
