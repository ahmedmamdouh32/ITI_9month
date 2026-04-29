import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'ratingFormat',
})
export class RatingFormatPipe implements PipeTransform {
  transform(value: number, maxRating: number = 5) {
    if (value < 0) value = 0

    if (maxRating > 5) {
      value = value * 5 / maxRating; //scalling rating to 5
      maxRating = 5; //resets the max rating
    }
    let fullStar = " ★"
    let emptyStar = "☆"
    let full = fullStar.repeat(Math.round(value))
    let empty = emptyStar.repeat(maxRating - Math.round(value))
    return `(${value}/${maxRating})`+full + empty;
  }
}
