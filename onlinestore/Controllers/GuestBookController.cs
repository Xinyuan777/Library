using System;
using System.Linq;
using System.Web.Mvc;

namespace onlinestore.Controllers
{
    public class GuestBookController : Controller
    {   
        //GET: GuestBook
        Models.Model1 db = new Models.Model1();
        public ActionResult Index()
        {
            var varMessageData = db.MessageData_Tb;
            return View(varMessageData);
        }

        public ActionResult Create()
        {
            return View();
        }
        public ActionResult CreateSave(Models.MessageData_Cs objMessageData_Val)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Create");
            }
            db.MessageData_Tb.Add
            (
                new Models.MessageData_Tb()
                {
                    No_F = objMessageData_Val.No_P,
                    UserID_From_F = objMessageData_Val.UserID_From_P,
                    Email_F = objMessageData_Val.Email_P,
                    Content_F = objMessageData_Val.Content_P,
                    IsSecret_F = objMessageData_Val.IsSecret_P,
                    JoinTime_F = DateTime.Now
                }
            );
            db.SaveChanges();
            TempData["LastPostGuestbookFormData"] = objMessageData_Val;
            return RedirectToAction("Result");
        }

        public ActionResult Edit(int id)
        {
            var varMessageData = db.MessageData_Tb.Where(p => p.No_F == id).First();
            return View(varMessageData);
        }
        [HttpPost]
        public ActionResult EditSave(Models.MessageData_Tb objMessageData_Val)
        {
            int intNo = objMessageData_Val.No_F;
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Edit", new { id = intNo });
            }
            var varMessageData = db.MessageData_Tb.Where(p => p.No_F == intNo).First();
            varMessageData.UserID_From_F = objMessageData_Val.UserID_From_F;
            varMessageData.Email_F = objMessageData_Val.Email_F;
            varMessageData.Content_F = objMessageData_Val.Content_F;
            varMessageData.JoinTime_F = objMessageData_Val.JoinTime_F;
            varMessageData.IsSecret_F = objMessageData_Val.IsSecret_F;
            db.SaveChanges();
            TempData["LastPostGuestbookFormData"] = objMessageData_Val;
            return RedirectToAction("Result");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var varMessageData = db.MessageData_Tb.Where(p => p.No_F == id).First();
            db.MessageData_Tb.Remove(varMessageData);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            var varMessageData = db.MessageData_Tb.Where(p => p.No_F == id).First();
            return View(varMessageData);
        }
        public ActionResult Result()
        {
            if (TempData["LastPostGuestbookFormData"] == null)
            {
                return RedirectToAction("Index");
            }

            var varMessageData = (Models.MessageData_Cs)TempData["LastPostGuestbookFormData"];
            return View(varMessageData);
        }
    }
}
       
