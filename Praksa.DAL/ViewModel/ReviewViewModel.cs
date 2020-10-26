using praksa_rent.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Praksa.DAL.ViewModel
{
    public class ReviewViewModel
    {
        public ReviewViewModel(IReadOnlyCollection<Review> reviews)
        {
            Collection = reviews.Select(review => new ReviewDto(review)).ToList();
        }
        public IReadOnlyCollection<ReviewDto> Collection { get; }
    }
}
