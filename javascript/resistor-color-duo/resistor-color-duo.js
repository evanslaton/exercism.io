//
// This is only a SKELETON file for the 'Resistor Color Duo' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

const COLOR_MAP = new Map();
  COLOR_MAP.set('black', '0');
  COLOR_MAP.set('brown', '1');
  COLOR_MAP.set('red', '2');
  COLOR_MAP.set('orange', '3');
  COLOR_MAP.set('yellow', '4');
  COLOR_MAP.set('green', '5');
  COLOR_MAP.set('blue', '6');
  COLOR_MAP.set('violet', '7');
  COLOR_MAP.set('grey', '8');
  COLOR_MAP.set('white', '9');

export const value = (colors) => parseInt(COLOR_MAP.get(colors[0]) + COLOR_MAP.get(colors[1]));
