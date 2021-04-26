using System;
using System.Collections.Generic;
using System.Threading;
using restfull_API_with_ASP.Net5._0.model;

namespace restfull_API_with_ASP.Net5._0.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService

    {
        private volatile int count;
        public Person Create(Person person) {
            return person;
        }
       public Person FindByID(long id) {
            return new Person
            {
                Id = IncrementAndGet(),
                FistName = "Lismar",
                LastName = "Oliveira",
                AddressName = "Salvador, Bahia - Brasil",
                Gender = "Male"
            };
        }

        

        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FistName = "Person Name" + i,
                LastName = "Person Last Name" + i,
                AddressName = "Some Address",
                Gender = "Some Name"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }

        public Person Update(Person person) {
            return person;
        }
        

        List<Person> IPersonService.FindAll()
        {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }
            return persons;
        }

        public void Delete(long id)
        {
                        
        }
    }
}
    

