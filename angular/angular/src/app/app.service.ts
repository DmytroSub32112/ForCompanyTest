import { Injectable } from "@angular/core";
import {HttpClient} from  "@angular/common/http";
@Injectable(
 {providedIn:'root'}
)
 export class GetPhoto {

   constructor( private http:HttpClient){}


   Get(){

    return this.http.get("https://localhost:44366/RESTapi")
   }
   GetId(id:number){

    return this.http.get("https://localhost:44366/RESTapi/"+id)
   }
   Post(text:any,Id:any){
    var forcomment = new ForComment();
    forcomment.id = Id;
    forcomment.text =text;
    console.log(text,Id)
    console.log(forcomment)
    return this.http.post("https://localhost:44366/RESTapi",forcomment)
   }
   GetComment(id:number){
      return this.http.get("https://localhost:44366/Comment/"+id)
   }
}
 class ForComment{
   constructor(){}
  id:any;
  text:any
 }