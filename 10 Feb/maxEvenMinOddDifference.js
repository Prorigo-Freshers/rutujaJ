//Given an array of integers A of size N.
//Return the difference between the maximum among all even numbers of A and the minimum among all odd numbers in A.

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

const A2 = [5, 17, 100, 1];
console.log(maxEvenMinOddDifference(A2)); 
