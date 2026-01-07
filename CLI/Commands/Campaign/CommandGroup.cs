namespace CLI.Commands.Campaign
{
    public class CommandGroup : ICommand
    {
        public string Name => "campaign";
        public string Description => "Manage Campaigns";
        public bool? RequiresCampaign { get; }

        private readonly Dictionary<string, ICommand> _subcommands;


        public void Execute(string[] args)
        {
            throw new NotImplementedException();
        }
    }
}
