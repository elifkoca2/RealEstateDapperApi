﻿using RealEstateDapperApi.Dtos.ProductDtos;

namespace RealEstateDapperApi.Repositories.EstateAgentRepositories.DashboardRepositories.LastProductsRepositories
{
    public interface ILast5ProductsRepository
    {
        Task<List<ResultLast5ProductWithCategoryDto>> GetLast5ProductAsync(int id );
    }
}