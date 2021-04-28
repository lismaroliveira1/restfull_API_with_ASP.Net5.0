using System.Collections.Generic;
using restfull_API_with_ASP.Net5._0.model;
using restfull_API_with_ASP.Net5._0.Repository;

namespace restfull_API_with_ASP.Net5._0.Business.Implementations
{
    public class PersonServiceImplementation : IPersonBusiness

    {
        private readonly IPersonRepository _repository;


       public PersonServiceImplementation (IPersonRepository personRepository) {

            _repository = personRepository;
        }

       public Person Create(Person person) {
            _repository.Create(person);
            return person;
        }

        List<Person> IPersonBusiness.FindAll()
        {
            return _repository.FindAll();
        }

        public Person FindByID(long id) {
            return _repository.FindByID(id);
        }

        public Person Update(Person person)
        {
            return _repository.Update(person);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);

        }
    }
}
    

