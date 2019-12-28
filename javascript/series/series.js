//
// This is only a SKELETON file for the 'Series' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export class Series {
  constructor(numbers) {
    this._digits = [];
    for (let i = 0; i < numbers.length; i++) {
      this._digits.push(parseInt(numbers[i]));
    }
  }

  get digits() {
    return this._digits;
  }

  slices(number) {
    if (number > this._digits.length) {
      throw new Error('Slice size is too big.');
    }

    const output = [];
    for (let i = 0; i < this._digits.length - (number - 1); i++) {
        output.push(this._digits.slice(i, i + number));
    }

    return output;
  }
}
