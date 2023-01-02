namespace SmartHome.Application;

using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using MediatR;

public static class Extensions
{
    public static void AddApplicationLayer(this ServiceCollection services)
    {
        services.AddMediatR(Assembly.GetExecutingAssembly());
    }
}