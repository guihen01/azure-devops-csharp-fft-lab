using System.Numerics;
using MathNet.Numerics.IntegralTransforms;

namespace FftConsoleApp;

public class FFT
{
    public static Complex[] ComputeFFT(double[] signal)
    {
        Complex[] samples = signal
            .Select(x => new Complex(x, 0))
            .ToArray();

        Fourier.Forward(samples, FourierOptions.Matlab);

        return samples;
    }
}