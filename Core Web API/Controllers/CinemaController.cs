using Core_Web_API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Core_Web_API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CinemaController : ControllerBase
    {
        private readonly CinemaDbContext Cinemadbcontext;
        public CinemaController(CinemaDbContext CinemaDbContext)
        {
            Cinemadbcontext = CinemaDbContext;
        }



        [HttpGet]
        public IEnumerable<Cinema> GetMovies()
        {
            return Cinemadbcontext.Cinema.ToList();
        }
        [HttpGet("GetMovieById")]
        public Cinema GetMovieById(int Id)
        {
            return Cinemadbcontext.Cinema.Find(Id);
         }
        [HttpPost("InsertMovie")]
        public IActionResult InsertMovie([FromBody] Cinema movie)
        {
            if (movie.Id.ToString() != "")
            {
                Cinemadbcontext.Cinema.Add(movie);
                Cinemadbcontext.SaveChanges();
                return Ok("Movie details saved successfully");
            }
            else
                return BadRequest();
        }
        [HttpPut("UpdateCinema")]
        public IActionResult UpdateTutorial([FromBody] Cinema cinema)
        {
            if (cinema.Id.ToString() != "")
            {
                Cinemadbcontext.Entry(cinema).State = EntityState.Modified;
                Cinemadbcontext.SaveChanges();
                return Ok("Updated successfully");
            }
            else
                return BadRequest();
        }
        [HttpDelete("DeleteCinema")]
        public IActionResult DeleteCinema(int  Id)
        {
            //select * from tutorial where tutorialId=3
            var result = Cinemadbcontext.Cinema.Find(Id);
            Cinemadbcontext.Cinema.Remove(result);
            Cinemadbcontext.SaveChanges();
            return Ok("Deleted successfully");
        }
    }
}
