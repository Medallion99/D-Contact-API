using BookAPI.Data;
using BookAPI.DataTransferObjects;
using BookAPI.Interfaces;
using BookAPI.Model;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BookAPI.Services
{
    public class UserServices : IUserServices
    {
        private readonly ApiDbContext _ctx;
        private readonly UserManager<User> _userManager;
        private readonly JwtService _jwtService;

        public UserServices(ApiDbContext ctx, UserManager<User> userManager, JwtService jwtService)
        {
            this._ctx = ctx;
            this._userManager = userManager;
            this._jwtService = jwtService;
        }

        public async Task<bool> Register(UserRegisterDto userRegisterDto)
        {
            try
            {
                var user = new User
                {
                    Name = userRegisterDto.Name,
                    Email = userRegisterDto.Email,
                    UserName = userRegisterDto.Email,
                };
                var result = await _userManager.CreateAsync(user, userRegisterDto.Password);
                if(result == null)
                {
                    return false;
                }
                return true;
                
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred during user registration. See logs for details.", ex);
            }

        }

        //public async Task<string> Login(UserRegisterDto userRegisterDto)
        //{
        //    var user = _ctx.Users.FirstOrDefault(x => x.Email == userRegisterDto.Email);
        //    if (user == null)
        //    {
        //        throw new Exception("Email or Password Invalid. You look like a criminal");
        //    }
        //    var result = await _userManager.CheckPasswordAsync(user, userRegisterDto.Password);
        //    if (!result)
        //    {
        //        throw new Exception("Email or Password Invali. you are a Rogue!");
        //    }
        //    var token = _jwtService.GenerateToken(user);
        //    return token;
        //}

        //public List<User> GetAll()
        //{
        //    var result = _ctx.Users.ToList();
        //    return result;
        //}

        //public User GetUserById(string id)
        //{
        //    var user = _ctx.Users.Find(id);
        //    return user;
        //}
        //public string DeleteUser(string id)
        //{
        //    var user = _ctx.Users.Where(s => s.Id == id.ToString()).FirstOrDefault();
        //    if (user != null)
        //    {
        //        _ctx.Users.Remove(user);
        //        return $"User Deleted Succesfully";
        //    }
        //    return $"No Matching Id Found";
        //    throw new NotImplementedException();
        //}
    }
}
