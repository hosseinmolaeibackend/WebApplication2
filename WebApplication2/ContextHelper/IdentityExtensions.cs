using System.Security.Claims;

namespace WebApplication2.ContextHelper;

public static class IdentityExtensions
{
    public static int GetUserId(this ClaimsPrincipal principal)
    {
        var claim = principal.Claims.SingleOrDefault(u => u.Type == ClaimTypes.NameIdentifier);
        if (claim!=null)
        {
            return Convert.ToInt32(claim.Value);
        }
        return default;
    }

    public static string GetUserEmail(this ClaimsPrincipal principal)
    {
        var claim = principal.Claims.SingleOrDefault(c => c.Type == ClaimTypes.Email);
        if (claim!=null) return claim.Value;
        return "";
    }
}