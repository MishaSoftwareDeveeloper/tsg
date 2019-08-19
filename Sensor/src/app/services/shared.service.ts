import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SharedService {
  //Deliver data beetween components
  private bsSensors = new BehaviorSubject<Array<any>>([]);
  private bsBackground = new BehaviorSubject<string>('');
  sensors = this.bsSensors.asObservable();
  backColor = this.bsBackground.asObservable();

  constructor() { }

  //Deliver selected sensors to content
  setSensors(lastSensors: Array<any>) {
    this.bsSensors.next(lastSensors);
  }
  //Deliver background color to content
  setBackgroundColor(color: string)
  {
    this.bsBackground.next(color);
  }

}
