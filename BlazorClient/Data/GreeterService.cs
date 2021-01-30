using CodeFirstProtos.Replys;
using CodeFirstProtos.Requests;
using CodeFirstProtos.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorClient.Data
{
    public class GreeterService
    {
        private IGreeterService _greeterService;
        public GreeterService(IGreeterService greeterService)
        {
            this._greeterService = greeterService;
        }

        public async Task<string> GetGreetingAsync(string name)
        {
            var reply = await this._greeterService.SayHelloAsync(new HelloRequest { Name = name });
            return reply.Message;
        }
    }
}
