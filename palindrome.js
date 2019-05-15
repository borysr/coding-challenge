/**
 * Determine wither the submitted string is a palindrome.
 *
 * Examples:
 * racecar (pass)
 * mom (pass)
 * tacocat (pass)
 * fizzbuzz (fail)
 *
 * @param {String} value
 * @return {Boolean}
 */
var isPalindrome = function(value) {
    const len = value.length;
    const halfLen = Math.floor(len / 2);
    for (let i = 0; i < halfLen; i++) {
      if (value[i] != value[len - 1 - i]) {
        return false;
      }
    }
    return true;
};

// console.log(isPalindrome('racecar'));
// console.log(isPalindrome('fizzbuzz'));
// console.log(isPalindrome('12344321'));
