using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using attendance.Models;

namespace attendance.Controllers
{

    [Route("[controller]")]
    public class StudentController : Controller
    {
        private readonly AttendanceDbContext context;

        public StudentController(AttendanceDbContext context)
        {
            this.context = context;
        }

        [Route("")]
        public async Task<ActionResult> Index()
        {
            var list = await List();
            return View(list);
        }

        [Route("[action]")]
        public async Task<List<Student>> List()
        {
            var list = await this.context.Student.ToListAsync<Student>();
            return list;
        }

        [Route("[action]/id:int")]
        public async Task<ActionResult> Get([FromRoute]int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Student student = await this.context.Student.FirstOrDefaultAsync(r => r.ID == id);

            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }

        [Route("[action]")]
        public async Task<ActionResult> Create([FromBody] Student student)
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
                return Ok();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }

        [Route("[action]/id:int")]
        public async Task<ActionResult> update([FromRoute]int id, [FromBody] Student s)
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

        [Route("[action]/id:int")]
        public async Task<ActionResult> Delete([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Student student = await this.context.Student.FindAsync(id);

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