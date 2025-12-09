// Este archivo es Fruteria.WebAgricultor/Program.cs

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// ▼▼▼ ¡AÑADE ESTA LÍNEA! ▼▼▼
// Esto registra el servicio HttpClientFactory, necesario
// para que nuestra página IndexModel pueda llamar a la API
builder.Services.AddHttpClient();
// ▲▲▲ ¡AÑADE ESTA LÍNEA! ▲▲▲

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();