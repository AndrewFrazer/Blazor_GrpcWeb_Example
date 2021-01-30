using CodeFirstProtos.Replys;
using CodeFirstProtos.Requests;
using CodeFirstProtos.Services;
using Microsoft.Extensions.Logging;
using ProtoBuf.Grpc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcWebService
{
    public class GreeterService : IGreeterService
    {
        private readonly ILogger<GreeterService> _logger;
        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        public Task<HelloReply> SayHelloAsync(HelloRequest request, CallContext context)
        {
            return Task.FromResult(new HelloReply
            {
                Message = "Hello, " + request.Name + "!"
            });
        }
    }
}
