using System.Collections.Generic;
using CommandAPI.Data;
using CommandAPILibrary.Models;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using CommandAPI.Dtos;

namespace CommandAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommandAPIRepo _repository;
        private readonly IMapper _mapper;
        public CommandsController(ICommandAPIRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        // [HttpGet]
        // public ActionResult<IEnumerable<string>> Get()
        // {
        //     return new string[] {"this", "is", "hard", "coded"};
        // }
        [HttpGet]
        public ActionResult<IEnumerable<CommandReadDto>> GetAllCommands ()
        {
            var CommandItems = _repository.GetAllCommands();
            return Ok(_mapper.Map<IEnumerable<CommandReadDto>>(CommandItems));
        }
        [HttpGet("{id}")]
        public ActionResult<CommandReadDto> GetCommandById (int id)
        {
            var CommandItem = _repository.GetCommandById(id);
            if (CommandItem == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<CommandReadDto>(CommandItem));
        }
    }
}