var express = require('express');
var app = express();
var http = require('http').Server(app);
var io = require('socket.io')(http);
var GPIO = require('onoff').Gpio,
    relay1 = new GPIO(17, 'out'),
    relay2 = new GPIO(27, 'out'),
    garageClosedSensor = new GPIO (23, 'in', 'both');

relay1.writeSync(1);
relay2.writeSync(1);

app.use(express.static('public'));

io.on('connection', function(socket){
  console.log('on connection ');
  var value = (garageClosedSensor.readSync() == 0) ? 'open' : 'closed';
  io.emit('status', { id: '#garage-sensor', value: value });
  socket.on('relay-1', function(){
    relay1.writeSync(0);
    io.emit('status', { id: '#relay-1', value: 'on' });
    setTimeout(function() {
      relay1.writeSync(1);
      io.emit('status', { id: '#relay-1', value: 'off' });
    }, 1000);
  });
  socket.on('relay-2', function(msg){
    relay2.writeSync(0);
    io.emit('status', { id: '#relay-2', value: 'on' });
    setTimeout(function() {
      relay2.writeSync(1);
      io.emit('status', { id: '#relay-2', value: 'off' });
    }, 1000);
  });
});

garageClosedSensor.watch(function(err, state) {
  var value = (state == 0) ? 'open' : 'closed';
  io.emit('status', { id: '#garage-sensor', value: value });
});

http.listen(3000, function(){
  console.log('listening on *:3000');
});
