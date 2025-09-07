using PremiacionDeportiva.Models;
using PremiacionDeportiva.Data;
using System.Collections.Generic;
using System.Linq;

namespace PremiacionDeportiva.Services
{
    public class ReporteService
    {
        private readonly Repositorio _repo;

        // En el constructor recibo el repositorio para acceder a los datos
        public ReporteService(Repositorio repo)
        {
            _repo = repo;
        }

        // Aquí muestro todos los datos de los deportistas
        public void MostrarReporteGeneral()
        {
            var deportistas = _repo.ObtenerDeportistas();

            Console.WriteLine("=== Reporte General de Premiación ===");
            foreach (var d in deportistas)
            {
                Console.WriteLine($"Nombre: {d.Nombre}, Edad: {d.Edad}, Disciplina: {d.Disciplina.Nombre}, Premio: {d.Premio.Tipo} en {d.Premio.Evento}");
            }
        }

        // Agrupo deportistas por disciplina usando un mapa (Dictionary) y conjuntos (HashSet)
        public void MostrarAgrupadosPorDisciplina()
        {
            var deportistas = _repo.ObtenerDeportistas();
            var mapaDisciplina = new Dictionary<string, HashSet<string>>();

            foreach (var d in deportistas)
            {
                string nombreDisciplina = d.Disciplina.Nombre;

                // Si la disciplina no está en el mapa, la agrego
                if (!mapaDisciplina.ContainsKey(nombreDisciplina))
                    mapaDisciplina[nombreDisciplina] = new HashSet<string>();

                // Agrego el nombre del deportista al conjunto correspondiente
                mapaDisciplina[nombreDisciplina].Add(d.Nombre);
            }

            Console.WriteLine("=== Deportistas agrupados por disciplina ===");
            foreach (var kvp in mapaDisciplina)
            {
                Console.WriteLine($"Disciplina: {kvp.Key}");
                foreach (var nombre in kvp.Value)
                {
                    Console.WriteLine($" - {nombre}");
                }
            }
        }

        // Cuento cuántos premios hay de cada tipo usando un mapa
        public void MostrarConteoPremios()
        {
            var deportistas = _repo.ObtenerDeportistas();
            var conteoPremios = new Dictionary<string, int>();

            foreach (var d in deportistas)
            {
                string tipoPremio = d.Premio.Tipo;

                // Si el tipo de premio no está en el mapa, lo inicializo
                if (!conteoPremios.ContainsKey(tipoPremio))
                    conteoPremios[tipoPremio] = 0;

                // Incremento el contador
                conteoPremios[tipoPremio]++;
            }

            Console.WriteLine("=== Conteo de premios por tipo ===");
            foreach (var kvp in conteoPremios)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }

        // Uso un conjunto para mostrar deportistas únicos
        public void MostrarDeportistasUnicos()
        {
            var deportistas = _repo.ObtenerDeportistas();
            var conjuntoNombres = new HashSet<string>();

            foreach (var d in deportistas)
            {
                // Agrego el nombre al conjunto, evitando duplicados
                conjuntoNombres.Add(d.Nombre);
            }

            Console.WriteLine("=== Deportistas únicos registrados ===");
            foreach (var nombre in conjuntoNombres)
            {
                Console.WriteLine(nombre);
            }
        }
    }
}