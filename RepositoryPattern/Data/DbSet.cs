using RepositoryPattern.Models;
using System;
using System.Collections.Generic;

namespace RepositoryPattern.Data
{
    public class DbSet<T>
    {
        internal void Remove(Employee employee)
        {
            throw new NotImplementedException();
        }

        internal List<Employee> ToList()
        {
            throw new NotImplementedException();
        }

        internal object Where(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }

        internal void Add(Employee employee)
        {
            throw new NotImplementedException();
        }

        internal void Update(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}