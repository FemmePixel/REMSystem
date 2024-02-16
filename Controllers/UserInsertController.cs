using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateMVC.Models;

namespace RealEstateMVC.Controllers
{
    public class UserInsertController : Controller
    {
        UsersDB dbobj =    new UsersDB();
        // GET: UserInsertController
        public IActionResult Insert_Pageload()
        {
            return View();
        }

        // GET: UserInsertController/Details/5
        [HttpPost]
        public IActionResult Insert_click(Userscls objcls)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string resp = dbobj.InsertDB(objcls);
                    TempData["msg"] = resp;
                }
            }
            catch(Exception ex)
            {
                TempData["msg"] = ex.Message;
            }
            return View("Insert_Pageload", objcls);
        }

        //// GET: UserInsertController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: UserInsertController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: UserInsertController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: UserInsertController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: UserInsertController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: UserInsertController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
