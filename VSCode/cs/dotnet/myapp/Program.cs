using System;
using System.Net;

/*
using Newtonsoft.Json; // Newton'S'oft.Json;

string API_URL = "https://jsonplaceholder.typicode.com/posts?_limit=5";
var client = new HttpClient();
var json = client.DownloadString(API_URL);
dyanmic posts = JsonConvert.DeserializeObject(json);

foreach(var post in posts)
{
    Console.WriteLine(post.id + ": " + post.title);
}
*/


Console.WriteLine("Hello, World!");
var menu = string.Format("Menu:\n 1. SUM\n 2. REST");
Console.WriteLine(menu);
string op = Console.ReadLine();
int option = Convert.ToInt32(op);
if(option!=1 || option!=2)
{
    Console.Clear();
    Console.WriteLine($"You have chosen {option}");
    Console.WriteLine($"Please choose one of the options\n {menu}");
    option = Convert.ToInt32(Console.ReadLine());
}
else
{
    Console.WriteLine("Nice");
}