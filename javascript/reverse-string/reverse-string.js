//
// This is only a SKELETON file for the 'Reverse String' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

const StringBuilder = require("string-builder");

export const reverseString = (string) => {
  let stringBuilder = new StringBuilder();
  for (let i = string.length - 1; i >= 0; i--) {
    stringBuilder.append(string[i]);
  }
  return stringBuilder.toString();
};
