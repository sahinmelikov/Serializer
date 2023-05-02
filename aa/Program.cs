
using aa.Models;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Net.Http.Json;
using System.Reflection.Metadata;
using System.Text.Json.Nodes;




#region task1
//string Path = @"C:/Users/555/OneDrive/Masaüstü/aa/Models";
//string PathData = @"C:/Users/555/OneDrive/Masaüstü/aa/Data";
string PathDataFile = @"C:/Users/555/OneDrive/Masaüstü/aa/Data/jsonData.json";


//Directory.CreateDirectory(Path);
//Directory.CreateDirectory(PathData);
//File.Create(PathDataFile);

#endregion





#region Task2
var urlJson = "https://jsonplaceholder.typicode.com/posts";

HttpClient httpClient = new HttpClient();
var content = await httpClient.GetStringAsync(urlJson);  
string data =JsonConvert.SerializeObject(content);


using (StreamWriter sw = new StreamWriter(PathDataFile))
{
    sw.WriteLine(JsonConvert.SerializeObject(data));
}
//Class1 class1;
//using (StreamReader sr = new StreamReader(PathDataFile))
//{

//    class1 = JsonConvert.DeserializeObject<Class1>(data);
//}



#endregion


