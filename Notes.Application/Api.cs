using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore;

namespace Notes.Application
{
    internal class Api
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        app.MapGet("/" => "Hello");

        app.Run();
    }
}
