/**
 * Write a function that prints the numbers from 1 to 100.
 * For multiples of 3, print the word "fizz".
 * For multiples of 5, print the word "buzz".
 * For multiples of 15, print the word "fizbuzz"
 *
 * In the case of this being Javascript, console.log() is sufficient to print.
 *
 * @return {void}
 */
var fizzBuzz = function() {
    for (let i = 1; i <= 100; i++) {
        let s = '';
    
        if (i % 3 == 0) s += 'fizz';
        if (i % 5 == 0) s += 'buzz';
    
        if (s !== '') console.log(s);
    }
};
// fizzBuzz();

var fizzBuzzWithNumbers = function() {
    for (let i = 1; i <= 100; i++) {
        let s = '';
    
        if (i % 3 == 0) s += 'fizz';
        if (i % 5 == 0) s += 'buzz';
    
        if (s !== '') console.log(i, ' - ', s);
    }
};
// fizzBuzzWithNumbers();