using Restaurant.Business.Abstract;
using Restaurant.Business.Concrete;
using Restaurant.DataAccess.Abstract;
using Restaurant.DataAccess.Concrete;
using Restaurant.DataAccess.EntityFramework;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<RestaurantContext>();

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.AddScoped<IAboutService, AboutManager>();
builder.Services.AddScoped<IAboutDAL, EFAboutDAL>();

builder.Services.AddScoped<IBookingService, BookingManager>();
builder.Services.AddScoped<IBookingDAL, EFBookingDAL>();

builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<ICategoryDAL, EFCategoryDAL>();

builder.Services.AddScoped<IContactService, ContactManager>();
builder.Services.AddScoped<IContactDAL, EFContactDAL>();

builder.Services.AddScoped<IDiscountService, DiscountManager>();
builder.Services.AddScoped<IDiscountDAL, EFDiscountDAL>();

builder.Services.AddScoped<IFeatureService, FeatureManager>();
builder.Services.AddScoped<IFeatureDAL, EFFeatureDAL>();

builder.Services.AddScoped<IProductService, ProductManager>();
builder.Services.AddScoped<IProductDAL, EFProductDAL>();

builder.Services.AddScoped<ITestimonialService, TestimonialManager>();
builder.Services.AddScoped<ITestimonialDAL, EFTestimonialDAL>();

builder.Services.AddScoped<ISocialMediaService, SocialMediaManager>();
builder.Services.AddScoped<ISocialMediaDAL, EFSocialMediaDAL>();

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
