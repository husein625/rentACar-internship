using praksa_rent.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Praksa.DAL.ViewModel
{
   public class ReviewDto
    {
        public ReviewDto()
        {

        }

        public ReviewDto(Review review)
        {
            Id = review.Id;
            Rating = review.Rating;
            Comment = review.Comment;
            BookingId = review.BookingId;
        }

        public int Id { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public int BookingId { get; set; }
    }

}
