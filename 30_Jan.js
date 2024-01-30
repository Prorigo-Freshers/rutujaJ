function twoSum(nums,target) {
for (let i = 0; i < nums.length; i++) {
    for (let j = i + 1; j < nums.length; j++) {
        if (nums[i]+nums[j] === target) {
                return [i,j];
            }
        }
    }
  return [];
}

const nums1 = [2,7,11,15];
const target1 = 9;
const result1 = twoSum(nums1,target1);
console.log(result1); 

const nums2 = [3,2,4];
const target2 = 6;
const result2 = twoSum(nums2,target2);
console.log(result2); 

const nums3 = [3,3];
const target3 = 6;
const result3 = twoSum(nums3,target3);
console.log(result3);  
