using AprobacionGastos.Models;

namespace AprobacionGastos.Handlers
{
    public class PresidenteHandler : AprobadorBase
    {
        public override void ProcesarSolicitud(SolicitudGasto solicitud)
        {
            Console.WriteLine($"Presidente aprueba la solicitud de gasto #{solicitud.Id} por ${solicitud.Monto}");
        }
    }
}