using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ToDo.Application.DTOs;

namespace ToDo.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToDosController : ControllerBase
    {
        private readonly IMapper _mapper;

        public ToDosController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet("/{todo_id}")]
        public IEnumerable<Application.Models.ToDo> GetById([FromRoute]Int64 todo_id)
        {
            
            var list = new List<Application.Models.ToDo>();

            for(int x = 1; x <= 10; x++)
            {
                var dto = new ToDoDto
                {
                    UserId = Guid.NewGuid(),
                    Title = $"Test {x}",
                    Description = $"Description Test {x}",
                    CreatedAt = DateTime.Now
                };

                var result = _mapper.Map<ToDoDto, Application.Models.ToDo>(dto);

                list.Add(result);
            }

            return list;
        }
    }
}
