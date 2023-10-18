using POS.Application.Common.DataTransferObjects.ReceiptDtos;
using POS.Application.Common.DataTransferObjects.TransactionDtos;

namespace POS.Application.Interfaces;

public interface IReceiptService
{
    Task<ReceiptDto> AddAsync(AddReceiptDto receiptDto, List<ReceiptItemDto> items);
}