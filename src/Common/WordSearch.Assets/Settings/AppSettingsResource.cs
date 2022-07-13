namespace WordSearch.Assets.Settings
{
    using WordSearch.Assets.Interfaces;
    using WordSearch.Assets.Base;

    public class AppSettingsResource : EmbeddedResourceBase, IAppSettingsResource
    {
        public override string Name => "appsettings.json";

        public override string RelativePath => $"{Name}";
    }
}
