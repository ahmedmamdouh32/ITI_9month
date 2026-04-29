import { Directive, ElementRef, HostListener } from '@angular/core';

@Directive({
  selector: '[appHoverText]',
})
export class HoverText {
  constructor(private ref: ElementRef) { };

  @HostListener('mouseenter') onMouseEnter() {
    this.ref.nativeElement.style.transform = 'scale(1.05)';
    this.ref.nativeElement.style.transition = 'all 0.5s ease';
  }

  @HostListener('mouseleave') onMouseOut() {
    this.ref.nativeElement.style.transform = 'scale(1)';
    this.ref.nativeElement.style.transition = 'all 0.5s ease';

  }
}
