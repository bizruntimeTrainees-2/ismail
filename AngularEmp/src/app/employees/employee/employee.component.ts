import { Component, OnInit } from '@angular/core';
import { EmployeeService } from 'src/app/shared/employee.service';
import { NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';



@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent implements OnInit {

  
  constructor(private service:EmployeeService, private toastr: ToastrService) { }

  ngOnInit() {
   this.resetForm();
  }

  resetForm(form? : NgForm){
   if(form != null)
    form.reset();

    this.service.formData = {
      employeeID:null,
      fullName :'',
      EMPCode : '',
      postion : '',
      mobileNo : ''
    }
  }

  onSubmit(form : NgForm){
    if(form.value.employeeID == null)
      this.insertRecord(form);
    else
     this.updateRecord(form);

     this.resetForm(form);
  
  }

  insertRecord(form:NgForm)
  {
  this.service.postData(form.value).subscribe(res => {
    this.toastr.success('inserted successfully',"Employee Registration ");    
    this.service.refreshList(); 
  });
  console.log("inserted successfully");
  }

  updateRecord(form:NgForm)
  {
    this.service.putData(form.value).subscribe(res => {
      this.toastr.success('updated successfully',"Employee Details");  
      this.service.refreshList();     
    });
    console.log("updated successfully");
  }
}
