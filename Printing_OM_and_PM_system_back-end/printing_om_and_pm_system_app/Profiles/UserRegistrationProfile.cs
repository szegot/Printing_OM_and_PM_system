namespace printing_om_and_pm_system_app.Profiles
{
	public class UserRegistrationProfile : Profile
	{
		public UserRegistrationProfile()
		{
            CreateMap<UserRegistrationDTO, User>()
                .ForMember(
                    dest => dest.UserName,
                    opt => opt.MapFrom(src => src.UserName)
                )
                .ForMember(
                    dest => dest.FirstName,
                    opt => opt.MapFrom(src => src.FirstName)
                ).ForMember(
                    dest => dest.LastName,
                    opt => opt.MapFrom(src => src.LastName)
                ).ForMember(
                    dest => dest.Email,
                    opt => opt.MapFrom(src => src.Email)
                ).ForMember(
                    dest => dest.Password,
                    opt => opt.MapFrom(src => src.Password)
                ).ForMember(
                    dest => dest.BillingAddress,
                    opt => opt.MapFrom(src => src.BillingAddress)
                ).ForMember(
                    dest => dest.BillingCity,
                    opt => opt.MapFrom(src => src.BillingCity)
                ).ForMember(
                    dest => dest.BillingZipCode,
                    opt => opt.MapFrom(src => src.BillingZipCode)
                );

        }
	}
}

