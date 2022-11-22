using HW2.Logic;
using Microsoft.AspNetCore.Mvc;

namespace HW2.Controllers
{
    public class FriendController : Controller
    {
        // GET: FriendController
        public ActionResult Index()
        {
            return View(FriendList.Friends);
        }

        // GET: FriendController/Details/5
        public ActionResult Details(int id)
        {
            var friend = FriendList.Friends.FirstOrDefault(x => x.FriendId == id) ?? throw new ArgumentException("no such id");

            return View(friend);
        }

        // GET: FriendController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FriendController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                FriendList.Friends.Add(FriendHandlers.CreateFriend(collection));
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FriendController/Edit/5
        public ActionResult Edit()
        {
            return View();
        }

        // POST: FriendController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                FriendHandlers.EditFriend(id, collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FriendController/Delete/5
        public ActionResult Delete(int id)
        {
            var friend = FriendList.Friends.FirstOrDefault(x => x.FriendId == id) ?? throw new ArgumentException("no such id");

            return View(friend);
        }

        // POST: FriendController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                FriendHandlers.DeleteFriend(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
