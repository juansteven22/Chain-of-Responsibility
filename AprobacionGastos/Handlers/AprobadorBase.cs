using AprobacionGastos.Models;

namespace AprobacionGastos.Handlers
{
    public abstract class AprobadorBase : IHandler
    {
        protected IHandler _siguienteAprobador;
        protected decimal _limiteAprobacion;

        public IHandler EstablecerSiguiente(IHandler handler)
        {
            _siguienteAprobador = handler;
            return handler;
        }

        public virtual void ProcesarSolicitud(SolicitudGasto solicitud)
        {
            if (_siguienteAprobador != null)
            {
                _siguienteAprobador.ProcesarSolicitud(solicitud);
            }
        }
    }
}