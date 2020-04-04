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


        string message = "";
        [HttpGet]

        public IActionResult GetStudents(string orderBy)
        {

            using (var con = new SqlConnection("Data Source=db-mssql;Initial Catalog=s17470;Integrated Security=True"))
            using (var com = new SqlCommand())
            {
                com.Connection = con;
                com.CommandText = "SELECT * FROM Student";

                con.Open();
                var dr = com.ExecuteReader();
                while (dr.Read())
                {
                    var st = new Student();
                    st.IndexNumber = dr["IndexNumber"].ToString();
                    st.FirstName = dr["FirstName"].ToString();
                    st.LastName = dr["LastName"].ToString();
                    st.BirthDate = dr["BirthDate"].ToString();
                    st.IdEnrollment = dr["IdEnrollment"].ToString();
                    message = string.Concat(message, '\n', st.IndexNumber, ", ", st.FirstName, ", ", st.LastName, ", ", st.BirthDate, ", ", st.IdEnrollment);
                }
            }
            return Ok(message);
        }

    }

         



}

            