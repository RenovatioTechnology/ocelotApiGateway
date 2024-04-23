using Microsoft.AspNetCore.Mvc;
using studentService.Service;

namespace StudentService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _repository;
        public StudentController(IStudentRepository repository) => _repository = repository;

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_repository.GetAll());
        }

        [HttpGet("{Id}")]
        public IActionResult Get(int id)
        {
            var teacher = _repository.Get(id);
            if (teacher is null)
                return NotFound();

            return Ok(teacher);
        }
    }
}


