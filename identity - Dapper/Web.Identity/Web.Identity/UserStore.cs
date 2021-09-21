using Microsoft.AspNetCore.Identity;
using Dapper;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Web.Identity
{
    public class UserStore : IUserStore<User>, IUserPasswordStore<User>
    {
        public DbConnection GetDBConnection()
        {
            var connection = new SqlConnection("Data Source=HOMOLOGAESCALA;Initial Catalog=identity;User ID=sa;Password=#escalasoft123");
            connection.Open();
            return connection;
        }

        public async Task<IdentityResult> CreateAsync(User user, CancellationToken cancellationToken)
        {
            using(var con = GetDBConnection())
            {
                await con.ExecuteAsync(
                    "INSERT INTO dbo.Users VALUES(@Id, @UserName, @NormalizedUserName, @PasswordHash)",
                    new
                    {
                        Id = user.Id,
                        UserName = user.UserName,
                        NormalizedUserName = user.NormalizedUserName,
                        PasswordHash = user.PasswordHash
                    });
            }

            return IdentityResult.Success;
        }

        public async Task<IdentityResult> DeleteAsync(User user, CancellationToken cancellationToken)
        {
            using (var con = GetDBConnection())
            {
                await con.ExecuteAsync(
                    "DELETE FROM users WHERE Id = @id",
                    new { id = user.Id });
            }

            return IdentityResult.Success;
        }

        public void Dispose()
        {
            
        }

        public async Task<User> FindByIdAsync(string userId, CancellationToken cancellationToken)
        {
            using(var con = GetDBConnection())
            {
                return await con.QueryFirstOrDefaultAsync<User>(
                    "SELECT * FROM users WHERE Id = @id",
                    new { id = userId });
            }
        }

        public async Task<User> FindByNameAsync(string UserName, CancellationToken cancellationToken)
        {
            using (var con = GetDBConnection())
            {
                return await con.QueryFirstOrDefaultAsync<User>(
                    "SELECT * FROM users WHERE UserName = @UserName",
                    new { UserName });
            }
        }

        public Task<string> GetNormalizedUserNameAsync(User user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.NormalizedUserName);
        }

        public Task<string> GetUserIdAsync(User user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.Id);
        }

        public Task<string> GetUserNameAsync(User user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.UserName);
        }

        public Task SetNormalizedUserNameAsync(User user, string normalizedName, CancellationToken cancellationToken)
        {
            user.NormalizedUserName = normalizedName;
            return Task.CompletedTask;
        }

        public Task SetUserNameAsync(User user, string userName, CancellationToken cancellationToken)
        {
            user.UserName = userName;
            return Task.CompletedTask;
        }

        public async Task<IdentityResult> UpdateAsync(User user, CancellationToken cancellationToken)
        {
            using (var con = GetDBConnection())
            {
                await con.ExecuteAsync(
                    "UPDATE users SET " +
                    "UserName = @UserName," +
                    "NormalizedUserName = @NormalizedUserName" +
                    "PaswordHash = @PaswordHash" +
                    "WHERE Id = @Id",
                    new
                    {
                        Id = user.Id,
                        UserName = user.UserName,
                        NormalizedUserName = user.NormalizedUserName,
                        PaswordHash = user.PasswordHash
                    });
            }

            return IdentityResult.Success;
        }

        public Task SetPasswordHashAsync(User user, string passwordHash)
        {
            user.PasswordHash = passwordHash;
            return Task.FromResult(0);
        }
        public Task<string> GetPasswordHashAsync(User user)
        {
            return Task.FromResult<string>(user.PasswordHash);
        }
        public Task<bool> HasPasswordAsync(User user)
        {
            return Task.FromResult<bool>(!String.IsNullOrEmpty(user.PasswordHash));
        }

        public Task SetPasswordHashAsync(User user, string passwordHash, CancellationToken cancellationToken)
        {
            user.PasswordHash = passwordHash;
            return Task.CompletedTask;
        }

        public Task<string> GetPasswordHashAsync(User user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.PasswordHash);
        }

        public Task<bool> HasPasswordAsync(User user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.PasswordHash != null);
        }
    }
}
