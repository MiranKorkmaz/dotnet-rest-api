using Commander.data;
using Commander.models;
using Microsoft.AspNetCore.Mvc;

namespace Commander.controllers {
    [Route("api/commands")]
    [ApiController]
    public class CommandsController: ControllerBase {

        private readonly MockCommanderRepo _repository = new MockCommanderRepo();
        // GET api/commands 
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands() {
            var commandItems = _repository.GetAppCommands();

            return Ok(commandItems);
        }
        // GET that responds to api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult <Command> GetCommandById(int id) {
            var commandItem = _repository.GetCommandById(id);

            return Ok(commandItem);
        }
    }
}