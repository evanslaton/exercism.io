//
// This is only a SKELETON file for the 'Pascals Triangle' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export class Triangle {
  constructor(numberOfRows) {
    this._rows = this.createRows(numberOfRows);
  }

  get lastRow() {
    return this._rows[this._rows.length - 1];
  }
  
  get rows() {
    return this._rows;
  }

  createRows(numberOfRows) {
    const rows = [];
    for (let row = 0; row < numberOfRows; row++) {
      let currentRow = [];
      for (let column = 0; column < row + 1; column++) {
        if (column === 0 || column === row) currentRow.push(1);
        else currentRow.push(rows[row - 1][column - 1] + rows[row - 1][column]);
      }
      rows.push(currentRow)
    }
    return rows;
  }
}
