import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";


@Injectable({
  providedIn: 'root'
})
export class BackendService {

  constructor(private http: HttpClient) { }
   //Get data from Server side
  get()
  {
    return this.http.get("/api/Metadata");
  }
  //Read display settings
  getDisplaySetting()
  {
    return this.http.get("./assets/display_settings.json");
  }

}
