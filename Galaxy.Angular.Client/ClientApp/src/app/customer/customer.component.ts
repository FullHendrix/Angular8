import { Component, OnInit } from '@angular/core';
import { Router } from "@angular/router";

@Component({
  selector: 'app-customer',
  templateUrl: './customer.component.html',
  styles: []
})
export class CustomerComponent implements OnInit {

  constructor(private router: Router) {

  }

  ngOnInit() {
  }
  public goto(url) {
    this.router.navigate([url]).then((e) => {
      if (e) {
        console.log("Navigation is successful!");
      } else {
        console.log("Navigation has failed!");
      }
    });
  }
}
