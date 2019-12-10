//
// This is only a SKELETON file for the 'Isogram' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export const isIsogram = (str) => {
  str = str.replace(/[-\s]/g, '').toLowerCase();
  const characters = new Set();
  for (let i = 0; i < str.length; i++) {
    if (characters.has(str[i])) {
      return false;
    } else {
      characters.add(str[i]);
    }
  }
  return true;
};
