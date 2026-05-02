import { Component, EventEmitter, Output } from '@angular/core';
import { NgClass } from '@angular/common';

@Component({
  selector: 'app-button',
  imports: [NgClass],
  templateUrl: './button.html',
  styleUrl: './button.css',
})
export class Button {

  isGreen: boolean = false;
  scale: boolean = false;

  @Output() clickEvent = new EventEmitter<void>();

  btnClicked() {
    this.isGreen = true;
    this.scale = true;
    this.clickEvent.emit();
  }

  btnBlur() {
    this.isGreen = false;
    this.scale = false;
    console.log('blured');
  }
}
