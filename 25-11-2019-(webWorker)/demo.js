self.addEventListener('message', function(e) {
  var data = e.data;
  switch (data.cmd) {
    case 'start':
      self.postMessage('woker started: ' + data.msg);
      break;
    case 'stop':
      self.postMessage('worker stopped: ' + data.msg +  '. (buttons will no longer work)');
	// Terminates the worker.
      self.close(); 
      break;
    default:
      self.postMessage('Unknown data: ' + data.msg);
  };
}, false);