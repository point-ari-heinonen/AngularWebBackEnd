import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title:string = 'sovellukseen!';
  productCount: number = -1;
  productList: string[] = [];

  constructor(private http: HttpClient){}

  ngOnInit(): void {
      // Make the HTTP request:
      this.http.get('/api/values/ProductCount').subscribe(data => {
          // Read the result field from the JSON response.
          this.productCount = parseInt(data.toString());
      });

      this.http.get('/api/values/productlist').subscribe(
          (data: string[]) => {
              this.productList = data;
        });
  }
}
