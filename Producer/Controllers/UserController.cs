using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Producer.Core;
using Producer.DTOs;
using Producer.Entities;

namespace Producer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;
        public UserController(IMapper mapper)
        {
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult Get()
        {
            List<User> entities = Datas.Users;
            List<UserToListDto> dtos = _mapper.Map<List<UserToListDto>>(entities);
            return Ok(dtos);
        }

        [HttpPost]
        public IActionResult Add([FromBody] UserToAddDto dto)
        {
            User entity = _mapper.Map<User>(dto);
            Datas.Users.Add(entity);
            return Ok();
        }


        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            User entity = Datas.Users.SingleOrDefault(m => m.Id == id);
            Datas.Users.Remove(entity); 
            return Ok();
        }
    }
}
