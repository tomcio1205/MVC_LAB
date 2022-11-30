using MVC_LAB.Context;
using MVC_LAB.Models.Person;

namespace MVC_LAB.Services
{
    public class PersonService : IPersonService
    {
        private readonly PersonContext _context;
        public PersonService(PersonContext context)
        {
            _context = context;
        }
        public List<PersonModel> GetPersons()
        {
            return _context.Persons.ToList();
        }
    }
}
