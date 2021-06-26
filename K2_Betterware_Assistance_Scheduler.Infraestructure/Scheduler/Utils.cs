using K2_Betterware_Assistance_Scheduler.Core.Interfaces;
using K2_Betterware_Assistance_Scheduler.Infraestructure.Repositories;
using K2_Betterware_Assistance_Scheduler.Core.DTOs;
using Quartz;
using System;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.IO;

/*namespace K2_Betterware_Assistance.Scheduler.Jobs
{

    public class Utils 
	{
		public Evento getPropiedades(JObject j) {
			
			Evento evento = new Evento();
			foreach (var property in j.Properties())
			{
				//Console.WriteLine($"         Name: {property.Name}  Value: {property.Value}");
				if (property.Name.Equals("datetime"))
				{
					evento.fechaEvento = (string)property.Value;
				}
				else if (property.Name.Equals("user_id"))
				{
					JObject user = (JObject)property.Value;
					evento.idEmpleado = (string)user["user_id"];
				}
				else if (property.Name.Equals("device_id"))
				{
					JObject device = (JObject)property.Value;
					evento.idDispositivo = (string)device["id"];
				}
			}
			Console.WriteLine($"            idEmpleado: {evento.idEmpleado} idDispositivo: {evento.idDispositivo}   fechaEvento: {evento.fechaEvento} ");
			return evento;
		}


		public  void setEventosFileSystem(Evento evento)
		{
			string linea = evento.idEmpleado + "|" + evento.idDispositivo + "|" + evento.fechaEvento ;
			File.AppendAllText("Events.txt", linea);
		}

		public string[] getEventosFileSystem(Evento evento)
		{
			return File.ReadAllLines("Events.txt");
		}

	}

}*/
