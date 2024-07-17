using AprobacionGastos.Models;

namespace AprobacionGastos.Handlers
{
    public class GerenteHandler : AprobadorBase
    {
        public GerenteHandler()
        {
            _limiteAprobacion = 1000;
        }

        public override void ProcesarSolicitud(SolicitudGasto solicitud)
        {
            if (solicitud.Monto <= _limiteAprobacion)
            {
                Console.WriteLine($"Gerente aprueba la solicitud de gasto #{solicitud.Id} por ${solicitud.Monto}");
            }
            else
            {
                base.ProcesarSolicitud(solicitud);
            }
        }
    }
}