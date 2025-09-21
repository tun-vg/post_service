using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Post.Application.Dtos;
using Post.Contract.Abstractions;
using Post.Contract.Repositories;

namespace Post.Application.Queries.CategoryQueries;

public class GetCategoriesQueryHandler : IRequestHandler<GetCategoriesQuery, Result>
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;

    public GetCategoriesQueryHandler(ICategoryRepository categoryRepository, IMapper mapper)
    {
        _categoryRepository = categoryRepository;
        _mapper = mapper;
    }

    public async Task<Result> Handle(GetCategoriesQuery request, CancellationToken cancellationToken)
    {
        var categories = await _categoryRepository.GetAll();
        return Result.Success(_mapper.Map<List<CategoryDto>>(categories));
    }
}
