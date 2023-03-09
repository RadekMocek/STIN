var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/time", () => {
    return DateTime.Now.ToString("HH:mm:ss tt");
})
.WithName("GetGreetings")
.WithOpenApi();

app.MapGet("/name", (string input) => {
    string surname;
    if (input.Contains(',')) {
        surname = input.Split(',')[1];
    }
    else if (input.Contains(' ')) {
        surname = input.Split(' ')[0];
    }
    else {
        surname = input;
    }
    return surname;
})
.WithName("GetSurname")
.WithOpenApi();

app.Run();
