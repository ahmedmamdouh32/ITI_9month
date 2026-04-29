import { Routes } from '@angular/router';
import { Products } from './products/products';
import { Home } from './home/home';
import { Contact } from './contact/contact';
// import { ProductDetails } from './product-details/product-details';
import { Details } from './details/details';

export const routes: Routes = [
    // { path: '', redirectTo: 'home', pathMatch: 'full' },
    // {
    //     path: 'home', component: Home, children: [
    //         { path: 'tv', component: Tv },
    //         { path: 'laptop', component: Laptop }
    //     ]
    // },
    // { path: 'about', loadComponent: () => import('./components/about/about').then(c => c.About) },
    // { path: 'products', component: Products },
    // { path: 'productDetails/:id', component: ProductDetails },
    // { path: '**', component: NotFound }
    { path: '', redirectTo: 'home', pathMatch: 'full' },
    { path: 'home', component: Home },
    { path: 'products', component: Products },
    { path: 'productDetails/:id', component: Details },
    { path: 'contacts', component: Contact },
    { path: '**', redirectTo: 'home' }  // Add this to catch invalid routes
];
