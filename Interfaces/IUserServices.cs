using BookAPI.DataTransferObjects;
using BookAPI.Model;

namespace BookAPI.Interfaces
{
    public interface IUserServices
    {
        Task<bool> Register(UserRegisterDto userRegisterDto);
        //public Task<string> Login(UserRegisterDto userRegisterDto);
        //List<User> GetAll();
        //User GetUserById(string id);
        //string DeleteUser(string id);
    }
}
