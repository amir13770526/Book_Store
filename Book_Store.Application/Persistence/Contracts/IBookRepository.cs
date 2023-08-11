﻿using Book_Store.Domain.Entites;

namespace Book_Store.Application.Persistence.Contracts
{
    public interface IBookRepository : IGenericRepository<Book>
    {
        Task<List<Book>> GetBooksWithDetailes();

        Task<Book> GetBookWithDetaile(int id);
    }
}
