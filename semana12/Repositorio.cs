using PremiacionDeportiva.Models;
using System.Collections.Generic;

namespace PremiacionDeportiva.Data
{
    public class Repositorio
    {
        // Aquí creo una lista de deportistas simulando una base de datos
        private List<Deportista> _deportistas;

        public Repositorio()
        {
            // Primero defino las disciplinas
            var atletismo = new Disciplina("Atletismo", "Individual");
            var natacion = new Disciplina("Natación", "Individual");

            // Luego creo los deportistas con sus respectivos premios
            _deportistas = new List<Deportista>
            {
                new Deportista(1, "Ana Gómez", 23, atletismo, new Premio("Oro", "Juegos Nacionales")),
                new Deportista(2, "Luis Torres", 27, natacion, new Premio("Plata", "Juegos Nacionales")),
                new Deportista(3, "Carlos Ruiz", 21, atletismo, new Premio("Bronce", "Juegos Nacionales")),
                new Deportista(4, "Ana Gómez", 23, atletismo, new Premio("Oro", "Juegos Nacionales")) // Repetido para mostrar uso de conjuntos
            };
        }

        // Este método me permite acceder a la lista de deportistas
        public List<Deportista> ObtenerDeportistas()
        {
            return _deportistas;
        }
    }
}