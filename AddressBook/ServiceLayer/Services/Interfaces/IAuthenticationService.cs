using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models;
namespace ServiceLayer.Services.Interfaces
{
    public interface IAuthService
    {
        Task<AuthModel> RegisterAsync(User user);
        Task<JwtSecurityToken> CreateJwtToken(User user);
        Task<AuthModel> GetTokenAsync(TokenRequestModel model);
    }
}
