'use strict';

var path = require('path')
var electron = require('electron');
var BrowserWindow = electron.BrowserWindow;
const {app, Menu, Tray} = require('electron');

const io = require('socket.io-client');
const socket = io('http://192.168.0.81:3000');

var trayIcon = null;
var window = null;

const TRAY_ARROW_HEIGHT = 50;
const WINDOW_WIDTH = 600;
const WINDOW_HEIGHT = 400;
const HORIZ_PADDING = 15;
const VERT_PADDING = 15;

app.on('ready', function() {

  if(process.platform === 'darwin') app.dock.hide();

  window = new BrowserWindow({
    width: WINDOW_WIDTH,
    height: WINDOW_HEIGHT,
    resizable: false,
    frame: false,
    transparent: true,
    show: false
  });

  window.loadURL('file://' + __dirname + '/index.html');


  window.on('close', function () {
    window = null;
  });

  window.on('blur', function(){
    window.hide();
  });

  const iconName = 'images/icon.png';
  const iconPath = path.join(__dirname, iconName);

  trayIcon = new Tray(iconPath);
  trayIcon.setToolTip('CtrlBar');

  trayIcon.on('click', (event) => {
    var screen = electron.screen;
    const cursorPosition = screen.getCursorScreenPoint();
    const primarySize = screen.getPrimaryDisplay().workAreaSize;
    const trayPositionVert = cursorPosition.y >= primarySize.height/2 ? 'bottom' : 'top';
    const trayPositionHoriz = cursorPosition.x >= primarySize.width/2 ? 'right' : 'left';
    window.setPosition(getTrayPosX(),  getTrayPosY());
    window.isVisible() ? window.hide() : window.show();

    function getTrayPosX() {
      const horizBounds = {
        left:   cursorPosition.x - WINDOW_WIDTH/2,
        right:  cursorPosition.x + WINDOW_WIDTH/2
      }
      if (trayPositionHoriz == 'left') {
        return horizBounds.left <= HORIZ_PADDING ? HORIZ_PADDING : horizBounds.left;
      }
      else {
        return horizBounds.right >= primarySize.width ? primarySize.width - HORIZ_PADDING - WINDOW_WIDTH: horizBounds.right - WINDOW_WIDTH;
      }
    }
    function getTrayPosY() {
      return trayPositionVert == 'bottom' ? cursorPosition.y - WINDOW_HEIGHT - VERT_PADDING : cursorPosition.y + VERT_PADDING;
    }

    // socket.on('status', function(state){
    //   if (state.value == 'closed') {
    //     $(state.id).removeClass('open');
    //     $(state.id).addClass('closed');
    //   } else if (state.value == 'open') {
    //     $(state.id).addClass('open');
    //     $(state.id).removeClass('closed');
    //   } else if (state.value == 'off') {
    //     $(state.id).removeClass('on');
    //     $(state.id).addClass('off');
    //   } else if (state.value == 'on') {
    //     $(state.id).addClass('on');
    //     $(state.id).removeClass('off');
    //   }
    // });
  });

  const {Menu, MenuItem} = require('electron');
  var menu = new Menu();

  menu.append(new MenuItem({ label: 'Quit', click: () => app.quit() }));

  var ipcMain = require('electron').ipcMain;
  ipcMain.on('show-config-menu', (event) => {
      menu.popup(window);
  });
  ipcMain.on('socket-send', (event, arg) => {
      console.log('on socket-send ' + arg);
      // socket.emit(arg);
  });
  ipcMain.on('register-listener', (event, arg) => {
      console.log('on register-listener ' + arg);
      sensorListener = event.sender;
      // socket.emit(arg);
  });

  var onOff = 'on';
  var sensorListener = null;
  setInterval( function () {
    if (sensorListener != null) {
      console.log('Emitting: ' + onOff);
      sensorListener.send('status', onOff);
      if (onOff === 'off') {
        onOff = 'on';
      } else {
        onOff = 'off';
      }
    }
  }, 3000);
});
