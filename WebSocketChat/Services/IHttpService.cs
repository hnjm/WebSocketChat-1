﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WebSocketChat.Services
{
    public interface IHttpService
    {
        Task<HttpResponseMessage> PostData(string endpoint, string jsonContent);
        Task<HttpResponseMessage> GetData(string endponit);
        void SetEndPoint(Uri endpoint);
    }
}
