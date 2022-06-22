namespace WordSearch.Assets.Properties
{
    using System.Reflection;

    public class AssetProperties
    {
        public static Assembly Assembly { get; }

        static AssetProperties()
        {
            Assembly = IntrospectionExtensions.GetTypeInfo(
                typeof(AssetProperties)).Assembly;
        }
    }
}
