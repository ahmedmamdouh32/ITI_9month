import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Istudent } from './Interfaces/istudent';
import { StudentCardComponent } from './Components/student-card-component/student-card-component';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, StudentCardComponent],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('day4');

  students: Istudent[] = [
    { id: 1, name: 'Sara', track: 'Frontend', grade: 85 },
    { id: 2, name: 'Ali', track: 'Backend', grade: 70 },
    { id: 3, name: 'Mona', track: 'UI/UX', grade: 90 }
  ];

  selectedStudent: Istudent | null = null;


  storeSelectedStudent(student: Istudent) {
    this.selectedStudent = student;
  }




}
