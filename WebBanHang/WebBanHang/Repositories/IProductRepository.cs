﻿using System.Collections.Generic;
using WebBanHang.Models;

namespace WebBanHang.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        void Add(Product product);
        void Update(Product product);
        void Delete(int id);

    }
}
