import { Component } from '@angular/core';
import { Navbar } from '../navbar/navbar';
import { Footer } from '../footer/footer';
import { HeroSection } from '../hero-section/hero-section';
import { MainSection } from '../main-section/main-section';
import { Products } from '../products/products';

@Component({
  selector: 'app-home',
  imports: [Footer, HeroSection, MainSection, Products],
  templateUrl: './home.html',
  styleUrl: './home.css',
})
export class Home { }
