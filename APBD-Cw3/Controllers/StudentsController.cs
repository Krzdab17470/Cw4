using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using APBD_Cw3.DAL;
using APBD_Cw3.Models; //!!!
using Microsoft.AspNetCore.Mvc;

namespace APBD_Cw3.Controllers
{
    /*
    //ZAD3======================================
    [ApiController]
    [Route("api/students")]

     public class StudentsController : ControllerBase
     {
        [HttpGet]
        public string GetStudent()
        {
            return "Kowalski, Malewski, Andrzejewski";
        }
    }
    */


    /*
    //ZAD4======================================
    [ApiController]
    [Route("api/students")]
    public class StudentsController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            if (id == 1)
            {
                return Ok("Kowalski");
            }
            else if (id == 2)
            {
                return Ok("Malewski");
            }

            return NotFound("Nie znaleziono studenta.");
        }
    }
    */

    /*
   //ZAD5======================================
   [ApiController]
   [Route("api/students")]
   public class StudentsController : ControllerBase
   {
       [HttpGet]
       public string GetStudent(string orderBy)
       {
           return $"Kowalski, Malewski, Andrzejewski sortowanie={orderBy}";
       }
   }
   */


    /*
    //ZAD6======================================
    [ApiController]
    [Route("api/students")]
    //https://localhost:44362/api/students/

    public class StudentsController : ControllerBase
        //ta klasa dziedziczy po ControllerBase
    {
        [HttpPost]
        public IActionResult CreateStudent(Student student)
        //IActionResult zwraca dane np. tekst, JSON, XML itp
        {
            student.IndexNumber = $"s{new Random().Next(1, 20000)}";
            return Ok(student);
        }
    }
    */

    /*
 //ZAD7======================================
 [ApiController]
 [Route("api/students")]
 //https://localhost:44362/api/students/

 public class StudentsController : ControllerBase
     //ta klasa dziedziczy po ControllerBase
 {
     [HttpPut("{id}")]
     public IActionResult putUpdate(int id)
     {
         if (id == 1)
             {
                 //Response.StatusCode = "201";
                 //StatusCode(201);
                 //return new HttpResponseMessage(HttpStatusCode.NotModified);
                 return Ok("Aktualizacja dokończona");

             }
             else
             {
                 return Ok("Blad aktualizacji!");
             }

     }


     [HttpDelete("{id}")]
     public IActionResult delDat(int id)
     {
         if (id == 1)
         {
             return Ok("Usuwanie dokonczone.");

         }
         else
         {
             return Ok("Blad usuwania!");
         }

     }
 }
 */

    //ZAD8======================================
    [ApiController]
    [Route("api/students")]
    //https://localhost:44362/api/students/

    public class StudentsController : ControllerBase
    {
        private readonly IDbService _dbService;

        public StudentsController(IDbService dbService)
        {
            _dbService = dbService;
        }

        [HttpGet]

        public IActionResult GetStudents(string orderBy)
        {
            return Ok(_dbService.GetStudents());
        }
    }
}