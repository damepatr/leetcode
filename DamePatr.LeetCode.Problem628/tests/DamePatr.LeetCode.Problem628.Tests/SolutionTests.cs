namespace DamePatr.LeetCode.Problem628.Tests;

public class SolutionTests
{
    private const int MAXIMUM_PRODUCT_MIN_COUNT = 3;
    private const int MAXIMUM_PRODUCT_MAX_COUNT = 10_000;
    private const int MAXIMUM_PRODUCT_MIN_VALUE = -1_000;
    private const int MAXIMUM_PRODUCT_MAX_VALUE = 1_000;

    [Theory]
    [InlineData(0)]
    [InlineData(MAXIMUM_PRODUCT_MIN_COUNT-1)]
    [InlineData(MAXIMUM_PRODUCT_MAX_COUNT+1)]
    public void MaximumProduct_NumsCountDoesNotMatchConstraints_ThrowsArgumentException(int count)
    {
        var nums = new int[count];
        var exception = Record.Exception(() => new Solution().MaximumProduct(nums));
        Assert.IsType<ArgumentException>(exception);
    }

    [Theory]
    [InlineData(MAXIMUM_PRODUCT_MIN_COUNT)]
    [InlineData(1_000)]
    [InlineData(MAXIMUM_PRODUCT_MAX_COUNT)]
    public void MaximumProduct_NumsCountDoesMatchConstraints_DoesNotThrowArgumentException(int count)
    {
        var nums = new int[count];
        new Solution().MaximumProduct(nums);
    }

    [Theory]
    [InlineData(MAXIMUM_PRODUCT_MIN_VALUE-1)]
    [InlineData(MAXIMUM_PRODUCT_MAX_VALUE+1)]
    public void MaximumProduct_NumValueDoesNotMatchConstraint_ThrowsArgumentOutOfRangeException(int num)
    {
        // Arrange
        var nums = new int[10];
        nums[5] = num;

        // Act
        var exception = Record.Exception(() => new Solution().MaximumProduct(nums));

        // Assert
        Assert.IsType<ArgumentOutOfRangeException>(exception);
    }

    [Theory]
    [InlineData(MAXIMUM_PRODUCT_MIN_VALUE)]
    [InlineData(0)]
    [InlineData(MAXIMUM_PRODUCT_MAX_VALUE)]
    public void MaximumProduct_NumValueDoesMatchConstraint_DoesNotThrowArgumentOutOfRangeException(int num)
    {
        // Arrange
        var nums = new int[10];
        nums[5] = num;

        // Act
        new Solution().MaximumProduct(nums);
    }
}
