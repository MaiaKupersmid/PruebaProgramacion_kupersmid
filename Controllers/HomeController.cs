using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PruebaProgramacion_kupersmid.Models;

namespace PruebaProgramacion_kupersmid.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult Listado()
        {
            List<Alumno> alumnos = BD.GetListadoAlumnos();
            ViewBag.Titulo1 = "Listado de Alumnos";
            ViewBag.Alumnos = alumnos;

            List<Alumno> alumnosNo = BD.GetMenor6();
            List<Alumno> alumnosSi = BD.GetMayor6();

            ViewBag.Titulo3 = "Listado de Alumnos Promedio >= 6";
            ViewBag.Aprobados = alumnosSi;

            ViewBag.Titulo2 = "Listado de Alumnos Promedio <6";
            ViewBag.Desaprobados = alumnosNo;

            return View();
        }
        
        public IActionResult Detalles(string legajo)
        {
            Alumno alumno = BD.GetDetalleAlumno(legajo);
            if (alumno == null)
            {
                return View("GetLegajo");
            }
            ViewBag.Titulo = "Detalles del Alumno";
            ViewBag.Alumno = alumno;
            
            return View();
        }

        public IActionResult GetLegajo()
        {
            return View();
        }
}
