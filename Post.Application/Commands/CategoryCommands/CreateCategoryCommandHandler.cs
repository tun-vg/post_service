using AutoMapper;
using MediatR;
using Post.Application.Dtos;
using Post.Contract.Abstractions;
using Post.Contract.Repositories;
using Post.Domain.Entities;

namespace Post.Application.Commands.CategoryCommands;

public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, Result>
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;
    
    public CreateCategoryCommandHandler(ICategoryRepository categoryRepository, IMapper mapper)
    {
        _categoryRepository = categoryRepository;
        _mapper = mapper;
    }

    public async Task<Result> Handle(CreateCategoryCommand command, CancellationToken cancellationToken)
    {
        Category category = new Category
        {
            Name = command.Name
        };

        await _categoryRepository.CreateCategory(category);
        var categoryDto = _mapper.Map<CategoryDto>(category);
        return Result.Success(categoryDto);
    }
}