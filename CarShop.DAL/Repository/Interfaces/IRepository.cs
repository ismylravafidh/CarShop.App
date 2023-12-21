using CarShop.Core.Common.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.DAL.Repository.Interfaces
{
    public interface IRepository<T> where T : BaseEntity, new()
    {
        Task<IQueryable<T>> GetAllAsync(Expression<Func<T, bool>>? expression = null,
            Expression<Func<T, object>>? orderbyExpression = null,
            bool isDescinding = false,
            params string[]? includes);
        DbSet<T> Table { get; }
    }
}
