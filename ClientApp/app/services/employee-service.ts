import { Injectable } from '@angular/core';
import { Http } from '@angular/http';

@Injectable()
export class EmployeeService {
    constructor(private http: Http) { }

    getEmployeeList() {
        return this.http.get('http://localhost:50770/api/employee');
    }
}
