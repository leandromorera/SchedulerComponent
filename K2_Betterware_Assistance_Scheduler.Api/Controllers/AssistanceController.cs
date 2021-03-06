using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using K2_Betterware_Assistance_Scheduler.Core.Interfaces;
using K2_Betterware_Assistance_Scheduler.Infraestructure.Repositories;

using System.Configuration;
using System.Collections.Specialized;
using System.Timers;
using Quartz;
using Quartz.Impl;



namespace K2_Betterware_Assistance_Scheduler.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssistanceController : ControllerBase
    {
        private readonly IRepository _repository;

        


        public AssistanceController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetAssistance(string f_ini, string f_nal, string limit, string type)
        {
            dynamic orchesting;


            if (f_ini == null || f_nal == null || limit == null || type == null)
            { orchesting = "Error;  debe ingresar fecha de inicio, fecha final, limite de registros y tipo de registro por ejemplo: https://localhost:44354/api/Assistance?df27f4c5b655409bb94c471e5c314aba&f_ini=\"2021-06-20T10:26:57\"&f_nal=\"2021-06-20T20:26:57\"&limit=\"51\"&type=\"4867\""; }
            else 
            { orchesting = _repository.registrando_bio_beat(f_ini, f_nal, limit, type);}

           //var orchesting = _repository.registrando_bio_beat(f_ini, f_nal, limit, type);

            //return Ok(assistance+"WWWWWWWWWWWWWWWWWWWW_"+ emp_resp_empl+"WWWWWWWWWWWWWWWWWWWWW_"+ emp_resp_per+"WWWWWWWWWWWWWWWWWWWW_"+response_check+"BBBBBBBBBBBBBBBBBBB_"+ tk_bio + "BBBBBBBBBBBBBBBB_"+ Usr_bio + "BBBBBBBBBBBBBBB_"+ Ev_bio + "BBBBBBBBBBBBBBBBBBB_"+ Dev_bio);
            return Ok(orchesting);


        }

        

        /// <summary>
        /// Componente de temporizacion;
        /// </summary>
        /*
        public void Program()
        {
            // timer to call MyMethod() every minutes 
            System.Timers.Timer timer = new System.Timers.Timer(TimeSpan.FromMinutes(2).TotalMilliseconds);
            timer.AutoReset = true;
            timer.Elapsed += new System.Timers.ElapsedEventHandler(Continue);
            timer.Start();
        }

        public void Continue(object sender, ElapsedEventArgs e)
        {
            var orchesting = _repository.registrando_bio_beat();
        }*/







    }
}
