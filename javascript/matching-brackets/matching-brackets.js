//
// This is only a SKELETON file for the 'Matching Brackets' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export const matchingBrackets = (str) => {
  const brackets = new Map();
  brackets.set('}', '{');
  brackets.set(']', '[');
  brackets.set(')', '(');
  const stack = [];
  for (let i = 0; i < str.length; i++) {
    if (str[i] === '{' || str[i] === '[' || str[i] === '(') {
      stack.push(str[i]);
    } else if (str[i] === '}' || str[i] === ']' || str[i] === ')') {
      if (stack.pop() !== brackets.get(str[i])) return false;
    }
  }
  return stack.length === 0 ? true : false;
};
