using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace ACO_Maze_Solver{
    class ImageProcessor{

        public Bitmap resizeBitmap(Bitmap bmp, Size size) {
            Bitmap newBitMap = new Bitmap(size.Width, size.Height);
            using (Graphics g = Graphics.FromImage((Image)newBitMap)) {
                g.InterpolationMode = InterpolationMode.High;
                g.CompositingQuality = CompositingQuality.HighQuality;
                g.DrawImage(bmp, 0, 0, size.Width, size.Height);
            }
            return newBitMap;
        }

        public Bitmap image2BW(Bitmap image, double thresholdValue){
            Bitmap bmp = (Bitmap)image.Clone();
            for (int y = 0; y < bmp.Height; y++){
                for (int x = 0; x < bmp.Width; x++){
                    Color pixel = bmp.GetPixel(x,y);
                    double bw = (pixel.R * .30 + pixel.G * .59 + pixel.B * .11) / 255;
                    if (bw >= thresholdValue)
                        bmp.SetPixel(x, y, Color.White);
                    else
                        bmp.SetPixel(x, y, Color.Black);
                    if (pixel.G > 100 && pixel.R < 70 && pixel.B < 70)
                        bmp.SetPixel(x, y, Color.FromArgb(0,255,0));
                    if (pixel.R > 100 && pixel.G<=60 && pixel.B<=60)
                        bmp.SetPixel(x, y, Color.FromArgb(255,0,0));
                }
            
            }
            return bmp;
        }

        public int[,] getImageMatrix(Bitmap bmp) {
            int[,] imageMatrix = new int[bmp.Height, bmp.Width];
            for (int y = 0; y < bmp.Height; y++) {
                for (int x = 0; x < bmp.Width; x++) {
                    if (bmp.GetPixel(x, y) == Color.FromArgb(0,0,0))
                        imageMatrix[y, x] = 0;
                    else if (bmp.GetPixel(x, y) == Color.FromArgb(255,255,255))
                        imageMatrix[y, x] = 1;
                    if (bmp.GetPixel(x, y) == Color.FromArgb(255,0,0))
                        imageMatrix[y, x] = 4;
                    if (bmp.GetPixel(x, y) == Color.FromArgb(0,255,0))
                        imageMatrix[y, x] = 5;

                }
            }
            return imageMatrix;
        }

        public Image matrix2Image(double[,] mazeMatrix) {
            Stream imageStream = new MemoryStream();
            Bitmap bmp = new Bitmap(mazeMatrix.GetLength(1), mazeMatrix.GetLength(0));
            for (int y = 0; y < mazeMatrix.GetLength(0); y++) {
                for (int x = 0; x < mazeMatrix.GetLength(1); x++) {
                    if (mazeMatrix[y, x] == 1)
                        bmp.SetPixel(x, y, Color.White);
                    else if (mazeMatrix[y, x] == 0)
                        bmp.SetPixel(x, y, Color.Black);
                    else if (mazeMatrix[y, x] == -4)
                        bmp.SetPixel(x, y, Color.Red);
                    else if (mazeMatrix[y, x] == -5)
                        bmp.SetPixel(x, y, Color.Green);
                    else {
                        double pheromone = mazeMatrix[y, x] > 255 ? 255 : mazeMatrix[y, x];
                        double t = Math.Abs(1 / mazeMatrix[y, x]);
                        bmp.SetPixel(x, y, Color.FromArgb(Math.Abs((int)Math.Floor(255 * (1-t))), Math.Abs((int)Math.Floor(255 * t)), 0));
                    }
                }
            }
            bmp.Save(imageStream, ImageFormat.Jpeg);
            return Image.FromStream(imageStream);
        }

        public Image matrix2Image(int[,] mazeMatrix) {
            Stream imageStream = new MemoryStream();
            Bitmap bmp = new Bitmap(mazeMatrix.GetLength(1), mazeMatrix.GetLength(0));
            for (int y = 0; y < mazeMatrix.GetLength(0); y++) {
                for (int x = 0; x < mazeMatrix.GetLength(1); x++) {
                    if (mazeMatrix[y, x] == 1)
                        bmp.SetPixel(x, y, Color.White);
                    else if (mazeMatrix[y, x] == 0)
                        bmp.SetPixel(x, y, Color.Black);
                    else if (mazeMatrix[y, x] == 2)
                        bmp.SetPixel(x, y, Color.Blue);
                    else if (mazeMatrix[y, x] == 3)
                        bmp.SetPixel(x, y, Color.Magenta);
                    else if (mazeMatrix[y, x] == 4)
                        bmp.SetPixel(x, y, Color.Red);
                    else if (mazeMatrix[y,x] == 5)
                        bmp.SetPixel(x, y, Color.Green);
                }
            }
            bmp.Save(imageStream, ImageFormat.Jpeg);
            return Image.FromStream(imageStream);
        }
    }
}
