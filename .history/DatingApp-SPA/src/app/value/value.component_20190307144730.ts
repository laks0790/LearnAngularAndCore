import { Component, OnInit } from '@angular/core';
import { HttpClientModule } from '@angular/common/http'
 

@Component({
  selector: 'app-value',
  templateUrl: './value.component.html',
  styleUrls: ['./value.component.css']
})
export class ValueComponent implements OnInit {

  constructor(private http:HttpClient) { 

  }

  ngOnInit() {
  }

}
