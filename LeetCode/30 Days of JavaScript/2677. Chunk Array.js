/**
 * @param {Array} arr
 * @param {number} size
 * @return {Array}
 */
var chunk = function (arr, size) {
  const outputArr = [];

  for (let i = 0; i < arr.length; i += size) {
    outputArr.push(arr.slice(i, i + size));
  }

  return outputArr;
};
