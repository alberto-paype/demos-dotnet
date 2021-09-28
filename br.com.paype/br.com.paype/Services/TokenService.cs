using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using br.com.paype.Data;
using br.com.paype.Models;
using System.Security.Cryptography;
using Microsoft.Extensions.Configuration;
using br.com.paype.Models.TI;
using Microsoft.EntityFrameworkCore;

namespace br.com.paype.Services
{
    public static class TokenService
    {

        //public static string GenerateToken([FromServices] DataContextDB context)
        public static string GenerateToken(Usuario user, DataContextDB context)
        {
            
            var tokenHandler = new JwtSecurityTokenHandler();
            string chave = Startup.StaticConfig.GetSection("API").GetSection("chave").Value;
            var hashSHA256 = TokenService.GenerateHashSHA256(chave);
            var key = Encoding.ASCII.GetBytes(hashSHA256); //chave secreta
            SecurityKey symetricSecurityKey = new SymmetricSecurityKey(key);
            UsuarioStore _userStore = new UsuarioStore(user);

            //List<dynamic> permissoes = _userStore.GetPermissoes();

            List<Claim> claims = new List<Claim> {
                new Claim(ClaimTypes.Name, user.Username)
            };

            //foreach (var permissao in permissoes)
            //{
            //    claims.Add(new Claim(ClaimTypes.Role, permissao.Role));
            //    claims.Add(new Claim("policies", permissao.Role + "." + permissao.Policy));
            //}

            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddHours(12),
                SigningCredentials = new SigningCredentials(symetricSecurityKey, SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);

        }

        public static JwtSecurityToken DecodeToken(string token)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            return tokenHandler.ReadJwtToken(token.Replace("Bearer ", ""));
        }

        public static string GenerateHashSHA256(string chave)
        {
            SHA256 sha256Hash = SHA256.Create();

            // ComputeHash - returns byte array  
            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(chave));

            // Convert byte array to a string   
            StringBuilder builder = new();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2"));
            }
            return builder.ToString();
        }

    }
}

