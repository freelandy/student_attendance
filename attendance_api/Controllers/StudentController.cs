using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using attendance_api.Entity;
using attendance_api.Repository;
using Microsoft.EntityFrameworkCore;

namespace attendance_api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly AttendanceDbContext context;

        public StudentController(AttendanceDbContext context)
        {
            this.context = context;
        }

        // GET api/values
        [HttpGet]
        public async Task<List<Student>> Get()
        {
            var list = await this.context.Student.ToListAsync<Student>();
            return list;
        } 

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get([FromRoute]int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Student s = await this.context.Student.FirstOrDefaultAsync(r => r.ID == id);

            if(s == null)
            {
                return NotFound();
            }

            return Ok(s);
        }

        // POST api/values
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Student student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            this.context.Entry(student).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            try
            {
                this.context.Student.Add(student);
                await this.context.SaveChangesAsync();
                return CreatedAtAction("Get", new { id = student.ID }, student);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put([FromRoute]int id, [FromBody] Student s)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != s.ID)
            {
                return BadRequest();
            }

            this.context.Entry(s).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            try
            {
                await this.context.SaveChangesAsync();
                return Ok();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }

        // DELETE api/values/5
        [HttpDelete("/{id}")]
        public async Task<ActionResult> Delete([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Student student = this.context.Student.Find(id);

            student.IsDeleted = 1;
            this.context.Entry(student).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            try
            {
                await this.context.SaveChangesAsync();
                return Ok();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }
    }
}
