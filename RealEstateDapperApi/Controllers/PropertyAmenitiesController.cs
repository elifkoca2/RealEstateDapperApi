﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateDapperApi.Repositories.PropertyAmenityRepositories;

namespace RealEstateDapperApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyAmenitiesController : ControllerBase
    {
        private readonly IPropertyAmenityRepository _propertyAmenityRepository;
        public PropertyAmenitiesController(IPropertyAmenityRepository propertyAmenityRepository)
        {
            _propertyAmenityRepository = propertyAmenityRepository;
        }

        [HttpGet]
        public async Task<IActionResult> ResultPropertyAmenityByStatusTrue(int id)
        {
            var values = await _propertyAmenityRepository.ResultPropertyAmenityByStatusTrue(id);
            return Ok(values);
        }
    }
}
