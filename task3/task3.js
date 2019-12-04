
function LoadData(){

	fetch('company1.txt').then(function(response){
		return response.text();
	}).then(function(data)
	{
        var filedata = data;
        var employee_data = data.split("\n");
        
        var table_data = '<table id="mytable" class="table table-hover">';
        var row_id =0;
        var remove_id =1;
        
        for (var count=0; count < employee_data.length; count++)
        {
            var cell_data = employee_data[count].split(",");
            table_data += '<tr>';
            for(var cell_count =0; cell_count < cell_data.length; cell_count++)
                {                         
                    if(count==0)
                    {
                        table_data += '<th>'+'<a  onclick="Sorting('+cell_count+')">' +cell_data[cell_count]+'</a>'+' </th>';
                        
                    }
                    else
                    {
                        table_data += '<td >'+cell_data[cell_count]+'</td>';
                    }
                    
                }
                if(count ==0)
                {
                    table_data += '<td>' +'<h4>'+' Edit '+'</h4>'+' </td>';
                    table_data += '<td>' +'<h4>' +'Delete '+'</h4>'+' </td>';	
                }
                if(count !=0 && count < employee_data.length-1)
                {
                   
                    table_data += '<td>' +'<button onclick="Editing(event) " class="btn btn-primary">Edit</button> '+' </td>';
                    table_data += '<td>'  +'<button  class="Remove btn btn-primary"> Delete</button> '+' </td>';	
                }
                
                table_data +='</tr>';
        }
                        
        table_data += '</table>';
    
        $("#employee_table").html(table_data);
        
        $(document).on('click', '.Remove', function() {
            $(this).parents('tr').remove();
        });
      
	}); 
}