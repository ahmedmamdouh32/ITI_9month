import { NgClass } from '@angular/common';
import { Component, Input, Output, EventEmitter, OnChanges, SimpleChanges } from '@angular/core';
import { waitForAsync } from '@angular/core/testing';

@Component({
  selector: 'app-child',
  imports: [NgClass],
  templateUrl: './child.html',
  styleUrl: './child.css',
})
export class Child {
  isRed: boolean = false;
  scale: boolean = false;
  toggleColor() {
    this.isRed = !this.isRed;
    this.scale = !this.scale;
  }
}
