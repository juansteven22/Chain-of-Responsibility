using AprobacionGastos.Models;

namespace AprobacionGastos.Handlers
{
    public class DirectorHandler : AprobadorBase
    {
        public DirectorHandler()
        {
            _limiteAprobacion = 5000;
        }

        public override void ProcesarSolicitud(SolicitudGasto solicitud)
        {
            if (solicitud.Monto <= _limiteAprobacion)
            {
                Console.WriteLine($"Director aprueba la solicitud de gasto #{solicitud.Id} por ${solicitud.Monto}");
            }
            else
            {
                base.ProcesarSolicitud(solicitud);
            }
        }
    }
}