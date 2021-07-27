
namespace WhyAreYouRunning
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.titleBar = new Guna.UI2.WinForms.Guna2Panel();
            this.closeBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.minBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.imageButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.locInfo = new System.Windows.Forms.Label();
            this.dragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.titleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.titleBar.Controls.Add(this.locInfo);
            this.titleBar.Controls.Add(this.minBox);
            this.titleBar.Controls.Add(this.closeBox);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.ShadowDecoration.Parent = this.titleBar;
            this.titleBar.Size = new System.Drawing.Size(800, 30);
            this.titleBar.TabIndex = 1;
            // 
            // closeBox
            // 
            this.closeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBox.FillColor = System.Drawing.Color.Transparent;
            this.closeBox.HoverState.FillColor = System.Drawing.Color.Red;
            this.closeBox.HoverState.Parent = this.closeBox;
            this.closeBox.IconColor = System.Drawing.Color.White;
            this.closeBox.Location = new System.Drawing.Point(755, 0);
            this.closeBox.Name = "closeBox";
            this.closeBox.ShadowDecoration.Parent = this.closeBox;
            this.closeBox.Size = new System.Drawing.Size(45, 30);
            this.closeBox.TabIndex = 0;
            // 
            // minBox
            // 
            this.minBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minBox.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.minBox.FillColor = System.Drawing.Color.Transparent;
            this.minBox.HoverState.Parent = this.minBox;
            this.minBox.IconColor = System.Drawing.Color.White;
            this.minBox.Location = new System.Drawing.Point(710, 0);
            this.minBox.Name = "minBox";
            this.minBox.ShadowDecoration.Parent = this.minBox;
            this.minBox.Size = new System.Drawing.Size(45, 30);
            this.minBox.TabIndex = 0;
            // 
            // imageButton
            // 
            this.imageButton.BackColor = System.Drawing.Color.Transparent;
            this.imageButton.CheckedState.Parent = this.imageButton;
            this.imageButton.HoverState.Image = global::WhyAreYouRunning.Properties.Resources.mario_pixel_invert;
            this.imageButton.HoverState.ImageSize = new System.Drawing.Size(50, 50);
            this.imageButton.HoverState.Parent = this.imageButton;
            this.imageButton.Image = global::WhyAreYouRunning.Properties.Resources.mario_pixel;
            this.imageButton.ImageSize = new System.Drawing.Size(50, 50);
            this.imageButton.Location = new System.Drawing.Point(291, 174);
            this.imageButton.Name = "imageButton";
            this.imageButton.PressedState.ImageSize = new System.Drawing.Size(50, 50);
            this.imageButton.PressedState.Parent = this.imageButton;
            this.imageButton.Size = new System.Drawing.Size(50, 50);
            this.imageButton.TabIndex = 2;
            this.imageButton.UseTransparentBackground = true;
            this.imageButton.MouseHover += new System.EventHandler(this.imageButton_MouseHover);
            // 
            // locInfo
            // 
            this.locInfo.AutoSize = true;
            this.locInfo.Location = new System.Drawing.Point(12, 9);
            this.locInfo.Name = "locInfo";
            this.locInfo.Size = new System.Drawing.Size(48, 13);
            this.locInfo.TabIndex = 1;
            this.locInfo.Text = "Location";
            // 
            // dragControl
            // 
            this.dragControl.TargetControl = this.titleBar;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imageButton);
            this.Controls.Add(this.titleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel titleBar;
        private Guna.UI2.WinForms.Guna2ControlBox minBox;
        private Guna.UI2.WinForms.Guna2ControlBox closeBox;
        private Guna.UI2.WinForms.Guna2ImageButton imageButton;
        private System.Windows.Forms.Label locInfo;
        private Guna.UI2.WinForms.Guna2DragControl dragControl;
    }
}

