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
        [HttpGet("teknik-servis")]
        public IActionResult TeknikServis(string slug)
        {
            const string fixedSlug = "teknik-servis"; // veritabanındaki slug
            var query = _manager.OpenCloseMenuService.GetServiceWithImagesAndDescription(fixedSlug, false);
            return View("Defulat", query); // -> Views/Hizmetlerimiz/teknik-servis.cshtml

        }
        [HttpGet("teknik-ozellikler")]
        public IActionResult TeknikOzellikler(string slug)
        {
            const string fixedSlug = "teknik-ozellikler"; // veritabanındaki slug
            var query = _manager.OpenCloseMenuService.GetServiceWithImagesAndDescription(fixedSlug, false);
            return View("Defulat", query); // -> Views/Hizmetlerimiz/teknik-servis.cshtml

        }
        [HttpGet("blackout-pergola-tente-kumasi")]
        public IActionResult BlackoutPergolaTenteKumasi(string slug)
        {
            const string fixedSlug = "blackout-pergola-tente-kumasi"; // veritabanındaki slug
            var query = _manager.OpenCloseMenuService.GetServiceWithImagesAndDescription(fixedSlug, false);
            return View("Defulat", query);
        }
        [HttpGet("pergola-tente-teknik-ozellikleri")]
        public IActionResult PergolaTenteTeknikOzellikleri(string slug)
        {
            const string fixedSlug = "pergola-tente-teknik-ozellikleri"; // veritabanındaki slug
            var query = _manager.OpenCloseMenuService.GetServiceWithImagesAndDescription(fixedSlug, false);
            return View("Defulat", query);
        }
        [HttpGet("pergola-tente-imalati-cesitleri")]
        public IActionResult PergolaTenteImalatiCesitleri(string slug)
        {
            const string fixedSlug = "pergola-tente-imalati-cesitleri"; // veritabanındaki slug
            var query = _manager.OpenCloseMenuService.GetServiceWithImagesAndDescription(fixedSlug, false);
            return View("Defulat", query);
        }
        [HttpGet("kullanim-ozellikleri")]
        public IActionResult KullanimOzellikleri(string slug)
        {
            const string fixedSlug = "kullanim-ozellikleri"; // veritabanındaki slug
            var query = _manager.OpenCloseMenuService.GetServiceWithImagesAndDescription(fixedSlug, false);
            return View("Defulat", query);
        }
        [HttpGet("projeler")]
        public IActionResult Projeler(string slug)
        {
            const string fixedSlug = "projeler"; // veritabanındaki slug
            var query = _manager.OpenCloseMenuService.GetServiceWithImagesAndDescription(fixedSlug, false);
            return View("Defulat", query);
        }
        [HttpGet("faydali-bilgiler")]
        public IActionResult FaydaliBilgiler(string slug)
        {
            const string fixedSlug = "faydali-bilgiler"; // veritabanındaki slug
            var query = _manager.OpenCloseMenuService.GetServiceWithImagesAndDescription(fixedSlug, false);
            return View("Defulat", query);
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
