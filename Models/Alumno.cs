public class Alumno
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Legajo { get; set; }
    public string Curso { get; set; }
    public int Promedio { get; set; }
    public string Especialidad { get; set; }


    public Alumno(string nombre, string apellido, string legajo, string curso, int promedio, string especialidad)
    {
        Nombre = nombre;
        Apellido = apellido;
        Legajo = legajo;
        Curso = curso;
        Promedio = promedio;
        Especialidad = especialidad;
    }

    public Alumno() {}
}
