﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Catalog.Dtos.FeatureDtos;
using MultiShop.Catalog.Services.FeatureServices;

namespace MultiShop.Catalog.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class FeaturesController : ControllerBase
    {
        private readonly IFeatureService _FeatureService;

        public FeaturesController(IFeatureService FeatureService)
        {
            _FeatureService = FeatureService;
        }

        [HttpGet]
        public async Task<IActionResult> FeatureList()
        {
            var values = await _FeatureService.GetAllFeatureAsync();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetFeatureById(string id)
        {
            var values = await _FeatureService.GetByIdFeatureAsync(id);
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateFeature(CreateFeatureDto createFeatureDto)
        {
            await _FeatureService.CreateFeatureAsync(createFeatureDto);
            return Ok("Feature added");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteFeature(string id)
        {
            await _FeatureService.DeleteFeatureAsync(id);
            return Ok("Feature deleted");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateFeature(UpdateFeatureDto updateFeatureDto)
        {
            await _FeatureService.UpdateFeatureAsync(updateFeatureDto);
            return Ok("Feature updated");
        }
    }
}
