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

        public async Task<IEnumerable<Assistance>> GetAssistance()
        {

            var assistance = Enumerable.Range(1, 10).Select(x => new Assistance
            {
                Hour = x
            }
            );

            await Task.Delay(10);
            return assistance;
        }


        public async Task<Boolean> AssistanceRegister(Assistance assistance)
        {
            await Task.Delay(10);
            return true;
        }


        public string getToken()
        {
            AssistanceService assistanceService = new AssistanceService();

            String strResponse = assistanceService.getToken();

            return strResponse;
        }


        /*public string get_employed(string word)
        {
            AssistanceService assistanceService = new AssistanceService();

            String strResponse = assistanceService.giveme_workbeat_generic(word);

            return strResponse;
        }

        public string get_empleado(string word)
        {
            AssistanceService assistanceService = new AssistanceService();

            String strResponse = assistanceService.giveme_workbeat_empleados(word);  // servicio lista de empleados

            return strResponse;
        }

        public string get_persona(string word, string npr)
        {
            AssistanceService assistanceService = new AssistanceService();

            String strResponse = assistanceService.giveme_workbeat_persona(word, npr); // servicio y parametro persona

            return strResponse;
        }


        public string checando(string id, string fechora, string disid, string direccion)
        {
            AssistanceService assistanceService = new AssistanceService();

            String strResponse = assistanceService.Checando(id, fechora, disid, direccion); // servicio y parametro persona

            return strResponse;
        }*/

        //////////////////////// metodos biostar ///////////////////////////////
        public string Token_bio()
        {
            AssistanceService assistanceService = new AssistanceService();
            String strResponse = assistanceService.token_bio(); // servicio y parametro persona
            return strResponse;
        }

        /*public string User_bio()
        {
            AssistanceService assistanceService = new AssistanceService();
            String strResponse = assistanceService.user_bio(); // servicio y parametro persona
            return strResponse;
        }

        public string Event_search_bio()
        {
            AssistanceService assistanceService = new AssistanceService();
            String strResponse = assistanceService.event_search_bio(); // servicio y parametro persona
            return strResponse;
        }

        public string Device_bio()
        {
            AssistanceService assistanceService = new AssistanceService();
            String strResponse = assistanceService.device_bio(); // servicio y parametro persona
            return strResponse;
        }*/


        public string Checando_tok(string id, string fechora, string disid, string direccion, string tk_beat)
        {
            AssistanceService assistanceService = new AssistanceService();
            String strResponse = assistanceService.Checando_tok(id, fechora, disid, direccion, tk_beat); // servicio y parametro persona
            return strResponse;
        }

        public string[] bio_event_search(string tk_bio)
        {
            AssistanceService assistanceService = new AssistanceService();
            String[] strResponse = assistanceService.bio_event_search(tk_bio); // servicio y parametro persona
            return strResponse;
        }

        public string[] registrando_bio_beat()
        {
            AssistanceService assistanceService = new AssistanceService();
            String[] strResponse = assistanceService.registrando_bio_beat(); // servicio y parametro persona
            return strResponse;
        }


    }
}
