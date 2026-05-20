using FftConsoleApp;
using System.Numerics;

double[] signal = { 1, 0, 1, 0 };

Complex[] result = FFT.ComputeFFT(signal);

Console.WriteLine("FFT Result:");

foreach (var value in result)
{
    Console.WriteLine(value);
}