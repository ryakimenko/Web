using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Data;
using Web.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web.Controllers
{
    [Route("person")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        // GET: api/<PersonController>
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Person.ToArray();
            }
        }

        // GET api/<PersonController>/5
        [HttpGet("{id}")]
        public Person Get(int id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Person.Find(id);
            }
        }

        // POST api/<PersonController>
        [HttpPost]
        public ActionResult Post([FromBody] PersonModel personModel)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                
                db.Person.Add(new Person(personModel));
                db.SaveChanges();
                return Ok("Created");
            }
        }

        // PUT api/<PersonController>/5
        [HttpPut]
        public ActionResult Put([FromBody] Person person)
        {
            using (ApplicationContext db = new ApplicationContext())
            { 
                var FoundPerson = db.Person.Find(person.Id);
                if (FoundPerson != null) {
               
                    db.Person.Update(person);
                    db.SaveChanges();
                    return Ok("Updated");
                }
                else
                {
                    db.Person.Add(new Person
                    {
                    FirstName = person.FirstName,
                    MiddleName = person.MiddleName,
                    LastName = person.LastName,
                    Email = person.Email
                });
                    db.SaveChanges();
                    return Ok("Created");
                }
            }
        }

        // DELETE api/<PersonController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var FoundPerson = db.Person.Find(id);
                if(FoundPerson == null)
                {
                    return BadRequest("No person with that Id");

                }
                else
                {
                    db.Person.Remove(FoundPerson);
                    db.SaveChanges();
                    return Ok("Deleted");
                }
            }
        }
    }
}
