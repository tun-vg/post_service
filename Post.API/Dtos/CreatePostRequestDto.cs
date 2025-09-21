namespace Post.API.Dtos;

public class CreatePostRequestDto
{
    public string Title { get; set; } = string.Empty;
    public string Slug { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public Guid AuthorId { get; set; }
    public Guid CategoryId { get; set; }
    public Guid[] PostTags { get; set; } = [];
    public IFormFile? Image { get; set; }
}
