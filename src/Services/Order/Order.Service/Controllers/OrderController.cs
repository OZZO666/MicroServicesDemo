using MediatR;
using Microsoft.AspNetCore.Mvc;
using Order.Common.Entities;
using Order.Service.Handlers.Order.Commands;
using Order.Service.Handlers.Order.Queries;

namespace Order.Service.Controllers;

[ApiController]
[Route("/api/[controller]/")]
public class OrderController : ControllerBase
{
    private readonly IMediator _mediator;
    
    public OrderController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    [Route("{orderId}")]
    public async Task<IActionResult> Get(Guid orderId)
    {
        var query = new GetOrderQuery() {OrderId = orderId};
        return Ok(await _mediator.Send(query));
    }
    
    [HttpPost]
    public async Task<IActionResult> Post(CreateOrderCommand command)
    {
        return Ok(await _mediator.Send(command));
    }
}