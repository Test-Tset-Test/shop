import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Product } from '../models/product';
import {ProductService} from '../services/product.service';

@Component({
  selector: 'app-products-component',
  templateUrl: './products.component.html'
})
export class ProductsComponent {
  product: Product = new Product();
  products: Product[];
  tableMode: boolean = true;

  constructor(private productService: ProductService) { }

  ngOnInit() {
    this.loadProducts();
  }

  loadProducts() {
    this.productService.getProducts()
      .subscribe((data: Product[]) => this.products = data);
  }

  save() {
    if (this.product.id == null) {
      this.productService.createProduct(this.product)
        .subscribe((data: Product) => this.products.push(data));
    } else {
      this.productService.updateProduct(this.product)
        .subscribe(data => this.loadProducts());
    }
    this.cancel();
  }
  editProduct(p: Product) {
    this.product = p;
  }
  cancel() {
    this.product = new Product();
    this.tableMode = true;
  }
  delete(p: Product) {
    this.productService.deleteProduct(p.id)
      .subscribe(data => this.loadProducts());
  }
  add() {
    this.cancel();
    this.tableMode = false;
  }
}
