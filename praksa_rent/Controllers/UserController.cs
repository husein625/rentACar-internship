using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Praksa.Repositories.Repositories;

namespace praksa_rent.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var users = await _userRepository.GetTopTen();
            return Ok(users);
        }

        [HttpGet]
        public async Task GetById(int Id)
        {
            var user = await _userRepository.GetById();
        }


    }
}
