using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Post.Application.Dtos;
using Post.Domain.Entities;

namespace Post.Application;

public class ProfileMapper : AutoMapper.Profile
{
    public ProfileMapper()
    {
        CreateMap<Post.Domain.Entities.Post, PostDto>()
            .ForMember(dest => dest.PostId, opt => opt.MapFrom(src => src.PostId))
            .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
            .ForMember(dest => dest.Slug, opt => opt.MapFrom(src => src.Slug))
            .ForMember(dest => dest.Content, opt => opt.MapFrom(src => src.Content))
            .ForMember(dest => dest.AuthorId, opt => opt.MapFrom(src => src.AuthorId))
            .ForMember(dest => dest.CategoryId, opt => opt.MapFrom(src => src.CategoryId))
            .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
            .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
            .ForMember(dest => dest.PostTags, opt => opt.MapFrom(src => src.PostTags))
            .ForMember(dest => dest.Approved, opt => opt.MapFrom(src => src.Approved))
            .ForMember(dest => dest.Point, opt => opt.MapFrom(src => src.Point))
            .ForMember(dest => dest.UpPoint, opt => opt.MapFrom(src => src.UpPoint))
            .ForMember(dest => dest.DownPoint, opt => opt.MapFrom(src => src.DownPoint))
            .ForMember(dest => dest.ReadingTime, opt => opt.MapFrom(src => src.ReadingTime))
            .ForMember(dest => dest.ViewCount, opt => opt.MapFrom(src => src.ViewCount));

        CreateMap<Tag, TagDto>()
            .ForMember(TagDto => TagDto.TagId, opt => opt.MapFrom(src => src.TagId))
            .ForMember(TagDto => TagDto.Name, opt => opt.MapFrom(src => src.Name))
            .ForMember(TagDto => TagDto.Slug, opt => opt.MapFrom(src => src.Slug));

        CreateMap<Category, CategoryDto>()
            .ForMember(c => c.CategoryId, opt => opt.MapFrom(src => src.CategoryId))
            .ForMember(c => c.Name, opt => opt.MapFrom(src => src.Name));

        CreateMap<CategoryDto, Category>()
            .ForMember(c => c.CategoryId, opt => opt.MapFrom(src => src.CategoryId))
            .ForMember(c => c.Name, opt => opt.MapFrom(src => src.Name));
    }
}
