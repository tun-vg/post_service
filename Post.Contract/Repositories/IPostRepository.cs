using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post.Contract.Repositories;

public interface IPostRepository
{

    Task<List<Post.Domain.Entities.Post>> GetPostByPage();

    Task<Post.Domain.Entities.Post> GetPostById(Guid postId);

    Task SavePost(Post.Domain.Entities.Post post);

    Task UpdatePost(Post.Domain.Entities.Post post);

    Task<bool> DeletePost(Guid postId);
}
