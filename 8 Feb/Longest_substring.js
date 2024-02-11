const s = "abcabcbb";
let maxLength = 0;
let start = 0;
const charIndexMap = {};

for (let end = 0; end < s.length; end++) {
    const char = s[end];
    if (char in charIndexMap && charIndexMap[char] >= start) {
        start = charIndexMap[char] + 1;
    }
    charIndexMap[char] = end;
    maxLength = Math.max(maxLength, end - start + 1);
}
console.log(maxLength);
