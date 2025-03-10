using Microsoft.AspNetCore.Mvc;
using OrbitHomeCinema.Core.Interfaces;

namespace OrbitHomeCinema.RestApi.Controllers
{
    public class DefaultController<TEntity> : ControllerBase where TEntity : class
    {
        private readonly IRepository<TEntity> _repository;
        public DefaultController(IRepository<TEntity> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> ListMovies()
        {
            return Ok(await _repository.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var entity = await _repository.GetByIdAsync(id);
            if(entity == null) 
                return NotFound();
            return Ok(entity);
        }

        [HttpPost]
        public async Task<IActionResult> Add(TEntity entity)
        {
            await _repository.AddAsync(entity);
            await _repository.SaveAsync();

            return Ok(entity);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(TEntity entity)
        {
            _repository.Update(entity);
            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var entity = await _repository.GetByIdAsync(id);
            if(entity == null)
                return NotFound();
            _repository.Delete(entity);
            await _repository.SaveAsync();
            return NoContent();
        }
    }
}
