protoc --proto_path=..\..\Protos\ greet.proto --js_out=import_style=commonjs:..\ --grpc-web_out=import_style=commonjs,mode=grpcwebtext:..\