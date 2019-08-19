import { Component, OnInit, ViewChild } from '@angular/core';
import { BackendService } from "../services/backend.service";
import { SharedService } from "../services/shared.service";

@Component({
  selector: 'app-content',
  templateUrl: './content.component.html',
  styleUrls: ['./content.component.css']
})
export class ContentComponent implements OnInit {

  @ViewChild('backContent') backContent;

  metadata: Array<any> = [];
  sensors: Array<any> = [];
  constructor(private api: BackendService,
    private shared: SharedService) { }

  ngOnInit() {
    var self = this;

    //Get data from server side
    this.api.get().subscribe((res:any[]) => {
      self.metadata = res;
    }, err => { console.log(err) })

    //Set background color
    this.shared.backColor.subscribe(color => {
      if (color.length > 0) {
        this.backContent.nativeElement.style.backgroundColor = color;
      }
    })

    //Set selected sensors
    this.shared.sensors.subscribe(selectedSensors => {
      if (selectedSensors.length > 0)
      {
        var ids = selectedSensors.map(s => s.id);
        self.sensors = self.metadata.filter(function (d) {
          return ids.indexOf(d.id) != -1;
        });
      }
    })

  }

}
