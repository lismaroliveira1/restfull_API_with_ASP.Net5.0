using System.Collections.Generic;
using restfull_API_with_ASP.Net5._0.model;

namespace restfull_API_with_ASP.Net5._0.Repository
{
    public interface IPersonRepository
    {
        Person Create(Person person);
        Person FindByID(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);
        bool Exists(long ig);
    }
}
