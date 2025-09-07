using PremiacionDeportiva.Data;
using PremiacionDeportiva.Services;

class Program
{
    static void Main(string[] args)
    {
        // Aquí creo el repositorio y el servicio de reportería
        var repo = new Repositorio();
        var servicio = new ReporteService(repo);

        // Llamo a los métodos para mostrar los distintos reportes
        servicio.MostrarReporteGeneral();
        Console.WriteLine();
        servicio.MostrarAgrupadosPorDisciplina();
        Console.WriteLine();
        servicio.MostrarConteoPremios();
        Console.WriteLine();
        servicio.MostrarDeportistasUnicos();
    }
}