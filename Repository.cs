// Name: Alex Kotoka
// Student ID: 11123892
// Project: Multi-question C# Console Application
// Date: August 2025

using System;
using System.Collections.Generic;
using System.Linq;

namespace AssignmentSolutions.Q2.Health
{
    // Generic repository for entity management
    public class Repository<T>
    {
        private readonly List<T> items = new();

        public void Add(T item) => items.Add(item);
        public List<T> GetAll() => new(items);
        public T? GetById(Func<T, bool> predicate) => items.FirstOrDefault(predicate);
        public bool Remove(Func<T, bool> predicate)
        {
            var i = items.FirstOrDefault(predicate);
            if (i is null) return false;
            return items.Remove(i);
        }
    }
}
