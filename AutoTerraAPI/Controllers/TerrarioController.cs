﻿using AutoMapper;
using AutoTerraApi.VMs;
using AutoTerraAPI.VMs;
using Business.DTOs;
using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace AutoTerraAPI.Controllers
{
    [ApiController]
    [Route("autoterra/v1")]
    public class TerrarioController : Controller
    {
        private readonly ITerrarioService _terrarioService;
        private readonly IMapper _mapper;

        public TerrarioController(ITerrarioService terrarioService, IMapper mapper)
        {
            _terrarioService = terrarioService;
            _mapper = mapper;
        }

        [HttpGet("terrarios")]
        public async Task<IActionResult> GetAll()
        {
            ICollection<TerrarioDTO> userDTOs = await _terrarioService.GetAll();
            ICollection<TerrarioVM> userVMs = _mapper.Map<ICollection<TerrarioVM>>(userDTOs);

            return Ok(userVMs);
        }

        [HttpGet("terrarios/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            TerrarioDTO TerrarioDTO = await _terrarioService.GetById(id);
            TerrarioVM TerrarioVM = _mapper.Map<TerrarioVM>(TerrarioDTO);

            return Ok(TerrarioVM);
        }

        [HttpPost("terrarios")]
        public async Task<IActionResult> Create(TerrarioVM TerrarioVM)
        {
            TerrarioDTO TerrarioDTO = _mapper.Map<TerrarioDTO>(TerrarioVM);

            _terrarioService.Create(TerrarioDTO);
            return Ok();
        }

        [HttpPut("terrarios/{id}")]
        public async Task<IActionResult> Update(int id, TerrarioVM TerrarioVM)
        {
            TerrarioDTO TerrarioDTO = _mapper.Map<TerrarioDTO>(TerrarioVM);

            _terrarioService.Update(id, TerrarioDTO);
            return Ok();
        }

        [HttpDelete("terrarios/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            _terrarioService.Delete(id);
            return Ok();
        }
    }
}