using Xunit;
using System.Numerics;
using FftConsoleApp;

namespace FftConsoleApp.Tests;

public class FFTTests
{
    [Fact]
    public void ComputeFFT_ShouldReturnCorrectLength()
    {
        // Arrange
        double[] signal = { 1, 0, 1, 0 };

        // Act
        Complex[] result = FFT.ComputeFFT(signal);

        // Assert
        Assert.Equal(signal.Length, result.Length);
    }

    [Fact]
    public void ComputeFFT_ShouldNotReturnNull()
    {
        // Arrange
        double[] signal = { 1, 0, 1, 0 };

        // Act
        Complex[] result = FFT.ComputeFFT(signal);

        // Assert
        Assert.NotNull(result);
    }
}