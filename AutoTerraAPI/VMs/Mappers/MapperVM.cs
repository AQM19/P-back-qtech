﻿using AutoMapper;
using AutoTerraApi.VMs;
using Business.DTOs;

namespace AutoTerraAPI.VMs.Mappers
{
    public class MapperVM : Profile
    {
        public MapperVM()
        {
            CreateMap<ConfiguracionUsuarioDTO, ConfiguracionUsuarioVM>().ReverseMap();
            CreateMap<DatoDTO, DatoVM>().ReverseMap();
            CreateMap<EspecieDTO, EspecieVM>().ReverseMap();
            CreateMap<EspecieTerrarioDTO, EspecieTerrarioVM>().ReverseMap();
            CreateMap<EstadisticaDTO, EstadisticaVM>().ReverseMap();
            CreateMap<LogroDTO, LogroVM>().ReverseMap();
            CreateMap<NotificacionDTO, NotificacionVM>().ReverseMap();
            CreateMap<ObservacionDTO, ObservacionVM>().ReverseMap();
            CreateMap<TareaDTO, TareaVM>().ReverseMap();
            CreateMap<TerrarioDTO, TerrarioVM>().ReverseMap();
            CreateMap<UsuarioLogroDTO, UsuarioLogroVM>().ReverseMap();
            CreateMap<UsuarioUsuarioDTO, UsuarioUsuarioVM>().ReverseMap();
            CreateMap<UsuarioDTO, UsuarioVM>().ReverseMap();
            CreateMap<VisitaDTO, VisitaVM>().ReverseMap();
        }
    }
}