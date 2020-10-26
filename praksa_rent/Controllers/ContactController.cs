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
    public class ContactController : Controller
    {
        private readonly IContactRepository _contactRepository;

        public ContactController(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var cars = await _contactRepository.GetContacts();
            return Ok(cars);
        }

    
     
    }
}