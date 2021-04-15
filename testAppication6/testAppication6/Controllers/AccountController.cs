using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace testAppication6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IConfiguration _config;

        public AccountController(IConfiguration configuration)
        {
            _config = configuration;

        }


        [HttpGet]
        public JsonResult Get()
        {
            string query = @"
                    select Acc_ID from dbo.Account";
            DataTable table = new DataTable();
            string sqlDataSourse = _config.GetConnectionString("TestDB");
            SqlDataReader myreader;
            using (SqlConnection mycon = new SqlConnection(sqlDataSourse))
            {
                mycon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, mycon))
                {
                    myreader = myCommand.ExecuteReader();
                    table.Load(myreader); ;

                    myreader.Close();
                    mycon.Close();

                }
            }

            return new JsonResult(table);
        }

    }


}
