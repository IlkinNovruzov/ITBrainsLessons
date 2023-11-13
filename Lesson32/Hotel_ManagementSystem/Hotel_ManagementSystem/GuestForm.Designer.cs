
namespace Hotel_Management_System
{
    partial class GuestForm
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
            panel_button = new Panel();
            button_clean = new Button();
            button_delete = new Button();
            button_update = new Button();
            button_save = new Button();
            textBox_id = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox_fName = new TextBox();
            label3 = new Label();
            textBox_lName = new TextBox();
            label5 = new Label();
            textBox_city = new TextBox();
            panel1 = new Panel();
            label_exit = new Label();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            panel_button.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel_button
            // 
            panel_button.Controls.Add(button_clean);
            panel_button.Controls.Add(button_delete);
            panel_button.Controls.Add(button_update);
            panel_button.Controls.Add(button_save);
            panel_button.Dock = DockStyle.Bottom;
            panel_button.Location = new Point(0, 590);
            panel_button.Name = "panel_button";
            panel_button.Size = new Size(959, 108);
            panel_button.TabIndex = 0;
            // 
            // button_clean
            // 
            button_clean.FlatAppearance.BorderSize = 0;
            button_clean.FlatStyle = FlatStyle.Flat;
            button_clean.ForeColor = Color.White;
            button_clean.Image = Hotel_ManagementSystem.Properties.Resources.clear_formatting_40px;
            button_clean.Location = new Point(615, 3);
            button_clean.Name = "button_clean";
            button_clean.Size = new Size(105, 78);
            button_clean.TabIndex = 5;
            button_clean.Text = "Clean";
            button_clean.TextImageRelation = TextImageRelation.ImageAboveText;
            button_clean.UseVisualStyleBackColor = true;
            button_clean.Click += button_clean_Click;
            // 
            // button_delete
            // 
            button_delete.FlatAppearance.BorderSize = 0;
            button_delete.FlatStyle = FlatStyle.Flat;
            button_delete.ForeColor = Color.White;
            button_delete.Image = Hotel_ManagementSystem.Properties.Resources.delete_document_40px;
            button_delete.Location = new Point(504, 3);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(105, 78);
            button_delete.TabIndex = 4;
            button_delete.Text = "Delete";
            button_delete.TextImageRelation = TextImageRelation.ImageAboveText;
            button_delete.UseVisualStyleBackColor = true;
            // 
            // button_update
            // 
            button_update.BackColor = SystemColors.ActiveCaptionText;
            button_update.FlatAppearance.BorderSize = 0;
            button_update.FlatStyle = FlatStyle.Flat;
            button_update.ForeColor = Color.White;
            button_update.Image = Hotel_ManagementSystem.Properties.Resources.available_updates_40px;
            button_update.Location = new Point(393, 3);
            button_update.Name = "button_update";
            button_update.Size = new Size(105, 78);
            button_update.TabIndex = 3;
            button_update.Text = "Update";
            button_update.TextImageRelation = TextImageRelation.ImageAboveText;
            button_update.UseVisualStyleBackColor = false;
            // 
            // button_save
            // 
            button_save.BackColor = Color.Black;
            button_save.FlatAppearance.BorderSize = 0;
            button_save.FlatStyle = FlatStyle.Flat;
            button_save.ForeColor = Color.White;
            button_save.Image = Hotel_ManagementSystem.Properties.Resources.save_40px;
            button_save.Location = new Point(283, 3);
            button_save.Name = "button_save";
            button_save.Size = new Size(105, 78);
            button_save.TabIndex = 2;
            button_save.Text = "Save";
            button_save.TextImageRelation = TextImageRelation.ImageAboveText;
            button_save.UseVisualStyleBackColor = false;
            button_save.Click += button_save_Click;
            // 
            // textBox_id
            // 
            textBox_id.Location = new Point(623, 492);
            textBox_id.Name = "textBox_id";
            textBox_id.Size = new Size(141, 30);
            textBox_id.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(545, 497);
            label1.Name = "label1";
            label1.Size = new Size(64, 25);
            label1.TabIndex = 2;
            label1.Text = "Id No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(141, 445);
            label2.Name = "label2";
            label2.Size = new Size(117, 25);
            label2.TabIndex = 4;
            label2.Text = "First Name :";
            // 
            // textBox_fName
            // 
            textBox_fName.Location = new Point(264, 440);
            textBox_fName.Name = "textBox_fName";
            textBox_fName.Size = new Size(141, 30);
            textBox_fName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(139, 492);
            label3.Name = "label3";
            label3.Size = new Size(117, 25);
            label3.TabIndex = 6;
            label3.Text = "Last Name :";
            // 
            // textBox_lName
            // 
            textBox_lName.Location = new Point(262, 487);
            textBox_lName.Name = "textBox_lName";
            textBox_lName.Size = new Size(141, 30);
            textBox_lName.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(560, 445);
            label5.Name = "label5";
            label5.Size = new Size(57, 25);
            label5.TabIndex = 10;
            label5.Text = "City :";
            // 
            // textBox_city
            // 
            textBox_city.Location = new Point(623, 442);
            textBox_city.Name = "textBox_city";
            textBox_city.Size = new Size(139, 30);
            textBox_city.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.Controls.Add(label_exit);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(959, 74);
            panel1.TabIndex = 11;
            // 
            // label_exit
            // 
            label_exit.AutoSize = true;
            label_exit.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_exit.ForeColor = Color.White;
            label_exit.Location = new Point(911, 1);
            label_exit.Name = "label_exit";
            label_exit.Size = new Size(42, 38);
            label_exit.TabIndex = 2;
            label_exit.Text = "X";
            label_exit.Click += label_exit_Click;
            label_exit.MouseEnter += label_exit_MouseEnter;
            label_exit.MouseLeave += label_exit_MouseLeave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(401, 19);
            label6.Name = "label6";
            label6.Size = new Size(221, 36);
            label6.TabIndex = 1;
            label6.Text = "Manage Guest";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(935, 326);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // GuestForm
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(959, 698);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(textBox_city);
            Controls.Add(label3);
            Controls.Add(textBox_lName);
            Controls.Add(label2);
            Controls.Add(textBox_fName);
            Controls.Add(label1);
            Controls.Add(textBox_id);
            Controls.Add(panel_button);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "GuestForm";
            Text = "GuestForm";
            Load += GuestForm_Load;
            panel_button.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_button;
        private TextBox textBox_id;
        private Label label1;
        private Label label2;
        private TextBox textBox_fName;
        private Label label3;
        private TextBox textBox_lName;
        private Label label5;
        private TextBox textBox_city;
        private Panel panel1;
        private Label label6;
        private Button button_clean;
        private Button button_delete;
        private Button button_update;
        private Button button_save;
        private Label label_exit;
        private DataGridView dataGridView1;
    }
}