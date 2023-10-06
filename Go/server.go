package main

import (
	pb "Go/proto"
	context2 "context"
	"fmt"
	"io"
	"log"
	"math/rand"
	"net"
	// 导入grpc包
	"google.golang.org/grpc"
	// 导入刚才我们生成的代码所在的proto包。
	"google.golang.org/grpc/reflection"
)

type server struct {
	pb.DemoEchoServer
}

func (s *server) Simple(ctx context2.Context, request *pb.DemoRequest) (*pb.DemoResponse, error) {
	//TODO implement me
	panic("implement me")
}

func (s *server) ClientStream(streamServer pb.DemoEcho_ClientStreamServer) error {
	//TODO implement me
	panic("implement me")
}

func (s *server) ServerStream(request *pb.DemoRequest, streamServer pb.DemoEcho_ServerStreamServer) error {
	//TODO implement me
	panic("implement me")
}

func (s *server) ServerClientStream(streamServer pb.DemoEcho_ServerClientStreamServer) error {
	var rate float32
	rate = 0.3
	go func() {
		var cnt int32
		cnt = 0
		var maxCnt int32
		maxCnt = 12
		for {
			if cnt >= maxCnt {
				break
			}
			if rand.Float32() < rate {
				var msg string
				msg = fmt.Sprintf("server client stream %d", cnt)
				err := streamServer.Send(&pb.DemoResponse{Message: msg})
				if err != nil {
					return
				}
				cnt++
			}
		}
	}()
	for {
		in, err := streamServer.Recv()
		if err == io.EOF {
			return nil
		}
		if err != nil {
			return err
		}

		fmt.Println("request receive:", in.Message)
		err = streamServer.Send(&pb.DemoResponse{Message: "server client stream"})
		if err != nil {
			return err
		}
	}
}

func main() {
	// 监听127.0.0.1:50051地址
	lis, err := net.Listen("tcp", "127.0.0.1:50051")
	if err != nil {
		log.Fatalf("failed to listen: %v", err)
	}

	// 实例化grpc服务端
	s := grpc.NewServer()

	// 注册Greeter服务
	pb.RegisterDemoEchoServer(s, &server{})

	// 往grpc服务端注册反射服务
	reflection.Register(s)

	// 启动grpc服务
	if err := s.Serve(lis); err != nil {
		log.Fatalf("failed to serve: %v", err)
	}
}
