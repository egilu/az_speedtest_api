﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpeedTestApi.Models;
using SpeedTestApi.Services;


namespace SpeedTestApi.Controllers
{
    //[Route("api/[controller]")]


    [Route("[controller]")]
    [ApiController]
    public class SpeedTestController : ControllerBase
    {

        private readonly ISpeedTestEvents _eventHub;

        public SpeedTestController(ISpeedTestEvents eventHub)
        {
            _eventHub = eventHub;
        }

       // public SpeedTestController()
        //{

        //}



        // GET speedtest/ping
        [Route("ping")]
        [HttpGet]
        public ActionResult<string> Ping()
        {

	        Console.WriteLine("PONG");
            return Ok("PONG-Azure72");

        }

//public async Task<Actio

        [HttpPost]
        public async Task<ActionResult<string>> UploadSpeedTest([FromBody] TestResult speedTest)
        {

       // public async Task<ActionResult<string>> UploadSpeedTest([FromBody] string speedTest)
       // {
            await _eventHub.PublishSpeedTest(speedTest);

          
            //speedTest.User = "Kommer fra Azure 2018";
          //  Console.WriteLine("---------------------------");
          //  Console.WriteLine("ok");
         //   Console.WriteLine("---------------------------");

            //var speedTestEx = $"Got a TestResult retur fra API-24/11/2018"; 
            //speedTest = "jada";
            return Ok(speedTest);
        }







        //public ActionResult<string> UploadSpeedTest([FromBody] TestResult speedTest)
        //{
        //    var speedTestData = $"Got a TestResult from { speedTest.User } with download { speedTest.Data.Speeds.Download } Mbps.";

        //    return Ok(speedTestData);
        //}



        //// GET api/values
        //[HttpGet]
        //public ActionResult<IEnumerable<string>> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/values/5
        //[HttpGet("{id}")]
        //public ActionResult<string> Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
