using System.Runtime.InteropServices;



namespace Enroll
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            //Estas lineas eliminan los parpadeos del formulario o controles en la interfaz grafica (Pero no en un 100%)
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }

        private void panelDashBoard_Paint(object sender, PaintEventArgs e)
        {

        }

        #region Functionalitys of Form
        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.panelDashBoard.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // Capturar posicion y tamano antes de maximizar para restaurar
        int lx, ly;
        int sw, sh;
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTopBar_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            lx = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnRestore.Visible = true;
            btnMaximize.Visible = false;
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            OpenForm<FormCourse>();
            btnCourses.BackColor = Color.FromArgb(246, 135, 31);
        }


        private void btnStudent_Click(object sender, EventArgs e)
        {
            OpenForm<FormStudent>();
            btnStudent.BackColor = Color.FromArgb(246, 135, 31);
        }

        private void btnEnrolled_Click(object sender, EventArgs e)
        {
            OpenForm<FormEnrolled>();
            btnEnrolled.BackColor = Color.FromArgb(246, 135, 31); 
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRestore_Click(object sender, EventArgs e)
        {

            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
            btnMaximize.Visible = true;
            btnRestore.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
      
        }

        private void tmrHidden_Tick(object sender, EventArgs e)
        {
            if (panelMenu.Width <= 60)
            {
                tmrHidden.Enabled = false;
            }
            else {

                panelMenu.Width = panelMenu.Width - 20;
            
            }
        }

        private void tmrVisible_Tick(object sender, EventArgs e)
        {

            if (panelMenu.Width >= 160)
            {

                tmrVisible.Enabled = false;

            }
            else {

                panelMenu.Width = panelMenu.Width + 20; 
           
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (panelMenu.Width == 160)
            {

                tmrHidden.Enabled = true;

            }
            else if (panelMenu.Width == 60) {

                tmrVisible.Enabled = true;
            
            }
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        #endregion

        // Open Form inside of Panel

        private void OpenForm<MyForm>()where MyForm : Form, new() {
            Form theForm;
            theForm = panelForms.Controls.OfType<MyForm>().FirstOrDefault(); // Search in the collection the form

            // if the form or instance no exist

            if (theForm == null)
            {

                theForm = new MyForm();
                theForm.TopLevel = false;
                theForm.FormBorderStyle = FormBorderStyle.None;
                theForm.Dock = DockStyle.Fill; 
                theForm.Location = new Point(0, 40);
                panelForms.Controls.Add(theForm);
                theForm.Tag = theForm;
                theForm.Show();
                theForm.BringToFront();
                theForm.FormClosed += new FormClosedEventHandler(CloseFormsColors);


            }
            // if form exist so take to the front
            else {

                theForm.BringToFront()
;            
            }
        }

        private void CloseFormsColors(Object sender, FormClosedEventArgs e) {

 
            if (Application.OpenForms["FormCourse"] == null) {
                btnCourses.BackColor = Color.FromArgb(2, 28, 42);
  
            }

            if (Application.OpenForms["FormEnrolled"] == null) {

                btnEnrolled.BackColor = Color.FromArgb(2, 28, 42);
         

            }

            if (Application.OpenForms["FormStudent"] == null) {

                btnStudent.BackColor = Color.FromArgb(2, 28, 42);


            }
        }

    }
}