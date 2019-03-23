using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using veega.Controllers.Resources;
using veega.Models;
using veega.Persistence;

namespace veega.Controllers
{
    public class FeaturesController : Controller
    {
        private readonly VeegaDbContext context;
        private readonly IMapper mapper;

        public FeaturesController(VeegaDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;
        }

        [HttpGet("/api/features")]
        public async Task<IEnumerable<FeatureResource>> GetFeatures()
        {
            var features = await context.Features.ToListAsync();
            return mapper.Map<List<Feature>, List<FeatureResource>>(features);
        }    
    }
}