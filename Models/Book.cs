namespace LibrarySystem.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        
        public string Branch {  get; set; }
        public int Sayfa {  get; set; }
        public int Year { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }

        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }

        public ICollection<Reservation> Reservations { get; set; }
    }
}
