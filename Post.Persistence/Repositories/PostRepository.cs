using Microsoft.EntityFrameworkCore;
using Post.Contract.Repositories;
using Post.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post.Persistence.Repositories;

public class PostRepository : IPostRepository
{
    private readonly ApplicationDBContext _context;

    public PostRepository(ApplicationDBContext context)
    {
        _context = context;
    }

    public async Task<List<Post.Domain.Entities.Post>> GetPostByPage()
    {
        List<Post.Domain.Entities.Post> result = await _context.Posts.ToListAsync();
        return result;
    }

    public async Task<Post.Domain.Entities.Post> GetPostById(Guid id)
    {
        var result = await _context.Posts.FindAsync(id);
        if (result != null)
        {
            return result;
        }
        else throw new Exception($"Coun't found post by id: {id}");
    }

    public async Task<bool> DeletePost(Guid id)
    {
        var entity = await _context.Posts.FindAsync(id);
        if (entity != null)
        {
            _context.Posts.Remove(entity);
            return await _context.SaveChangesAsync() > 0 ? true : false;
        }
        else throw new Exception($"Coun't found post by id: {id}");
    }

    public async Task SavePost(Post.Domain.Entities.Post entity)
    {
        await _context.Posts.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdatePost(Post.Domain.Entities.Post post)
    {
        var entity = await _context.Posts.FindAsync(post.PostId);
        if (entity != null)
        {
            entity.Title = post.Title;
            entity.Slug = post.Slug;
            entity.Content = post.Content;
            entity.CategoryId = post.CategoryId;
            entity.UpdatedDate = DateTime.Now;

            await _context.SaveChangesAsync();
        }
        else throw new Exception($"Coun't found post by id: {post.PostId}");
    }
}
