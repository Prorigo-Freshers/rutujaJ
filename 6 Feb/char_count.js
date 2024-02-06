function characterCount(str) {
    const count = {};
    for (let i = 0; i < str.length; i++) {
        const char = str[i];
        if (count[char]) {
          count[char]++;
        } else {
          count[char] = 1;
        }
    }    
    return count;
}
const input = "Rajababu";
const output = characterCount(input);
console.log("Output:",output);
