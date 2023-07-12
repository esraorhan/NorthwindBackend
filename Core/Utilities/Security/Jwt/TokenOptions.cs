using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Jwt
{
    public class TokenOptions
    {
        public string Audience { get; set; } //kullanıcı kitlesi
        public string Issuer { get; set; } //imzalayan kisi
        public int AccessTokenExpiration { get; set; } //token sona erme süresi
        public string SecurityKey { get; set; }
    }
}
