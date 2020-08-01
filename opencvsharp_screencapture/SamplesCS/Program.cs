namespace SamplesCS
{
    using System;

    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            ScreenCaptureSample sample = new ScreenCaptureSample();
            sample.Run();
        }
    }
}
