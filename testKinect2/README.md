# Afficher le flux vidéo #

La kinect dispose d'une caméra RGB dont allons maintenant récupérer et afficher l'image.

Plusieurs solutions sont possibles. En voici une décrite ici en français : [https://devonkinect.wordpress.com/2012/02/07/comment-afficher-la-video-de-kinect/](https://devonkinect.wordpress.com/2012/02/07/comment-afficher-la-video-de-kinect/)

En voici une autre dont le principe est de lire les données couleurs issues de la Kinect pour créer une image bitmap qui sera afficher dans un composant pictureBox.

- Ajouter un composant pictureBox sur le formulaire et le renommer pbKinectVideo
- Dans le code, ajouter les espaces de nom suivant :



    using System.Runtime.InteropServices;
    using System.Drawing.Imaging;

- Ajouter les attributs privés suivant à la classe du formulaire (normalement Form1) :

    private KinectSensor sensor;
    private byte[] colorData = null;
    private IntPtr colorPtr;
    private Bitmap kinectVideoBitmap = null;

- Dans le gestionnaire d'événement Form1_Load(), ajouter l'activation de la lecture du flux vidéo après l'activation de la détection des squelettes :

//enable color video stream
sensor.ColorStream.Enable(ColorImageFormat.RgbResolution640x480Fps30);
sensor.ColorFrameReady += SensorColorFrameReady;

Ecrire le gestionnaire d'événement de disponibilité d'une nouvelle image couleur disponible `SensorColorFrameReady()` :

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
    
          kinectVideoBitmap = new Bitmap(colorFrame.Width,
                                    colorFrame.Height,
                                    colorFrame.Width * colorFrame.BytesPerPixel,
                                    PixelFormat.Format32bppRgb,
                                    colorPtr);
    
          pbKinectVideo.Image = kinectVideoBitmap;
       }
    }

![Affichage du flux vidéo](http://silanus.fr/sin/wp-content/uploads/2017/02/videoKinect-768x367.png)