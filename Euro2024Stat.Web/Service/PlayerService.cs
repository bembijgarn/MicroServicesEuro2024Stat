﻿using Euro2024Stat.Web.Helper;
using Euro2024Stat.Web.Interface;
using Euro2024Stat.Web.Models;
using Euro2024Stat.Web.Models.Dto;

namespace Euro2024Stat.Web.Service
{
    public class PlayerService : IPlayer
    {
        private readonly IRequestResponse _service;
        public PlayerService(IRequestResponse service)
        {
            _service = service;
        }
        public async Task<ResponseDto?> GetPlayerByCountryId(int Id)
        {
            return await _service.SendAsync(new RequestDto()
            {
                ApiType = ApiHelper.ApiType.GET,
                Url = ApiHelper.PlayerAPIBase + "/api/Player/GetPlayersByCountryId?CountryId=" + Id
            });
        }

        public async Task<ResponseDto?> GetPlayerById(int playerId)
        {
            return await _service.SendAsync(new RequestDto()
            {
                ApiType = ApiHelper.ApiType.GET,
                Url = ApiHelper.PlayerAPIBase + "/api/Player/GetPlayerById?Id=" + playerId
            });
        }

        public async Task<ResponseDto?> GetPlayersByPlayerIds(List<FantasyPlayerDto> playerIds)
        {
            return await _service.SendAsync(new RequestDto()
            {
                ApiType = ApiHelper.ApiType.POST,
                Data = playerIds,
                Url = ApiHelper.PlayerAPIBase + "/api/Player/GetPlayersByIds"
            });
        }

       
    }
}
