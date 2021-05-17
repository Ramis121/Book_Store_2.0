using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_WPF_Stap
{
    public class ApplicationViewModel : BaseViewModel
    {
        private Categoty_Book Categoty_;
        public ObservableCollection<Categoty_Book> categoty_Book { get; set; }
        public ApplicationViewModel()
        {
            categoty_Book = new ObservableCollection<Categoty_Book> 
            {
                new Categoty_Book{Name_Book = "Black Sun", Price = 12000, Years = 2015},
                new Categoty_Book{Name_Book = "НЕ ТУ ПИ", Price = 5000, Years = 2018},
                new Categoty_Book{Name_Book = "Марсианин", Price = 18000, Years = 2020},
                new Categoty_Book{Name_Book = "Приключения Какашки", Price = 10000},
                new Categoty_Book{Name_Book = "Маленький Принц", Price = 11000},
                new Categoty_Book{Name_Book = "Макс Фрай ", Price = 6000},
                new Categoty_Book{Name_Book = "Hobbit", Price = 22000},
                new Categoty_Book{Name_Book = "Жакомино", Price = 10000},

            };
        }

        public Categoty_Book SelectedPhone
        {
            get => Categoty_; 
            set => SetValue(ref Categoty_, value); 
        }
    }
}
