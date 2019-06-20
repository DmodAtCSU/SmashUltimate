using SmashUltimate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SmashUltimate.Controllers
{
    public class HomeController : ApiController
    {
        [HttpGet]
        [Route("home")]
        public IHttpActionResult DefaultCall()
        {
            GameModel newGame = new GameModel();
            newGame.gameGeneration = "Ultimate";
            newGame.patchNumber = 3.0;
            newGame.player1 = "mario";
            newGame.player2 = "link";

            return Ok(newGame);
        }
    }
}
