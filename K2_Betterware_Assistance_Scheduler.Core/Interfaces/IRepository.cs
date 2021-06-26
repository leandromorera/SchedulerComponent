using K2_Betterware_Assistance_Scheduler.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace K2_Betterware_Assistance_Scheduler.Core.Interfaces
{
    public interface IRepository
    {


        string getToken();
        

        string Token_bio();

        string Checando_tok(string id, string fechora, string disid, string direccion, string tk_beat);
        string[] bio_event_search(string tk_bio, string jsonb);
        string[] registrando_bio_beat(string f_ini, string f_nal, string limit, string type);

    }
}
