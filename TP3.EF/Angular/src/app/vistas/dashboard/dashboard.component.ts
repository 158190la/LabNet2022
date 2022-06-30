import { Component, OnInit, SimpleChange } from '@angular/core';
import { ApiService } from 'src/app/servicios/api/api.service';
import { Router } from '@angular/router';

import { ListaShipperI } from 'src/app/interface/dashboard.interface';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { delay } from 'rxjs';



@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
  export class DashboardComponent implements OnInit {
    ShipperID:any = 0
  shippers:ListaShipperI[] = [];
    formulario!:FormGroup;
    formularioUpdate!:FormGroup;
    shipperaeditar:ListaShipperI[] = [
      {
        CompanyName : "",
        Phone : "",
        ShipperID: 0
      }
    ];


  constructor(private api:ApiService, private router:Router,private formbuilder:FormBuilder) { }

  ngOnInit(): void {
    this.formulario = this.formbuilder.group({
      CompanyName: new FormControl('', [Validators.maxLength(40), Validators.required, Validators.minLength(2), Validators.pattern('[a-zA-Z ]*')]),
      Phone: new FormControl('', [Validators.maxLength(24), Validators.required, Validators.minLength(10), Validators.pattern('[0-9]*')])
    });

    this.formularioUpdate = this.formbuilder.group({
      CompanyNameUpdate: new FormControl('', [Validators.maxLength(40), Validators.required, Validators.minLength(2), Validators.pattern('[a-zA-Z ]*')]),
      PhoneUpdate: new FormControl('', [Validators.maxLength(24), Validators.required, Validators.minLength(10), Validators.pattern('[0-9]*')]),
      ShipperIDUpdate: new FormControl('')
    });


    this.api.getAllShippers().subscribe((data: ListaShipperI[])=>{
      this.shippers = data;
    });


  }

    eliminar(ShipperID:number){
      this.api.DeleteShipper(ShipperID).subscribe();
      window.location.reload();
    ;
    }
    editar(ShipperID: any,CompanyName: string, Phone: string){
      let newShipper:ListaShipperI = {
        CompanyName : CompanyName,
        Phone : Phone,
        ShipperID: ShipperID
    }
      this.api.EditShipper(newShipper).subscribe();
        window.location.reload();
    }

    CreateShipper(CompanyName: string, Phone: string): void {
      let newShipper:ListaShipperI = {
        CompanyName : CompanyName,
        Phone : Phone,
        ShipperID: 0
      }

      this.api.NewShipper(newShipper).subscribe();
      window.location.reload();
    }

    formvisibility:boolean = true;
    editarvisibility:boolean = true;
    shippereditar:ListaShipperI[] = [
      {ShipperID:0,CompanyName:'',Phone:''}
    ];


    // shipperSeleccionado(_ShipperID: any) {
    //   this.api.getAllShippers().subscribe((data: ListaShipperI[])=>{
    //     console.log(data);
    //     this.shippereditar = data;
    //     this.shipperaeditar = this.shippereditar.filter(x => x.ShipperID == _ShipperID);
    //     return(this.shipperaeditar);
    //   }
    //   );

    // }

    ngOnchanges(changes: SimpleChange):void{
      this.api.getAllShippers().subscribe((data: ListaShipperI[])=>{
        console.log(data);
        this.shippers = data;
      });




  }
}



