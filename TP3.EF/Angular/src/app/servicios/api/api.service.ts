import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse, HttpStatusCode } from '@angular/common/http';
import { HttpHeaders } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError, retry } from 'rxjs/operators';
import { ListaShipperI } from 'src/app/interface/dashboard.interface';
@Injectable({
  providedIn: 'root'
})
export class ApiService {
  url:string = "https://localhost:44332/api/Shippers";
  constructor(private http:HttpClient) { }


  getAllShippers():Observable<ListaShipperI[]>{
  let direccion = this.url ;
  return this.http.get<ListaShipperI[]>(direccion).pipe(
    catchError((error) => {
      return this.errorhandler(error);
    })
  );

  }

  NewShipper(shipper:ListaShipperI):Observable<ListaShipperI>{
  let direccion = this.url ;
  return this.http.post<ListaShipperI>(direccion,shipper).pipe(
    catchError((error) => {
      return this.errorhandler(error);
    })
  );
  }

  EditShipper(shipper:ListaShipperI):Observable<ListaShipperI>{
    let direccion = this.url ;
    return this.http.put<ListaShipperI>(direccion,shipper).pipe(
      catchError((error) => {
        return this.errorhandler(error);
      })
    );
  }

  DeleteShipper(ShipperID:number){
  let direccion = this.url + "/" + ShipperID;
  let Options = new HttpHeaders({ 'Content-Type' : 'string' });
  return this.http.delete(direccion,{headers:Options,responseType:'text',observe:'body'}).pipe(
    catchError((error) => {

      return this.errorhandler(error);
    })
  );

  }

  errorhandler(error: HttpErrorResponse){
    if(error instanceof HttpErrorResponse) {
      if(error.error instanceof ErrorEvent) {
        alert("Error de Cliente")
      }else{
        alert("Error del Servidor")
      }
    }else{
      alert("Error no Determinado")
    }
    alert(error.message);
    return throwError(error);
  }

}
