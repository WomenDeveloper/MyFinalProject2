using Autofac;
using Autofac.Extensions.DependencyInjection;
using Business.Abstract;
using Business.Concreate;
using Business.DependencyResolvers.Autofac;
using DataAccess.Abstract;
using DataAccess.Concreate.EntityFramework;

var builder = WebApplication.CreateBuilder(args);
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory())
    .ConfigureContainer<ContainerBuilder>(builder =>
    {
        builder.RegisterModule(new AutofacBusinessModule());
    });
    

// Add services to the container.
//Autofac,Ninjet,CastleWindsor,StructureMap,LightInject,DryInject-->IoC C.
builder.Services.AddControllers();
//builder.Services.AddSingleton<IProductService,ProductManager>();
//builder.Services.AddSingleton<IProductDal, EfProductDal>();
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

