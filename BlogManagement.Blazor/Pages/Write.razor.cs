using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using Volo.Abp.AspNetCore.Components.Web;
using Volo.Abp.Users;

namespace BlogManagement.Pages;

public class StoryModel 
{
    public bool IsDraft {get; set;}
    public bool IsPublished {get; set;}

    public string Title {get; set;}

    public string MarkdownValue {get; set;}

    public void updateStatus(string status)
    {
        if (status == "draft") 
        {
            IsDraft = true;
            IsPublished = false;
        }else if (status == "publish")
        {
            IsPublished = true;
            IsDraft = false;
        }
    }
}
public partial class Write: ComponentBase 
{
    public StoryModel storyModel = new()
    {
        IsDraft =  true,
        IsPublished = false
    };

    private HttpClient _http;
    private CurrentUser _user;
    private CookieService _cookie;

    private const string AntiForgeryCookieName = "XSRF-TOKEN";

    private const string AntiForgeryHeaderName = "RequestVerificationToken";

    public Write(HttpClient http, CurrentUser user, CookieService cookie)
    {
        _http = http;
        _user = user;
        _cookie = cookie;
        
    }

    public Task OnMarkdownValueHTMLChanged(string value)
    {
        storyModel.MarkdownValue = value;
        return Task.CompletedTask;
    }


    public async Task HandleSubmitAsync()
    {
        Console.WriteLine($"Draft is {storyModel.IsDraft}");
        Console.WriteLine($"Publish is {storyModel.IsPublished}");
        Console.WriteLine($"Title is {storyModel.Title}");
        Console.WriteLine($"MarkdownValue is {storyModel.MarkdownValue}");
        var addItem = new  
        { 
            title = storyModel.Title,
            is_draft = storyModel.IsDraft,
            is_published = storyModel.IsPublished,
            post_content = storyModel.MarkdownValue,
            created_by =  _user.GetId()
        };
        
        await _http.PostAsJsonAsync("api/app/blog/post", addItem);
        await Task.CompletedTask;
    }

}
