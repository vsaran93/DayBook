using System;
using DayBook.Models;

namespace DayBook.Services
{
    public class TransactionService
    {
        private DataContext _dataContext;
        public TransactionService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void CreateTransaction(TransactionDto transactionDto)
        {
            try
            {
                var body = new Transaction
                {
                    Description = transactionDto.Description,
                    Amount = transactionDto.Amount,
                    CreatedAt = transactionDto.CreatedAt
                };

                _dataContext.Transactions.Add(body);

                _dataContext.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Transaction> GetTransactions()
        {
            try
            {
                List <Transaction> result = new List<Transaction>();
                var transactions = _dataContext.Transactions.ToList();

                if (transactions != null)
                {
                    result = transactions;
                }
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Transaction GetTransactionById(int id)
        {
            try
            {
                var transaction = _dataContext.Transactions.First(t => t.Id == id);

                return transaction;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteTransactionById(int id)
        {
            try
            {
                var transaction = _dataContext.Transactions.First(t => t.Id == id);

                _dataContext.Transactions.Remove(transaction);

                _dataContext.SaveChanges();
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateTransaction(int id, TransactionDto transactionDto)
        {
            try
            {
                var transaction = _dataContext.Transactions.First(t => t.Id == id);

                transaction.Description = transactionDto.Description;
                transaction.Amount = transactionDto.Amount;
                transaction.CreatedAt = transaction.CreatedAt;

                _dataContext.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

