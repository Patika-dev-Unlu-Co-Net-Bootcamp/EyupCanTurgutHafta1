using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using UnluCoBootCamp.Odev1.Api.Models;

namespace UnluCoBootCamp.Odev1.Api.Controllers
{
    [Route("api/animal")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            List<int> list = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
            }

            return Ok(list);
        }

        [HttpGet("{tur}/{id}")]//yapi su sekil : //api/animal/kedi/animalid(mesela 9)
        public IActionResult GetById(string tur,int id)
        {
            return Ok(new { tur=tur, id=id });
        }

        [HttpPost]
        public IActionResult Create([FromForm]Animal animal)//201 kodu gondermem gerek
        {
            return Created("AnimalController",201);
        }

        [HttpPut("{id}")]//Id ile hangi hayvanin bilgisi update ediliyor onu gorebiliyoruz. Aslinda ihtiyacimiz yok ama bize avantaji var
        public IActionResult Update(string id,Animal animal)
        {

            return Ok();
        }

        [HttpDelete("{id}")]//Update gibi burada da hangi hayvan siliniyor onu gorebilmemiz icin id kullandik.
        public IActionResult Delete(string id, Animal animal)
        {

            return Ok();
        }
    }
}
