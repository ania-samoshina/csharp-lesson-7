
namespace Course7
{
    partial class MainForm
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
            this.btnShowDoubler = new System.Windows.Forms.Button();
            this.btnGuesNumber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowDoubler
            // 
            this.btnShowDoubler.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDoubler.Location = new System.Drawing.Point(12, 12);
            this.btnShowDoubler.Name = "btnShowDoubler";
            this.btnShowDoubler.Size = new System.Drawing.Size(631, 279);
            this.btnShowDoubler.TabIndex = 0;
            this.btnShowDoubler.Text = "Удвоитель";
            this.btnShowDoubler.UseVisualStyleBackColor = true;
            this.btnShowDoubler.Click += new System.EventHandler(this.btnShowDoubler_Click);
            // 
            // btnGuesNumber
            // 
            this.btnGuesNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuesNumber.Location = new System.Drawing.Point(12, 297);
            this.btnGuesNumber.Name = "btnGuesNumber";
            this.btnGuesNumber.Size = new System.Drawing.Size(631, 283);
            this.btnGuesNumber.TabIndex = 1;
            this.btnGuesNumber.Text = "Угадай число";
            this.btnGuesNumber.UseVisualStyleBackColor = true;
            this.btnGuesNumber.Click += new System.EventHandler(this.btnGuesNumber_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 592);
            this.Controls.Add(this.btnGuesNumber);
            this.Controls.Add(this.btnShowDoubler);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игры";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowDoubler;
        private System.Windows.Forms.Button btnGuesNumber;
    }
}