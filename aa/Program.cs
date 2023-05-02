
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Net.Http.Json;
using System.Reflection.Metadata;
using System.Text.Json.Nodes;

var myObject=new JsonObject();


#region task1
//string Path = @"C:/Users/555/OneDrive/Masaüstü/aa/Models";
//string PathData = @"C:/Users/555/OneDrive/Masaüstü/aa/Data";
string PathDataFile = @"C:/Users/555/OneDrive/Masaüstü/aa/Data/jsonData.json";


//Directory.CreateDirectory(Path);
//Directory.CreateDirectory(PathData);
//File.Create(PathDataFile);

#endregion





#region Task2
var urlJson = @"https://jsonplaceholder.typicode.com/posts";

HttpClient httpClient = new HttpClient();
var content = await httpClient.GetStringAsync(urlJson);  ///////<====bu hissede sehv var🤐

Console.WriteLine(JsonConvert.SerializeObject(content));

//using (StreamWriter sw = new StreamWriter(PathDataFile))
//{
//    sw.WriteLine(JsonConvert.SerializeObject(content));
//}
//using (StreamReader sr = new StreamReader(PathDataFile))
//{
//    string data = await sr.ReadToEndAsync();
//    JsonConvert.DeserializeObject<JsonObject>(content);


//}


#endregion


