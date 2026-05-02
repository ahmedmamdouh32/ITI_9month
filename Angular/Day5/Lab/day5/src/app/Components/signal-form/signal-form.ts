import { Component, signal } from '@angular/core';
import { email, form, FormField, required } from '@angular/forms/signals';
import { FormControl, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';

@Component({
  selector: 'app-signal-form',
  imports: [FormField, FormsModule],
  templateUrl: './signal-form.html',
  styleUrl: './signal-form.css',
})
export class SignalForm {
  loginModel = signal({
    email: '',
    password: '',
    username: ''
  });

  loginForm = form(this.loginModel, (schema) => {
    required(schema.email, { message: "Email is required" });
    email(schema.email, { message: "Invalid email format" });
    required(schema.password, { message: "Password is required" });
  });

  showData: boolean = false;
  submit() {
    const formInstance = this.loginForm();

    if (formInstance.invalid()) {
      console.log("invalid input");
      return;
    }
    else {
      this.showData = true;
      if (this.loginModel().username === '') {
        this.loginModel.update((model) => (model = { ...model, username: 'not set' }))
      }
    }
  }


}
