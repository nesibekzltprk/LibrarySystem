using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma
{
    public class Member
    {
        public int Id { get; set; }           // Primary Key
        public string Name { get; set; } = string.Empty;   // Üye Adı
        public string Email { get; set; }     // Email
        public string Password { get; set; }  // Şifre (hashlenmiş saklanmalı)

        public DateTime DateBirth { get; set; }

        public string TelNo { get; set; }
    }
}
