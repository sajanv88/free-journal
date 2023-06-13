using Volo.Abp.Application.Services;
using BlogManagement.Dtos;
using BlogManagement.Services.Dtos;
using BlogManagement.Entities;
using Volo.Abp.Domain.Repositories;
using Volo.Abp;
using Volo.Abp.AspNetCore.Components.Web.BasicTheme.Themes.Basic;
using Microsoft.AspNetCore.Http.HttpResults;

namespace BlogManagement.Services;
public class BlogService : ApplicationService, IBlogService
{
    private readonly IRepository<Post, Guid> _postRepository;
    
    public BlogService(IRepository<Post, Guid> postRepository)
    {
        _postRepository = postRepository;
    }

    public async Task<ReadPostDto> GetPostAsync(Guid Id) 
    {
        var result =  await _postRepository.GetAsync(p => p.Id == Id) ?? throw new BusinessException("Post not found");
        return new ReadPostDto 
        {
            Title = result.Title, 
            Id = result.Id, 
            PostContent = result.PostContent, 
            CreatedBy = result.CreatedBy,
            IsPublished = result.IsPublished,
            IsDraft = result.IsDraft,
        };
    }

    public async Task<ReadPostDto> CreatePostAsync(CreatePostDto post)
    {
        var newPostItem = new Post { Title = post.Title, PostContent = post.PostContent, CreatedBy = post.CreatedBy, IsPublished = post.IsPublished, IsDraft = post.IsDraft };
        if (post.IsPublished && post.IsDraft)
        {
            throw new BusinessException("Contract doesn't match. Post must contain status. Either published or draft set to true.");
        }

        var result = await _postRepository.InsertAsync(newPostItem);
        return new ReadPostDto 
        {
            Title = result.Title, 
            Id = result.Id, 
            PostContent = result.PostContent, 
            CreatedBy = result.CreatedBy,
            IsPublished = result.IsPublished,
            IsDraft = result.IsDraft,
        };
       
    }

    public async Task DeletePostAsync(Guid Id)
    {
        await _postRepository.DeleteAsync(Id);
    }

    public async Task<List<ReadPostDto>> GetPostsAsync()
    {
       var posts = await _postRepository.GetListAsync();
        return posts.Select(p => new ReadPostDto 
        { 
            Title = p.Title,
            PostContent = p.PostContent,
            Id = p.Id,
            CreatedBy = p.CreatedBy,
            IsPublished = p.IsPublished,
            IsDraft = p.IsDraft,
        }).ToList();
    }

    public async Task<ReadPostDto> UpdatePostAsync(CreatePostDto post, Guid Id)
    {
        var exisitingPost = await _postRepository.GetAsync(Id);
        exisitingPost.Title = post.Title;
        exisitingPost.PostContent = post.PostContent;
        var result = await _postRepository.UpdateAsync(exisitingPost);
         return new ReadPostDto 
        {
            Title = result.Title, 
            Id = result.Id, 
            PostContent = result.PostContent, 
            CreatedBy = result.CreatedBy,
            IsPublished = result.IsPublished,
            IsDraft = result.IsDraft,
        };
    }
}
