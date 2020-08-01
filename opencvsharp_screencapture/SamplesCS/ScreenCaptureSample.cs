namespace SamplesCS
{
    using System;
    using System.Drawing;

    using OpenCvSharp;
    using OpenCvSharp.Extensions;

    using ScreenCapture;

    /// <summary>
    /// Screen Capture sample to process PC screen
    /// </summary>
    class ScreenCaptureSample : ISample
    {
        const float framesPerSecond = 60.0f;

        public void Run()
        {
            int sleepTime = (int)Math.Round(1000 / framesPerSecond);

            using (var window = new Window("capture"))
            {
                PrintScreen ps = new PrintScreen();
                // Frame image buffer
                Mat image = new Mat();

                while (true)
                {
                    Image img = ps.CaptureScreen();
                    Bitmap bmpScreenshot = new Bitmap(img);
                    image = BitmapConverter.ToMat(bmpScreenshot);

                    if (!image.Empty())
                    {
                        window.ShowImage(image);
                    }

                    Cv2.WaitKey(sleepTime);
                } 
            }
        }

    }
}