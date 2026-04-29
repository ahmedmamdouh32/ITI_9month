import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Istudent } from '../../Interfaces/istudent';

@Component({
  selector: 'app-student-card-component',
  imports: [],
  templateUrl: './student-card-component.html',
  styleUrl: './student-card-component.css',
})
export class StudentCardComponent {

  @Input()
  student: Istudent = { id: 0, name: '', grade: 0, track: '' };

  @Output()
  myEvent = new EventEmitter()   // this is the messenger

  emitStudent(): void {
    this.myEvent.emit(this.student)  // fire! send product to parent
  }




}
