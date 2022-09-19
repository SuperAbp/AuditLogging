using AutoMapper;
using SuperAbp.AuditLogging.Dtos;
using Volo.Abp.AuditLogging;

namespace SuperAbp.AuditLogging;

public class AuditLoggingApplicationAutoMapperProfile : Profile
{
    public AuditLoggingApplicationAutoMapperProfile()
    {
        CreateMap<AuditLog, AuditLogListDto>();
        CreateMap<AuditLogAction, AuditLogActionDetailDto>();
        CreateMap<AuditLog, AuditLogDetailDto>()
            .ForMember(entity => entity.Actions,
                opt => opt
                    .MapFrom(src =>
                        src.Actions));
    }
}