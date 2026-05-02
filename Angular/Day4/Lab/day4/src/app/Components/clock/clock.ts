import { AfterViewInit, Component, OnDestroy, OnInit, signal, Signal } from '@angular/core';
import { dateTimestampProvider } from 'rxjs/internal/scheduler/dateTimestampProvider';

@Component({
  selector: 'app-clock',
  imports: [],
  templateUrl: './clock.html',
  styleUrl: './clock.css',
})
export class Clock implements OnInit, OnDestroy, AfterViewInit {

  time = signal(new Date().toLocaleTimeString());
  timerId: any;

  ngOnInit() {
    this.startClock();
  }


  ngOnDestroy() {
    clearInterval(this.timerId);
  }

  ngAfterViewInit() {
    // this.startClock();
  }

  // private updateTime(): void {
  //   const now = new Date();
  //   this.time = now.toTimeString();
  //   const hours = now.getHours().toString().padStart(2, '0');
  //   const minutes = now.getMinutes().toString().padStart(2, '0');
  //   const seconds = now.getSeconds().toString().padStart(2, '0');

  //   this.time = `${hours}:${minutes}:${seconds}`;
  // }

  private startClock(): void {
    // this.updateTime(); //fisrt call
    this.timerId = setInterval(() => {
      // this.updateTime();
      console.log('asd');
      this.time.set(new Date().toLocaleTimeString());
      console.log(this.time);
    }, 1000);
  }
}
