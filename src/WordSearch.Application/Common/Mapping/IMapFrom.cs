using AutoMapper;

namespace WordSearch.Application.Common.Mapping
{
    public interface IMapFrom<T>
    {
        void MappingFrom(Profile profile)
        {
            profile.CreateMap(typeof(T), GetType());
        }
    }
}
