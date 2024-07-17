using AprobacionGastos.Handlers;
using AprobacionGastos.Models;

class Program
{
    static void Main(string[] args)
    {
        // Crear la cadena de responsabilidad
        var gerente = new GerenteHandler();
        var director = new DirectorHandler();
        var presidente = new PresidenteHandler();

        gerente.EstablecerSiguiente(director).EstablecerSiguiente(presidente);

        // Crear algunas solicitudes de gasto
        var solicitudes = new List<SolicitudGasto>
        {
            new SolicitudGasto(1, "Materiales de oficina", 800),
            new SolicitudGasto(2, "Equipo de cómputo", 3500),
            new SolicitudGasto(3, "Viaje de negocios", 8000)
        };

        // Procesar las solicitudes
        foreach (var solicitud in solicitudes)
        {
            Console.WriteLine($"Procesando solicitud #{solicitud.Id} por ${solicitud.Monto}");
            gerente.ProcesarSolicitud(solicitud);
            Console.WriteLine();
        }
    }
}