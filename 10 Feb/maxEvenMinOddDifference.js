function maxEvenMinOddDifference(A) {
    let maxEven = -Infinity;
    let minOdd = Infinity;
    
    for (let i = 0; i < A.length; i++) {
        const num = A[i];
        if (num % 2 === 0 && num > maxEven) {
            maxEven = num;
        } else if (num % 2 !== 0 && num < minOdd) {
            minOdd = num;
        }
    }
    
    return maxEven - minOdd;
}

// Example usage:
const A1 = [0, 2, 9];
const A2 = [5, 17, 100, 1];

console.log(maxEvenMinOddDifference(A1)); // Output: -7
console.log(maxEvenMinOddDifference(A2)); // Output: 99
