using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShapeGame
{
    public partial class frmMain : Form
    {
        PictureBox[] ptcTopshapes;
        PictureBox[] ptcBottomshapes;
        Point[] OriginalBottomShapeLocation;
        bool[] Solved;
        bool[] isDragging;
        public int CurrentTimeInterval { get; set; }

        public string ShapeImagePath
        {
            get
            {
                return System.IO.Directory.GetCurrentDirectory() + "\\Img\\Shapes\\";
            }
        }

        public int CurrentIndex { get; set; }

        public string NaturalImagePath
        {
            get
            {
                return System.IO.Directory.GetCurrentDirectory() + "\\Img\\Natural\\";
            }
        }

        public string[] ShapeNames
        {
            get
            {
                return new string[] { "مثلث", "دائرة", "مربع", "مستطيل" };
            }
        }

        public string[] ShapeLocation
        {
            get
            {
                return new string[] { "triangle", "circle", "square", "rectangle" };
            }
        }
        public string[] ShapeFileNames
        {
            get
            {
                return new string[] { "triangle.jpg", "circle.jpg", "square.jpg", "rectangle.jpg" };
            }
        }

        bool IsInLearnMode = true;
        public frmMain()
        {
            InitializeComponent();
            ShowMode();
            IsInLearnMode = false;
        }

        private void btnChangeMode_Click(object sender, EventArgs e)
        {
          //  pnlMain.Controls.Clear();
            ShowMode();
            IsInLearnMode = (!IsInLearnMode);
        }

        private void ShowMode()
        {
            if (IsInLearnMode)
            {
                btnChangeMode.Text = "تغير الى التدريب";
                grbLearn.Visible = true;
                grbPlay.Visible = false;
                CurrentIndex = 0;

                EndGame();
                ShowTrainingImg();
            }
            else
            {
                btnChangeMode.Text = "تغير الى تعلم الاشكال";
                
                grbLearn.Visible = false;
                grbPlay.Visible = true;
               
            }
        }

        private void ShowTrainingImg()
        {
            ptcShape.Image = ShapeImg(ShapeFileNames[CurrentIndex]);
            lblShapeName.Text = ShapeNames[CurrentIndex];
            ptcNatural1.Image = ShapeNaturalImg(ShapeLocation[CurrentIndex], 0);
            ptcNatural2.Image = ShapeNaturalImg(ShapeLocation[CurrentIndex], 1);
            ptcNatural3.Image = ShapeNaturalImg(ShapeLocation[CurrentIndex], 2);
        }

        private Image ShapeNaturalImg(string shape,int num)
        {
            return Image.FromFile(string.Format("{0}{1}\\{2}.jpg", NaturalImagePath, shape, num));
        }
        private Image ShapeImg(string shape)
        {
            return Image.FromFile(ShapeImagePath + shape);
        }

       
        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (CurrentIndex > 0)
            {
                if (btnNext.Enabled == false) { btnNext.Enabled = true; }
                CurrentIndex--;
                ShowTrainingImg();
            }
            else
            {
                btnPrev.Enabled = false;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CurrentIndex < ShapeNames.Length - 1)
            {
                if (btnPrev.Enabled == false) { btnPrev.Enabled = true; }
                CurrentIndex++;
                ShowTrainingImg();
            }
            else
            {
                btnNext.Enabled = false;
            }
        }

        private void tmrHelp_Tick(object sender, EventArgs e)
        {
            CurrentTimeInterval = CurrentTimeInterval+1000;
            lblTime.Text = TimeSpan.FromMilliseconds(CurrentTimeInterval).ToString();
            if (CurrentTimeInterval == 6000)
            {
                var RandomBottomShapes = RandomShape(3)[0];
                var gg = ptcBottomshapes[RandomBottomShapes];
                gg.Visible = false;
                var ggg = int.Parse(gg.Tag.ToString());
                var top = ptcTopshapes[ggg];
                top.Visible = false;
                Solved[ggg] = true;
                IsAllSolved();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            StartGame();
        }


        

        void StartGame()
        {
            OriginalBottomShapeLocation = new Point[3] ;//{ ptcGameNatural1.Location, ptcGameNatural2.Location, ptcGameNatural3.Location };

            ptcTopshapes = new PictureBox[] { ptcGameShape1, ptcGameShape2, ptcGameShape3 };
            ptcBottomshapes = new PictureBox[] { ptcGameNatural1, ptcGameNatural2, ptcGameNatural3 };
            Solved = new bool[3];
            isDragging = new bool[3];
            foreach (var item in ptcBottomshapes)
            {
                item.MouseMove += item_MouseMove;
                item.MouseDown += item_MouseDown;
                item.MouseUp += item_MouseUp;
            }
            btnStart.Visible = false;
            btnEndGame.Visible = true;
            //get random Top shapes
            var RandomTopShapes = RandomShape(ShapeNames.Length);
            var RandomBottomShapes = RandomShape(3);
            //  display the random images
            for (int i = 0; i < ptcTopshapes.Length; i++)
            {
                var ptcg =ptcTopshapes[i];
                if (ptcg != null)
                {
                    var randomShapeIndex = RandomTopShapes[i];
                    ptcg.Image = ShapeImg(ShapeFileNames[randomShapeIndex]);

                   
                    var rbShapeIndex = RandomBottomShapes[i];

                    var ptcNatural = ptcBottomshapes[rbShapeIndex];
                    OriginalBottomShapeLocation[i] = ptcNatural.Location;
                    // get random location for bottom Images
                   // ptcNatural.Parent = ptcg;
                    ptcNatural.Tag = i;
                    isDragging[i] = false;
                    Solved[i] = false;
                    ptcNatural.Image = ShapeNaturalImg(ShapeLocation[randomShapeIndex], rbShapeIndex);
                }
            }

            // start the timer of the game
            tmrHelp.Start();
        }


      //  bool isDragging = false;
      //  int currentX, currentY,startX,startY;


        void item_MouseUp(object sender, MouseEventArgs e)
        {

            var myPictureBox = sender as PictureBox;
            var indx = int.Parse(myPictureBox.Tag.ToString());
            isDragging[indx] = false;
            myPictureBox.Location = OriginalBottomShapeLocation[indx];

            // Get if it solved or Not
        }

        void item_MouseDown(object sender, MouseEventArgs e)
        {
            var myPictureBox = sender as PictureBox;
            var indx = int.Parse(myPictureBox.Tag.ToString());
            isDragging[indx] = true;
        }

        void item_MouseMove(object sender, MouseEventArgs e)
        {
            var myPictureBox = sender as PictureBox;
            var indx = int.Parse(myPictureBox.Tag.ToString());
            var toppic = ptcTopshapes[indx];
            if (isDragging[indx])
            {
                myPictureBox.Top = e.Y + myPictureBox.Top - myPictureBox.Height / 2;
                myPictureBox.Left = e.X + myPictureBox.Left - myPictureBox.Width / 2;

               if (myPictureBox.Top   > toppic.Top  && myPictureBox.Top  < toppic.Top  + 50 &&
                myPictureBox.Left > toppic.Left && myPictureBox.Left < toppic.Left + 50)
               {
                   isDragging[indx] = false;
                   Solved[indx] = true;
                   myPictureBox.Visible = false;
                   toppic.Visible = false;
                   //MessageBox.Show("أحسنت");


                   // check if all pic solved
                   IsAllSolved();
                       

               }
            }

        }

        private void IsAllSolved()
        {
            bool isAllSovled = true;
            for (int i = 0; i < ptcTopshapes.Length; i++)
            {
                if (!Solved[i])
                {
                    isAllSovled = false;
                }
            }

            if (isAllSovled)
            {
                MessageBox.Show("أحسنت");
                EndGame();
            }
        }

        
        void EndGame()
        {
            btnStart.Visible = true;
            btnEndGame.Visible = false;
            tmrHelp.Stop();
            tmrHelp.Enabled = false;
            CurrentTimeInterval = 0;      
            btnStart.Visible = true;
            lblTime.Text = string.Empty;
            if (ptcTopshapes != null)
            {
                for (int i = 0; i < ptcTopshapes.Length; i++)
                {

                    var ptcg = ptcTopshapes[i];
                    var ptcNatural = ptcBottomshapes[i];

                    if (ptcg != null)
                    {
                        ptcg.Visible = true;
                        ptcg.Image = null;
                    }

                    if (ptcNatural != null)

                    {
                        ptcNatural.MouseMove -= item_MouseMove;
                        ptcNatural.MouseDown -= item_MouseDown;
                        ptcNatural.MouseUp -= item_MouseUp;

                        ptcNatural.Visible = true;
                        ptcNatural.Location = OriginalBottomShapeLocation[i];
                        ptcNatural.Image = null;
                    }
                }
            }

            ptcTopshapes = null;
            ptcBottomshapes = null;
            Solved = null;
            
        }

        private void btnEndGame_Click(object sender, EventArgs e)
        {
            EndGame();
        }

        private int[] RandomShape(int top)
        {
            var rng = new Random();
            var values = Enumerable.Range(0, top).OrderBy(x => rng.Next()).ToArray();
            return values;
        }
    }
}
