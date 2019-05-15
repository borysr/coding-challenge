/**
 * Write a function that returns the first <i>n</i> numbers of the fibonacci sequence.
 *
 * Example: Given that total = 10, return the first 10 numbers of the fibonacci sequence.
 *
 * @see https://en.wikipedia.org/wiki/Fibonacci_number
 * @param {Number} total
 * @return {Array<Number>}
 */
var fibonacciSequence = function(total) {
  if (total === undefined) return [];
  let seq = []; // depending on definition of Fibonacci from different
  // source may start with seq = '0'

  if (total >= 1) seq.push(1);
  if (total >= 2) seq.push(1);

  if (total > 2) {
    let n1 = 1;
    let n2 = 1;
    for (let i = 2; i < total; i++) {
      let n3 = n1 + n2;
      seq.push(n3);
      n1 = n2;
      n2 = n3;
    }
  }
  return seq;
};

// console.log(fibonacciSequence(12));
