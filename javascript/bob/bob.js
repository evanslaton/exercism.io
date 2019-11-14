/* eslint-disable no-unused-vars */
//
// This is only a SKELETON file for the 'Bob' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

const hasLetters = (message) => /[a-zA-z]/.test(message);
const hasNumbers = (message) => /[0-9]/.test(message);
const isQuestion = (message) => message.trim().endsWith('?')
const isYelling = (message) => message === message.toUpperCase();

export const hey = (message) => {
  if (!hasLetters(message)) return isQuestion(message) ? 'Sure.' : hasNumbers(message) ? 'Whatever.' : 'Fine. Be that way!';
  if (isYelling(message)) return isQuestion(message) ? 'Calm down, I know what I\'m doing!' : 'Whoa, chill out!'; 
  if (isQuestion(message)) return 'Sure.';
  return 'Whatever.';
};