using APIProje.WebApi.Context;
using APIProje.WebApi.Dtos.FeatureDtos;
using APIProje.WebApi.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace APIProje.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeaturesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly APIContext _contex;


        public FeaturesController(IMapper mapper, APIContext contex)
        {
            _mapper = mapper;
            _contex = contex;
        }

        [HttpGet]

        public IActionResult FeatureList()
        {
            var values = _contex.Features.ToList();
            return Ok(_mapper.Map<List<ResultFeatureDto>>(values));
        }

        [HttpPost]

        public IActionResult CreateFeature(CreateFeatureDto createFeatureDto)
        {
            var value = _mapper.Map<Feature>(createFeatureDto);
            _contex.Features.Add(value);
            _contex.SaveChanges();
            return Ok("It has been added");
        }

        [HttpDelete]

        public IActionResult DeleteFeature(int id)
        {

            var value = _contex.Features.Find(id);
            _contex.Features.Remove(value);
            return Ok("Deletion successfull.");
        }

        [HttpGet("GetFeature")]

        public IActionResult GetFeature(int id)
        {
            
                var value = _contex.Features.Find(id);
                return Ok(_mapper.Map<GetByIdFeatureDto>(value));

            
        }

        [HttpPut]

        public IActionResult UpdateFeature(UpdateFeatureDto updateFeatureDto)
        {
            var value = _mapper.Map<Feature>(updateFeatureDto);
            _contex.Features.Update(value);
            _contex.SaveChanges();
            return Ok("It has been updated");
        }



    }
}
