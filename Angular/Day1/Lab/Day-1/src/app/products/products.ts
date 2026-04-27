import { Component, signal } from '@angular/core';
import { NgClass, NgStyle } from '@angular/common';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-products',
  imports: [NgClass, NgStyle, FormsModule],
  templateUrl: './products.html',
  styleUrl: './products.css',
})
export class Products {
  products = [
    { id: 1, name: 'Smart Watch', price: 120, image: 'watch1.jpg', inStock: true, category: 'sport' },
    { id: 2, name: 'Classic Watch', price: 90, image: 'watch2.jpg', inStock: false, category: 'classic' },
    { id: 3, name: 'Sport Watch', price: 150, image: 'watch3.jpg', inStock: true, category: 'sport' },
    { id: 4, name: 'Luxury Watch', price: 300, image: 'watch4.jpg', inStock: false, category: 'luxury' }
  ];


  categories: string[] = [...new Set(this.products.map(p => p.category))];
  AddToCart(productName: string) {
    alert(productName);
  }

  selectedCategory: string = 'all';

  getSelectedProducts() {
    if (this.selectedCategory === 'all') {
      return this.products;
    }
    return this.products.filter(p => p.category === this.selectedCategory);
  }



}
