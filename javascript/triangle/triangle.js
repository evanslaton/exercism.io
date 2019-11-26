//
// This is only a SKELETON file for the 'Triangle' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export class Triangle {
    constructor(side1, side2, side3) {
        this.side1 = side1;
        this.side2 = side2;
        this.side3 = side3;
    }

    kind() {
        if (!this.isTriangle()) throw new Error();

        if (this.side1 === this.side2 && this.side2 === this.side3) {
            return 'equilateral';
        } else if (this.side1 === this.side2 || this.side2 === this.side3 || this.side3 === this.side1) {
            return 'isosceles';
        } else {
            return 'scalene';
        }
    }

    isTriangle() {
        if (this.side1 <= 0 || this.side2 <= 0 || this.side3 <= 0)
            return false;
        else if (this.side1 + this.side2 < this.side3)
            return false;
        else if (this.side1 + this.side3 < this.side2)
            return false;
        else if (this.side2 + this.side3 < this.side1)
            return false;
        else
            return true;
    }
}
