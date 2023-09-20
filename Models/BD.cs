using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;

public static class BD
{
    public static string _connectionString = @"Server=LOCALHOST;
    Database=GestionAlumnos;Trusted_Connection=True;";

    public static List<Alumno> GetListadoAlumnos()
    {
        List<Alumno> ListadoAlumnos = new List<Alumno>();
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string sql = "SELECT Nombre, Apellido, Legajo, Curso, Especialidad, Promedio FROM Alumnos;";
            ListadoAlumnos = connection.Query<Alumno>(sql).ToList();
        }
        return ListadoAlumnos;
    }

    public static Alumno GetDetalleAlumno(string legajo)
    {
        Alumno alumno = null;
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string sql = "SELECT Nombre, Apellido, Curso, Especialidad, Promedio FROM Alumnos WHERE Legajo = @legajo;";
            alumno = connection.QueryFirstOrDefault<Alumno>(sql, new {legajo});
        }
        return alumno;
    }

    public static List<Alumno> GetMayor6()
    {
        List<Alumno> alumnoAprobado = new List<Alumno>();
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string sql = "SELECT Nombre, Apellido, Curso, Especialidad, Promedio FROM Alumnos WHERE Promedio >= 6";
            alumnoAprobado = connection.Query<Alumno>(sql).ToList();
        }
        return alumnoAprobado;
    }

    public static List<Alumno> GetMenor6()
    {
        List<Alumno> alumnoDesaprobado = new List<Alumno>();
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string sql = "SELECT Nombre, Apellido, Curso, Especialidad, Promedio FROM Alumnos WHERE Promedio < 6;";
            alumnoDesaprobado = connection.Query<Alumno>(sql).ToList();
        }
        return alumnoDesaprobado;
    }
}