//Given an integer N you need to print all the Armstrong Numbers between 1 to N. (N inclusive).
//If sum of cubes of each digit of the number is equal to the number itself, then the number is called an Armstrong number.

function armstrongNumbers(N) {
    for (let i = 1; i <= N; i++) {
        let num = i;
        let sumOfCubes = 0;
        while (num > 0) {
            const digit = num % 10;
            sumOfCubes += digit ** 3;
            num = Math.floor(num / 10);
        }
        if (sumOfCubes === i) {
            console.log(i);
        }
    }
}

const N = parseInt(prompt("Enter a number:"));
armstrongNumbers(N);
