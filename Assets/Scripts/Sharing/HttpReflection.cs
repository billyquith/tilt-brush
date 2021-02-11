using System.Net;
using UnityEngine;

namespace TiltBrush
{
    public class HttpReflection : MonoBehaviour
    {
        void Awake()
        {
            Debug.Log("HttpReflection starting");
            App.HttpServer.AddHttpHandler("/reflect", this.OnRequest);
        }

        private string OnRequest(HttpListenerRequest req)
        {
            string purpose = req.QueryString.Get("p");

            if (purpose == "");
            
            return "<html><b>Hello world!</b></html>";
        }
    }
}