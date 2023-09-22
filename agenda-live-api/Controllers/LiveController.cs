using agenda_live_api.Domain.DTOs;
using agenda_live_api.Domain.Models;
using agenda_live_api.infraestrutura.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;

namespace agenda_live_api.Controllers
{

    [ApiController]
    [Route("api/v1/live")]
    public class LiveController : ControllerBase
    {
        private readonly ILiveRepository _liveRepository;
        public LiveController(ILiveRepository liveRepository)
        {
            _liveRepository = liveRepository;
        }

        [HttpPost]
        public IActionResult Post(LiveDTO live) // ONDE PASSAR O MEU MODEL(LIVE)
        {
            _liveRepository.Post(live);
            return Ok(live);
        }


        [HttpGet]
        public IActionResult ObterTodas()
        {
            var lives = _liveRepository.Get();
            return Ok(lives);
        }


        [HttpGet]
        [Route("{id}")]
        public IActionResult GetId(int id)
        {
            var live = _liveRepository.GetId(id);
            if (live == null)
                return NotFound();

            return Ok(live);
        }
    }
}
