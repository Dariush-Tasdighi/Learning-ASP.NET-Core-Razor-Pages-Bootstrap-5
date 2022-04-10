// **************************************************
// **************************************************
// **************************************************
// Step 01
// **************************************************
//var builder = WebApplication.CreateBuilder(args);
//var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

//app.Run();
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// **************************************************
// **************************************************
// Step 02
// **************************************************
//using Microsoft.AspNetCore.Builder;
//using Microsoft.Extensions.DependencyInjection;

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(args: args);

//// AddRazorPages() -> using Microsoft.Extensions.DependencyInjection;
//builder.Services.AddRazorPages();

//var app =
//	builder.Build();

//// UseStaticFiles() -> using Microsoft.AspNetCore.Builder;
//app.UseStaticFiles();

//// MapRazorPages() -> using Microsoft.AspNetCore.Builder;
//app.MapRazorPages();

//app.Run();
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// **************************************************
// **************************************************
// Step 03
// **************************************************
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var webApplicationOptions =
	new Microsoft.AspNetCore.Builder.WebApplicationOptions
	{
		EnvironmentName =
			System.Diagnostics.Debugger.IsAttached ?
			Microsoft.Extensions.Hosting.Environments.Development
			:
			Microsoft.Extensions.Hosting.Environments.Production,
	};

var builder =
	Microsoft.AspNetCore.Builder
	.WebApplication.CreateBuilder(options: webApplicationOptions);

// **************************************************
// AddHttpContextAccessor() -> using Microsoft.Extensions.DependencyInjection;
builder.Services.AddHttpContextAccessor();
// **************************************************

// **************************************************
// AddRazorPages() -> using Microsoft.Extensions.DependencyInjection;
builder.Services.AddRazorPages();
// **************************************************

// **************************************************
var app =
	builder.Build();
// **************************************************

// **************************************************
// UseHttpsRedirection() -> using Microsoft.AspNetCore.Builder;
app.UseHttpsRedirection();
// **************************************************

// **************************************************
// UseStaticFiles() -> using Microsoft.AspNetCore.Builder;
app.UseStaticFiles();
// **************************************************

// **************************************************
// MapRazorPages() -> using Microsoft.AspNetCore.Builder;
app.MapRazorPages();
// **************************************************

// **************************************************
app.Run();
// **************************************************
// **************************************************
// **************************************************
