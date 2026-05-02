import { Routes, RouterModule } from '@angular/router';
import { TemplateForm } from './Components/template-form/template-form';
import { ReactiveForm } from './Components/reactive-form/reactive-form';
import { SignalForm } from './Components/signal-form/signal-form';
// import { Students } from './Components/students/students';
// import { Clock } from './Components/clock/clock';

export const routes: Routes = [
    { path: '', redirectTo: 'template_form', pathMatch: 'full' },
    { path: 'template_form', component: TemplateForm },
    { path: 'reactive_form', component: ReactiveForm },
    { path: 'signal_form', component: SignalForm }
];