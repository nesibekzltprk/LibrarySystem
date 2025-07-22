namespace LibrarySystem.Models
{
    public class Reservation
    {
        public int Id { get; set; }

        public int MemberId { get; set; }
        public Member Member { get; set; }  

        public int BookId { get; set; }
        public Book Book { get; set; }

        public DateTime ReservationDate { get; set; }
        public DateTime? ReturnDate { get; set; } // İade tarihi, nullable
    }
}
