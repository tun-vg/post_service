using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post.Domain.Entities;

public class Post
{
    public Guid PostId { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Slug { get; set; } = string.Empty;

    public string Content { get; set; } = string.Empty;

    public Guid AuthorId { get; set; }

    public Guid CategoryId { get; set; }

    public Category? Category { get; set; }

    public IEnumerable<PostTag> PostTags { get; set; } = new List<PostTag>();

    public IEnumerable<Comment> Comments { get; set; } = new List<Comment>();

    public DateTime CreatedDate { get; set; }

    public DateTime UpdatedDate { get; set; }

    public Post() { }

    public Post(Guid postId, string title, string slug, string content, Guid authorId, Guid categoryId, Category? category, IEnumerable<PostTag> postTags, IEnumerable<Comment> comments, DateTime createdDate, DateTime updatedDate)
    {
        PostId = postId;
        Title = title;
        Slug = slug;
        Content = content;
        AuthorId = authorId;
        CategoryId = categoryId;
        Category = category;
        PostTags = postTags;
        Comments = comments;
        CreatedDate = createdDate;
        UpdatedDate = updatedDate;
    }
}
