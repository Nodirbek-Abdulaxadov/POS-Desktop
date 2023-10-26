using POS.Application.Common.Enums;
using POS.Application.Common.Models;
using POS.Application.Interfaces;
using POS.Domain.Entities.Auth;
using POS.Domain.Interfaces;

namespace POS.Application.Services;
public class AuthService : IAuthInterface
{
    private readonly IUnitOfWork _unitOfWork;

    public AuthService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Result> LoginAsync(string phoneNumber, string password, UserRoles role)
    {
        var users = await _unitOfWork.Users.GetAllAsync();
        var user = users.FirstOrDefault(u => u.PhoneNumber == phoneNumber);
       
        if (user == null)
        {
            return new Result(false, ErrorMessages.USER_NOT_FOUND);
        }

        if (CheckPassword(user, password))
        {
            if (!IsInRole(user, role))
            {
                return new Result(false, ErrorMessages.ACCESS_DENIED);
            }

            return new Result();
        }

        return new Result(false, ErrorMessages.LOGIN_FAILED);
    }

    private bool CheckPassword(User user, string password)
    {
        var userPassword = PasswordEncoder.EncodePasswordToBase64(password);
        return user.PasswordHash.Equals(userPassword);
    }

    private bool IsInRole(User user, UserRoles role)
    {
        return user.Role.ToString().Equals(role.ToString());
    }
}