using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using Telegram.Bot;
using Telegram.Bot.Types;

using WeatherBotLib;

namespace WeatherBotApi.Controllers
{
    [ApiController]
    public class HandleUpdateController : ControllerBase
    {
        private readonly ILogger<HandleUpdateController> _logger;
        private readonly WeatherBot _bot;

        public HandleUpdateController(ILogger<HandleUpdateController> logger, WeatherBot bot)
        {
            _logger = logger;
            _bot = bot;
        }

        [HttpPost]
        [Route("")]
        public IActionResult HandleUpdates([FromBody] Update update)
        {
            Console.WriteLine("hey!");
            try
            {
                _bot.HandleUpdate(update);
                return Ok();
            } catch (Exception e) {
                _logger.LogCritical(new EventId(0), e, "bot cann't handle message");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet] 
        [Route("")]
        public IActionResult Foo() {
            return Ok("True");
        }
    }
}
