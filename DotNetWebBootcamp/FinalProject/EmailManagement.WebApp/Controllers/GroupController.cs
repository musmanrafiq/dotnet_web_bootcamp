using EmailManagement.Models;
using EmailManagement.Services.DataServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmailManagement.WebApp.Controllers
{
    public class GroupController : Controller
    {
        private readonly GroupService _groupService;

        public GroupController(GroupService groupService)
        {
            _groupService = groupService;
        }

        // GET: GroupController
        public ActionResult Index(string? search)
        {
            List<GroupModel> groups = null;
            if (search != null)
            {
               groups =  _groupService.GetSearch(search);
            } else { 
                groups = _groupService.GetAll(); 
            }

            return 
                View(groups);
        }

        // GET: GroupController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GroupController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GroupController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(GroupModel model)
        {
            try
            {
                _groupService.Add(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GroupController/Edit/5
        public ActionResult Edit(int id)
        {
            GroupModel model = _groupService.GetById(id);
            return View(model);
        }

        // POST: GroupController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(GroupModel model)
        {
            try
            {
                _groupService.Update(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GroupController/Delete/5
        public ActionResult Delete(int id)
        {
            _groupService.Remove(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
