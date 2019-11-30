$(document).ready(function(){
	$("#company4_data").click(function(){
		$.ajax({
			url:"company4.txt",
			dataType:"text",
			success:function(data)
			{
				var employee_data = data.split("\n");
				var table_data = '<table class="table table-bordered table-striped">';
				for (var count=0; count < employee_data.length; count++)
				{
					var cell_data = employee_data[count].split(",");
                    table_data += '<tr>';
					for(var cell_count =0; cell_count < cell_data.length; cell_count++)
						{
                           
							if(count==0)
							{
								table_data += '<th>'+ cell_data[cell_count]+'</th>';
							}
							else
							{
								table_data += '<td>'+cell_data[cell_count]+'</td>';
                            }
                            
                        }
						table_data += '<td>' +"<a href='#'>edit</a>"+"</td>";
						table_data += '<td>' +"<a href='#'>delete</a>"+"</td>";
                        table_data +='</tr>';
				}
				table_data += '</table>';
				$("#employee_table").html(table_data);
			}

		})
	});
});