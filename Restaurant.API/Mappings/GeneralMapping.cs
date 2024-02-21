using AutoMapper;
using Restaurant.DTO.DTOs.AboutDTOs;
using Restaurant.DTO.DTOs.BookingDTOs;
using Restaurant.DTO.DTOs.CategoryDTOs;
using Restaurant.DTO.DTOs.ContactDTOs;
using Restaurant.DTO.DTOs.DiscountDTOs;
using Restaurant.DTO.DTOs.FeatureDTOs;
using Restaurant.DTO.DTOs.ProductDTOs;
using Restaurant.DTO.DTOs.SocialMediaDTOs;
using Restaurant.DTO.DTOs.TestimonialDTOs;
using Restaurant.Entity.Entities;

namespace Restaurant.API.Mappings
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<CreateAboutDTO, About>().ReverseMap();
            CreateMap<GetAboutDTO, About>().ReverseMap();
            CreateMap<UpdateAboutDTO, About>().ReverseMap();
            CreateMap<ResultAboutDTO, About>().ReverseMap();

            CreateMap<CreateBookingDTO, Booking>().ReverseMap();
            CreateMap<GetBookingDTO, Booking>().ReverseMap();
            CreateMap<UpdateBookingDTO, Booking>().ReverseMap();
            CreateMap<ResultBookingDTO, Booking>().ReverseMap();

            CreateMap<CreateCategoryDTO, Category>().ReverseMap();
            CreateMap<GetCategoryDTO, Category>().ReverseMap();
            CreateMap<UpdateCategoryDTO, Category>().ReverseMap();
            CreateMap<ResultCategoryDTO, Category>().ReverseMap();

            CreateMap<CreateContactDTO, Contact>().ReverseMap();
            CreateMap<GetContactDTO, Contact>().ReverseMap();
            CreateMap<UpdateContactDTO, Contact>().ReverseMap();
            CreateMap<ResultContactDTO, Contact>().ReverseMap();

            CreateMap<CreateDiscountDTO, Discount>().ReverseMap();
            CreateMap<GetDiscountDTO, Discount>().ReverseMap();
            CreateMap<UpdateDiscountDTO, Discount>().ReverseMap();
            CreateMap<ResultDiscountDTO, Discount>().ReverseMap();

            CreateMap<CreateFeatureDTO, Feature>().ReverseMap();
            CreateMap<GetFeatureDTO, Feature>().ReverseMap();
            CreateMap<UpdateFeatureDTO, Feature>().ReverseMap();
            CreateMap<ResultFeatureDTO, Feature>().ReverseMap();

            CreateMap<CreateProductDTO, Product>().ReverseMap();
            CreateMap<GetProductDTO, Product>().ReverseMap();
            CreateMap<UpdateProductDTO, Product>().ReverseMap();
            CreateMap<ResultProductDTO, Product>().ReverseMap();

            CreateMap<CreateSocialMediaDTO, SocialMedia>().ReverseMap();
            CreateMap<GetSocialMediaDTO, SocialMedia>().ReverseMap();
            CreateMap<UpdateSocialMediaDTO, SocialMedia>().ReverseMap();
            CreateMap<ResultSocialMediaDTO, SocialMedia>().ReverseMap();

            CreateMap<CreateTestimonialDTO, Testimonial>().ReverseMap();
            CreateMap<GetTestimonialDTO, Testimonial>().ReverseMap();
            CreateMap<UpdateTestimonialDTO, Testimonial>().ReverseMap();
            CreateMap<ResultTestimonialDTO, Testimonial>().ReverseMap();
        }
    }
}