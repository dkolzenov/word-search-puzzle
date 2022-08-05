namespace WordSearch.Core.Attributes
{
    using System;

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public sealed class IndexOutOfRangeAttribute : Attribute
    {

    }
}
