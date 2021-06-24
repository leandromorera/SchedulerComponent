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
            { orchesting = "Debe ingresar fecha de entrada, fecha de salida, limite de registros y tipo de registro"; }
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
