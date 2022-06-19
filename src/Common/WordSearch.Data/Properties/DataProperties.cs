namespace WordSearch.Data.Properties
{
    using System.Reflection;

    public static class DataProperties
    {
        public static Assembly Assembly { get; }

        static DataProperties()
        {
            Assembly = IntrospectionExtensions.GetTypeInfo(
                typeof(DataProperties)).Assembly;
        }
    }
}
