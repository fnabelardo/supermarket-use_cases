using CoreBusiness;

namespace UseCases.CategoriesUseCases;

public interface IViewSelectedCategoriesUseCase
{
    Category? Execute(int categoryId);
}