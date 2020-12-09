using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Innoscripta.Pizza.Authentication
{
    public class AuthOptions
    {
        public const string Issuer = "PizzaServer";
        public const string Audience = "PizzaClient";
        const string Key = "123456789012345678901234567890";
        /// <summary>
        /// In minutes
        /// </summary>
        public const int Lifetime = 24 * 60;
        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Key));
        }
    }
}
