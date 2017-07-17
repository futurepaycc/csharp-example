using System;
using System.IO;
using System.Net;

public class Http{
    public static void Main(string[] args){
        string url="http://www.baidu.com";
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        Stream stream = response.GetResponseStream();
        StreamReader reader = new StreamReader(stream);

        string result = reader.ReadToEnd();
        Console.WriteLine(result);
    }
}