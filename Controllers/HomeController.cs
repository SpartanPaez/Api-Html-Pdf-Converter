using Api.Clientes.ReporteActualizacionDatos.Models;
using Microsoft.AspNetCore.Mvc;
using SelectPdf;
using System.Diagnostics;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public IViewRenderService _viewRenderService { get; }

        public HomeController(ILogger<HomeController> logger, IViewRenderService viewRenderService)
        {
            _logger = logger;
            _viewRenderService = viewRenderService;
        }

        //[HttpPost]
        [HttpGet("prueba")]
        public async Task<IActionResult> ReturnVista([FromBody] DatosCliente model)
        {

            //return View(model);
            string asd = await _viewRenderService.RenderToStringAsync("Home/Index", model);
           
            var Vista = View(model);
            return GenerarReportePDF(asd);
        }
        [HttpPost("prueba2")]
        public IActionResult Index([FromBody] DatosCliente model)
        {

            return View(model);
            
        }
        public IActionResult GenerarReportePDF(string ReporteHtml)
        {
            HtmlToPdf convertidor = new HtmlToPdf();
            ReporteHtml = ReporteHtml.Replace("start", ">").Replace("end",">");
            PdfDocument reporte = convertidor.ConvertHtmlString(ReporteHtml);
            byte[] pdfFile = reporte.Save();
            return File(pdfFile, "application/pdf");
        }



    }
}