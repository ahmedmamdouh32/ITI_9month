import { Component } from '@angular/core';
import { FormsModule } from "@angular/forms";

@Component({
  selector: 'app-practicing',
  imports: [FormsModule],
  templateUrl: './practicing.html',
  styleUrl: './practicing.css',
})
export class Practicing {

  name: string = "Ahmed Mamdouh";
  age: number = 25;
  schools: string[] = ['ahmed zewail', 'mostafa kamel'];

  greet() {
    return "hello world";
  }


  colorflag: boolean = false;
  imgAlt: string = "smart watch"


  //old school
  imgUrl: string = "watch1.jpg";

  //nowadays 

  buttonFlag: boolean = true;
  paragraph: string = "";

  printInupt(e: Event) {
    let targetEle = e.target as HTMLInputElement
    this.paragraph = targetEle.value;
  }

  paragraph2: string = "";

  gender: string = "";

  userName: string = "";
  dispFlag: boolean = false;
  usernameValidation() {
    if (this.userName.length < 5) {
      this.dispFlag = true;
    }
    else {
      this.dispFlag = false;
      // raeturn "";
    }
    return "name is tooooo short";
  }

  bgFlag: boolean = true;
  styleFlag: boolean = false;

}



