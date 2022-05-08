using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

var host = new WebHostBuilder()
    .UseUrls("http://localhost:80")
    .UseKestrel()
    .Configure(app =>
    {
        app.Run(async (context) =>
        {
            await context.Response.WriteAsync("Hello World");
        });
    })
    .Build();

host.Run();
