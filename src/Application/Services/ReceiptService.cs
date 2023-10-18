using IdentityModels;
using Microsoft.AspNetCore.Identity;
using POS.Application.Common.DataTransferObjects.ReceiptDtos;
using POS.Application.Common.DataTransferObjects.TransactionDtos;
using POS.Application.Interfaces;
using POS.Domain.Interfaces;

namespace BLL.Services;

public class ReceiptService : IReceiptService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly UserManager<User> userManager;

    public ReceiptService(IUnitOfWork unitOfWork, UserManager<User> userManager)
    {
        _unitOfWork = unitOfWork;
        this.userManager = userManager;
    }

    public Task<ReceiptDto> AddAsync(AddReceiptDto receiptDto, List<ReceiptItemDto> items)
    {
        throw new NotImplementedException();
    }
}