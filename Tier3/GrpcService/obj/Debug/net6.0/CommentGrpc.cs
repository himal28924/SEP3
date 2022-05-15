// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: comment.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GRPCService {
  public static partial class comment
  {
    static readonly string __ServiceName = "comment.comment";

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
    static readonly grpc::Marshaller<global::GRPCService.CommentObjAndInteger> __Marshaller_comment_CommentObjAndInteger = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GRPCService.CommentObjAndInteger.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GRPCService.CommentObj> __Marshaller_comment_CommentObj = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GRPCService.CommentObj.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GRPCService.Integer> __Marshaller_comment_Integer = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GRPCService.Integer.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GRPCService.CommentObjAndInteger, global::GRPCService.CommentObj> __Method_AddComment = new grpc::Method<global::GRPCService.CommentObjAndInteger, global::GRPCService.CommentObj>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddComment",
        __Marshaller_comment_CommentObjAndInteger,
        __Marshaller_comment_CommentObj);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GRPCService.Integer, global::GRPCService.CommentObj> __Method_DeleteComment = new grpc::Method<global::GRPCService.Integer, global::GRPCService.CommentObj>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteComment",
        __Marshaller_comment_Integer,
        __Marshaller_comment_CommentObj);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GRPCService.CommentReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of comment</summary>
    [grpc::BindServiceMethod(typeof(comment), "BindService")]
    public abstract partial class commentBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GRPCService.CommentObj> AddComment(global::GRPCService.CommentObjAndInteger request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GRPCService.CommentObj> DeleteComment(global::GRPCService.Integer request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(commentBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_AddComment, serviceImpl.AddComment)
          .AddMethod(__Method_DeleteComment, serviceImpl.DeleteComment).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, commentBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_AddComment, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GRPCService.CommentObjAndInteger, global::GRPCService.CommentObj>(serviceImpl.AddComment));
      serviceBinder.AddMethod(__Method_DeleteComment, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GRPCService.Integer, global::GRPCService.CommentObj>(serviceImpl.DeleteComment));
    }

  }
}
#endregion
