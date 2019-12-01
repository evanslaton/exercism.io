//
// This is only a SKELETON file for the 'Word Count' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export class Words {
  count(inputString) {
    const words = inputString.trim().toLowerCase().split(/\s/);
    const output = {};
    words.forEach(word => {
      if (word !== '') {
        if (output.hasOwnProperty(word)) {
          output[word] = output[word] + 1;
        } else {
          output[word] = 1;
        }
      }
    });
    return output;
  }
}
