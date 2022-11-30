using MVC_LAB.Models.Person;

namespace MVC_LAB.Services
{
    public interface IPersonService
    {
        public List<PersonModel> GetPersons();
    }
}
