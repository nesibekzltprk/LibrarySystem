namespace LibrarySystem.Models
{
    public class Member
    {
        public int Id { get; set; }           // Primary Key
        public string Name { get; set; } = string.Empty;   // Üye Adı
        public string Email { get; set; }     // Email
        public string Password { get; set; }  // Şifre (hashlenmiş saklanmalı)

        public DateTime DateBirth { get; set; }

        public string TelNo { get; set; }

        // Bir üyenin birden fazla rezervasyonu olabilir
        public ICollection<Reservation> Reservations { get; set; }

    }
}
