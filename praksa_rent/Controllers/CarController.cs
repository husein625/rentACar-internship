using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Praksa.DAL.ViewModel;
using Praksa.Repositories.Repositories;
using praksa_rent.Domain;


namespace praksa_rent.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CarController : Controller
    {
        private readonly ICarRepository _carRepository;

        public CarController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var cars = await _carRepository.GetCars();
            return Ok(cars);
        }

        [HttpPost]
        public async Task<IActionResult> Save([FromBody] CarDto car)
        {
            var id = await _carRepository.SaveCar(car);
            return Ok(id);
        }

        [HttpPut]
        public async Task Edit(int carId, [FromBody] CarDto car)
        {
            await _carRepository.EditCar(carId, car);

        }

    }
}