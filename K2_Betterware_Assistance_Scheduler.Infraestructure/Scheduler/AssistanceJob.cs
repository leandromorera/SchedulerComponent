using K2_Betterware_Assistance_Scheduler.Core.Interfaces;
using K2_Betterware_Assistance_Scheduler.Infraestructure.Repositories;
using K2_Betterware_Assistance_Scheduler.Core.DTOs;
using Quartz;
using System;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

/*namespace K2_Betterware_Assistance.Scheduler.Jobs
{

    public class AssistanceJob : IJob
	{
	public async Task Execute(IJobExecutionContext context)
		{
			await Console.Out.WriteLineAsync("/////////////////////////////////////////////////////////////.");
			await Console.Out.WriteLineAsync("Incio de Job Scheduler Assistance Betterware.");

// 1.- Establecer el rango de Fecha para obtener Eventos del Biometricos.
			Criterios criterios = new Criterios();
			criterios.fechaIni = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
			criterios.fechaFin = DateTime.Now.AddMinutes(5).ToString("yyyy-MM-ddTHH:mm:ss");
			criterios.tipoEvento = "4867";
			Console.WriteLine($"  Fecha Inicio: {criterios.fechaIni}");
			Console.WriteLine($"  Fecha Fin: {criterios.fechaFin}");
			Console.WriteLine($"  Tipo Evento: {criterios.tipoEvento}");

//2.- Obtener los registros de Eventos del Biometrico solo los correspondiente a Face.
			IRepository _repository = new Repository();
			var jsonBiostartEvents = _repository.getBiostartEvents(criterios);

//3.- Convertir Json.
			try
			{
				if (!jsonBiostartEvents.Contains("Error"))
				{
					JObject joResponse = JObject.Parse(jsonBiostartEvents);
					JObject result = (JObject)joResponse["EventCollection"];
					if (typeof(JArray).IsInstanceOfType(result))
					{
						JArray array = (JArray)result["rows"];   
						foreach (JObject j in array)
						{	
							Utils util = new Utils();
							Evento evento = util.getPropiedades(j);

//4.- Realizar el registro de asistencia en Workbeat y almacenar los registros que no se pudieron registrar.
							//_repository.putWorkbeatAssistance(evento);

//5.- Si no se puede insrtar el registro guardarlo en Disco Duro para su posterior procesamiento.


						}


					}
				}
				
			}
			catch (Exception ex)
			{
				Console.WriteLine($"            Error Servicio 1 ");
			}

			await Console.Out.WriteLineAsync("Fin de Proceso Scheduler Assistance Betterware.");
			await Console.Out.WriteLineAsync("/////////////////////////////////////////////////////////////.");
		}
	}


}
*/