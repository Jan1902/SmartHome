using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace SmartHome.WebAPI.Controllers;

[ApiController]
public class ApiControllerBase : ControllerBase
{
    private IMediator _mediator;
    protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
}