using K2_Betterware_Assistance_Scheduler.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using K2_Betterware_Assistance_Scheduler.Core.Interfaces;
using System.Threading.Tasks;
using K2_Betterware_Assistance_Scheduler.Infraestructure.Service;

namespace K2_Betterware_Assistance_Scheduler.Infraestructure.Repositories
{
    public class AssistanceRepository : IRepository
    {




        public string getToken()
        {
            AssistanceService assistanceService = new AssistanceService();

            String strResponse = assistanceService.getToken();

            return strResponse;
        }


        
        //////////////////////// metodos biostar ///////////////////////////////
        public string Token_bio()
        {
            AssistanceService assistanceService = new AssistanceService();
            String strResponse = assistanceService.token_bio(); // servicio y parametro persona
            return strResponse;
        }

        
        public string Checando_tok(string id, string fechora, string disid, string direccion, string tk_beat)
        {
            AssistanceService assistanceService = new AssistanceService();
            String strResponse = assistanceService.Checando_tok(id, fechora, disid, direccion, tk_beat); // servicio y parametro persona
            return strResponse;
        }

        public string[] bio_event_search(string f_ini, string f_nal, string limit, string type,string tk_bio)
        {
            AssistanceService assistanceService = new AssistanceService();
            String[] strResponse = assistanceService.bio_event_search(f_ini,f_nal,limit,type,tk_bio); // servicio y parametro persona
            return strResponse;
        }

        public string[] registrando_bio_beat(string f_ini, string f_nal, string limit, string type)
        {
            AssistanceService assistanceService = new AssistanceService();
            String[] strResponse = assistanceService.registrando_bio_beat(f_ini,f_nal,limit,type); // servicio y parametro persona
            return strResponse;
        }


    }
}
