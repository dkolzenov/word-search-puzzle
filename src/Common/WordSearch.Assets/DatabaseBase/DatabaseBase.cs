namespace WordSearch.Assets.DatabaseBase
{
    using WordSearch.Assets.Interfaces;
    using WordSearch.Assets.ResourceBase;
    using WordSearch.Helpers.Interfaces;

    public abstract class DatabaseBase : EmbeddedResourceBase, IDatabasableBase
    {
        protected DatabaseBase(IPlatformPathHelper platformPathHelper)
            : base(platformPathHelper)
        {
        }

        public abstract string DbConnectionString { get; }
    }
}
