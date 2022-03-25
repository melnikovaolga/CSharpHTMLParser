using AngleSharp;
using AngleSharp.Dom;

var config = Configuration.Default.WithDefaultLoader();
using var context = BrowsingContext.New(config);

var url = "https://www.toy.ru/catalog/boy_transport/";

using var doc = await context.OpenAsync(url);
var div = doc.QuerySelector("div.select-city-link");
Console.WriteLine(div.TextContent.Split(":").Last().Trim());
