using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Praksa.DAL.Repositories;
using Praksa.DAL.ViewModel;
using Praksa.Repositories.Repositories;
using praksa_rent.Domain;


namespace praksa_rent.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ReviewController : Controller
    {
        private readonly IReviewRepository _reviewRepository;

        public ReviewController(IReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var reviews = await _reviewRepository.GetReviews();
            return Ok(reviews);
        }



    }
}