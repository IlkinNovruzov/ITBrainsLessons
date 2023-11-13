
namespace Hotel_Management_System
{
    partial class RoomForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dataGridView_room = new Guna.UI2.WinForms.Guna2DataGridView();
            label_exit = new Label();
            label6 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            label4 = new Label();
            label2 = new Label();
            button_clean = new Button();
            button_delete = new Button();
            button_update = new Button();
            button_add = new Button();
            panel_button = new Panel();
            comboBox_roomType = new ComboBox();
            radioButton_free = new RadioButton();
            radioButton_busy = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView_room).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel_button.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView_room
            // 
            dataGridView_room.AllowUserToAddRows = false;
            dataGridView_room.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridView_room.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView_room.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_room.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView_room.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView_room.Dock = DockStyle.Fill;
            dataGridView_room.GridColor = Color.FromArgb(231, 229, 255);
            dataGridView_room.Location = new Point(0, 0);
            dataGridView_room.Name = "dataGridView_room";
            dataGridView_room.ReadOnly = true;
            dataGridView_room.RowHeadersVisible = false;
            dataGridView_room.RowHeadersWidth = 51;
            dataGridView_room.RowTemplate.DefaultCellStyle.NullValue = null;
            dataGridView_room.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView_room.Size = new Size(916, 301);
            dataGridView_room.TabIndex = 0;
            dataGridView_room.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dataGridView_room.ThemeStyle.AlternatingRowsStyle.Font = null;
            dataGridView_room.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dataGridView_room.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dataGridView_room.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dataGridView_room.ThemeStyle.BackColor = Color.White;
            dataGridView_room.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dataGridView_room.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dataGridView_room.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView_room.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView_room.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dataGridView_room.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridView_room.ThemeStyle.HeaderStyle.Height = 23;
            dataGridView_room.ThemeStyle.ReadOnly = true;
            dataGridView_room.ThemeStyle.RowsStyle.BackColor = Color.White;
            dataGridView_room.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView_room.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView_room.ThemeStyle.RowsStyle.ForeColor = Color.White;
            dataGridView_room.ThemeStyle.RowsStyle.Height = 22;
            dataGridView_room.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridView_room.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridView_room.CellContentClick += dataGridView_room_CellContentClick;
            // 
            // label_exit
            // 
            label_exit.AutoSize = true;
            label_exit.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_exit.ForeColor = Color.White;
            label_exit.Location = new Point(897, 0);
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
            label6.Size = new Size(236, 36);
            label6.TabIndex = 1;
            label6.Text = "Manage Rooms";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView_room);
            panel2.Location = new Point(12, 74);
            panel2.Name = "panel2";
            panel2.Size = new Size(916, 301);
            panel2.TabIndex = 25;
            // 
            // panel1
            // 
            panel1.Controls.Add(label_exit);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(939, 74);
            panel1.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(504, 441);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 21;
            label4.Text = "Status :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 445);
            label2.Name = "label2";
            label2.Size = new Size(124, 25);
            label2.TabIndex = 17;
            label2.Text = "Room Type :";
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
            // button_add
            // 
            button_add.BackColor = Color.Black;
            button_add.FlatAppearance.BorderSize = 0;
            button_add.FlatStyle = FlatStyle.Flat;
            button_add.ForeColor = Color.White;
            button_add.Image = Hotel_ManagementSystem.Properties.Resources.save_40px;
            button_add.Location = new Point(283, 3);
            button_add.Name = "button_add";
            button_add.Size = new Size(105, 78);
            button_add.TabIndex = 2;
            button_add.Text = "Add";
            button_add.TextImageRelation = TextImageRelation.ImageAboveText;
            button_add.UseVisualStyleBackColor = false;
            button_add.Click += button_add_Click;
            // 
            // panel_button
            // 
            panel_button.Controls.Add(button_clean);
            panel_button.Controls.Add(button_delete);
            panel_button.Controls.Add(button_update);
            panel_button.Controls.Add(button_add);
            panel_button.Dock = DockStyle.Bottom;
            panel_button.Location = new Point(0, 592);
            panel_button.Name = "panel_button";
            panel_button.Size = new Size(939, 108);
            panel_button.TabIndex = 13;
            // 
            // comboBox_roomType
            // 
            comboBox_roomType.FormattingEnabled = true;
            comboBox_roomType.Items.AddRange(new object[] { "Single", "Double", "Family" });
            comboBox_roomType.Location = new Point(247, 441);
            comboBox_roomType.Name = "comboBox_roomType";
            comboBox_roomType.Size = new Size(141, 33);
            comboBox_roomType.TabIndex = 26;
            // 
            // radioButton_free
            // 
            radioButton_free.AutoSize = true;
            radioButton_free.Location = new Point(589, 439);
            radioButton_free.Name = "radioButton_free";
            radioButton_free.Size = new Size(73, 29);
            radioButton_free.TabIndex = 0;
            radioButton_free.TabStop = true;
            radioButton_free.Text = "Free";
            radioButton_free.UseVisualStyleBackColor = true;
            // 
            // radioButton_busy
            // 
            radioButton_busy.AutoSize = true;
            radioButton_busy.Location = new Point(668, 439);
            radioButton_busy.Name = "radioButton_busy";
            radioButton_busy.Size = new Size(77, 29);
            radioButton_busy.TabIndex = 0;
            radioButton_busy.TabStop = true;
            radioButton_busy.Text = "Busy";
            radioButton_busy.UseVisualStyleBackColor = true;
            // 
            // RoomForm
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(939, 700);
            Controls.Add(radioButton_free);
            Controls.Add(radioButton_busy);
            Controls.Add(comboBox_roomType);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(panel_button);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "RoomForm";
            Text = "RoomForm";
            Load += RoomForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_room).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel_button.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_room;
        private Label label_exit;
        private Label label6;
        private Panel panel2;
        private Panel panel1;
        private Label label4;
        private Label label2;
        private Button button_clean;
        private Button button_delete;
        private Button button_update;
        private Button button_add;
        private Panel panel_button;
        private ComboBox comboBox_roomType;
        private RadioButton radioButton_busy;
        private RadioButton radioButton_free;
    }
}