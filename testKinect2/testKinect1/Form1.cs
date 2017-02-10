using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Drawing.Imaging;
using System.Runtime.InteropServices;

using Microsoft.Kinect;


namespace testKinect1
{
    public partial class Form1 : Form
    {
        private KinectSensor sensor;
        private byte[] colorData = null;
        private IntPtr colorPtr;
        private Bitmap kinectVideoBitmap = null;
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                sensor = KinectSensor.KinectSensors[0];  //Une seule Kinect connectée
                sensor.Start();
                MessageBox.Show("Kinect Démarrée !");

                // enable skeleton stream
                sensor.SkeletonStream.Enable();
                // enable depth stream
                sensor.DepthStream.Enable(DepthImageFormat.Resolution640x480Fps30);

                // enable color video stream
                sensor.ColorStream.Enable(ColorImageFormat.RgbResolution640x480Fps30);

                sensor.SkeletonFrameReady += SensorSkeletonFrameReady;
                sensor.ColorFrameReady += SensorColorFrameReady;
            }
            catch
            {
                MessageBox.Show("Pas de kinect Détectée !");
                Application.Exit();
            }

        }

       
        private void SensorSkeletonFrameReady(object sender, SkeletonFrameReadyEventArgs e)
        {
            Skeleton[] skeletons = new Skeleton[0];

            using (SkeletonFrame skeletonFrame = e.OpenSkeletonFrame())
            {
                if (skeletonFrame != null)
                {
                    skeletons = new Skeleton[skeletonFrame.SkeletonArrayLength];
                    skeletonFrame.CopySkeletonDataTo(skeletons);
                }

                foreach (Skeleton skeleton in skeletons)
                {
                    if (skeleton.TrackingState == SkeletonTrackingState.Tracked)
                    {
                        Joint rightHand = skeleton.Joints[JointType.HandRight];
                        float rightX = rightHand.Position.X;
                        float rightY = rightHand.Position.Y;
                        float rightZ = rightHand.Position.Z;

                        lblX.Text = "X=" + rightX.ToString();
                        lblY.Text = "Y=" + rightY.ToString();
                        lblZ.Text = "Z=" + rightZ.ToString();
                    }
                }
            }
        }

        private void SensorColorFrameReady(object sender, ColorImageFrameReadyEventArgs e)
        {

            using (ColorImageFrame colorFrame = e.OpenColorImageFrame())
            {
                if (colorFrame == null) return;
                if (colorData == null) colorData = new byte[colorFrame.PixelDataLength];

                colorFrame.CopyPixelDataTo(colorData);

                Marshal.FreeHGlobal(colorPtr);
                colorPtr = Marshal.AllocHGlobal(colorData.Length);
                Marshal.Copy(colorData, 0, colorPtr, colorData.Length);

                kinectVideoBitmap = new  Bitmap(colorFrame.Width, 
                                                colorFrame.Height,
                                                colorFrame.Width*colorFrame.BytesPerPixel, 
                                                PixelFormat.Format32bppRgb,
                                                colorPtr);

                pbKinectVideo.Image = kinectVideoBitmap;
            }
        }

    }
}
