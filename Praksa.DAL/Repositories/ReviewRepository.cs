using Microsoft.EntityFrameworkCore;
using Praksa.DAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Praksa.DAL.Repositories
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly RentDbContext _rentDbContext;
        public ReviewRepository(RentDbContext rentDbContext)
        {
            _rentDbContext = rentDbContext;

        }
        public async Task<ReviewViewModel> GetReviews(CancellationToken cancellationToken = default)
        {
            var collection = await _rentDbContext.Reviews.ToListAsync(cancellationToken);
            return new ReviewViewModel(collection);
        }
    }
}
