using BankingRepository.Business;
using System.Collections.Generic;

namespace BankingRepository.Repositries
{
    public interface ILoanRepository
    {
        List<LInfo> GetAll();
        LInfo Get(int id);
        int Insert(LInfo loan, User user);
        int Update(LInfo loan, User user);
    }
}