using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using ECommerce.Data.Core;
using ECommerce.Data.Core.Data;
using ECommerce.Data.Entities.Catalog;
using ECommerce.Data.Entities.Customers;
using ECommerce.Data.Entities.Orders;

namespace ECommerce.Data.Repository
{
    public class CustomerRepository : IRepository<Customer>
    {
        private readonly string _connectionString;
        public CustomerRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public Customer GetById(object id)
        {
            Customer customer;
            using (var conn = DBConnectFactory.ConnectionFactory())
            {
                customer = conn.Query<Customer>("select * FROM Customer Where Id = @Id", new { id = id }).FirstOrDefault();
            }
            return customer;
        }

        public ICollection<Customer> GetByProductId(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Customer> Get()
        {
            throw new NotImplementedException();
        }

        public void Insert(Customer entity)
        {
            using (var connection = DBConnectFactory.ConnectionFactory())
            {
                connection.Open();
                var identity = connection.Execute(
                        "insert into Customer" +
                        "(CustomerGuid" +
                        ",Username" +
                        ",Email" +
                        ",EmailToRevalidate" +
                        ",AdminComment" +
                        ",IsTaxExempt" +
                        ",AffiliateId" +
                        ",VendorId" +
                        ",HasShoppingCartItems" +
                        ",RequireReLogin" +
                        ",FailedLoginAttempts" +
                        ",CannotLoginUntilDateUtc" +
                        ",Active" +
                        ",Deleted" +
                        ",IsSystemAccount" +
                        ",SystemName" +
                        ",LastIpAddress" +
                        ",CreatedOnUtc" +
                        ",LastLoginDateUtc" +
                        ",LastActivityDateUtc" +
                        ",RegisteredInStoreId" +
                        ",BillingAddress_Id" +
                        ",ShippingAddress_Id)" +
                        "Values(" +
                        "@CustomerGuid" +
                        ",@Username" +
                        ",@Email" +
                        ",@EmailToRevalidate" +
                        ",@AdminComment" +
                        ",@IsTaxExempt" +
                        ",@AffiliateId" +
                        ",@VendorId" +
                        ",@HasShoppingCartItems" +
                        ",@RequireReLogin" +
                        ",@FailedLoginAttempts" +
                        ",@CannotLoginUntilDateUtc" +
                        ",@Active" +
                        ",@Deleted" +
                        ",@IsSystemAccount" +
                        ",@SystemName" +
                        ",@LastIpAddress" +
                        ",@CreatedOnUtc" +
                        ",@LastLoginDateUtc,@LastActivityDateUtc,@RegisteredInStoreId,@BillingAddress_Id,@ShippingAddress_Id)",
                    new
                    {
                        CustomerGuid = entity.CustomerGuid,
                        Username = entity.Username,
                        Email = entity.Email,
                        EmailToRevalidate = entity.EmailToRevalidate,
                        AdminComment = entity.AdminComment,
                        IsTaxExempt = entity.IsTaxExempt,
                        AffiliateId = entity.AffiliateId,
                        VendorId = entity.VendorId,
                        HasShoppingCartItems = entity.HasShoppingCartItems,
                        RequireReLogin = entity.RequireReLogin,
                        FailedLoginAttempts = entity.FailedLoginAttempts,
                        CannotLoginUntilDateUtc = entity.CannotLoginUntilDateUtc,
                        Active = entity.Active,
                        Deleted = entity.Deleted,
                        IsSystemAccount = entity.IsSystemAccount,
                        SystemName = entity.SystemName,
                        LastIpAddress = entity.LastIpAddress,
                        CreatedOnUtc = entity.CreatedOnUtc,
                        LastLoginDateUtc = entity.LastLoginDateUtc,
                        LastActivityDateUtc = entity.LastActivityDateUtc,
                        RegisteredInStoreId = entity.RegisteredInStoreId,
                        BillingAddress_Id = entity.BillingAddressId,
                        ShippingAddress_Id = entity.ShippingAddress
                    });
            }
        }

        public void Insert(IEnumerable<Customer> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Update(IEnumerable<Customer> entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(IEnumerable<Customer> entities)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Customer> Table { get; }
        public IQueryable<Customer> TableNoTracking { get; }
    }
}
