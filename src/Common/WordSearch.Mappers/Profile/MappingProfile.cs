namespace WordSearch.Mappers.Profile
{
    using System.Collections.Generic;

    using AutoMapper;

    using WordSearch.Mappers.Converters;
    using WordSearch.Data.Entities.Character;
    using WordSearch.Data.Entities.Grid;
    using WordSearch.Data.Entities.Word;
    using WordSearch.Data.Entities.GameSettings;
    using WordSearch.Data.Entities.Direction;
    using WordSearch.Models.Character;
    using WordSearch.Models.Grid;
    using WordSearch.Models.Word;
    using WordSearch.Models.GameSettings;
    using WordSearch.Models.Direction;
    using WordSearch.Presentation.Models.GameMenu;

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region Entities to Models

            CreateMap<CharacterEntity, CharacterModel>();
            CreateMap<CharacterEntity, IEnumerable<CharacterModel>>()
                .ConvertUsing<CharacterConverter>();

            CreateMap<WordEntity, WordModel>();
            CreateMap<WordEntity, IEnumerable<WordModel>>()
                .ConvertUsing<WordConverter>();

            CreateMap<GridEntity, GridModel>();
            CreateMap<GameSettingsEntity, GameSettingsModel>();
            CreateMap<DirectionEntity, DirectionModel>();

            #endregion

            #region Models to Models

            CreateMap<GameMenuModel, GameSettingsSelectionModel>();
            CreateMap<GameSettingsSelectionModel, GameMenuModel>();
            CreateMap<GameSettingsModel, GameSettingsSelectionModel>();
            CreateMap<GameSettingsSelectionModel, GameSettingsModel>();

            #endregion
        }
    }
}
