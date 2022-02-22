using Microsoft.AspNetCore.Mvc.Testing;
using TextAPI.WebAPI;

namespace TextAPI.IntegrationTests.Helpers;

public class WebAppFactory : WebApplicationFactory<Startup>
{
    public WebAppFactory() : base()
    {
        
    }
}