using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGPFE.CLI
{
    public class CommandNode : ICommandNode
    {
        public string Name { get; }
        public string Description { get; }
        public ICommand? LeafCommand { get; }
        public Dictionary<string, ICommandNode> Subcommands { get; } = new();

        public CommandNode(string name, string description, ICommand? command = null) {
            Name = name;
            Description = description;
            LeafCommand = command;
        }

        public void AddSub(ICommandNode child) {
            Subcommands[child.Name] = child;
        }
    }
}
