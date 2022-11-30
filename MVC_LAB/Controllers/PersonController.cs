using Microsoft.AspNetCore.Mvc;
using MVC_LAB.Models.Person;
using MVC_LAB.Services;

namespace MVC_LAB.Controllers
{
    public class PersonController : Controller
    {
        private readonly ILogger<PersonController> _logger;
        private readonly IPersonService _personService;
        public PersonController(ILogger<PersonController> logger, IPersonService personService)
        {
            _logger = logger;
            _personService = personService;
        }

        public IActionResult Index()
        {
            var model = new PersonViewModel()
            {
                Persons =_personService.GetPersons()
            };
            return View(model);
        }
    }
}
