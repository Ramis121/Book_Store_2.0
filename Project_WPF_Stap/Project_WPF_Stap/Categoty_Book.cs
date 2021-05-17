using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_WPF_Stap
{
    public class Categoty_Book : BaseViewModel
    {
        public string name_Book;
        public int years;
        public int price;

        public string Name_Book
        {
            get => name_Book;
            set => SetValue(ref name_Book, value);
        }
        public int Years 
        {
            get => years;
            set => SetValue(ref years, value);
        }
        public int Price
        {
            get => price;
            set => SetValue(ref price, value); 
        }
    }
}
