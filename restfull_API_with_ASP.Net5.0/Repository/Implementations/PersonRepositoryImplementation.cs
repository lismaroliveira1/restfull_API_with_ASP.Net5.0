﻿using System;
using System.Collections.Generic;
using System.Linq;
using restfull_API_with_ASP.Net5._0.model;
using restfull_API_with_ASP.Net5._0.model.Context;
using restfull_API_with_ASP.Net5._0.Repository;

namespace restfull_API_with_ASP.Net5._0.Repositor.Implementations
{
    public class PersonRepositoryImplementation : IPersonRepository

    {
        private MySQLContext _context;


       public PersonRepositoryImplementation (MySQLContext context) {

            _context = context;
        }

       public Person Create(Person person) {
            try {
                _context.Add(person);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
            return person;
        }

        public List<Person> FindAll()
        {
            return _context.Persons.ToList();
        }

        public Person FindByID(long id) {
            return _context.Persons.SingleOrDefault(p => p.Id.Equals(id));
        }

        public Person Update(Person person) {
            if (!Exists(person.Id)) return null;
            var result = _context.Persons.SingleOrDefault(p => p.Id.Equals(person.Id));
            if(result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(person);
                    _context.SaveChanges();
                }
                catch (Exception) { throw; }
            }
            
            return person;
        }

        public bool Exists(long id)
        {
            return _context.Persons.Any(p => p.Id.Equals(id));
        }

        public void Delete(long id)
        {
            var result = _context.Persons.SingleOrDefault(p => p.Id.Equals(id));
            if (result != null)
            {
                try
                {
                    _context.Persons.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception) { throw; }
            }

        }
    }
}
    

