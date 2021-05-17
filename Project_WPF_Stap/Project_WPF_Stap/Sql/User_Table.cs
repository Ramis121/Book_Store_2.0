using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_WPF_Stap
{
    public class User_Table
    {
        public int u_id { get; set; } // id
        public string fnm { get; set; } // ФИО
        public string u_unm { get; set; }
        public string pwd { get; set; } // Пароль
        public string u_qender { get; set; }
        public string u_email { get; set; } // Email
        public int u_contact { get; set; }  // Контакты
    }
}
