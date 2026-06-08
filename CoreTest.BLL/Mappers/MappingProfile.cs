using AutoMapper;
using CoreTest.Domain.Entites;
using CoreTest.Shared.DTOs;
using CoreTest.Shared.DTOs.Categories;
using CoreTest.Shared.DTOs.Questions;
using CoreTest.Shared.DTOs.Tests;
using CoreTest.Shared.DTOs.TestSolution;
using CoreTest.Shared.DTOs.Topic;
using CoreTest.Shared.DTOs.User;
using CoreTest.Shared.DTOs.UserTestSolutions;

namespace Laptops.BLL.Mappers;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Category, CategoryForCreateDTO>().ReverseMap();

        CreateMap<Category, CategoryForUpdateDTO>().ReverseMap();

        CreateMap<Category, CategoryForResultDTo>().ReverseMap();


        CreateMap<Category, CategoryForShortResultDTO>().ReverseMap();

        CreateMap<Option, OptionForCreateDTO>().ReverseMap();

        CreateMap<Option, OptionForUpdateDTO>().ReverseMap();

        CreateMap<Option, OptionForResultDTO>().ReverseMap();

        CreateMap<Option, OptionForShortResultDTO>().ReverseMap();


        CreateMap<Questions, QuestionForCreateDTO>().ReverseMap();

        CreateMap<Questions, QuestionForUpdateDTO>().ReverseMap();

        CreateMap<Questions, QuestionForResultDTO>().ReverseMap();

        CreateMap<Questions, QuestionForShortResultDTO>().ReverseMap();


        CreateMap<User, TestForCreateDTO>().ReverseMap();

        CreateMap<User, TestForUpdateDTO>().ReverseMap();

        CreateMap<User, TestForResultDTO>().ReverseMap();

        CreateMap<User, TestForShortResultDTO>().ReverseMap();


        CreateMap<TestSolution, TestSolutionForCreateDTO>().ReverseMap();

        CreateMap<TestSolution, TestSolutionForUpdateDTO>().ReverseMap();

        CreateMap<TestSolution, TestSolutionForResultDTO>().ReverseMap();

        CreateMap<TestSolution, TestSolutionForShortResultDTO>().ReverseMap();


        CreateMap<Topic, TopicForCreateDTO>().ReverseMap();

        CreateMap<Topic, TopicForUpdateDTO>().ReverseMap();

        CreateMap<Topic, TopicForResultDTO>().ReverseMap();

        CreateMap<Topic, TopicForShortResultDTO>().ReverseMap();


        CreateMap<User, UserForCreateDto>().ReverseMap();

        CreateMap<User, UserForUpdateDto>().ReverseMap();

        CreateMap<User, UserForResultDto>().ReverseMap();

        CreateMap<User, UserForShortResultDto>().ReverseMap();


        CreateMap<UserTestSolution, UserTestSolutionsForCreateDto>().ReverseMap();

        CreateMap<UserTestSolution, UserTestSolutionsForUpdateDto>().ReverseMap();

        CreateMap<UserTestSolution, UserTestSolutionsForResultDto>().ReverseMap();

        CreateMap<UserTestSolution, UserTestSolutionsForShortResultDto>().ReverseMap();
    }
}