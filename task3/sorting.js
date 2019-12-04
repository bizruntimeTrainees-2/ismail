
  function Sorting(c) {
    var table, rows, switching, i, x, y, shouldSwitch;
    table = document.getElementById('mytable');
    switching = true;
    while (switching) {
      switching = false;
      rows = table.rows;
      for (i = 1; i < (rows.length - 1); i++) {
        shouldSwitch = false;
        x = rows[i].getElementsByTagName("td")[c];
        y = rows[i + 1].getElementsByTagName("td")[c]; 
        if( c == 0|| c == 3) 
        {
			x = parseInt(x.innerHTML);
			y = parseInt(y.innerHTML);
          if (x > y) {
            shouldSwitch = true;
            break;
          }    
        }
      else {
          if (x.innerHTML.toLowerCase() > y.innerHTML.toLowerCase()) {
          shouldSwitch = true;
          break;
        }
      }
      }
      if (shouldSwitch) {
        rows[i].parentNode.insertBefore(rows[i + 1], rows[i]);
        switching = true;
      }
    }
  }
