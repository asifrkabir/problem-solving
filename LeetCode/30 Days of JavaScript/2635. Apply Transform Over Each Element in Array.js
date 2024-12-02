/**
 * @param {number[]} arr
 * @param {Function} fn
 * @return {number[]}
 */
var map = function (arr, fn) {
  const returnedArray = [];

  for (let i = 0; i < arr.length; i++) {
    const val = fn(arr[i], i);
    returnedArray.push(val);
  }

  return returnedArray;
};
