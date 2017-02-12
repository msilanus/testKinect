# Matérialiser la jointure traquée #

Le but ici est de matérialiser la jointure traquée (la main droite) à l'aide d'un cercle bleu. Il faut pour cela ajouter un élément de graphique à l'image affichée. l'idée consiste donc à créer un graphique contenant l'image issue de la Kinect et le dessin d'une ellipse contenue dans un rectangle centré sur la main droite de la personne dont le squelette est traqué.

Dans le code, déclarer un nouvel attribut privé à la classe du formulaire pour créer un objet de la classe Graphics.


    private Graphics g;

En utilisant g dans le pictureBox pbKinectVideo, on essaye de faire :
Dessiner l'image dans le `Graphics g`
Si la checkBox cbTracking est cochée, dessiner une ellipse contenue dans un carré de 20x20 pixels et centrée sur les coordonnées X et Y de la main droite traquée :

    //pbKinectVideo.Image = kinectVideoBitmap;
     
    try
    {
       using (g = pbKinectVideo.CreateGraphics())
       {
         g.DrawEllipse(p, 320*(1+rightX)-5, 240*(1-rightY)-5, 20, 20);
         if(cbTracking.Checked)
         {
           Pen p = new Pen(Color.Blue, 10.0f);
           g.DrawEllipse(p, rightX - 5, rightY - 5, 20, 20);
         }
       }
    }
    catch { }

Ajouter les attributs privés rightX et rightY :

    private float rightX;
    private float rightY;

Lecture de rightX et rightY dans le gestionnaire dévénement `SensorSkeletonFrameReady()`  :

    rightX = rightHand.Position.X; //Supprimer le type float
    rightY = rightHand.Position.Y; //Supprimer le type float

Tester le programme. Visiblement, le cercle bleu n'est pas vraiment centré sur la main droite ! Il y a de toute évidence un problème de coordonnées rightX et rightY. En effet, les données brutes ne sont pas exploitable directement. Il faut tenir compte des dimensions de l'image (640x480) et de la profondeur. Dans le calcul suivant :

        320*(1+rightX)-5
        240*(1-rightY)-5

On tient compte du fait qu'au centre de l'image, on a rightX=0 et rightY=0 et que l'image fait 640 pixel en largeur et 480 pixel en hauteur. Mais on ne tiens pas compte de la profondeur. on peut aisément le remarquer en avançant ou reculant devant la Kinect. Les effets sont encore plus flagrants sur les bords de l'images.

![Joiture sans correction](http://silanus.fr/sin/wp-content/uploads/2017/02/badTracking.png)

# Détection de la profondeur et correction du tracking #

La Kinect se compose d'un émetteur laser infrarouge, d’une caméra infrarouge et d’une caméra RGB. La mesure de la profondeur se fait par un processus de triangulation. Pour en savoir plus sur son fonctionnement, [lire le rapport de projet bibliographique de Bertrand PECUCHET](http://iut-gmp.univ-lille1.fr/fichiers/LPVI/RapportFinalkinect.pdf).

Chaque trame du flux de données du capteur de profondeur est composée de pixels qui contiennent la distance (en millimètres) du plan de caméra à l'objet le plus proche. Pour commencer il faut activer le flux de données du capteur de profondeur, puis obtenir les coordonnées X et Y corrigées de la jointure souhaitée.

**Activer le flux de données du capteur de profondeur :**

    // enable depth stream
    sensor.DepthStream.Enable(DepthImageFormat.Resolution640x480Fps30);

Pour afficher les coordonnées brutes et corrigées, ajouter les attributs privés qui recueilleront les coordonnées brutes :

    private float JointRightX;
    private float JointRightY;
    private float JointRightZ;

Pour obtenir un point (X,Y) des coordonnées corrigées de la main droite. A jouter dans le gestionnaire d'événement de tracking des squelettes :

    DepthImagePoint depthPoint;
    depthPoint = sensor.CoordinateMapper.MapSkeletonPointToDepthPoint(rightHand.Position, DepthImageFormat.Resolution640x480Fps30);

Obtenir et afficher les coordonnées brutes et corrigées de la main droite.

![Composition du Formulaire](http://silanus.fr/sin/wp-content/uploads/2017/02/formTrackingRightHand-768x420.png)

    JointRightX = rightHand.Position.X;
    JointRightY = rightHand.Position.Y;
    JointRightZ = rightHand.Position.Z;

    rightX = depthPoint.X;
    rightY = depthPoint.Y;
                      
    lblX.Text = "X=" + JointRightX.ToString();
    lblY.Text = "Y=" + JointRightY.ToString();
    lblZ.Text = "Z=" + rightZ.ToString();
    
    lblXcorr.Text = "X=" + rightX.ToString();
    lblYcorr.Text = "Y=" + rightY.ToString();

Corriger la position du cercle qui matérialise le tracking :

    g.DrawEllipse(p, rightX - 5, rightY - 5, 20, 20);

Détecter la sortie de la main du champs de vision de la caméra revient à s'assurer que ses coordonnées X et Y sont positives et comprises dans le format de l'image (680x480) :

    if (rightX < 0 || rightX > 640 
     || rightY < 0 || rightY > 480) 
       lblHorsChamps.Visible = true;
    else lblHorsChamps.Visible = false;

![Tracking corrigé](http://silanus.fr/sin/wp-content/uploads/2017/02/trackingRightHand.png)