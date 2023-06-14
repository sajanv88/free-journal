using System.Net.Http.Json;
using BlogManagement.Dtos;
using Microsoft.AspNetCore.Components;
namespace BlogManagement.Components;

public partial class RenderPost: ComponentBase
{
    [Parameter] public ReadPostDto? Post { get; set; }

    private readonly HttpClient _http;

    public RenderPost(HttpClient http)
    {
        _http = http;
    }
}