using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace finalProject.Models
{
    public class User
    {
        [DisplayName("Id")]
        public int userID { get; set; }
        [DisplayName("Adı")]
        public string userName { get; set; }
        [DisplayName("Soyadı")]
        public string userSurname { get; set; }
        [DisplayName("Email")]
        public string userEmail { get; set; }
        [DisplayName("Şifre")]
        public string userPassword { get; set; }
        [DisplayName("Yetki")]
        public string userRole { get; set; }

    }
}
