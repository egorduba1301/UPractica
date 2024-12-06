using System.Security.Claims;
using JeverlyStroe.Domain.Models;

namespace JeverlyStroe.Domain.Helpers;

public class AuthenticateUserHelper
{
    public static ClaimsIdentity Authenticate(User user)
    {
        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Email, user.Email),
            new Claim(ClaimTypes.Name, user.Login),
            new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Role.ToString()),
            new Claim("AvatarPath", user.ProfileImagePath),
        };
        return new ClaimsIdentity(claims, "ApplicationCookie", ClaimTypes.Email, ClaimsIdentity.DefaultRoleClaimType);
    }
}