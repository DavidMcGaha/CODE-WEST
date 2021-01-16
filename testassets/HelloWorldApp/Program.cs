using System;
using System.IO;
using System.Text;
using WebWindows;

namespace HelloWorldGRpc
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //Sending messages to the web UI
            var window = new WebWindow("My great app", options =>
            {
                options.SchemeHandlers.Add("app", (string url, out string contentType) =>
                {
                    contentType = "text/javascript";
                    return new MemoryStream(Encoding.UTF8.GetBytes("alert('super')"));
                });
            });

            //receiving messages from web UI
            window.OnWebMessageReceived += (sender, message) =>
            {
                window.SendMessage("Got message: " + message);
            };

            window.NavigateToLocalFile("wwwroot/index.html");
            window.WaitForExit();
        }
    }
}
