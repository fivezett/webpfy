﻿namespace webpfy
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            progressBar1 = new ProgressBar();
            convertByClipBoard = new Button();
            forceFrontCheckBox = new CheckBox();
            openOutputDir = new Button();
            copyButton = new Button();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progressBar1.Location = new Point(0, 0);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(338, 46);
            progressBar1.TabIndex = 0;
            // 
            // convertByClipBoard
            // 
            convertByClipBoard.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            convertByClipBoard.Location = new Point(0, 52);
            convertByClipBoard.Name = "convertByClipBoard";
            convertByClipBoard.Size = new Size(338, 46);
            convertByClipBoard.TabIndex = 1;
            convertByClipBoard.Text = "クリップボードから変換";
            convertByClipBoard.UseVisualStyleBackColor = true;
            convertByClipBoard.Click += convertByClipBoard_Click;
            // 
            // forceFrontCheckBox
            // 
            forceFrontCheckBox.AutoSize = true;
            forceFrontCheckBox.Location = new Point(12, 254);
            forceFrontCheckBox.Name = "forceFrontCheckBox";
            forceFrontCheckBox.Size = new Size(118, 36);
            forceFrontCheckBox.TabIndex = 2;
            forceFrontCheckBox.Text = "最前面";
            forceFrontCheckBox.UseVisualStyleBackColor = true;
            forceFrontCheckBox.CheckedChanged += forceFrontCheckBox_CheckedChanged;
            // 
            // openOutputDir
            // 
            openOutputDir.Location = new Point(289, 241);
            openOutputDir.Name = "openOutputDir";
            openOutputDir.Size = new Size(41, 49);
            openOutputDir.TabIndex = 4;
            openOutputDir.Text = "📂";
            openOutputDir.UseVisualStyleBackColor = true;
            openOutputDir.Click += openOutputDir_Click;
            // 
            // copyButton
            // 
            copyButton.Enabled = false;
            copyButton.Location = new Point(0, 296);
            copyButton.Name = "copyButton";
            copyButton.Size = new Size(338, 46);
            copyButton.TabIndex = 5;
            copyButton.Text = "コピー";
            copyButton.UseVisualStyleBackColor = true;
            copyButton.Click += copyButton_Click;
            // 
            // MainForm
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 343);
            Controls.Add(copyButton);
            Controls.Add(openOutputDir);
            Controls.Add(forceFrontCheckBox);
            Controls.Add(convertByClipBoard);
            Controls.Add(progressBar1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            Text = "webpfy";
            Load += MainForm_Load;
            DragDrop += MainForm_DragDrop;
            DragEnter += MainForm_DragEnter;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Button convertByClipBoard;
        private CheckBox forceFrontCheckBox;
        private Button openOutputDir;
        private Button copyButton;
    }
}
