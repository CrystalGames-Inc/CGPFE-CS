namespace CGPFE.CLI
{
    public interface ICommand
    {
        string Name { get; }
        string Description { get; }

        /// <summary>
        /// true  - Requires a campaign to be loaded.
        /// false - Requires a campaign NOT to be loaded.
        /// null  - Does not matter.
        /// </summary>
        bool? RequiresCampaign { get; }
        void Execute(string[] args);
    }
}
