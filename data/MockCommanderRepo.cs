using Commander.models;
using System.Collections.Generic;

namespace Commander.data {
    // inherit the methods from ICommanderRepo
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            throw new NotImplementedException();
        }

        public Command GetCommandById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

