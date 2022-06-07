using Commander.models;
using System.Collections.Generic;

namespace Commander.data {
    // inherit the methods from ICommanderRepo
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command> {
                new Command{Id=0, HowTo="Boil an egg", Line="Boil water", Platform="Kettle & Pan"},
                new Command{Id=1, HowTo="Make a cup of tea", Line="Boil water", Platform="Kettle & Pan"},
                new Command{Id=2, HowTo="Cut bread", Line="Get a knife", Platform="Knife and chopping board"}
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="Boil an egg", Line="Boil water", Platform="Kettle & Pan"};
        }
    }
}

