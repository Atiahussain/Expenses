using Expensive.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expensive.DataAciton.Resposities
{
   public class ExpenseRespository : IExpensiveRespository
    {
        private readonly ApplicationDbContext _context;

        public ExpenseRespository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(ExpensiveModel expense)
        {
            try
            {
                
            }
            catch(Exception)
            {

            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ExpensiveModel> GetAllExpenses()
        {
            throw new NotImplementedException();
        }

        public ExpensiveModel GetExpenseById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ExpensiveModel> Search(string searchString)
        {
            throw new NotImplementedException();
        }

        public int Update(ExpensiveModel expenses)
        {
            throw new NotImplementedException();
        }
    }
}
