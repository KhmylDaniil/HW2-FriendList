using HW2.Interfaces;
using HW2.ViewModels.Friend;
using Microsoft.AspNetCore.Mvc;

namespace HW2.Controllers
{
    public class FriendController : Controller
    {
        readonly IFriendService _friendService;

        public FriendController(IFriendService friendService)
        {
            _friendService = friendService;
        }
        
        // GET: FriendController
        public ActionResult Index()
        {
            return View(_friendService.GetFriends());
        }

        // GET: FriendController/Details/5
        public ActionResult Details(int id)
        {
            var friend = _friendService.Details(id);
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
        public ActionResult Create(CreateFriendRequest request)
        {
            try
            {
                _friendService.CreateFriend(request);
                
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
        public ActionResult Edit(ChangeFriendRequest request)
        {
            try
            {
                _friendService.EditFriend(request);
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
            var friend = _friendService.Details(id);

            return View(friend);
        }

        // POST: FriendController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                _friendService.DeleteFriend(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
