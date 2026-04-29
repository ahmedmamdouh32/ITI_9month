import { Component, inject, signal } from '@angular/core';
import { ActivatedRoute, RouterLink } from '@angular/router';
import { Iproducts } from '../../Interfaces/Iproducts';
import { RatingFormatPipe } from '../pipes/rating-format-pipe';
import { DescriptionFormatPipe } from '../pipes/description-format-pipe';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-details',
  imports: [RatingFormatPipe, DescriptionFormatPipe, CommonModule],
  templateUrl: './details.html',
  styleUrl: './details.css',
})
export class Details {

  products = signal<Iproducts[]>([
    { id: '1', name: 'Smart Watch', price: 120, description: 'this watch is very beautiful and unique', image: 'https://i.pinimg.com/736x/96/56/72/965672c5c08380048860f92b4216b6bb.jpg', category: 'sport', quantity: 0, inStock: true, rating: 4 },
    { id: '2', name: 'Classic Watch', price: 90, description: 'this watch is very beautiful and unique', image: 'watch2.jpg', category: 'classic', quantity: 0, inStock: false, rating: 5 },
    { id: '3', name: 'Sport Watch', price: 150, description: 'this watch is very beautiful and unique', image: 'watch3.jpg', category: 'sport', quantity: 0, inStock: true, rating: 3 },
    { id: '4', name: 'Luxury Watch', price: 300, description: 'this watch is very beautiful and unique', image: 'watch4.jpg', category: 'luxury', quantity: 0, inStock: false, rating: 2 }
  ]);

  id: string | null = ""
  product: any;
  constructor(private route: ActivatedRoute) {
    this.route.paramMap.subscribe(params => {
      this.id = params.get('id')
      this.product = this.products().find(p => p.id === this.id)
    })
  }


  AddToCart(productName: string) {
    alert(productName);
    console.log(this.product.image);
  }


}
