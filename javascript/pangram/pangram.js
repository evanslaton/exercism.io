//
// This is only a SKELETON file for the 'Pangram' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export const isPangram = (text) => {
  const NUMBER_OF_LETTERS = 26;
  const letters = new Set();
  const regex = RegExp('[a-z]');
  for (let i = 0; i < text.length; i++) {
    if (regex.test(text[i].toLowerCase())) {
      letters.add(text[i].toLowerCase());
    }
  }
  return letters.size === NUMBER_OF_LETTERS ? true : false;
};
