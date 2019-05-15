/**
 * Return the indices of a given array where two numbers within
 * the array add up to a provided target. Assume each input has only
 * one solution and the same element of the array cannot be used more
 * than once.
 *
 * The length of numbers is n.
 *
 * Example:
 * numbers = [3, 9, 2, 11, 8, 23]
 * target =  17
 * Answer: [1, 4] Is the answer as 9 + 8 = target (17)
 *
 * @param {Array<Number>} numbers
 * @param {Number} target
 * @return {Array<Number}
 */
var twoSum = function(numbers, target) {
    for (let i = 0; i < numbers.length; i++) {
        let rem = target - numbers[i];
        for (let j = i; j < numbers.length; j++) {
          if (numbers[j] === rem) {
            return [i, j];
          }
        }
      }
      return [];
};

// twoSum([3, 9, 2, 11, 8, 23], 17);

