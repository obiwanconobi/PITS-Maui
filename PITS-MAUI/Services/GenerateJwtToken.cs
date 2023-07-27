using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace PITS_MAUI.Services
{
    public class GenerateJwtToken
    {
        public string Generate()
        {
            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345jsdfjsjdfjsdjfslcskveokeorkgoekrgoekrgsoodkxodfdsok"));
            var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
            var tokeOptions = new JwtSecurityToken(
                issuer: "https://api.panaro.uk",
                audience: "webapp",
                claims: new List<Claim>(),
                signingCredentials: signinCredentials,
                expires: DateTime.Now.AddMinutes(5)

            );
            try
            {
                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
                
             //   return "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJleHAiOjE2ODk0NjI0NzMsImlzcyI6Imh0dHBzOi8vYXBpLnBhbmFyby51ayIsImF1ZCI6IndlYmFwcCJ9.-82cDRKyvXUlCMSHM0ffRQ_V03-rszrzMPeN2Cw1GeQ";

                return tokenString;
            }
            catch 
            (Exception ex) 
            {
                return null;
            }
           

          
        }
    }
}
