using Expensive.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expensive.DataAciton.Resposities
{
    public interface IExpensiveRespository
    {
        IEnumerable<ExpensiveModel> GetAllExpenses();
        IEnumerable<ExpensiveModel> Search(string searchString);
        void Add(ExpensiveModel expense);
        int Update(ExpensiveModel expenses);
        ExpensiveModel GetExpenseById(int id);
        void Delete(int id);
     }
}
