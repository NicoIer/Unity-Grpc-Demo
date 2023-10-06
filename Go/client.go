package main

import (
	pb "Go/proto"
	"context"
	"google.golang.org/grpc"
	"google.golang.org/grpc/credentials/insecure"
	"log"
	// 导入grpc包
)

func DoubleStream(client pb.DemoEchoClient) {
	ctx := context.Background()
	stream, err := client.ServerClientStream(ctx)
	if err != nil {
		log.Fatalf("%v.ServerClientStream(_) = _, %v", client, err)
	}
	go func() {
		for i := 0; i < 10; i++ {
			err = stream.Send(&pb.DemoRequest{Message: "client server stream"})
			if err != nil {
				return
			}
		}
	}()
	for {
		in, err := stream.Recv()
		if err != nil {
			return
		}
		log.Printf("Received: %v", in.Message)
	}
}

func main() {
	// 连接grpc服务器
	conn, err := grpc.Dial("localhost:50051", grpc.WithTransportCredentials(insecure.NewCredentials()))
	if err != nil {
		log.Fatalf("did not connect: %v", err)
	}
	// 延迟关闭连接
	defer func(conn *grpc.ClientConn) {
		err := conn.Close()
		if err != nil {

		}
	}(conn)

	// 初始化Greeter服务客户端
	c := pb.NewDemoEchoClient(conn)
	//SimpleTest(c)
	//ClientStreamTest(c)
	DoubleStream(c)
}
