using Application.Commands.Cats;
using Application.Commands.Cats.AddCat;
using Application.Commands.Cats.DeleteCat;
using Application.Commands.Cats.UpdateCat;
using Application.Dtos;
using Application.Queries.Cats.GetAll;
using Application.Queries.Cats.GetById;
using Application.Queries.Cats.GetCatsByBreed;
using Application.Queries.Cats.GetCatsByWeight;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers.CatsController
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatsController : ControllerBase
    {
        internal readonly IMediator _mediator;
        public CatsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //Get all Cats from Db
        [HttpGet]
        [Route("getAllCats")]
        public async Task<IActionResult> GetAllCats()
        {
            return Ok(await _mediator.Send(new GetAllCatsQuery()));
            //Return Ok(Get All Cats)
        }

        //Get Cat By Id
        [HttpGet]
        [Route("getCatById/{catId}")]
        public async Task<IActionResult> GetCatById(Guid catId)
        {
            return Ok(await _mediator.Send(new GetCatByIdQuery(catId)));
        }

        //Create a new Cat
        [HttpPost]
        [Route("addNewCat")]
        public async Task<IActionResult> AddCat([FromBody] CatDto newCat)
        {
            return Ok(await _mediator.Send(new AddCatCommand(newCat)));

        }

        [HttpPut]
        [Route("updateCat/{updateCatId}")]
        public async Task<IActionResult> UpdateCat([FromBody] CatDto updatedCat, Guid updatedCatId)
        {

            return Ok(await _mediator.Send(new UpdateCatByIdCommand(updatedCat, updatedCatId, updatedCat.LikesToPlay)));
        }


        [HttpDelete("{id}")]

        public async Task<IActionResult> DeleteCatById(Guid id)
        {
            var cat = await _mediator.Send(new DeleteCatByIdCommand(id));
            if (cat != null)
            {
                return Ok($"Cat with Id {id} has been successfully deleted.");
            }
            return NotFound();

        }

        //Get cats by breed
        [HttpGet]
        [Route("getCatsByBreed/{catBreed}")]
        public async Task<IActionResult> GetCatsByBreed(string catBreed)
        {
            try
            {
                return Ok(await _mediator.Send(new GetCatsByBreedQuery(catBreed)));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Get cats by Weight
        [HttpGet]
        [Route("getCatsByWeight/{catWeight}")]
        public async Task<IActionResult> GetCatsByWeight(int catWeight)
        {
            try
            {
                return Ok(await _mediator.Send(new GetCatsByWeightQuery(catWeight)));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
