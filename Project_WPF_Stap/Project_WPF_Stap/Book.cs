using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_WPF_Stap
{
    public class Book
    {
        public Book()
        {
            Dictionary<int, Categoty_Book> keyValuePairs = new Dictionary<int, Categoty_Book>();

            keyValuePairs.Add(1, new Categoty_Book() { Name_Book = "Black Sun" , Price = 100, Years = 2015});
            keyValuePairs.Add(2, new Categoty_Book() { Name_Book = "Приключения какашки", Price = 120, Years = 2020 });
            keyValuePairs.Add(3, new Categoty_Book() { Name_Book = "Глазами Волка", Price = 150, Years = 2019 });

            foreach(KeyValuePair<int, Categoty_Book> key in keyValuePairs)
            {

            }

        }
    }
}
