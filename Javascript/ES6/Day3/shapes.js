export class Shape {
    constructor() {
        if (this.constructor === Shape) {
            throw new Error("Cannot instantiate abstract class Shape directly.");
        }
    }

    area() {
        throw new Error("Method 'area()' must be implemented.");
    }

    perimeter() {
        throw new Error("Method 'perimeter()' must be implemented.");
    }

    toString() {
        return `Area: ${this.area()} , Perimeter: ${this.perimeter()}`;
    }
}

export class Rectangle extends Shape {
    constructor(width, height) {
        super();
        this.width = width;
        this.height = height;
    }

    area() {
        return this.width * this.height;
    }

    perimeter() {
        return 2 * (this.width + this.height);
    }

    toString() {
        return `Rectangle → Width: ${this.width}, Height: ${this.height}, Area: ${this.area()}, Perimeter: ${this.perimeter()}`;
    }
}

export class Square extends Shape {
    constructor(side) {
        super();
        this.side = side;
    }

    area() {
        return this.side * this.side;
    }

    perimeter() {
        return 4 * this.side;
    }

    toString() {
        return `Square → Side: ${this.side}, Area: ${this.area()}, Perimeter: ${this.perimeter()}`;
    }
}

export class Circle extends Shape {
    constructor(radius) {
        super();
        this.radius = radius;
    }

    area() {
        return Math.PI * this.radius ** 2;
    }

    perimeter() {
        return 2 * Math.PI * this.radius;
    }

    toString() {
        return `Circle → Radius: ${this.radius}, Area: ${this.area().toFixed(2)}, Perimeter: ${this.perimeter().toFixed(2)}`;
    }
}