namespace GradientEditor
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
            this.bDel = new System.Windows.Forms.Button();
            this.tbPos = new System.Windows.Forms.TrackBar();
            this.cbWedge = new System.Windows.Forms.ComboBox();
            this.btnIns = new System.Windows.Forms.Button();
            this.tbG = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbB = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.tbR = new System.Windows.Forms.TrackBar();
            this.rtbCode = new System.Windows.Forms.RichTextBox();
            this.cbOr = new System.Windows.Forms.ComboBox();
            this.lR = new System.Windows.Forms.Label();
            this.lG = new System.Windows.Forms.Label();
            this.lB = new System.Windows.Forms.Label();
            this.gPanel = new GradientEditor.GPanel();
            ((System.ComponentModel.ISupportInitialize)(this.tbPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbR)).BeginInit();
            this.SuspendLayout();
            // 
            // bDel
            // 
            this.bDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bDel.Location = new System.Drawing.Point(93, 643);
            this.bDel.Name = "bDel";
            this.bDel.Size = new System.Drawing.Size(75, 23);
            this.bDel.TabIndex = 1;
            this.bDel.Text = "Delete";
            this.bDel.UseVisualStyleBackColor = true;
            this.bDel.Click += new System.EventHandler(this.bDel_Click);
            // 
            // tbPos
            // 
            this.tbPos.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPos.Location = new System.Drawing.Point(0, 0);
            this.tbPos.Name = "tbPos";
            this.tbPos.Size = new System.Drawing.Size(1205, 45);
            this.tbPos.TabIndex = 2;
            this.tbPos.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbPos.Scroll += new System.EventHandler(this.tbPos_Scroll);
            // 
            // cbWedge
            // 
            this.cbWedge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbWedge.FormattingEnabled = true;
            this.cbWedge.Location = new System.Drawing.Point(12, 616);
            this.cbWedge.Name = "cbWedge";
            this.cbWedge.Size = new System.Drawing.Size(156, 21);
            this.cbWedge.TabIndex = 3;
            this.cbWedge.SelectedIndexChanged += new System.EventHandler(this.cbWedge_SelectedIndexChanged);
            // 
            // btnIns
            // 
            this.btnIns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnIns.Location = new System.Drawing.Point(12, 643);
            this.btnIns.Name = "btnIns";
            this.btnIns.Size = new System.Drawing.Size(75, 23);
            this.btnIns.TabIndex = 4;
            this.btnIns.Text = "Insert";
            this.btnIns.UseVisualStyleBackColor = true;
            this.btnIns.Click += new System.EventHandler(this.btnIns_Click);
            // 
            // tbG
            // 
            this.tbG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbG.Location = new System.Drawing.Point(665, 570);
            this.tbG.Maximum = 255;
            this.tbG.Name = "tbG";
            this.tbG.Size = new System.Drawing.Size(515, 45);
            this.tbG.TabIndex = 5;
            this.tbG.Scroll += new System.EventHandler(this.tbG_Scroll);
            this.tbG.ValueChanged += new System.EventHandler(this.tbG_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(640, 570);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "G";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(640, 621);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "B";
            // 
            // tbB
            // 
            this.tbB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbB.Location = new System.Drawing.Point(665, 621);
            this.tbB.Maximum = 255;
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(515, 45);
            this.tbB.TabIndex = 7;
            this.tbB.Scroll += new System.EventHandler(this.tbB_Scroll);
            this.tbB.ValueChanged += new System.EventHandler(this.tbB_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(640, 519);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "R";
            // 
            // tbR
            // 
            this.tbR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbR.Location = new System.Drawing.Point(665, 519);
            this.tbR.Maximum = 255;
            this.tbR.Name = "tbR";
            this.tbR.Size = new System.Drawing.Size(515, 45);
            this.tbR.TabIndex = 9;
            this.tbR.Scroll += new System.EventHandler(this.tbR_Scroll);
            this.tbR.ValueChanged += new System.EventHandler(this.tbR_ValueChanged);
            // 
            // rtbCode
            // 
            this.rtbCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbCode.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbCode.Location = new System.Drawing.Point(12, 284);
            this.rtbCode.Name = "rtbCode";
            this.rtbCode.ReadOnly = true;
            this.rtbCode.Size = new System.Drawing.Size(622, 326);
            this.rtbCode.TabIndex = 12;
            this.rtbCode.Text = "";
            this.rtbCode.WordWrap = false;
            // 
            // cbOr
            // 
            this.cbOr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbOr.FormattingEnabled = true;
            this.cbOr.Items.AddRange(new object[] {
            "Top Down",
            "Left to Right"});
            this.cbOr.Location = new System.Drawing.Point(174, 616);
            this.cbOr.Name = "cbOr";
            this.cbOr.Size = new System.Drawing.Size(134, 21);
            this.cbOr.TabIndex = 13;
            this.cbOr.Text = "Top Down";
            this.cbOr.SelectedIndexChanged += new System.EventHandler(this.cbOr_SelectedIndexChanged);
            // 
            // lR
            // 
            this.lR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lR.AutoSize = true;
            this.lR.Location = new System.Drawing.Point(1177, 522);
            this.lR.Name = "lR";
            this.lR.Size = new System.Drawing.Size(13, 13);
            this.lR.TabIndex = 14;
            this.lR.Text = "0";
            // 
            // lG
            // 
            this.lG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lG.AutoSize = true;
            this.lG.Location = new System.Drawing.Point(1177, 573);
            this.lG.Name = "lG";
            this.lG.Size = new System.Drawing.Size(13, 13);
            this.lG.TabIndex = 15;
            this.lG.Text = "0";
            // 
            // lB
            // 
            this.lB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lB.AutoSize = true;
            this.lB.Location = new System.Drawing.Point(1177, 624);
            this.lB.Name = "lB";
            this.lB.Size = new System.Drawing.Size(13, 13);
            this.lB.TabIndex = 16;
            this.lB.Text = "0";
            // 
            // gPanel
            // 
            this.gPanel.BackColor = System.Drawing.Color.White;
            this.gPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.gPanel.Location = new System.Drawing.Point(0, 45);
            this.gPanel.Name = "gPanel";
            this.gPanel.Size = new System.Drawing.Size(1205, 207);
            this.gPanel.TabIndex = 11;
            this.gPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.gPanel_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 678);
            this.Controls.Add(this.lB);
            this.Controls.Add(this.lG);
            this.Controls.Add(this.lR);
            this.Controls.Add(this.cbOr);
            this.Controls.Add(this.rtbCode);
            this.Controls.Add(this.gPanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbG);
            this.Controls.Add(this.btnIns);
            this.Controls.Add(this.cbWedge);
            this.Controls.Add(this.tbPos);
            this.Controls.Add(this.bDel);
            this.Name = "Form1";
            this.Text = "Gradient Editor";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.tbPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bDel;
        private System.Windows.Forms.TrackBar tbPos;
        private System.Windows.Forms.ComboBox cbWedge;
        private System.Windows.Forms.Button btnIns;
        private System.Windows.Forms.TrackBar tbG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar tbB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar tbR;
        private GPanel gPanel;
        private System.Windows.Forms.RichTextBox rtbCode;
        private System.Windows.Forms.ComboBox cbOr;
        private System.Windows.Forms.Label lR;
        private System.Windows.Forms.Label lG;
        private System.Windows.Forms.Label lB;

    }
}

