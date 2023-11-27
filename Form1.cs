using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ImageProcessingActivity
{
    public partial class Form1 : Form
    {
        Bitmap loadedImage, secondImage, resultImage, originalImage;
        OpenFileDialog openFileDialog = new OpenFileDialog();
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        Device webcamDevice;
        DeviceManager manager;
        public Form1()
        {
            InitializeComponent();
            manager = new DeviceManager();
            webcamDevice = new Device();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                InitializeWebcam();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error starting webcam: {ex.Message}");
            }
        }

        private void InitializeWebcam()
        {
            Device[] devices = DeviceManager.GetAllDevices();

            if (devices.Length > 0)
            {
                webcamDevice = devices[0];
                try
                {
                    webcamDevice.ShowWindow(pictureBoxWebcam);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error initializing webcam: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("No webcam devices found.");
            }
        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (resultImage != null)
            {
                saveFileDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg;*.jpeg|GIF Image|*.gif|BMP Image|*.bmp|All Files|*.*";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string savePath = saveFileDialog.FileName;

                    // Determine the file format based on the selected filter
                    ImageFormat format;
                    switch (saveFileDialog.FilterIndex)
                    {
                        case 1:
                            format = ImageFormat.Png;
                            break;
                        case 2:
                            format = ImageFormat.Jpeg;
                            break;
                        case 3:
                            format = ImageFormat.Gif;
                            break;
                        case 4:
                            format = ImageFormat.Bmp;
                            break;
                        default:
                            format = ImageFormat.Png; // Default to PNG
                            break;
                    }

                    // Save the result image to the specified path and format
                    resultImage.Save(savePath, format);
                }
            }
        }

        private void btnGreyscale_Click(object sender, EventArgs e)
        {
            if (loadedImage != null)
            {
                resultImage = new Bitmap(loadedImage.Width, loadedImage.Height);
                for (int x = 0; x < loadedImage.Width; x++)
                {
                    for (int y = 0; y < loadedImage.Height; y++)
                    {
                        Color pixel = loadedImage.GetPixel(x, y);
                        int grey = (pixel.R + pixel.G + pixel.B) / 3;
                        Color newPixel = Color.FromArgb(grey, grey, grey);
                        resultImage.SetPixel(x, y, newPixel);
                    }
                }
                pictureBox2.Image = resultImage;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnColorInversion_Click(object sender, EventArgs e)
        {
            if (loadedImage != null)
            {
                resultImage = new Bitmap(loadedImage.Width, loadedImage.Height);
                for (int x = 0; x < loadedImage.Width; x++)
                {
                    for (int y = 0; y < loadedImage.Height; y++)
                    {
                        Color pixel = loadedImage.GetPixel(x, y);
                        Color newPixel = Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B);
                        resultImage.SetPixel(x, y, newPixel);
                    }
                }
                pictureBox2.Image = resultImage;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnHistogram_Click(object sender, EventArgs e)
        {
            if (loadedImage != null)
            {
                resultImage = new Bitmap(loadedImage.Width, loadedImage.Height);

                for (int x = 0; x < loadedImage.Width; x++)
                {
                    for (int y = 0; y < loadedImage.Height; y++)
                    {
                        Color pixel = loadedImage.GetPixel(x, y);
                        int grey = (pixel.R + pixel.G + pixel.B) / 3;
                        Color newPixel = Color.FromArgb(grey, grey, grey);
                        resultImage.SetPixel(x, y, newPixel);
                    }
                }

                int[] histdata = new int[256];
                for (int x = 0; x < resultImage.Width; x++)
                {
                    for (int y = 0; y < resultImage.Height; y++)
                    {
                        Color sample = resultImage.GetPixel(x, y);
                        histdata[sample.R]++;
                    }
                }

                int maxFrequency = histdata.Max();
                double scaleFactor = 800.0 / maxFrequency;

                Bitmap histogramImage = new Bitmap(256, 800);
                for (int x = 0; x < 256; x++)
                {
                    int barHeight = (int)(histdata[x] * scaleFactor);

                    for (int y = 0; y < barHeight; y++)
                    {
                        histogramImage.SetPixel(x, 799 - y, Color.Black);
                    }
                }

                pictureBox2.Image = histogramImage;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnSepia_Click(object sender, EventArgs e)
        {
            if (loadedImage != null)
            {
                resultImage = new Bitmap(loadedImage.Width, loadedImage.Height);
                for (int x = 0; x < loadedImage.Width; x++)
                {
                    for (int y = 0; y < loadedImage.Height; y++)
                    {
                        Color pixel = loadedImage.GetPixel(x, y);

                        int tr = (int)(0.393 * pixel.R + 0.769 * pixel.G + 0.189 * pixel.B);
                        int tg = (int)(0.349 * pixel.R + 0.686 * pixel.G + 0.168 * pixel.B);
                        int tb = (int)(0.272 * pixel.R + 0.534 * pixel.G + 0.131 * pixel.B);

                        tr = Math.Max(0, Math.Min(tr, 255));
                        tg = Math.Max(0, Math.Min(tg, 255));
                        tb = Math.Max(0, Math.Min(tb, 255));

                        Color newPixel = Color.FromArgb(tr, tg, tb);
                        resultImage.SetPixel(x, y, newPixel);
                    }
                }
                pictureBox2.Image = resultImage;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                pictureBox1.Image = originalImage;
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void forFirstImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                loadedImage = new Bitmap(openFileDialog.FileName);
                originalImage = loadedImage;
                pictureBox1.Image = loadedImage;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            Color mygreen = Color.FromArgb(0, 0, 255);
            int greygreen = (mygreen.R + mygreen.G + mygreen.B) / 3;
            int threshold = 5;

            if (loadedImage != null && secondImage != null)
            {
                if (loadedImage.Width != secondImage.Width || loadedImage.Height != secondImage.Height)
                {
                    secondImage = new Bitmap(secondImage, new Size(loadedImage.Width, loadedImage.Height));
                }

                resultImage = new Bitmap(loadedImage.Width, loadedImage.Height);
                for (int x = 0; x < loadedImage.Width; x++)
                {
                    for (int y = 0; y < loadedImage.Height; y++)
                    {
                        Color pixel = loadedImage.GetPixel(x, y);
                        Color backpixel = secondImage.GetPixel(x, y);
                        int grey = (pixel.R + pixel.G + pixel.B) / 3;
                        int subtractvalue = Math.Abs(grey - greygreen);

                        if (subtractvalue > threshold)
                            resultImage.SetPixel(x, y, pixel);
                        else
                            resultImage.SetPixel(x, y, backpixel);
                    }
                }
                pictureBox2.Image = resultImage;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            InitializeWebcam();
        }

        private void forSecondImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                secondImage = new Bitmap(openFileDialog.FileName);
                pictureBox3.Image = secondImage;
                pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            webcamDevice.Stop();
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            if (loadedImage != null)
            {
                pictureBox1.Image = resultImage;
                loadedImage = resultImage;
            }
        }

        private void btnBasicCopy_Click(object sender, EventArgs e)
        {
            if (loadedImage != null)
            {
                resultImage = new Bitmap(loadedImage.Width, loadedImage.Height);
                for (int x = 0; x < loadedImage.Width; x++)
                {
                    for (int y = 0; y < loadedImage.Height; y++)
                    {
                        Color pixel = loadedImage.GetPixel(x, y);
                        resultImage.SetPixel(x, y, pixel);
                    }
                }
                pictureBox2.Image = resultImage;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            webcamDevice?.Stop();
        }
    }
}
