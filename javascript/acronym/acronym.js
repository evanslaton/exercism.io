//
// This is only a SKELETON file for the 'Acronym' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export const parse = (str) => {
  let words = str.replace(/'/g, '').replace(/[_\W]/g, ' ').split(' ');
  let acronym = '';
  words.forEach(word => {
    if (word !== '') acronym += word[0].toUpperCase();
  });
  return acronym;
};
