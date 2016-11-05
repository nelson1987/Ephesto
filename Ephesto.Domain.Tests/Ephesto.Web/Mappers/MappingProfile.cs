using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using AutoMapper.Configuration;
using Ephesto.Domain.Entities;
using Ephesto.Web.ViewModels;

namespace Ephesto.Web.Mappers
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x => { x.AddProfile<MappingProfile>(); });
        }  
    }
    public class MappingProfile : Profile
    {
        //private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            try
            {
                ViewToApiModel();
                Mapper.AssertConfigurationIsValid();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message);
            }
            
        }

        protected void ViewToApiModel()
        {
            CreateMap<Usuario, UsuarioApiModel>()
                .ForMember(dest => dest.Login, ori => ori.MapFrom(x => x.Login))
                .ForMember(dest => dest.Nome, ori => ori.MapFrom(x => x.Nome));
            //CreateMap<Usuario, UsuarioApiModel>()
            //    .ForMember(dest => dest.Login, ori => ori.MapFrom(x => x.Login))
            //    .ForMember(dest => dest.Nome, ori => ori.MapFrom(x => x.Nome));
            //CreateMap<Categoria, GridPesquisaCategoriaVM>()
            //    .ForMember(dest => dest.Id, ori => ori.MapFrom(x => x.Id))
            //    .ForMember(dest => dest.Ativo, ori => ori.MapFrom(x => x.Ativo))
            //    .ForMember(dest => dest.Codigo, ori => ori.MapFrom(x => x.Codigo))
            //    .ForMember(dest => dest.Descricao, ori => ori.MapFrom(x => x.Descricao));
            //CreateMap<FornecedorIndividualVM, Fornecedor>()
            //    .ForCtorParam("id", opt => opt.MapFrom(src => src.Id))
            //    .ForCtorParam("documento", opt => opt.MapFrom(src => src.Documento))
            //    .ForCtorParam("razaoSocial", opt => opt.MapFrom(src => src.RazaoSocial));
            //CreateMap<Fornecedor, FornecedorIndividualVM>();
        }
    }
}