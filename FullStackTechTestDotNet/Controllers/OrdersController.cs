namespace FullStackTechTestDotNet.Controllers;

using DataAccessLayer.Entities;
using BusinessLogic;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class OrdersController : ControllerBase
{
    private readonly OrdersLogic _ordersLogic;

    public OrdersController(OrdersLogic ordersLogic)
    {
        _ordersLogic = ordersLogic;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Order>> Get()
    {
        var orders = _ordersLogic.GetOrders();

        return Ok(orders);
    }

    [HttpPost]
    public IActionResult Post([FromBody] Order order)
    {
        _ordersLogic.AddOrder(order);

        return Created();
    }

    [HttpPut("{id}")]
    public IActionResult Put(
        [FromRoute] int id,
        [FromBody] Order updatedOrder)
    {
        _ordersLogic.UpdateOrder(id, updatedOrder);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete([FromRoute] int id)
    {
        _ordersLogic.DeleteOrder(id);

        return NoContent();
    }
}