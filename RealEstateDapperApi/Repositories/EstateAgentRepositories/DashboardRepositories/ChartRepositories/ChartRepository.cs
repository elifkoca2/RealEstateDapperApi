﻿using Dapper;
using RealEstateDapperApi.Dtos.ChartDtos;
using RealEstateDapperApi.Models.DapperContext;

namespace RealEstateDapperApi.Repositories.EstateAgentRepositories.DashboardRepositories.ChartRepositories
{
    public class ChartRepository : IChartRepository
    {
        private readonly Context _context;

        public ChartRepository(Context context)
        {
            _context = context;
        }
        public async Task<List<ResultChartDto>> Get5CityForChart()
        {
            string query = "Select top(5) City,Count(*) as 'CityCount' From Product Group By City order by CityCount Desc";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultChartDto>(query);
                return values.ToList();
            }
        }
        public async Task<List<ResultChartDto>> GetAveragePriceByCityAsync()
        {
            var sql = @"
        SELECT City, AVG(Price) AS AveragePrice
        FROM Product
        GROUP BY City";

            using (var connection = _context.CreateConnection())
            {
                var result = await connection.QueryAsync<ResultChartDto>(sql);
                return result.ToList();
            }
        }
    }
}
