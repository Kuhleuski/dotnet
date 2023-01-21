using System.IO;
using System.Net;

internal class Program
{
    private static void Main(string[] args)
    {
        string url = "https://api.openweathermap.org/data/2.5/weather?lat=44.34&lon=10.99&appid=74a645c6549e5fb7137ecdc84d8577a5";

        HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);

         HttpWebResponse httpWebResponse = (HttpWebResponse) httpWebRequest.GetResponse();

        string response;

        using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream())) {

            response = streamReader.ReadToEnd();

        }

        

    }
}