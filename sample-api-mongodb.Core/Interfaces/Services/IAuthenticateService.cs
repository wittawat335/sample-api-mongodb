﻿using sample_api_mongodb.Core.DTOs;
using sample_api_mongodb.Core.Entities;

namespace sample_api_mongodb.Core.Interfaces.Services
{
    public interface IAuthenticateService
    {
        Task<LoginResponse> LoginAsync(LoginRequest request);
        Task<RegisterReaponse> RegisterAsync(RegisterRequest request);
        Task<LoginResponse> CreateToken(ApplicationUser user);
        Task<LoginResponse> RefreshToken(LoginResponse token);
        Task CreateRole(CreateRoleRequest request);
    }
}
