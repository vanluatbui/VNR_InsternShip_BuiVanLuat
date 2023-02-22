using Microsoft.AspNetCore.Mvc;
using VNR_InsternShip_BuiVanLuat.Data;

namespace VNR_InsternShip_BuiVanLuat.Controllers
{
    public class KhoaHocController : Controller
    {
        private ApplicationDbContext _dbContext;

         public KhoaHocController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public ActionResult KhoaHoc()
        {
            var listKhoaHoc = _dbContext.KhoaHocs.ToList();
            return View(listKhoaHoc);
        }

        public ActionResult MonHoc(int IDKhoaHoc)
        {
            var khoahoc = _dbContext.KhoaHocs.Where(p => p.ID == IDKhoaHoc);

            if (khoahoc == null)
            {
                var listKhoaHoc = _dbContext.KhoaHocs.ToList();
                return RedirectToAction("KhoaHoc", listKhoaHoc);
            }

            ViewBag.TenKhoaHoc = khoahoc.FirstOrDefault().TenKhoaHoc;

            var listMonHoc = _dbContext.MonHocs.Where(p => p.KhoaHocID == IDKhoaHoc).ToList();
            return View(listMonHoc);
        }
    }
}
