﻿namespace Saga.Services.OrderService.Repositories;

public interface IRepository<T>
{
    T? Get(Guid id);
    T Insert(T entity);
    T? Update(T entity);
    void Delete(Guid id);
}
