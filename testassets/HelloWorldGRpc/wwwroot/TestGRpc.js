const {HelloRequest, HelloReply} = require('./greet_pb.js');
const {GreeterClient} = require('./greet_grpc_web_pb.js');

debugger;

var client = new GreeterClient('http://localhost:5000');

var request = new HelloRequest();
request.setName('World');

client.sayHello(request, {}, (err, response) => {
  console.log(response.getMessage());
});