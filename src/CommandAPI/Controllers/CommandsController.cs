using System.Collections.Generic;
using CommandAPI.Data;
using CommandAPILibrary.Models;
using Microsoft.AspNetCore.Mvc;

namespace CommandAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommandAPIRepo _repository;
        public CommandsController(ICommandAPIRepo repository)
        {
            _repository = repository;
        }
        // [HttpGet]
        // public ActionResult<IEnumerable<string>> Get()
        // {
        //     return new string[] {"this", "is", "hard", "coded"};
        // }
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands ()
        {
            var CommandItems = _repository.GetAllCommands();
            return Ok(CommandItems);
        }
        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById (int id)
        {
            var CommandItem = _repository.GetCommandById(id);
            if (CommandItem == null)
            {
                return NotFound();
            }
            return Ok(CommandItem);
        }
    }
}