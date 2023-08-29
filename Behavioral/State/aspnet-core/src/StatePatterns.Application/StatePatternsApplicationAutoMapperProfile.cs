using AutoMapper;

namespace StatePatterns;

public class StatePatternsApplicationAutoMapperProfile : Profile
{
    public StatePatternsApplicationAutoMapperProfile()
    {
        CreateMap<Invoices.Invoice, Invoices.DTOs.InvoiceDto>()
            .ForMember(x => x.State, z => z.MapFrom(q => q.State.ToString()));
    }
}
