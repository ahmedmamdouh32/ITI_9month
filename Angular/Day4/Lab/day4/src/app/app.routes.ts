import { Routes, RouterModule } from '@angular/router';
import { Students } from './Components/students/students';
import { Clock } from './Components/clock/clock';

export const routes: Routes = [
    { path: '', redirectTo: 'students', pathMatch: 'full' },
    { path: 'students', component: Students },
    { path: 'clock', component: Clock }
];