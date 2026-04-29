import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Navbar } from './navbar/navbar';
import { MainSection } from './main-section/main-section';
import { HeroSection } from './hero-section/hero-section';
import { Footer } from './footer/footer';
import { Products } from './products/products';
import { Practicing } from './practicing/practicing';
import { Child } from './child/child';


@Component({
  selector: 'app-root',
  // imports: [Navbar, MainSection, HeroSection, Footer, Products],
  // imports: [Navbar, RouterOutlet, Child],
  imports: [Navbar, Child],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('Day-1');

}