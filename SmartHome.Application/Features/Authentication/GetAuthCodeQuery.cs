namespace SmartHome.Application.Features.Authentication;

public class GetAuthCodeQuery : IRequest<GetAuthCodeResponse>
{
    public string? RedirectUri { get; set; }
    public string? State { get; set; }

    public GetAuthCodeQuery(GetAuthCodeParameters parameters)
    {
        RedirectUri = parameters.RedirectUri;
        State = parameters.State;
    }
}