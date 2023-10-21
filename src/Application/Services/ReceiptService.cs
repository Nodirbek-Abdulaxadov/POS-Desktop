using POS.Application.Common.DataTransferObjects.ReceiptDtos;
using POS.Application.Common.DataTransferObjects.TransactionDtos;
using POS.Application.Interfaces;
using POS.Domain.Interfaces;

namespace POS.Application.Services;

public class ReceiptService : IReceiptService
{
    private readonly IUnitOfWork _unitOfWork;

    public ReceiptService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public Task<ReceiptDto> AddAsync(AddReceiptDto receiptDto, List<ReceiptItemDto> items)
    {
        throw new NotImplementedException();
    }
}