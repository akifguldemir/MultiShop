﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Catalog.Dtos.AboutDto;
using MultiShop.Catalog.Services.AboutServices;

namespace MultiShop.Catalog.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController : ControllerBase
    {
        private readonly IAboutService _AboutService;

        public AboutsController(IAboutService AboutService)
        {
            _AboutService = AboutService;
        }

        [HttpGet]
        public async Task<IActionResult> AboutList()
        {
            var values = await _AboutService.GetAllAboutAsync();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAboutById(string id)
        {
            var values = await _AboutService.GetByIdAboutAsync(id);
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAbout(CreateAboutDto createAboutDto)
        {
            await _AboutService.CreateAboutAsync(createAboutDto);
            return Ok("About added");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAbout(string id)
        {
            await _AboutService.DeleteAboutAsync(id);
            return Ok("About deleted");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAbout(UpdateAboutDto updateAboutDto)
        {
            await _AboutService.UpdateAboutAsync(updateAboutDto);
            return Ok("About updated");
        }
    }
}
