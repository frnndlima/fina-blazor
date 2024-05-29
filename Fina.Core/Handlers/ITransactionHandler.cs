using Fina.Core.Models;
using Fina.Core.Requests.Transactions;
using Fina.Core.Responses;

namespace Fina.Core.Handlers
{
    public interface ITransactionHandler
    {
        Task<Response<Transaction?>> CreateAsync(CreateTransactionRequest createTransactionRequest);
        Task<Response<Transaction?>> UpdateAsync(UpdateTransactionRequest updateTransactionRequest);
        Task<Response<Transaction?>> DeleteAsync(DeleteTransactionRequest deleteTransactionRequest);
        Task<Response<Transaction?>> GetByIdAsync(GetTransactionByIdRequest createTransactionRequest);
        Task<PagedResponse<List<Transaction>?>> GetByPeriodAsync(GetTransactionsByPeriodRequest getTransactionByPeriod);
    }
}
