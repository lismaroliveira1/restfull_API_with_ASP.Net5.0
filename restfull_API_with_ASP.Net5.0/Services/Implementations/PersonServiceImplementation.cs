using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using restfull_API_with_ASP.Net5._0.model;
using restfull_API_with_ASP.Net5._0.model.Context;

namespace restfull_API_with_ASP.Net5._0.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService

    {
        private MySQLContext _context;


       public PersonServiceImplementation (MySQLContext context) {

            _context = context;
        }
       public Person Create(Person person) {
            return person;
        }
       public Person FindByID(long id) {
            return new Person
            {
                Id = 1,
                FistName = "Lismar",
                LastName = "Oliveira",
                AddressName = "Salvador, Bahia - Brasil",
                Gender = "Male"
            };
        }
        public Person Update(Person person) {
            return person;
        }
        

        List<Person> IPersonService.FindAll()
        {
            return _context.Persons.ToList();
        }

        public void Delete(long id)
        {
                        
        }
    }
}
    

