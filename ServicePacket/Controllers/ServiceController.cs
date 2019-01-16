using Microsoft.AspNetCore.Mvc;
using ServicePacket.Data.Interface;

namespace ServicePacket.Controllers
{
    public class ServiceController : Controller
    {
        
        protected readonly ICategoryRepository _categoryRepository;

        public ServiceController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IActionResult Index()
        {
            var model = _categoryRepository.GetAllWithServices();
            
            return View(model);
        }
    }
}