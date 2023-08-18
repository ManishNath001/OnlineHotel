using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using OnlineHotel.BLL;
using OnlineHotel.ViewModels;

namespace OnlineHotelWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RoomTypeController : Controller
    {
        private ApplicationDbContext _context;
        public RoomTypeController(ApplicationDbContext context)
        {
            _context= context;
        }
        public IActionResult Index()
        {
            var roomTypeList=_context.RoomTypes.ToList();
            List<RoomTypeViewModel> vm = new List<RoomTypeViewModel>();
            foreach (var item in roomTypeList) 
            {
                vm.Add(new RoomTypeViewModel { Name = item.Name });
            }
            return View(vm);
        }
        public IActionResult Edit()
        {
            //var roomType=
            return View();
        }
    }
}
