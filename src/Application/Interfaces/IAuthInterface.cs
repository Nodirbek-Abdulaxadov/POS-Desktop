using POS.Application.Common.DataTransferObjects.UserDtos;
using POS.Application.Common.Enums;
using POS.Application.Common.Models;

namespace POS.Application.Interfaces;
public interface IAuthInterface
{
    Task<Result> LoginAsync(string phoneNumber, string password, UserRoles role);
}