import { Component,OnInit } from '@angular/core';
import {GetPhoto} from './app.service';
import { FormGroup,FormControl } from '@angular/forms';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  comment:any= [""];
  form:any;
  myphoto:any;
  myphotoid:any = 1;
  onephoto:any;
  flagPhoto:boolean = true;
  newcoment:any ="";
  constructor(private service:GetPhoto)
  {
  }
  ngOnInit(): void {
    this.form = new FormGroup({
      text: new FormControl()})
    this.service.Get().subscribe(res=>{this.myphoto=res});
    
     }
  onChange(id:any){
    this.myphotoid = id;
    this.flagPhoto = !this.flagPhoto;
    this.service.GetId(this.myphotoid).subscribe(res=>{this.onephoto=res})
    this.service.GetComment(id).subscribe(res=>{this.comment = res})
    
  }
  onSubmit(form:any){
    console.log(form)
    this.service.Post(this.form.value.text, this.myphotoid).subscribe();
    this.newcoment += this.form.value.text + document.createElement("</br>").parentElement +" ";
    

  }
 

}
