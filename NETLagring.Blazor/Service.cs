using NETLagring.Blazor.Model;
using System.Collections.Generic;
using System.Linq;

namespace NETLagring.Blazor
{
    public class Service
    {
        private readonly ApplicationDbContext db;
        public Service(ApplicationDbContext _db)
        {
            db = _db;
        }
        public int? AddCustomer(Customer model)
        {
            var customer = new Customer
            {
                Name = model.Name,
                Mail = model.Mail,
                PhoneNumber = model.PhoneNumber,
                City = model.City,
                Country = model.Country,
            };
            db.Customers.Add(customer);
            db.SaveChanges();

            return customer.Id;
        }

        public List<Customer> GetListOfCustomer()
        {
            var getList = db.Customers.ToList();
            return getList;
        }

        public int? AddCustomerService(CustomersService model)
        {
            var customerService = new CustomersService
            {
                Rubric = model.Rubric,
                Description = model.Description,
                Created = System.DateTime.Now,
                Status = model.Status,
                CustomerId = db.Customers.FirstOrDefault(x => x.Id == model.CustomerId).Id
            };
            db.CustomersServices.Add(customerService);
            db.SaveChanges();

            return customerService.Id;
        }
        public List<CustomersService> GetListOfService()
        {
            var getList = db.CustomersServices.ToList();
            return getList;
        }
        public void EditStatus(int id, CustomersService model)
        {
            var getServiceId = db.CustomersServices.FirstOrDefault(x => x.Id == id);
            if (getServiceId != null)
            {
                getServiceId.Status = model.Status;
                getServiceId.LastEdited = System.DateTime.Now;

                db.CustomersServices.Update(getServiceId);
                db.SaveChanges();

            }
        }
    }
}
