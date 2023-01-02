using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace SmartHome.Application.Features.Authentication;

public class GetAuthCodeParameters
{
    [FromQuery(Name = "redirect_uri")]
    public string? RedirectUri { get; set; }

    [FromQuery(Name = "state")]
    public string? State { get; set; }
}