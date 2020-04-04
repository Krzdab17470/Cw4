using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using APBD_Cw3.DAL;
using APBD_Cw3.Models; //!!!
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using System.Data;



namespace APBD_Cw3.Controllers
{

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
            using (var client = new SqlConnection("Data Source=db-mssql;Initial Catalog=s17470;Integrated Security=True"))
            {

            }
            return Ok(_dbService.GetStudents());
        }

    }



}

            