using CGPFE.CLI;
namespace CGPFE.CLI
{
    public class CommandNode : ICommandNode
    {
        public string Name { get; }
        public string Description { get; }
        public ICommand? LeafCommand { get; }
        public Dictionary<string, ICommandNode> Subcommands { get; } = new();

        public CommandNode(string name, string description, ICommand? command = null)
        {
            Name = name;
            Description = description;
            LeafCommand = command;
        }

        public void AddSub(ICommandNode child)
        {
            Subcommands[child.Name] = child;
        }
    }
}
