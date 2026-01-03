using AutoMapper;
using MediatR;
using Post.Application.Dtos;
using Post.Contract.Abstractions;
using Post.Contract.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Post.Application.Queries.PostQueries;

public class SearchPostsQueryHandler : IRequestHandler<SearchPostsQuery, PagedResult<Object>>
{
    private readonly IPostRepository _postRepository;
    private readonly IMapper _mapper;

    public SearchPostsQueryHandler(IPostRepository postRepository, IMapper mapper)
    {
        _postRepository = postRepository;
        _mapper = mapper;
    }

    public async Task<PagedResult<Object>> Handle(SearchPostsQuery query, CancellationToken cancellationToken)
    {
        if (query.Type.ToLower() == "post")
        {
            var (posts, count) = await _postRepository.SearchPost(query.Search, query.Page, query.PageSize);
            var postDtos = _mapper.Map<List<Object>>(posts);
            return PagedResult<Object>.Create(postDtos, query.Page, query.PageSize, count);
        }
        else if (query.Type.ToLower() == "user")
        {
            // call to user service to search users by grpc
            throw new NotImplementedException("User search is not implemented.");
        }
        else
        {
            throw new Exception("Invalid type search");
        }
    }
}
