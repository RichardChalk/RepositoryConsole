using RepositoryConsole.Models;
using RepositoryConsole.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryConsole
{
    public class App
    {
        public void Run() 
        {
            // Dependency Injection borde användas här!
            IRepository repository = new PersonRepository();

            // Vi kan byta ut vår repository som vi vill!
            // Så länge den implmenterar samma Interface
            // Plug & Play baby!
            // IRepository repository = new PersonRepositoryNew();

            // Nu har vi tagit bort ALL business logik från vår App klass
            // Vi anropar istället vår repository! :)

            // Create
            repository.Add(new Person { Name = "Alice" });
            repository.Add(new Person { Name = "Bob" });
            repository.Add(new Person { Name = "Charlie" });

            // Read All
            Console.WriteLine("All Persons:");
            foreach (var person in repository.GetAll())
            {
                Console.WriteLine($"Id: {person.Id}, Name: {person.Name}");
            }

            // Read by Id
            Console.WriteLine("\nGet Person with Id = 2:");
            var personById = repository.GetById(2);
            if (personById != null)
            {
                Console.WriteLine($"Id: {personById.Id}, Name: {personById.Name}");
            }

            // Update
            Console.WriteLine("\nUpdating Person with Id = 2:");
            repository.Update(new Person { Id = 2, Name = "Bobby" });
            var updatedPerson = repository.GetById(2);
            Console.WriteLine($"Id: {updatedPerson.Id}, Name: {updatedPerson.Name}");

            // Delete
            // Console.WriteLine("\nDeleting Person with Id = 1");
            

            // Read All After Deletion
           
            Console.ReadLine();
        }
    }
}
