using RestWithASPNET.Model;
using System.Collections.Generic;

namespace RestWithASPNET.Service.Implementations
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindByID(long id);
        List<Person> FindAll();
        Person Update(Person person);
        Person Delete(long id);
    }
}
