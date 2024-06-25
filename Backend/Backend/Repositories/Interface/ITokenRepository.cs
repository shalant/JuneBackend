using Microsoft.AspNetCore.Identity;

namespace Backend.Repositories.Interface;

public interface ITokenRepository
{
    string CreateJwtToken(IdentityUser user, List<string> roles);
}
