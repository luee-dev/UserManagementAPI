using UserManagementAPI.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// ✅ Middleware pipeline order
app.UseMiddleware<ErrorHandlingMiddleware>();        // 1. Catch exceptions first
app.UseMiddleware<TokenAuthenticationMiddleware>();  // 2. Enforce authentication
app.UseMiddleware<RequestResponseLoggingMiddleware>(); // 3. Log requests/responses

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();