using Lab1;

namespace Lab1Test;

public class ProgramTests
{
    [Test]
    public void FindMinAbsValue_ShouldReturnMinAbsValue()
    {
        int[] array = { 2, -5, 3, 1, -4, 0, 7, -2, 9, 8 };
        int minAbsValue = Program.CalculateMinAbsValue(array);
        
        Assert.That(minAbsValue, Is.EqualTo(0));
    }

    [Test]
    public void SumAfterZero_ShouldReturnSumAfterFirstZero()
    {
        int[] array = { 2, -5, 3, 1, -4, 0, 7, -2, 9, 8 };
        int sumAfterZero = Program.CalculateSumAfterZero(array);
        
        Assert.That(sumAfterZero, Is.EqualTo(26));
    }

    [Test]
    public void TransformArray_ShouldReturnTransformedArray()
    {
        int[] array = { 2, -5, 3, 1, -4, 0, 7, -2, 9, 8 };
        int[] transformedArray = Program.TransformArray(array);

        int[] expectedTransformedArray = { 2, 3, -4, 7, 9, -5, 1, 0, -2, 8 };
        
        Assert.That(transformedArray, Is.EqualTo(expectedTransformedArray));
    }

    [Test]
    public void CalculateLocalMinCount_ShouldReturnCountOfLocalMin()
    {
        int[,] matrix = {
            { 3, 3, 3, 1, 2, 3, 4, 5, 6, 7 },
            { 3, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
            { 3, 3, 3, 5, 6, 7, 8, 9, 10, 11 },
            { 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 },
            { 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 },
            { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 },
            { 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 },
            { 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 },
            { 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 },
            { 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 }
        };

        int localMinCount = Program.CalculateLocalMinCount(matrix);
        Assert.That(localMinCount, Is.EqualTo(1));
    }

    [Test]
    public void SumAboveDiagonal_ShouldReturnSumAboveDiagonal()
    {
        int[,] matrix = {
            { 3, 2, 1, 1, 2, 3, 4, 5, 6, 7 },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
            { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 },
            { 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 },
            { 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 },
            { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 },
            { 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 },
            { 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 },
            { 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 },
            { 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 }
        };

        int sumAboveDiagonal = Program.CalculateSumAboveDiagonal(matrix);
        Assert.That(sumAboveDiagonal, Is.EqualTo(391));
    }
}
