//
// This is only a SKELETON file for the 'Space Age' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

const DECIMAL_PLACES = 2;

const YEARS = new Map();
  YEARS.set('earth', 31557600);
  YEARS.set('mercury', YEARS.get('earth') * .2408467);
  YEARS.set('venus', YEARS.get('earth') * .61519726);
  YEARS.set('mars', YEARS.get('earth') * 1.8808158);
  YEARS.set('jupiter', YEARS.get('earth') * 11.862615);
  YEARS.set('saturn', YEARS.get('earth') * 29.447498);
  YEARS.set('uranus', YEARS.get('earth') * 84.016846);
  YEARS.set('neptune', YEARS.get('earth') * 164.79132);

export const age = (planet, age) => Number(Math.round((age / YEARS.get(planet)) + 'e' + DECIMAL_PLACES) + 'e-' + DECIMAL_PLACES);


