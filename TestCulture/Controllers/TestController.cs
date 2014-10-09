namespace TestCulture.Controllers
{
    using System.Globalization;
    using System.Threading;
    using System.Web.Mvc;
    using TestCulture.Models;

    public class TestController : Controller
    {
        //
        // GET: /Test/

        public ActionResult Index(string culture)
        {
            ////var model = (TestClass)this.TempData["Model"] ?? new TestClass
            ////{
            ////    Amount = 7.50m,
            ////    CreatedAt = DateTime.Now,
            ////};
            var model = (TestClass)this.TempData["Model"] ?? new TestClass();

            if (!string.IsNullOrWhiteSpace(culture))
            {
                model.Culture = culture;

                Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
                Thread.CurrentThread.CurrentCulture = new CultureInfo(culture);
            }

            return View(model);
        }

        [HttpPost]
        public ActionResult TestPost(TestClass model)
        {
            this.TempData["Model"] = model;

            return this.RedirectToAction("Index", new { culture = model.Culture });
        }
    }
}
