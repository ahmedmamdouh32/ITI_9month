import { Component, signal } from '@angular/core';
import { NgClass, NgStyle } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { Iproducts } from '../../Interfaces/Iproducts';
import { DescriptionFormatPipe } from '../pipes/description-format-pipe';
import { RatingFormatPipe } from '../pipes/rating-format-pipe';
import { HoverText } from '../directives/hover-text';
import { RouterLink } from "@angular/router";

@Component({
  selector: 'app-products',
  imports: [NgClass, NgStyle, FormsModule, DescriptionFormatPipe, RatingFormatPipe, HoverText, RouterLink],
  templateUrl: './products.html',
  styleUrl: './products.css',
})
export class Products {
  products = signal<Iproducts[]>([
    { id: '1', name: 'Smart Watch', price: 120, description: 'this watch is very beautiful and unique', image: 'watch1.jpg', category: 'sport', quantity: 0, inStock: true, rating:4},
    { id: '2', name: 'Classic Watch', price: 90, description: 'this watch is very beautiful and unique', image: 'watch2.jpg', category: 'classic', quantity: 0, inStock: false, rating:5 },
    { id: '3', name: 'Sport Watch', price: 150, description: 'this watch is very beautiful and unique', image: 'watch3.jpg', category: 'sport', quantity: 0, inStock: true, rating:3 },
    { id: '4', name: 'Luxury Watch', price: 300, description: 'this watch is very beautiful and unique', image: 'watch4.jpg', category: 'luxury', quantity: 0, inStock: false , rating:2}
  ]);


  categories: string[] = [...new Set(this.products().map(p => p.category))];
  AddToCart(productName: string) {
    alert(productName);
  }

  selectedCategory: string = 'all';

  selectedProducts: any = this.products();

  selectProducts() {
    if (this.selectedCategory === 'all') {
      this.selectedProducts = this.products();
    }
    else {
      this.selectedProducts = this.products().filter(p => p.category === this.selectedCategory);
    }
  }


}
