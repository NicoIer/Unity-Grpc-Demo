using System;
using Grpc.Core;
using Proto;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Assemblies
{
    public class GrpcClient : MonoBehaviour
    {
        Greeter.GreeterClient client;
        private HelloRequest request;
        private void Awake()
        {
            request = new HelloRequest();
            request.Name = "Unity";
            Channel channel = new Channel("localhost:50051", ChannelCredentials.Insecure);
            client = new Greeter.GreeterClient(channel);
            
        }

        [Button]
        public void RpcTest1()
        {
            HelloReply helloReply = client.SayHello(request);
            Debug.Log(helloReply.Message);
        }

        [Button]
        public void RpcTest2()
        {
            var handle=   client.SayHelloAsync(request);
            //最多等2s
            handle.ResponseAsync.ContinueWith(task =>
            {
                Debug.Log(task.Result.Message);
            }).Wait(2000);
        }

    }
}