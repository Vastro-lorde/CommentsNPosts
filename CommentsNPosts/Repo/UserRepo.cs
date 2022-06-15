using CommentsNPosts.Data;
using CommentsNPosts.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using System.Web.Http.Results;

namespace CommentsNPosts.Repo
{
    public class UserRepo : IUserRepo
    {
        public AppDbContext _DbContext;
        public UserRepo(AppDbContext DbContext)
        {
            _DbContext = DbContext;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            return await _DbContext.Users.ToListAsync();
        }


        public async Task<User> GetById(Guid id)
        {
            var user = await _DbContext.Users.FindAsync(id);
            return user;
        }

        public async Task<bool> CreateUser(User user)
        {
            var NewUser = await _DbContext.Users.AddAsync(user);
            await _DbContext.SaveChangesAsync();
            return NewUser == null? false : true;
        }
    }
}
