﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sample_api_mongodb.Core.DTOs;
using sample_api_mongodb.Core.Entities;
using sample_api_mongodb.Core.Interfaces.Services;
using sample_api_mongodb.Core.Responses;
using System.Net;

namespace sample_api_mongodb.Api.Controllers
{
    [Authorize(Roles = "Developer, Administrator")]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController(IUserService _service) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _service.GetAll();
            return response.success ? Ok(response) : BadRequest(response.message);
        }

        //[HttpPost]
        //public async Task<IActionResult> Insert(UserDTO model)
        //{
        //    var response = await _service.Insert(model);
        //    return Ok(response);
        //}

        //[HttpPut]
        //public async Task<IActionResult> Update(ProductDTO model)
        //{
        //    var response = await _service.Update(model);
        //    return Ok(response);
        //}

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var response = await _service.Delete(id);
            return response.success ? Ok(response) : BadRequest(response.message);
        }
    }
}
