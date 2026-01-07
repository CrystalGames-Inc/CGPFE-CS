namespace CLI
{
    public interface ICommandNode
    {
        string Name { get; }
        string Description { get; }

        ICommand LeafCommand { get; }
        Dictionary<string, ICommandNode> Subcommands { get; }
    }
}
