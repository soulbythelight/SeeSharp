/*=================================================
 * This code is brought to you by Mahvish
 * visit http://fewtutorials.bravesites.com/ for more
 * tutorials on EmguCV and C#
 * **************************************************
 *        PLEASE DO NOT REMOVE THIS NOTE!
 * **************************************************
 * ==================================================
 * Modified by awesomepol September 5 2015 
 * (Labored on making it KINDA work for 2 days so technically
 * september 3)
 * 
 * Project was written to use EMgucv 2.something, modified this 
 * to emgucv 3.0
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;
using Emgu.CV.CvEnum;
using Emgu.CV.Util;


namespace LiveFaceDetection
{
    public partial class TrainingSetEditor : Form
    {
        //declaring global variables

        //.............FOR LIVE CAMERA CAPTURE.............
        //-----------------------------------------------------------------------------------
        private Capture capture;        //takes images from camera as image frames
        Image<Bgr, Byte> TestImage;    //EmguCV type color image

        //.............FOR FACE DETECTION.............
        //-----------------------------------------------------------------------------------
        private CascadeClassifier haar;            //the viola-jones classifier (detector)       
        //Lets set the Default values of the parameters, to be used as a variable in call to DetectHaarCascase()
        private int WindowsSize = 25;
        private Double ScaleIncreaseRate = 1.1;
        private int MinNeighbors = 3;

        //.............For Face "EXTRACTION".............
        //-----------------------------------------------------------------------------------
        //string[] FaceCollection = Directory.GetFiles(@"Face Collection\", "*.bmp");  // the folder where we want to save extracted faces
        int faceNo = 0;             //Total no. of faces detected in an image
        Bitmap[] EXfaces;           //an array to hold the extracted faces


        public TrainingSetEditor()
        {
            InitializeComponent();
        }

        private void TrainingSetEditor_Load(object sender, EventArgs e)
        {
            // adjust path to find your xml at loading
            haar = new CascadeClassifier("haarcascade_frontalface_alt_tree.xml");
        }

        //----------------------------------------------------------------------------//
        //<<<<<<<<------FUNCTIONS USED TO GET INPUT IMAGE----------------------->>>>>>>>
        //----------------------------------------------------------------------------//
        /// <summary>
        /// Loads an image from Hard disk and detects faces from it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBrowse_Click(object sender, EventArgs e)
        {           
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Image InputImg = Image.FromFile(openFileDialog.FileName);
                TestImage = new Image<Bgr, byte>(new Bitmap(InputImg));
                CamImageBox.Image = TestImage;
                
                DetectFaces();
            }
        }     
        
        /// <summary>
        /// Starts live video streaming, Pauses it to detect faces, Resumes it 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {         

            if (capture != null)
            {
                if (btnStart.Text == "Extract Face")
                {  //if camera is getting frames then pause the capture and set button Text to
                    // "Resume" for resuming capture
                    btnStart.Text = "Resume Live Video"; //

                    //Pause the live streaming video
                    Application.Idle -= ProcessFrame;

                    //Call face detection 
                    DetectFaces(); 
                }
                else
                {
                    //if camera is NOT getting frames then start the capture and set button
                    // Text to "Pause" for pausing capture
                    btnStart.Text = "Extract Face";
                    Application.Idle += ProcessFrame;
                }
            }
        }
      
        /// <summary>
        /// Captures a picture from the connected camera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="arg"></param>
        private void ProcessFrame(object sender, EventArgs arg)
        {
            //------------------------------------------------------------------------------//
            //Process Frame() below is our user defined function in which we will create an EmguCv 
            //type image called TestImage. capture a frame from camera and allocate it to our 
            //TestImage. then show this image in ourEmguCV imageBox
            //------------------------------------------------------------------------------//
            //fetch the frame captured by web camera
            TestImage = capture.QueryFrame().ToImage<Bgr, Byte>();

            //show the image in the EmguCV ImageBox
            CamImageBox.Image = TestImage;   
        }

        /// <summary>
        /// Connects to the selected camera attached to the system
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbCamIndex_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Set the camera number to the one selected via combo box
            int CamNumber = -1;
            CamNumber = int.Parse(cbCamIndex.Text);

            //Start the selected camera
            #region if capture is not created, create it now
            if (capture == null)
            {
                try
                {
                    capture = new Capture(CamNumber);
                }
                catch (NullReferenceException excpt)
                {
                    MessageBox.Show(excpt.Message);
                }
            }
            #endregion

            //Start showing the stream from camera
            btnStart_Click(sender, e);
            btnStart.Enabled = true;
        }
        
        /// <summary>
        /// Disconnects from the camera
        /// </summary>
        private void ReleaseCamera()
        {
            if (capture != null)
            {
                //Pause the live streaming video
                Application.Idle -= ProcessFrame;
                capture.Dispose();
                
            }
        }
        
        //----------------------------------------------------------------------------//
        //<<<<<<<<------FUNCTION USED TO DETECT AND EXTRACT FACES--------------->>>>>>>>
        //----------------------------------------------------------------------------//
        private void DetectFaces()
        {
            Image<Gray, byte> grayframe = TestImage.Convert<Gray, byte>();
            
            //Assign user-defined Values to parameter variables:
            MinNeighbors = int.Parse(comboBoxMinNeigh.Text);  // the 3rd parameter
            WindowsSize = int.Parse(textBoxWinSiz.Text);   // the 5th parameter
            ScaleIncreaseRate = Double.Parse(comboBoxScIncRte.Text); //the 2nd parameter

            //detect faces from the gray-scale image and store into an array of type 'var',i.e 'MCvAvgComp[]'
            var faces = haar.DetectMultiScale(grayframe, ScaleIncreaseRate, MinNeighbors);
            if (faces.Length > 0)
            {
                MessageBox.Show("Total Faces Detected: " + faces.Length.ToString());

                Bitmap BmpInput = grayframe.ToBitmap();
                Bitmap ExtractedFace;  // an empty "box"/"image" to hold the extracted face.

                Graphics FaceCanvas;

                //Set The Face Number
                //FaceCollection = Directory.GetFiles(@"Face Collection\", "*.bmp");
                //int FaceNo = FaceCollection.Length;

                //A Bitmap Array to hold the extracted faces
                EXfaces = new Bitmap[faces.Length];
                int i = 0;
                
                //draw a green rectangle on each detected face in image
                foreach (Rectangle face in faces)
                {
                    //locate the detected face & mark with a rectangle
                    TestImage.Draw(face, new Bgr(Color.Green), 3);

                    //set the size of the empty box(ExtractedFace) which will later contain the detected face
                    ExtractedFace = new Bitmap(face.Width, face.Height);

                    //set empty image as FaceCanvas, for painting
                    FaceCanvas = Graphics.FromImage(ExtractedFace);
                    
                    //graphics draws the located face on the faceCancas, thus filling the empty ExtractedFace 
                    //image with exact pixels of the face to be extracted from input image
                    FaceCanvas.DrawImage(BmpInput, 0, 0, face, GraphicsUnit.Pixel);

                    //save this extracted face to hard disk
                    //ExtractedFace.Save(@"Face Collection\" + "Face_" + (FaceNo++) + ".bmp");//save images in folder

                    //Save this extracted face to array
                    EXfaces[i] = ExtractedFace;
                    i++;
                   // Image<Gray, byte> faceGrayPic = grayframe.Copy(face).Convert<Gray, Byte>().Resize(64, 64, Emgu.CV.CvEnum.Inter.Cubic);
                    //faceGrayPic.Save("trainingset/"+txtBoxFaceName.Text+".bmp");

                }
                //Display the detected faces in imagebox
                CamImageBox.Image = TestImage;

                MessageBox.Show(faces.Length.ToString() + " Face(s) Extracted sucessfully!");
                pbCollectedFaces.Image = EXfaces[0];
                btnAddtoTS.Enabled = true;
                txtBoxFaceName.Enabled = true;
                if (faces.Length > 1)
                {
                    btnNext.Enabled = true;
                    btnPrev.Enabled = true;
                }
                else
                {
                    btnNext.Enabled = false;
                    btnPrev.Enabled = false;
                }
            }
            else
                MessageBox.Show("NO faces Detected!");
        }
        //----------------------------------------------------------------------------//
        //<<<<<<<<------BUTTONS USED TO NAVIGATE THROUGH EXTRACTED FACES----------->>>>>
        //----------------------------------------------------------------------------//
        /// <summary>
        /// Navigates to the NEXT image in the Extracted Faces 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (faceNo < EXfaces.Length - 1)
            {

                faceNo++;
                //pbCollectedFaces.Image = Image.FromFile(FaceCollection[faceNo]);
                pbCollectedFaces.Image = EXfaces[faceNo];

            }
            else
                MessageBox.Show("this is the LAST image!");
        }

        /// <summary>
        /// Navigates to the Previous image in the Extracted Faces 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (faceNo > 0)
            {
                faceNo--;
                pbCollectedFaces.Image = EXfaces[faceNo];
                //pbCollectedFaces.Image = Image.FromFile(FaceCollection[faceNo]);
            }
            else
                MessageBox.Show("this is the 1st image!");
        }          

        //----------------------------------------------------------------------------//
        //<<<<<<<<------FUNCTIONS USED TO CONNECT TO DB---------------->>>>>>>>>>>>>>
        //----------------------------------------------------------------------------//
        /// <summary>
        /// Connects to an MS Access database using Oledb connection
        /// </summary>
        private void ConnectToDatabase()
        {
            
        }
        
        /// <summary>
        /// Refreshes connection to MS Access Database to load Latest data
        /// </summary>
        private void RefreshDBConnection()
        {
            
        }


        //---------------------------------------------------------------------------------------------//
        //<<<------BUTTONS & FUNCTIONS USED TO NAVIGATE & ADD FACE-LABEL PAIRS TO DATABASE--------->>>>>>
        //---------------------------------------------------------------------------------------------//

        /// <summary>
        /// Adds the extracted face and its label to the Training Set
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddtoTS_Click(object sender, EventArgs e)
        {
            AddFaceToDB(pbCollectedFaces.Image, txtBoxFaceName.Text);
        }
        
        /// Converts an Image to a byte array format
        /// </summary>
        /// <param name="InputImage"></param> the image to be coverted is a Drawing.Image
        /// <returns></returns> byte array for input image
        private byte[] ConvertToDBFormat(Image InputImage)
        {
            return null;
        }
        /// <summary>
        /// Stores a Face image and its Name in the Training Set, in MS Access Database 
        /// </summary>
        /// <param name="ImageAsBytes"></param> Face image converted to bytes 
        /// <param name="FaceName"></param>the name of face set in the textbox
        private void AddFaceToDB(Image InputFace, string FaceName)
        {
            Image<Bgr, byte> grayframe = new Image<Bgr, byte>(new Bitmap(InputFace));
            Image<Gray, byte> faceGrayPic = grayframe.Convert<Gray, Byte>().Resize(64, 64, Emgu.CV.CvEnum.Inter.Cubic);
            faceGrayPic.Save("trainingset/"+txtBoxFaceName.Text+".bmp");
            MessageBox.Show("nailigtas");
        }
        
        
        //-------------------------------------------------------------------------------------------------------//
        //<<<<<<<<------FUNCTIONS USED TO READ & NAVIGATE DATAFACE-LABEL PAIRS FROM DATABASE--------->>>>>>>>>>>>>>
        //-------------------------------------------------------------------------------------------------------//       
        /// <summary>
        /// Reads the Face stored in MS Access Database at the specified row & converts it to Image
        /// </summary>
        /// <returns></returns>
        private Image GetFaceFromDB()
        {
            
                return null;
           
        }

        /// <summary>
        /// Loads the stored 1ST face-label pair from Training Set to windows form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTSFirst_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Loads the Previous face label from Training Set to windows form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTSPrev_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Loads the Next face label from Training Set to windows form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTSNxt_Click(object sender, EventArgs e)
        {
           
        }

        /// <summary>
        /// Loads the LAST face label from Training Set to windows form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoadTSLast_Click(object sender, EventArgs e)
        {
            
        }


        //-----------------------------------------------------------------------------------------//
        //<<<<<<<<------FUNCTIONS USED TO EDIT CURRENT FACE-LABEL PAIRS in DATABASE--------->>>>>>>>>>>>>>
        //------------------------------------------------------------------------------------------//
        /// <summary>
        /// Updates any change to a Face Name/Label in the Training Set
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateFace_Click(object sender, EventArgs e)
        {
                               
        }
 
        /// <summary>
        /// Deletes a face from the Training Set
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelFace_Click(object sender, EventArgs e)
        {
            
        }


        private void btnLoadRecog_Click(object sender, EventArgs e)
        {
            FaceRecogger fcrec = new FaceRecogger();
            fcrec.Show();
        }

        
        
      }

}
