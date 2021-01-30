using CodeFirstProtos.Replys;
using CodeFirstProtos.Requests;
using ProtoBuf.Grpc;
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstProtos.Services
{
    [ServiceContract]
    public interface IGreeterService
    {
        [OperationContract]
        Task<HelloReply> SayHelloAsync(HelloRequest request, CallContext context = default);
    }
}
