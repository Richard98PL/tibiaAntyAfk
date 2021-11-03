
namespace TibiaAntyAFK
{
    partial class Tibia
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tibia));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.right = new System.Windows.Forms.CheckBox();
            this.down = new System.Windows.Forms.CheckBox();
            this.left = new System.Windows.Forms.CheckBox();
            this.top = new System.Windows.Forms.CheckBox();
            this.characterName = new System.Windows.Forms.Label();
            this.delayLabel = new System.Windows.Forms.Label();
            this.hideTibia = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 2000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.right, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.down, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.left, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.top, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(137, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(59, 61);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // right
            // 
            this.right.AutoSize = true;
            this.right.Location = new System.Drawing.Point(41, 23);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(15, 14);
            this.right.TabIndex = 2;
            this.right.UseVisualStyleBackColor = true;
            this.right.CheckedChanged += new System.EventHandler(this.executeLogicOnChangedCheckbox);
            // 
            // down
            // 
            this.down.AutoSize = true;
            this.down.Checked = true;
            this.down.CheckState = System.Windows.Forms.CheckState.Checked;
            this.down.Location = new System.Drawing.Point(22, 43);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(13, 14);
            this.down.TabIndex = 3;
            this.down.UseVisualStyleBackColor = true;
            this.down.CheckedChanged += new System.EventHandler(this.executeLogicOnChangedCheckbox);
            // 
            // left
            // 
            this.left.AutoSize = true;
            this.left.Location = new System.Drawing.Point(3, 23);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(13, 14);
            this.left.TabIndex = 1;
            this.left.UseVisualStyleBackColor = true;
            this.left.CheckedChanged += new System.EventHandler(this.executeLogicOnChangedCheckbox);
            // 
            // top
            // 
            this.top.AutoSize = true;
            this.top.Checked = true;
            this.top.CheckState = System.Windows.Forms.CheckState.Checked;
            this.top.Location = new System.Drawing.Point(22, 3);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(13, 14);
            this.top.TabIndex = 0;
            this.top.UseVisualStyleBackColor = true;
            this.top.CheckedChanged += new System.EventHandler(this.executeLogicOnChangedCheckbox);
            // 
            // characterName
            // 
            this.characterName.AutoSize = true;
            this.characterName.Location = new System.Drawing.Point(12, 23);
            this.characterName.Name = "characterName";
            this.characterName.Size = new System.Drawing.Size(88, 15);
            this.characterName.TabIndex = 1;
            this.characterName.Text = "characterName";
            // 
            // delayLabel
            // 
            this.delayLabel.AutoSize = true;
            this.delayLabel.Location = new System.Drawing.Point(12, 52);
            this.delayLabel.Name = "delayLabel";
            this.delayLabel.Size = new System.Drawing.Size(63, 15);
            this.delayLabel.TabIndex = 2;
            this.delayLabel.Text = "delayLabel";
            // 
            // hideTibia
            // 
            this.hideTibia.AutoSize = true;
            this.hideTibia.Location = new System.Drawing.Point(13, 89);
            this.hideTibia.Name = "hideTibia";
            this.hideTibia.Size = new System.Drawing.Size(77, 19);
            this.hideTibia.TabIndex = 3;
            this.hideTibia.Text = "hide Tibia";
            this.hideTibia.UseVisualStyleBackColor = true;
            // 
            // Tibia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 120);
            this.Controls.Add(this.hideTibia);
            this.Controls.Add(this.delayLabel);
            this.Controls.Add(this.characterName);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Tibia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tibia";
            this.TopMost = true;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox right;
        private System.Windows.Forms.CheckBox down;
        private System.Windows.Forms.CheckBox top;
        private System.Windows.Forms.CheckBox left;
        private System.Windows.Forms.Label characterName;
        private System.Windows.Forms.Label delayLabel;
        private System.Windows.Forms.CheckBox hideTibia;
    }
}

