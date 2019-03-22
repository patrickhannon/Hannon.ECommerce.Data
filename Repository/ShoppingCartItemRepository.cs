using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
using ECommerce.Data.Core;
using ECommerce.Data.Core.Data;
using ECommerce.Data.Entities;
using ECommerce.Data.Entities.Catalog;
using ECommerce.Data.Entities.Orders;

namespace ECommerce.Data.Repository
{
    public class ShoppingCartItemRepository : IRepository<ShoppingCartItem>, ICustomerRepository
    {
        private readonly string _connectionString;
        public ShoppingCartItemRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Delete(IEnumerable<ShoppingCartItem> entities)
        {
            throw new NotImplementedException();
        }

        public IQueryable<ShoppingCartItem> Table { get; }

        public IQueryable<ShoppingCartItem> TableNoTracking { get; }

        public ShoppingCartItem GetById(object id)
        {
            ShoppingCartItem shoppingCartItem;
            using (var conn = DBConnectFactory.ConnectionFactory())
            {
                shoppingCartItem = conn.Query<ShoppingCartItem>("select * FROM ShoppingCartItem Where Id = @Id", new { id = id }).FirstOrDefault();
            }
            return shoppingCartItem;
        }

        ICollection<ShoppingCartItem> IRepository<ShoppingCartItem>.GetByProductId(int id)
        {
            throw new NotImplementedException();
        }

        IList<ShoppingCartItem> IRepository<ShoppingCartItem>.Get()
        {
            throw new NotImplementedException();
        }

        public IList<ShoppingCartItem> GetByCustomerId(object id)
        {
            IList<ShoppingCartItem> items;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                items = connection.Query<ShoppingCartItem>("select * FROM ShoppingCartItem Where CustomerId = @Id", new { id = id}).ToList();
            }
            return items;
        }


        public ICollection<Category> GetByProductId(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Category> Get()
        {
            IList<Category> category;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                category = connection.Query<Category>("select * FROM ShoppingCartItem").ToList();
            }
            return category;
        }

        public void Insert(ShoppingCartItem item)
        {
            using (var connection = DBConnectFactory.ConnectionFactory())
            {
                connection.Open();
                var identity = connection.Execute("insert into ShoppingCartItem" +
                                            "(StoreId,ShoppingCartTypeId,CustomerId,ProductId,Quantity,CreatedOnUtc, UpdatedOnUtc) " +
                                "values (@StoreId,@ShoppingCartTypeId,@CustomerId,@ProductId,@Quantity,@CreatedOnUtc,@UpdatedOnUtc)",
                new
                {
                    StoreId = item.StoreId,
                    ShoppingCartTypeId = item.ShoppingCartTypeId,
                    CustomerId = item.CustomerId,
                    ProductId = item.ProductId,
                    Quantity = item.Quantity,
                    CreatedOnUtc = item.CreatedOnUtc,
                    UpdatedOnUtc = item.UpdatedOnUtc
                });
            }
        }

        public void Insert(IEnumerable<ShoppingCartItem> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(ShoppingCartItem item)
        {
            using (var connection = DBConnectFactory.ConnectionFactory())
            {
                connection.Open();
                var identity = connection.Execute("update ShoppingCartItem" +
                                                  "set StoreId =@StoreId," +
                                                  "ShoppingCartTypeId = @ShoppingCartTypeId," +
                                                  "CustomerId = @CustomerId," +
                                                  "ProductId = @ProductId," +
                                                  "Quantity = @Quantity" +
                                                  " Where Id = @Id",
                    new
                    {
                        Id = item.Id,
                        StoreId = item.StoreId,
                        ShoppingCartTypeId = item.ShoppingCartTypeId,
                        CustomerId = item.Customer.Id,
                        ProductId = item.ProductId,
                        Quantity = item.Quantity
                    });
            }
        }

        public void Update(IEnumerable<ShoppingCartItem> entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(ShoppingCartItem entity)
        {
            throw new NotImplementedException();
        }
    }
}
