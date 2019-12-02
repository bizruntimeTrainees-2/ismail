

$(document).ready(function(){
	
	$("#TotalEmployee_data").click(function(){
		$.ajax({
			url:"finalEmp.csv",
			dataType:"text",
			success:function(data)
			{
				var filedata = data;
				var employee_data = data.split("\n");
				
				var table_data = '<table class="table table-hover">';
				var row_id =0;
				var remove_id =1;
				var Edit = "Edit";
				var Delete = "Delete";
				for (var count=0; count < employee_data.length; count++)
				{
					var cell_data = employee_data[count].split(",");
					table_data += '<tbody>';
                    table_data += '<tr>';
					for(var cell_count =0; cell_count < cell_data.length; cell_count++)
						{                         
							if(count==0)
							{
								table_data += '<th>'+ cell_data[cell_count]+'</th>';
								
							}
							else
							{
								table_data += '<td contenteditable="true">'+cell_data[cell_count]+'</td>';
                            }
							
						}
						if(count ==0)
						{
							table_data += '<td>' +'<h4>'+' Edit '+'</h4>'+' </td>';
							table_data += '<td>' +'<h4>' +'Delete '+'</h4>'+' </td>';	
						}
						if(count !=0)
						{
							table_data += '<td>' +'<a href="#" class="btn btn-link " row_id="'+ ++row_id+' " > Edit</a> '+' </td>';
							table_data += '<td>'  +'<a href="#" class="Remove "  row_id="'+ ++remove_id+' " > Delete</a> '+' </td>';	
						}
						
						table_data +='</tr>';
						table_data += '</tbody>';
				}
								
				table_data += '</table>';
			
				$("#employee_table").html(table_data);
				
				$(document).on('click', '.Remove', function() {
					$(this).parents('tr').remove();
				});
  
			}

		})
	});
});




 