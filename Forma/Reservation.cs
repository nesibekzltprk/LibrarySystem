﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Forma
{
    public class Reservation
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        // public Member Member { get; set; }
        // public Book Book { get; set; }
        public int BookId { get; set; }
        public DateTime ReservationDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}
