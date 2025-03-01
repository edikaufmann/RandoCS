﻿using RandoPro.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace RandoPro.Services;

public class RandoService
{
    HttpClient httpClient;
    public RandoService()
    {
        this.httpClient = new HttpClient();
    }

    List<Rando> randoList;
    public async Task<List<Rando>> GetRandos()
    {
        if (randoList?.Count > 0)
            return randoList;

        // Online
        //var response = await httpClient.GetAsync("https://www.montemagno.com/monkeys.json");
        //var response = await httpClient.GetAsync("https://randopro.org/MyUploads/Data/VARHaute.json");
        //if (response.IsSuccessStatusCode)
        //{
        //    monkeyList = await response.Content.ReadFromJsonAsync<List<Rando>>();
        //}
        // Offline
        using var stream = await FileSystem.OpenAppPackageFileAsync("VARHaute.json");
        using var reader = new StreamReader(stream);
        var contents = await reader.ReadToEndAsync();
        randoList = JsonSerializer.Deserialize<List<Rando>>(contents);

        return randoList;
    }
}
