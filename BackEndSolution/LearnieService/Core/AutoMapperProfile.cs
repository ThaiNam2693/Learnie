using AutoMapper;
using LearnieService.DTOs;
using LearnieService.Models;

namespace LearnieService.Core
{
	public class AutoMapperProfile : Profile
	{
		public AutoMapperProfile()
		{
			CreateMap<UserModelForLogin, User>();
			CreateMap<UserModelForRegister, User>();
		}
	}
}
