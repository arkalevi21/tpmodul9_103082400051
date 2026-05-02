var builder = WebApplication.CreateBuilder(args);

// Tambahkan services untuk Controller
builder.Services.AddControllers();

// Tambahkan services untuk Swagger UI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Konfigurasi HTTP untuk menampilkan halaman Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// rute agar mengarah ke MahasiswaController
app.MapControllers();

app.Run();