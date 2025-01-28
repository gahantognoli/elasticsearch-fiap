using AutoMapper;
using crop_api_elastic_demo.Entities;
using crop_api_elastic_demo.ViewModels;

namespace crop_api_elastic_demo.Mappers;

public class ViewModelToEntityMapping : Profile
{

    public ViewModelToEntityMapping()
    {
        CreateMap<CropViewModel, Crop>();
    }
    
}