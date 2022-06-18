namespace WordSearch.Data.Properties
{
    using System.Reflection;

    public static class DataProperties
    {
        public static Assembly Assembly
        {
            get => IntrospectionExtensions.GetTypeInfo(typeof(DataProperties)).Assembly;
        }
    }
}
