import { Component } from '@angular/core';
import { FormControl, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { validate } from '@angular/forms/signals';
import { concatWith } from 'rxjs';

@Component({
  selector: 'app-reactive-form',
  imports: [ReactiveFormsModule, FormsModule],
  templateUrl: './reactive-form.html',
  styleUrl: './reactive-form.css',
})
export class ReactiveForm {

  // username = new FormControl(null, [Validators.required, Validators.minLength(3)]);
  // email = new FormControl(null, [Validators.required, Validators.email]);

  // formSubmit() {
  //   if (this.username.invalid || this.email.invalid) {
  //     this.username.markAsTouched();
  //     this.email.markAsTouched();
  //     return;
  //   }
  //   else console.log(this.username.value);
  // }

  paymentMethods: string[] = ["--Select Method--", "Orange Cash", "Etisalat Cash", "Credit Card"];

  form = new FormGroup({
    name: new FormControl(null, Validators.required),
    email: new FormControl(null, [Validators.required, Validators.email]),
    address: new FormGroup({
      city: new FormControl(null),
      street: new FormControl(null)
    })
    , paymentMethod: new FormControl(this.paymentMethods[0])
  })

  showData: boolean = false;

  userData = {
    name: '',
    email: '',
    address: {
      city: '',
      street: ''
    }
    , paymentMethod: ''
  };
  submit() {
    if (this.form.invalid || this.form.controls['paymentMethod'].value == this.paymentMethods[0]) {
      this.form.markAllAsTouched();
      return;
    }

    this.showData = true;
    this.userData.name = this.form.controls['name'].value ?? '';
    this.userData.email = this.form.controls['email'].value ?? '';
    this.userData.address.city = this.form.controls['address'].value.city ?? '';
    this.userData.address.street = this.form.controls['address'].value.street ?? 'not set';
    this.userData.paymentMethod = this.form.controls['paymentMethod'].value ?? 'not set';
    console.log(this.form.controls.name.value);
  }
}
