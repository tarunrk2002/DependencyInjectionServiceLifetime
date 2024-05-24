using dependency_Injection_service_lifetime.Models;
using dependency_Injection_service_lifetime.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text;

namespace dependency_Injection_service_lifetime.Controllers
{
    public class HomeController : Controller
    {
        private readonly IScopedGuidServices _Scope1;
        private readonly IScopedGuidServices _Scope2;

        private readonly ITransientGuidServices _Transient1;
        private readonly ITransientGuidServices _Transient2;

        private readonly ISingletonGuidServices _Singleton1;
        private readonly ISingletonGuidServices _Singleton2;



        private readonly ILogger<HomeController> _logger;

        public HomeController(IScopedGuidServices scoped1,
                               IScopedGuidServices scoped2,
                               ITransientGuidServices trans1,
                               ITransientGuidServices trans2,
                               ISingletonGuidServices single1,
                               ISingletonGuidServices single2)
        {
            _Scope1= scoped1;
            _Scope2= scoped2;
            _Transient1= trans1;
            _Transient2= trans2;
            _Singleton1= single1;
            _Singleton2= single2;

        }

        public IActionResult Index()
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(_Scope1.GetGuid());
                sb.Append(_Scope2.GetGuid());
                sb.Append(_Transient1);
                sb.Append(_Transient2);
                sb.Append(_Singleton1);
                sb.Append(_Singleton2);

                return Ok(sb.ToString());
            }
            catch (Exception ex)
            {
                ErrorEventArgs args = new ErrorEventArgs(ex);
            }
            return Ok();
            
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
    }
}
