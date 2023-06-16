using System.Net.Http.Json;
using BlogManagement.Dtos;
using Microsoft.AspNetCore.Components;
using Volo.Abp.Application.Dtos;

namespace BlogManagement.Components;

public partial class RenderPost: ComponentBase
{
    private PagedResultDto<ReadPostDto>? _items;
  

    private readonly HttpClient _http;
    
    [Parameter] 
    public string SelectedTab { get; set; }

    public RenderPost(HttpClient http)
    {
        _http = http;
     
    }

    protected async override Task OnParametersSetAsync()
    {
        _items = await _http.GetFromJsonAsync<PagedResultDto<ReadPostDto>>($"api/app/blog/posts?Filter={SelectedTab}");
      
    }
}