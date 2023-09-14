class ArrayWrapper {
    constructor(nums) {
      this.nums = nums;
    }
  
    valueOf() {
      return this.nums.reduce((acc, curr) => acc + curr, 0);
    }
  
    toString() {
      return JSON.stringify(this.nums);
    }
  }
  