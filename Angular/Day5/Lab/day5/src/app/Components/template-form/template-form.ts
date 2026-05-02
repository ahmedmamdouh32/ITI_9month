import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-template-form',
  imports: [FormsModule],
  templateUrl: './template-form.html',
  styleUrl: './template-form.css',
})
export class TemplateForm {
  formSubmission(form: any) {
    if (form.valid) {
      this.userData.username = form.controls.username.value;
      this.userData.email = form.controls.userEmail.value;
      this.userData.message = form.controls.userMessage.value;
      this.showData = true;
      form.reset()
    }
  }

  userData = {
    username: '',
    email: '',
    message: ''
  }
  showData: boolean = false;



}

