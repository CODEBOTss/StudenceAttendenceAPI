using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using studentattendanceapi.Data;
using studentattendanceapi.Models;
using Microsoft.EntityFrameworkCore;

namespace studentattendanceapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class studentcontroller : ControllerBase
    {
        private readonly applicationdbcontext _context;

        public studentcontroller(applicationdbcontext context) 
        {
            _context = context; 
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<student>>> GetStudents()
        {
            return await _context.students.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<student>> GetStudent(int id)
        {
            var student = await _context.students.FindAsync(id);
            if (student == null) return NotFound();
            return student;
        }

        [HttpPost]
        public async Task<ActionResult> AddStudent(student student)
        {
            student.Date = DateTime.Now;
            _context.students.Add(student);
            await _context.SaveChangesAsync();
            return Ok("Student added");
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateStudent(int id, student updated)
        {
            var student = await _context.students.FindAsync(id);
            if (student == null) return NotFound();

            student.name = updated.name;
            student.rollnumber = updated.rollnumber;
            student.ispresent = updated.ispresent;
            student.Date = updated.Date;

            await _context.SaveChangesAsync();
            return Ok("Student updated");
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteStudent(int id)
        {
            var student = await _context.students.FindAsync(id);
            if (student == null) return NotFound();

            _context.students.Remove(student);
            await _context.SaveChangesAsync();
            return Ok("Student deleted");
        }
    }
}
