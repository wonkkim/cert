using OpenCvSharp;

namespace ConsoleApp
{
    class cv
    {
        public void Test()
        {
            Mat img = new Mat(200, 300, MatType.CV_8UC3);
            Cv2.Rectangle(img, new Rect(50, 50, 200, 100), new Scalar(0, 0, 255), -1);
            Cv2.ImShow("a", img);
            Cv2.WaitKey(0);
            Cv2.DestroyAllWindows();
        }
    }
}
