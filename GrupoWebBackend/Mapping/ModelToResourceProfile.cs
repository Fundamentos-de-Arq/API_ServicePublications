﻿using AutoMapper;
using GrupoWebBackend.DomainPets.Domain.Models;
using GrupoWebBackend.DomainPublications.Domain.Models;
using GrupoWebBackend.DomainDistrict.Domain.Models;
using GrupoWebBackend.DomainDistrict.Resources;
using GrupoWebBackend.DomainPets.Resources;
using GrupoWebBackend.DomainPublications.Resources;
using GrupoWebBackend.Security.Domain.Entities;
using GrupoWebBackend.Security.Domain.Services.Communication;
using GrupoWebBackend.Security.Resources;
using GrupoWebBackend.DomainSubscriptions.Domain.Models;
using GrupoWebBackend.DomainSubscriptions.Resources;

namespace GrupoWebBackend.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Pet, PetResource>();
            CreateMap<District, DistrictResource>();
            CreateMap<Publication, PublicationResource>();
            CreateMap<User, RegisterRequest>();
            CreateMap<User, AuthenticateResponse>();
            CreateMap<User, AuthenticateRequest>();
            CreateMap<User, UserResource>();
            CreateMap<Subscription, SubscriptionResource>();
        }
    }
}
