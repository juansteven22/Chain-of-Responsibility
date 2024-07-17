using AprobacionGastos.Models;

namespace AprobacionGastos.Handlers
{
    public interface IHandler
    {
        IHandler EstablecerSiguiente(IHandler handler);
        void ProcesarSolicitud(SolicitudGasto solicitud);
    }
}