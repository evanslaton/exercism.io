//
// This is only a SKELETON file for the 'Grade School' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export class GradeSchool {
  constructor() {
    this._roster = {};
  }

  roster() {
    return JSON.parse(JSON.stringify(this._roster));
  }

  add(studentName, gradeLevel) {
    if (this._roster.hasOwnProperty(gradeLevel)) {
      this._roster[gradeLevel].push(studentName);
      this._roster[gradeLevel].sort();
    } else {
      this._roster[gradeLevel] = [studentName];
    }
  }

  grade(gradeLevel) {
    return this._roster.hasOwnProperty(gradeLevel) ? [...this._roster[gradeLevel]] : [];
  }
}
