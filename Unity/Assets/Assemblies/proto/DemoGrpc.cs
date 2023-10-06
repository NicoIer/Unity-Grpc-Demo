// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: demo.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Proto {
  public static partial class DemoEcho
  {
    static readonly string __ServiceName = "proto.DemoEcho";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Proto.DemoRequest> __Marshaller_proto_DemoRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Proto.DemoRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Proto.DemoResponse> __Marshaller_proto_DemoResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Proto.DemoResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Proto.DemoRequest, global::Proto.DemoResponse> __Method_Simple = new grpc::Method<global::Proto.DemoRequest, global::Proto.DemoResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Simple",
        __Marshaller_proto_DemoRequest,
        __Marshaller_proto_DemoResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Proto.DemoRequest, global::Proto.DemoResponse> __Method_ClientStream = new grpc::Method<global::Proto.DemoRequest, global::Proto.DemoResponse>(
        grpc::MethodType.ClientStreaming,
        __ServiceName,
        "ClientStream",
        __Marshaller_proto_DemoRequest,
        __Marshaller_proto_DemoResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Proto.DemoRequest, global::Proto.DemoResponse> __Method_ServerStream = new grpc::Method<global::Proto.DemoRequest, global::Proto.DemoResponse>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "ServerStream",
        __Marshaller_proto_DemoRequest,
        __Marshaller_proto_DemoResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Proto.DemoRequest, global::Proto.DemoResponse> __Method_ServerClientStream = new grpc::Method<global::Proto.DemoRequest, global::Proto.DemoResponse>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "ServerClientStream",
        __Marshaller_proto_DemoRequest,
        __Marshaller_proto_DemoResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Proto.DemoReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of DemoEcho</summary>
    [grpc::BindServiceMethod(typeof(DemoEcho), "BindService")]
    public abstract partial class DemoEchoBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Proto.DemoResponse> Simple(global::Proto.DemoRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Proto.DemoResponse> ClientStream(grpc::IAsyncStreamReader<global::Proto.DemoRequest> requestStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task ServerStream(global::Proto.DemoRequest request, grpc::IServerStreamWriter<global::Proto.DemoResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task ServerClientStream(grpc::IAsyncStreamReader<global::Proto.DemoRequest> requestStream, grpc::IServerStreamWriter<global::Proto.DemoResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for DemoEcho</summary>
    public partial class DemoEchoClient : grpc::ClientBase<DemoEchoClient>
    {
      /// <summary>Creates a new client for DemoEcho</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public DemoEchoClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for DemoEcho that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public DemoEchoClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected DemoEchoClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected DemoEchoClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Proto.DemoResponse Simple(global::Proto.DemoRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Simple(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Proto.DemoResponse Simple(global::Proto.DemoRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Simple, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Proto.DemoResponse> SimpleAsync(global::Proto.DemoRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SimpleAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Proto.DemoResponse> SimpleAsync(global::Proto.DemoRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Simple, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncClientStreamingCall<global::Proto.DemoRequest, global::Proto.DemoResponse> ClientStream(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ClientStream(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncClientStreamingCall<global::Proto.DemoRequest, global::Proto.DemoResponse> ClientStream(grpc::CallOptions options)
      {
        return CallInvoker.AsyncClientStreamingCall(__Method_ClientStream, null, options);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncServerStreamingCall<global::Proto.DemoResponse> ServerStream(global::Proto.DemoRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ServerStream(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncServerStreamingCall<global::Proto.DemoResponse> ServerStream(global::Proto.DemoRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_ServerStream, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncDuplexStreamingCall<global::Proto.DemoRequest, global::Proto.DemoResponse> ServerClientStream(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ServerClientStream(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncDuplexStreamingCall<global::Proto.DemoRequest, global::Proto.DemoResponse> ServerClientStream(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_ServerClientStream, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override DemoEchoClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new DemoEchoClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(DemoEchoBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Simple, serviceImpl.Simple)
          .AddMethod(__Method_ClientStream, serviceImpl.ClientStream)
          .AddMethod(__Method_ServerStream, serviceImpl.ServerStream)
          .AddMethod(__Method_ServerClientStream, serviceImpl.ServerClientStream).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, DemoEchoBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Simple, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Proto.DemoRequest, global::Proto.DemoResponse>(serviceImpl.Simple));
      serviceBinder.AddMethod(__Method_ClientStream, serviceImpl == null ? null : new grpc::ClientStreamingServerMethod<global::Proto.DemoRequest, global::Proto.DemoResponse>(serviceImpl.ClientStream));
      serviceBinder.AddMethod(__Method_ServerStream, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::Proto.DemoRequest, global::Proto.DemoResponse>(serviceImpl.ServerStream));
      serviceBinder.AddMethod(__Method_ServerClientStream, serviceImpl == null ? null : new grpc::DuplexStreamingServerMethod<global::Proto.DemoRequest, global::Proto.DemoResponse>(serviceImpl.ServerClientStream));
    }

  }
}
#endregion
