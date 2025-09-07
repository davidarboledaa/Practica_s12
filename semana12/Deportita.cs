namespace PremiacionDeportiva.Models
{
    public class Deportista
    {
        // Aquí defino las propiedades básicas del deportista
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public Disciplina Disciplina { get; set; }
        public Premio Premio { get; set; }

        // En este constructor inicializo los datos del deportista
        public Deportista(int id, string nombre, int edad, Disciplina disciplina, Premio premio)
        {
            Id = id;
            Nombre = nombre;
            Edad = edad;
            Disciplina = disciplina;
            Premio = premio;
        }
    }
}