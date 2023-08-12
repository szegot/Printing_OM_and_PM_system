namespace printing_om_and_pm_system_app.Profiles
{
	public class UserLoginProfile : Profile
	{
		public UserLoginProfile()
		{
			CreateMap<UserLoginDto, User>()
				.ForMember(
					dest => dest.Email,
					opt => opt.MapFrom(src => src.Email)
				)
				.ForMember(
					dest => dest.Password,
					opt => opt.MapFrom(src => src.Password)
				);
		}
	}
}

