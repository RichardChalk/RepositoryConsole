﻿using RepositoryConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryConsole.Services
{
    public class PersonRepositoryNew : IRepository
    {
        private readonly List<Person> _people = new List<Person>();
        private int _nextId = 1;
        public void Add(Person person)
        {
            person.Id = _nextId++;
            _people.Add(person);
            Console.WriteLine("Nu använder jag det nya Repository!");
        }

        public Person GetById(int id)
        {
            return _people.First(p => p.Id == id);
        }

        public List<Person> GetAll()
        {
            return _people.ToList();
        }

        public void Update(Person person)
        {
            var existingPerson = GetById(person.Id);
            if (existingPerson != null)
            {
                existingPerson.Name = person.Name;
            }
        }
    }
}
