namespace SmartHome.Application.Features.Authentication;

public class GetAuthCodeResponse : IRequest<string>
{
    public string? AuthCode { get; set; }

    public GetAuthCodeResponse(string? authCode)
        => AuthCode = authCode;
}