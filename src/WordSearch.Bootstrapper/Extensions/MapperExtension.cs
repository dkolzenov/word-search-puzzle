namespace WordSearch.Bootstrapper.Extensions
{
    using Microsoft.Extensions.DependencyInjection;

    using Prism.Ioc;

    using AutoMapper;

    using WordSearch.Mappers.Profile;

    public static class MapperExtension
    {
        public static void RegisterAutoMapper(
            this IContainerRegistry containerRegistry)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();

            containerRegistry.RegisterServices(
                service => service.AddSingleton(mapper));
        }
    }
}
