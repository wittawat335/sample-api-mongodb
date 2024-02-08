﻿using Microsoft.AspNetCore.Mvc;
using sample_api_mongodb.Core.DTOs;
using sample_api_mongodb.Core.Interfaces.Services;

namespace sample_api_mongodb.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticateController(IAuthenticateService _service) : ControllerBase
    {
        //[HttpPost]
        //[Route("refresh-token")]
        //public async Task<IActionResult> RefreshToken()
        //{

        //    var response = await _service.LoginAsync(request);

        //    return Ok(response);
        //}

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            var response = await _service.LoginAsync(request);
            return Ok(response);
        }
        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest request)
        {

            var response = await _service.RegisterAsync(request);
            return response.Success ? Ok(response) : BadRequest(response.Message);
        }
    }
}
