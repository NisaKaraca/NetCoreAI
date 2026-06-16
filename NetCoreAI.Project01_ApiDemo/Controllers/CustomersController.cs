using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreAI.Project01_ApiDemo.Context;
using NetCoreAI.Project01_ApiDemo.Entities;

namespace NetCoreAI.Project01_ApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ApiContext _context;
        public CustomersController(ApiContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult CustomerList()
        {
            var values = _context.Customers.ToList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return Ok("Müşteri ekleme işlemi başarılı");
        }
        [HttpDelete]
        public IActionResult DeleteCustomer(int id)
        {
            var customer = _context.Customers.Find(id);
            if (customer == null)
            {
                return NotFound("Müşteri bulunamadı");
            }
            _context.Customers.Remove(customer);
            _context.SaveChanges();
            return Ok("Müşteri silme işlemi başarılı");
        }
        [HttpGet("{id}")]
        public IActionResult GetCustomer(int id)
        {
            var customer = _context.Customers.Find(id);
            if (customer == null)
            {
                return NotFound("Müşteri bulunamadı");
            }
            return Ok(customer);
        }
        [HttpPut]
        public IActionResult UpdateCustomer(Customer customer)
        {
            var existingCustomer = _context.Customers.Find(customer.CustomerID);
            if(existingCustomer == null)
            {
                return NotFound("Müşteri bulunamadı");
            }
            existingCustomer.CustomerName = customer.CustomerName;
            existingCustomer.CustomerSurname = customer.CustomerSurname;
            existingCustomer.CustomerBalance = customer.CustomerBalance;
            _context.SaveChanges();
            return Ok("Müşteri güncelleme işlemi başarılı");
        }
    }
}
