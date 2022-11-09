using Microsoft.AspNetCore.Mvc;
using PeopleMVC.Models;

namespace PeopleMVC.Controllers
{
    public class AjaxController : Controller
    {
        public IActionResult Index()
        {
            return View(PeopleViewModel.people);
        }

        public IActionResult ShowDetails(string id)
        {
            Person person = PeopleViewModel.people.FirstOrDefault(x => x.Id == id);
            return PartialView("_Person", person);
        }

        public IActionResult Delete(string id)
        {
            Person person = PeopleViewModel.people.FirstOrDefault(x => x.Id == id);
            PeopleViewModel.people.Remove(person);
            return RedirectToAction("Index");
        }

    }
}
