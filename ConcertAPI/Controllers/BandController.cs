﻿using ConcertAPI.Repositories.Interfaces;
using ConcertData.DataModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ConcertAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BandController : BaseController<BandModel>
    {
        public BandController(IBandRepository repository, ILogger<BandController> logger)
            : base(repository, logger)
        {

        }
    }
}