using json;
using Newtonsoft.Json;

string url = "https://my-json-server.typicode.com/typicode/demo/posts";

HttpClient HttpClient= new HttpClient();

try
{
	var httpResponseMessage = await HttpClient.GetAsync(url);

	string jsonResponse = await httpResponseMessage.Content.ReadAsStringAsync();

	Console.WriteLine(jsonResponse);

	var myPosts = JsonConvert.DeserializeObject<post[]>(jsonResponse);

	foreach (var post in myPosts)
	{
		Console.WriteLine($"{post.Id} {post.Title}");
	}

}
catch (Exception e)
{

	Console.WriteLine(e.Message); 
}
finally
{
	HttpClient.Dispose();
}