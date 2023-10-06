// Code generated by protoc-gen-go-grpc. DO NOT EDIT.
// versions:
// - protoc-gen-go-grpc v1.3.0
// - protoc             v4.23.4
// source: demo.proto

package proto

import (
	context "context"
	grpc "google.golang.org/grpc"
	codes "google.golang.org/grpc/codes"
	status "google.golang.org/grpc/status"
)

// This is a compile-time assertion to ensure that this generated file
// is compatible with the grpc package it is being compiled against.
// Requires gRPC-Go v1.32.0 or later.
const _ = grpc.SupportPackageIsVersion7

const (
	DemoEcho_Simple_FullMethodName             = "/proto.DemoEcho/Simple"
	DemoEcho_ClientStream_FullMethodName       = "/proto.DemoEcho/ClientStream"
	DemoEcho_ServerStream_FullMethodName       = "/proto.DemoEcho/ServerStream"
	DemoEcho_ServerClientStream_FullMethodName = "/proto.DemoEcho/ServerClientStream"
)

// DemoEchoClient is the client API for DemoEcho service.
//
// For semantics around ctx use and closing/ending streaming RPCs, please refer to https://pkg.go.dev/google.golang.org/grpc/?tab=doc#ClientConn.NewStream.
type DemoEchoClient interface {
	Simple(ctx context.Context, in *DemoRequest, opts ...grpc.CallOption) (*DemoResponse, error)
	ClientStream(ctx context.Context, opts ...grpc.CallOption) (DemoEcho_ClientStreamClient, error)
	ServerStream(ctx context.Context, in *DemoRequest, opts ...grpc.CallOption) (DemoEcho_ServerStreamClient, error)
	ServerClientStream(ctx context.Context, opts ...grpc.CallOption) (DemoEcho_ServerClientStreamClient, error)
}

type demoEchoClient struct {
	cc grpc.ClientConnInterface
}

func NewDemoEchoClient(cc grpc.ClientConnInterface) DemoEchoClient {
	return &demoEchoClient{cc}
}

func (c *demoEchoClient) Simple(ctx context.Context, in *DemoRequest, opts ...grpc.CallOption) (*DemoResponse, error) {
	out := new(DemoResponse)
	err := c.cc.Invoke(ctx, DemoEcho_Simple_FullMethodName, in, out, opts...)
	if err != nil {
		return nil, err
	}
	return out, nil
}

func (c *demoEchoClient) ClientStream(ctx context.Context, opts ...grpc.CallOption) (DemoEcho_ClientStreamClient, error) {
	stream, err := c.cc.NewStream(ctx, &DemoEcho_ServiceDesc.Streams[0], DemoEcho_ClientStream_FullMethodName, opts...)
	if err != nil {
		return nil, err
	}
	x := &demoEchoClientStreamClient{stream}
	return x, nil
}

type DemoEcho_ClientStreamClient interface {
	Send(*DemoRequest) error
	CloseAndRecv() (*DemoResponse, error)
	grpc.ClientStream
}

type demoEchoClientStreamClient struct {
	grpc.ClientStream
}

func (x *demoEchoClientStreamClient) Send(m *DemoRequest) error {
	return x.ClientStream.SendMsg(m)
}

func (x *demoEchoClientStreamClient) CloseAndRecv() (*DemoResponse, error) {
	if err := x.ClientStream.CloseSend(); err != nil {
		return nil, err
	}
	m := new(DemoResponse)
	if err := x.ClientStream.RecvMsg(m); err != nil {
		return nil, err
	}
	return m, nil
}

func (c *demoEchoClient) ServerStream(ctx context.Context, in *DemoRequest, opts ...grpc.CallOption) (DemoEcho_ServerStreamClient, error) {
	stream, err := c.cc.NewStream(ctx, &DemoEcho_ServiceDesc.Streams[1], DemoEcho_ServerStream_FullMethodName, opts...)
	if err != nil {
		return nil, err
	}
	x := &demoEchoServerStreamClient{stream}
	if err := x.ClientStream.SendMsg(in); err != nil {
		return nil, err
	}
	if err := x.ClientStream.CloseSend(); err != nil {
		return nil, err
	}
	return x, nil
}

type DemoEcho_ServerStreamClient interface {
	Recv() (*DemoResponse, error)
	grpc.ClientStream
}

type demoEchoServerStreamClient struct {
	grpc.ClientStream
}

func (x *demoEchoServerStreamClient) Recv() (*DemoResponse, error) {
	m := new(DemoResponse)
	if err := x.ClientStream.RecvMsg(m); err != nil {
		return nil, err
	}
	return m, nil
}

func (c *demoEchoClient) ServerClientStream(ctx context.Context, opts ...grpc.CallOption) (DemoEcho_ServerClientStreamClient, error) {
	stream, err := c.cc.NewStream(ctx, &DemoEcho_ServiceDesc.Streams[2], DemoEcho_ServerClientStream_FullMethodName, opts...)
	if err != nil {
		return nil, err
	}
	x := &demoEchoServerClientStreamClient{stream}
	return x, nil
}

type DemoEcho_ServerClientStreamClient interface {
	Send(*DemoRequest) error
	Recv() (*DemoResponse, error)
	grpc.ClientStream
}

type demoEchoServerClientStreamClient struct {
	grpc.ClientStream
}

func (x *demoEchoServerClientStreamClient) Send(m *DemoRequest) error {
	return x.ClientStream.SendMsg(m)
}

func (x *demoEchoServerClientStreamClient) Recv() (*DemoResponse, error) {
	m := new(DemoResponse)
	if err := x.ClientStream.RecvMsg(m); err != nil {
		return nil, err
	}
	return m, nil
}

// DemoEchoServer is the server API for DemoEcho service.
// All implementations must embed UnimplementedDemoEchoServer
// for forward compatibility
type DemoEchoServer interface {
	Simple(context.Context, *DemoRequest) (*DemoResponse, error)
	ClientStream(DemoEcho_ClientStreamServer) error
	ServerStream(*DemoRequest, DemoEcho_ServerStreamServer) error
	ServerClientStream(DemoEcho_ServerClientStreamServer) error
	mustEmbedUnimplementedDemoEchoServer()
}

// UnimplementedDemoEchoServer must be embedded to have forward compatible implementations.
type UnimplementedDemoEchoServer struct {
}

func (UnimplementedDemoEchoServer) Simple(context.Context, *DemoRequest) (*DemoResponse, error) {
	return nil, status.Errorf(codes.Unimplemented, "method Simple not implemented")
}
func (UnimplementedDemoEchoServer) ClientStream(DemoEcho_ClientStreamServer) error {
	return status.Errorf(codes.Unimplemented, "method ClientStream not implemented")
}
func (UnimplementedDemoEchoServer) ServerStream(*DemoRequest, DemoEcho_ServerStreamServer) error {
	return status.Errorf(codes.Unimplemented, "method ServerStream not implemented")
}
func (UnimplementedDemoEchoServer) ServerClientStream(DemoEcho_ServerClientStreamServer) error {
	return status.Errorf(codes.Unimplemented, "method ServerClientStream not implemented")
}
func (UnimplementedDemoEchoServer) mustEmbedUnimplementedDemoEchoServer() {}

// UnsafeDemoEchoServer may be embedded to opt out of forward compatibility for this service.
// Use of this interface is not recommended, as added methods to DemoEchoServer will
// result in compilation errors.
type UnsafeDemoEchoServer interface {
	mustEmbedUnimplementedDemoEchoServer()
}

func RegisterDemoEchoServer(s grpc.ServiceRegistrar, srv DemoEchoServer) {
	s.RegisterService(&DemoEcho_ServiceDesc, srv)
}

func _DemoEcho_Simple_Handler(srv interface{}, ctx context.Context, dec func(interface{}) error, interceptor grpc.UnaryServerInterceptor) (interface{}, error) {
	in := new(DemoRequest)
	if err := dec(in); err != nil {
		return nil, err
	}
	if interceptor == nil {
		return srv.(DemoEchoServer).Simple(ctx, in)
	}
	info := &grpc.UnaryServerInfo{
		Server:     srv,
		FullMethod: DemoEcho_Simple_FullMethodName,
	}
	handler := func(ctx context.Context, req interface{}) (interface{}, error) {
		return srv.(DemoEchoServer).Simple(ctx, req.(*DemoRequest))
	}
	return interceptor(ctx, in, info, handler)
}

func _DemoEcho_ClientStream_Handler(srv interface{}, stream grpc.ServerStream) error {
	return srv.(DemoEchoServer).ClientStream(&demoEchoClientStreamServer{stream})
}

type DemoEcho_ClientStreamServer interface {
	SendAndClose(*DemoResponse) error
	Recv() (*DemoRequest, error)
	grpc.ServerStream
}

type demoEchoClientStreamServer struct {
	grpc.ServerStream
}

func (x *demoEchoClientStreamServer) SendAndClose(m *DemoResponse) error {
	return x.ServerStream.SendMsg(m)
}

func (x *demoEchoClientStreamServer) Recv() (*DemoRequest, error) {
	m := new(DemoRequest)
	if err := x.ServerStream.RecvMsg(m); err != nil {
		return nil, err
	}
	return m, nil
}

func _DemoEcho_ServerStream_Handler(srv interface{}, stream grpc.ServerStream) error {
	m := new(DemoRequest)
	if err := stream.RecvMsg(m); err != nil {
		return err
	}
	return srv.(DemoEchoServer).ServerStream(m, &demoEchoServerStreamServer{stream})
}

type DemoEcho_ServerStreamServer interface {
	Send(*DemoResponse) error
	grpc.ServerStream
}

type demoEchoServerStreamServer struct {
	grpc.ServerStream
}

func (x *demoEchoServerStreamServer) Send(m *DemoResponse) error {
	return x.ServerStream.SendMsg(m)
}

func _DemoEcho_ServerClientStream_Handler(srv interface{}, stream grpc.ServerStream) error {
	return srv.(DemoEchoServer).ServerClientStream(&demoEchoServerClientStreamServer{stream})
}

type DemoEcho_ServerClientStreamServer interface {
	Send(*DemoResponse) error
	Recv() (*DemoRequest, error)
	grpc.ServerStream
}

type demoEchoServerClientStreamServer struct {
	grpc.ServerStream
}

func (x *demoEchoServerClientStreamServer) Send(m *DemoResponse) error {
	return x.ServerStream.SendMsg(m)
}

func (x *demoEchoServerClientStreamServer) Recv() (*DemoRequest, error) {
	m := new(DemoRequest)
	if err := x.ServerStream.RecvMsg(m); err != nil {
		return nil, err
	}
	return m, nil
}

// DemoEcho_ServiceDesc is the grpc.ServiceDesc for DemoEcho service.
// It's only intended for direct use with grpc.RegisterService,
// and not to be introspected or modified (even as a copy)
var DemoEcho_ServiceDesc = grpc.ServiceDesc{
	ServiceName: "proto.DemoEcho",
	HandlerType: (*DemoEchoServer)(nil),
	Methods: []grpc.MethodDesc{
		{
			MethodName: "Simple",
			Handler:    _DemoEcho_Simple_Handler,
		},
	},
	Streams: []grpc.StreamDesc{
		{
			StreamName:    "ClientStream",
			Handler:       _DemoEcho_ClientStream_Handler,
			ClientStreams: true,
		},
		{
			StreamName:    "ServerStream",
			Handler:       _DemoEcho_ServerStream_Handler,
			ServerStreams: true,
		},
		{
			StreamName:    "ServerClientStream",
			Handler:       _DemoEcho_ServerClientStream_Handler,
			ServerStreams: true,
			ClientStreams: true,
		},
	},
	Metadata: "demo.proto",
}