using System.Text;
using System.Web;

namespace SmartHome.Application.Features.Authentication;

public class GetAuthCodeHandler : IRequestHandler<GetAuthCodeQuery, GetAuthCodeResponse>
{
    public Task<GetAuthCodeResponse> Handle(GetAuthCodeQuery request, CancellationToken cancellationToken)
    {
        var byteArray = new byte[64];
        new Random().NextBytes(byteArray);
        var authCode = HttpUtility.UrlEncode(Encoding.UTF8.GetString(byteArray));

        return Task.FromResult(new GetAuthCodeResponse(authCode));
    }
}