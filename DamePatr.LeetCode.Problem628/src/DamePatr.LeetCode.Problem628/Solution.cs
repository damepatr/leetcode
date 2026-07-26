namespace DamePatr.LeetCode.Problem628;

public class Solution {
    public virtual int MaximumProduct(ICollection<int> nums) {
	
		// Validate the constraint 3 <= nums.Count <= 10,000.
		// If this constraint isn't met, throw an ArgumentException.
		{
			const int MIN_COUNT = 3;
			const int MAX_COUNT = 10_000;
			int count = nums.Count;
			if (count < MIN_COUNT || count > MAX_COUNT)
			{
				string msg = $"{nameof(nums)}.{nameof(nums.Count)} is {count}. However, {nameof(nums)}.{nameof(nums.Count)} should satisfy the constraint {MIN_COUNT} <= {nameof(nums)}.{nameof(nums.Count)} <= {MAX_COUNT}.";
				throw new ArgumentException(msg, nameof(nums));
			}
		}

		// Validate the constraint -1,000 <= nums[i] <= 1,000.
		// If this constraint isn't met, throw an ArgumentOutOfRangeException.
		foreach (var num in nums)
		{
			const int MIN_VALUE = -1_000;
			const int MAX_VALUE = 1_000;
			if (num < MIN_VALUE || num > MAX_VALUE)
			{
				string msg = $"{nameof(nums)} contains {num}. However, each value in {nameof(nums)} should satisfy the constraint {MIN_VALUE} <= value <= {MAX_VALUE}.";
				throw new ArgumentOutOfRangeException(nameof(nums), msg);
			}
		}

        throw new NotImplementedException();
    }
}