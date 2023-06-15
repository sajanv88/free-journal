using AutoMapper;
using BlogManagement.Dtos;
using BlogManagement.Entities;

namespace BlogManagement.ObjectMapping;

public class BlogManagementAutoMapperProfile : Profile
{
    public BlogManagementAutoMapperProfile()
    {
        CreateMap<Post, ReadPostDto>();
    }
}
