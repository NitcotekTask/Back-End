namespace BusinessLogicLayer.MappingConfig
{
    public class MappingProfile : Profile
    {

        public MappingProfile()
        {

            CreateMap<AccountsChart, DisplayAccontDTO>().ReverseMap();
            CreateMap<SaveJournalEntryDetailsDTO, JournalEntryDetail>().ReverseMap();
            CreateMap<SaveJournalEntryHeaderDTO, JournalEntryHeader>()
            .ForMember(dest => dest.JournalEntryDetails, opt => opt.Ignore())
            .AfterMap((src, dest) =>
            {
                dest.CreatedAt = DateTime.UtcNow;
            })
            .ReverseMap();

        }

    }
}
