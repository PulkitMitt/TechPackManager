using Microsoft.AspNetCore.Mvc;
using TechPackManager.Data; // Replace with your namespace
using TechPackManager.Models; // Replace with your namespace
using System.Linq;

namespace TechPackManager.Controllers
{

    [Route("[controller]/[action]")]
    public class MaterialsController : Controller
    {
        private readonly AppDbContext _context;

        public MaterialsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Index
        public IActionResult Index()
        {
            // Fetch data for Type and Unit from the database
            ViewBag.Types = _context.TblTypes.ToList(); // Fetch all types
            ViewBag.Units = _context.TblUnits.ToList(); // Fetch all units

            // Fetch existing material records
            var materials = _context.TblMaterials.ToList();
            return View(materials);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(TblMaterial material)
        {
            if (ModelState.IsValid)
            {
                // Add the material to the database
                _context.TblMaterials.Add(material);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            // Log errors for debugging
            foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
            {
                // You can log these errors, or return them to the view for debugging
                Console.WriteLine(error.ErrorMessage);
            }

            // If there are validation errors, return to the Index page
            return RedirectToAction("Index");
        }



        // POST: /Materials/Edit
        [HttpPost]
        public IActionResult Edit(TblMaterial material)
        {
            if (ModelState.IsValid)
            {
                _context.TblMaterials.Update(material);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(nameof(Index), _context.TblMaterials.ToList());
        }

        // POST: /Materials/Delete
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var material = _context.TblMaterials.Find(id);
            if (material != null)
            {
                _context.TblMaterials.Remove(material);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
