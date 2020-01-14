import { Injectable } from '@angular/core';
    import { environment } from 'src/environments/environment';
    import { HttpClient } from '@angular/common/http';
    
export interface AddCustomerRequest {
    	name: string;
	email: string;
	age: number;
}

export interface CustomerDto {
    	customerId: number;
	name: string;
}
    
        @Injectable({
            providedIn: 'root'
        })
        export class CustomerService {
            apiBaseUrl = environment.apiBaseUrl;
        
            constructor(
                private httpClient: HttpClient
            ) { }            
        
async postCustomer(data: AddCustomerRequest): Promise<any> {
    
            return this.httpClient.post<any>(this.apiBaseUrl + '/Customer/add-customer', data).toPromise();
          }          
          
async getCustomer(id: number): Promise<any> {
            return this.httpClient.get<any>(this.apiBaseUrl + '/Customer/customer/' + id).toPromise();
        }        
        
    }
    