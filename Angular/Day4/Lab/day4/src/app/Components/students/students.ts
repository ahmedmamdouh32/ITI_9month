import { Component } from '@angular/core';
import { Istudent } from '../../Interfaces/istudent';
import { StudentCardComponent } from '../student-card-component/student-card-component';

@Component({
  selector: 'app-students',
  imports: [StudentCardComponent],
  templateUrl: './students.html',
  styleUrl: './students.css',
})
export class Students {

  students: Istudent[] = [
    { id: 1, name: 'Sara', track: 'Frontend', grade: 85 },
    { id: 2, name: 'Ali', track: 'Backend', grade: 70 },
    { id: 3, name: 'Mona', track: 'UI/UX', grade: 90 }
  ];

  selectedStudent: Istudent | null = null;
  activePage: boolean = true;

  storeSelectedStudent(student: Istudent) {
    this.selectedStudent = student;
  }

}
