namespace PremiacionDeportiva.Models
{
    public class Disciplina
    {
        // Aquí defino el nombre y la categoría de la disciplina
        public string Nombre { get; set; }
        public string Categoria { get; set; }

        // En el constructor asigno los valores recibidos
        public Disciplina(string nombre, string categoria)
        {
            Nombre = nombre;
            Categoria = categoria;
        }
    }
}