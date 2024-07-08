namespace DrawingApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelDrawing;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelDrawing = new Panel();
            SuspendLayout();
            // 
            // panelDrawing
            // 
            panelDrawing.BackColor = Color.White;
            panelDrawing.Location = new Point(10, 11);
            panelDrawing.Name = "panelDrawing";
            panelDrawing.Size = new Size(665, 410);
            panelDrawing.TabIndex = 0;
            panelDrawing.Paint += panelDrawing_Paint;
            panelDrawing.MouseDown += panelDrawing_MouseDown;
            panelDrawing.MouseMove += panelDrawing_MouseMove;
            panelDrawing.MouseUp += panelDrawing_MouseUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 432);
            Controls.Add(panelDrawing);
            Name = "Form1";
            Text = "Drawing App";
            ResumeLayout(false);
        }
    }
}
