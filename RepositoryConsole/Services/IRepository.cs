using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryConsole.Models;

namespace RepositoryConsole.Services
{
    public interface IRepository
    {
        // Create
        void Add(Person person);

        // Read
        Person GetById(int id);
        List<Person> GetAll();

        // Update
        void Update(Person person);
    }

}
