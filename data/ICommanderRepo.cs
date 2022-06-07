using Commander.models;

namespace Commander.data {
    public interface ICommanderRepo
    {
        // defining the methods avaliable in this interface
        IEnumerable<Command> GetAppCommands(); 
        Command GetCommandById(int id);
    }
}