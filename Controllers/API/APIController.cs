using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TGV.Domain.Entities;
using TGV.Service;
using TGV.ViewModels;

namespace TGV.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class APIController : ControllerBase
    {
        private IService<Steden> _stadService;
        private IService<Ritten> _ritService;
        private IService<AspNetUsers> _userService;

        private readonly IMapper _mapper;

        public APIController(IMapper mapper, IService<Steden> stadService, IService<Ritten> ritService, IService<AspNetUsers> userService)
        {
            _mapper = mapper;
            _stadService = stadService;
            _ritService = ritService;
            _userService = userService;
        }

        [HttpGet("steden")]
        public async Task<IEnumerable<StadVM>> GetAllSteden()
        {
            var listStad = await _stadService.GetAll();
            return _mapper.Map<List<StadVM>>(listStad);
        }

        [HttpGet("users")]
        public async Task<IEnumerable<UserVM>> GetAllUsers()
        {
            var listUsers = await _userService.GetAll();
            return _mapper.Map<List<UserVM>>(listUsers);
        }

        [HttpGet("ritten/{startId}/{bestemmingId}")]
        public async Task<IEnumerable<RitVM>> GetRittenWithStartAndBestemming(int startId, int bestemmingId)
        {
            var listRit = await _ritService.GetWithStartAndBestemming(startId, bestemmingId);
            return _mapper.Map<List<RitVM>>(listRit);
        }


    }
}