﻿namespace WordSearch.Mappers.Profile
{
    using AutoMapper;

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

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region Entities to Models

            CreateMap<CharacterEntity, CharacterModel>();
            CreateMap<GridEntity, GridModel>();
            CreateMap<WordEntity, WordModel>();
            CreateMap<GameSettingsEntity, GameSettingsModel>();
            CreateMap<DirectionEntity, DirectionModel>();

            #endregion

            #region Models to Entities

            CreateMap<CharacterModel, CharacterEntity>();
            CreateMap<GridModel, GridEntity>();
            CreateMap<WordModel, WordEntity>();
            CreateMap<GameSettingsModel, GameSettingsEntity>();
            CreateMap<DirectionModel, DirectionEntity>();

            #endregion
        }
    }
}
