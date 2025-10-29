using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Services.Contracts;

namespace TekSan.Controllers
{
    [Route("hizmetlerimiz")]
    public class HizmetlerimizController : Controller
    {
        private readonly IServiceManager _manager;
        private readonly ICompositeViewEngine _viewEngine;

        public HizmetlerimizController(IServiceManager manager, ICompositeViewEngine viewEngine)
        {
            _manager = manager;
            _viewEngine = viewEngine;
        }

        // GET /hizmetlerimiz

        public IActionResult Index(bool trackChanges)
        {
            var srv = _manager.OpenCloseMenuService.GetAllService(false);
            var img = _manager.OpenCloseMenuService.GetServiceFirstImageUrl(1); // örnek olarak id=1
            ViewBag.ImageUrl = img;
            return View(srv); // Views/Hizmetlerimiz/Index.cshtml
        }

        // GET /hizmetlerimiz/{slug}
        [HttpGet("{slug}")]
        public IActionResult Detail(string slug, bool trackChanges = false)
        {
            var svc = _manager.OpenCloseMenuService.FindBySlug(slug, trackChanges);
            if (svc is null) return NotFound();

            var viewName = slug; // sadece slug
            if (ViewExists(viewName))
            {
                ViewData["Title"] = svc.Name;
                return View(viewName, svc);
            }

            return View("Detail", svc); // fallback
        }
        [HttpGet("teknik-servis/{id}")]
        public IActionResult TeknikServis(int id)
        {
            var query = _manager.OpenCloseMenuService.FindById(id, false);
            return View("teknik-servis", query); // -> Views/Hizmetlerimiz/teknik-servis.cshtml

        }
        [HttpGet("teknik-ozellikler")]
        public IActionResult TeknikOzellikler()
        {

            return View("teknik-ozellikler"); // -> Views/Hizmetlerimiz/teknik-servis.cshtml

        }
        [HttpGet("blackout-pergola-tente-kumasi")]
        public IActionResult BlackoutPergolaTenteKumasi()
        {
            return View("blackout-pergola-tente-kumasi");
        }
        [HttpGet("pergola-tente-teknik-ozellikleri")]
        public IActionResult PergolaTenteTeknikOzellikleri()
        {
            return View("pergola-tente-teknik-ozellikleri");
        }
        [HttpGet("pergola-tente-imalati-cesitleri")]
        public IActionResult PergolaTenteImalatiCesitleri()
        {
            return View("pergola-tente-imalati-cesitleri");
        }
        [HttpGet("kullanim-ozellikleri")]
        public IActionResult KullanimOzellikleri()
        {
            return View("kullanim-ozellikleri");
        }
        [HttpGet("projeler")]
        public IActionResult Projeler()
        {
            return View("projeler");
        }
        [HttpGet("faydali-bilgiler")]
        public IActionResult FaydaliBilgiler()
        {
            return View("faydali-bilgiler");
        }
        private bool ViewExists(string viewName)
        {
            var rel = _viewEngine.FindView(ControllerContext, viewName, false);
            if (rel.Success) return true;

            var abs = _viewEngine.GetView(null, $"~/Views/Hizmetlerimiz/{viewName}.cshtml", false);
            return abs.Success;
        }
    }
}
