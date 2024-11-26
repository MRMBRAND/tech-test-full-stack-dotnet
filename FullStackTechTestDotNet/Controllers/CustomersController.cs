namespace FullStackTechTestDotNet.Controllers;

using DataAccessLayer.Entities;
using BusinessLogic;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class CustomersController : ControllerBase
{
    private readonly CustomersLogic _customersLogic;

    public CustomersController(CustomersLogic customersLogic)
    {
        _customersLogic = customersLogic;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Customer>> Get()
    {
        var orders = _customersLogic.Get();

        return Ok(orders);
    }

    [HttpPost]
    public ActionResult<IEnumerable<Order>> Post([FromBody] Customer customer)
    {
        _customersLogic.AddCustomer(customer);

        return Created();
    }

    [HttpPut("{id}")]
    public ActionResult<IEnumerable<Order>> Put(
        [FromRoute] int id,
        [FromBody] Customer updatedCustomer)
    {
        _customersLogic.UpdateCustomer(id, updatedCustomer);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete([FromRoute] int id)
    {
        _customersLogic.DeleteCustomer(id);

        return NoContent();
    }

    [HttpGet("/api/[controller]/customer-ids-with-orders")]
    public IActionResult GetCustomerIdsWithOrders()
    {
        var customerIdsWithOrders = _customersLogic.GetCustomerIdsWithOrders();

        return Ok(customerIdsWithOrders);
    }
}