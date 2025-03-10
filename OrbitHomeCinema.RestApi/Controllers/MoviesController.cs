using Microsoft.AspNetCore.Mvc;
using OrbitHomeCinema.Core.Entities;
using OrbitHomeCinema.Core.Interfaces;

namespace OrbitHomeCinema.RestApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController(IRepository<Movie> repository) : DefaultController<Movie>(repository)
    {

    }
}
