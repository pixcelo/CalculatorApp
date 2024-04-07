using CalculatorApp.Models;

namespace CalculatorApp.Repositories
{
    public interface IHistoryRepository
    {
        void Save(History history);
        void Delete(History history);
        History Find(int id);
    }
}
