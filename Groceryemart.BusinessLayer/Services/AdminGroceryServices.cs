﻿using GroceryEmart.BusinessLayer.Interfaces;
using GroceryEmart.BusinessLayer.Services.Repository;
using GroceryEmart.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GroceryEmart.BusinessLayer.Services
{
    public class AdminGroceryServices : IAdminGroceryServices
    {
        /// <summary>
        /// Creating referance Variable of IAdminGroceryRepository and injecting in AdminGroceryServices constructor
        /// </summary>
        private readonly IAdminGroceryRepository _adminRepository;

        public AdminGroceryServices(IAdminGroceryRepository adminGroceryRepository)
        {
            _adminRepository = adminGroceryRepository;
        }
        /// <summary>
        /// Add new category in category sql database
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public async Task<Category> AddCategory(Category category)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Add new Product
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public async Task<Product> AddProduct(Product product)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get all order
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<ProductOrder>> AllOrder()
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// get all product
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Product>> AllProduct()
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get all user
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<ApplicationUser>> GetAllUser()
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get Category ById
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Task<Category> GetCategoryById(int Id)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get Order By Id
        /// </summary>
        /// <param name="OrderId"></param>
        /// <returns></returns>
        public Task<ProductOrder> GetOrderById(int OrderId)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get Product By Id
        /// </summary>
        /// <param name="ProductId"></param>
        /// <returns></returns>
        public Task<Product> GetProductById(int ProductId)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Remove Category
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<bool> RemoveCategory(int Id)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Remove Product
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<bool> RemoveProduct(int Id)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Update Category
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="category"></param>
        /// <returns></returns>
        public Task<Category> UpdateCategory(int Id, Category category)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Update Product
        /// </summary>
        /// <param name="ProductId"></param>
        /// <param name="product"></param>
        /// <returns></returns>
        public Task<Product> UpdateProduct(int ProductId, Product product)
        {
            //Do code here
            throw new NotImplementedException();
        }
    }
}
