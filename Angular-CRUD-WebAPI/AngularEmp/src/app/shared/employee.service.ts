import { Injectable } from '@angular/core';
import { Employee } from './employee.model';
import { HttpClient } from "@angular/common/http";


@Injectable({
  providedIn: 'root'
})
export class EmployeeService {
  formData: Employee;
  list : Employee[];
  readonly rootUrl = "https://localhost:44319/api";
  constructor(private _http: HttpClient) { }

  postData(formData : Employee)
  {
    return  this._http.post(this.rootUrl+"/Employee",formData)
  }

  refreshList()
  {
     this._http.get(this.rootUrl+"/Employee").toPromise().then(res => this.list= res  as Employee[]);
  }
  
  putData(formData : Employee)
  {
     
    return  this._http.put(this.rootUrl+"/Employee/"+formData.employeeID,formData);  
  }

  deleteEmployee(id :number){
   return this._http.delete(this.rootUrl+"/Employee/"+id);
  }
}
