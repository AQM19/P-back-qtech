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
    public class VisitaController : Controller
    {
        private readonly IVisitaService _visitaService;
        private readonly IMapper _mapper;

        public VisitaController(IVisitaService visitaService, IMapper mapper)
        {
            _visitaService = visitaService;
            _mapper = mapper;
        }

        [HttpGet("visitas")]
        public async Task<IActionResult> GetAll()
        {
            ICollection<VisitaDTO> userDTOs = await _visitaService.GetAll();
            ICollection<VisitaVM> userVMs = _mapper.Map<ICollection<VisitaVM>>(userDTOs);

            return Ok(userVMs);
        }

        [HttpGet("visitas/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            VisitaDTO VisitaDTO = await _visitaService.GetById(id);
            VisitaVM VisitaVM = _mapper.Map<VisitaVM>(VisitaDTO);

            return Ok(VisitaVM);
        }

        [HttpPost("visitas")]
        public async Task<IActionResult> Create(VisitaVM VisitaVM)
        {
            VisitaDTO VisitaDTO = _mapper.Map<VisitaDTO>(VisitaVM);

            _visitaService.Create(VisitaDTO);
            return Ok();
        }

        [HttpPut("visitas/{id}")]
        public async Task<IActionResult> Update(int id, VisitaVM VisitaVM)
        {
            VisitaDTO VisitaDTO = _mapper.Map<VisitaDTO>(VisitaVM);

            _visitaService.Update(id, VisitaDTO);
            return Ok();
        }

        [HttpDelete("visitas/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            _visitaService.Delete(id);
            return Ok();
        }
    }
}