namespace PremiacionDeportiva.Models
{
    public class Premio
    {
        // Aquí defino el tipo de premio y el evento donde se otorgó
        public string Tipo { get; set; }
        public string Evento { get; set; }

        // En el constructor inicializo los datos del premio
        public Premio(string tipo, string evento)
        {
            Tipo = tipo;
            Evento = evento;
        }
    }
}