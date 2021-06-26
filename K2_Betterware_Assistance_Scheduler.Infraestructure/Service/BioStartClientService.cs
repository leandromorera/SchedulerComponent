
using System.Net;
using System.IO;
using System;
using K2_Betterware_Assistance_Scheduler.Core.DTOs;
using Newtonsoft.Json.Linq;

/*namespace K2_Betterware_Assistance.Infraestructure.Services{
    public class BioStartClientService{
 
        public string getBiostartEvents(Criterios criterios)
        {
            string responseBody = "";
            try
            {
                //string url = "https://localhost:5002/api/Assistance?f_ini=2021-06-20T10:26:57&f_nal=2021-06-20T20:26:57&limit=51&type=4867";
                string url = "https://localhost:5002/api/Assistance?f_ini=" + criterios.fechaIni + "&f_nal=" + criterios.fechaFin + "&limit=51&type=" + criterios.tipoEvento;
                Console.WriteLine($"        URL Biostar:: {url}");
                ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(AcceptAllCertifications);
                var myRequest = (HttpWebRequest)WebRequest.Create(url);
                myRequest.Method = "GET";

                WebResponse response = myRequest.GetResponse();
                Stream strReader = response.GetResponseStream();
                StreamReader objReader = new StreamReader(strReader);
                responseBody = objReader.ReadToEnd().ToString();
                Console.WriteLine($"        Events Biostar:: {responseBody}");

            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                responseBody = "Error:" ;
            }
            return responseBody;
        }

        public string putWorkbeatAssistance(){
            string responseBody = "";
            try
            {
               

            }
            catch (Exception ex)
            {
                responseBody = "Error:";
            }
            return responseBody; 
        }

        public bool AcceptAllCertifications(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certification, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors){
            return true;
        }


    }
}*/

