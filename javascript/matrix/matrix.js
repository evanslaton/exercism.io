//
// This is only a SKELETON file for the 'Matrix' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export class Matrix {
  constructor(matrix) {
    this._rows = getRows();
    this._columns = 0; 
  }

  createRows(matrix) {
    return matrix.split('\n').map(row => row.split(' ').map(number => parseInt(number)));
  }

  get rows() {
    return this.matrix.split('\n').map(row => row.split(' ').map(number => parseInt(number)));
  }

  get columns() {
    const rows = this.rows;
    const columns = rows[0].map(() => []);
    rows.forEach(row => row.forEach((number, i) => columns[i].push(number)));
    return columns;
  }
}
