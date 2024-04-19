using Autofac;
using DoIT.Data;
using Autofac.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using DoIT;
using static DoIT.DependencyModule;



var builder = WebApplication.CreateBuilder(args);

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(builder =>
builder.RegisterModule(new DependencyModule()));

// Add services to the container.


builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer
(builder.Configuration.GetConnectionString("DefaultConnection")));

/*builder.Services.AddControllers().AddFluentValidation(cfg => cfg.RegisterValidatorsFromAssemblyContaining<LectorCreateValidator>()).AddNewtonsoftJson(
    options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
    );*/


/*builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddScoped<ILectorService, LectorService>();
builder.Services.AddScoped<StudentService>();*/
//Scoped, Transient, Singleton lifetime.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();




// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
