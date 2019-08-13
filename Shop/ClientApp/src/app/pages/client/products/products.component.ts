import {Component, OnInit} from '@angular/core';
import {ProductModel} from "../../../models/procuct.model";
import {ProductsApiService} from "../../../api/product.api.service";

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit {
  public products: Array<ProductModel>;

  constructor(private productService: ProductsApiService) {
  }

  ngOnInit() {
    this.productService.getDataProductsList().subscribe(
      (response: any) => {
        return this.products = response;
      }
    )
  }

}
