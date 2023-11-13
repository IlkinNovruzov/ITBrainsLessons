
namespace Hotel_Management_System
{
    partial class ReservationForm
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
            button_clean = new Button();
            button_delete = new Button();
            button_save = new Button();
            dataGridView_reserv = new Guna.UI2.WinForms.Guna2DataGridView();
            panel2 = new Panel();
            label_exit = new Label();
            label6 = new Label();
            panel1 = new Panel();
            button_update = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox_guestId = new TextBox();
            label1 = new Label();
            textBox_reservId = new TextBox();
            panel_button = new Panel();
            label7 = new Label();
            comboBox_roomType = new ComboBox();
            comboBox_roomNo = new ComboBox();
            dateTimePicker_dateIn = new DateTimePicker();
            dateTimePicker_dateOut = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView_reserv).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel_button.SuspendLayout();
            SuspendLayout();
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
            button_save.Text = "Add";
            button_save.TextImageRelation = TextImageRelation.ImageAboveText;
            button_save.UseVisualStyleBackColor = false;
            // 
            // dataGridView_reserv
            // 
            dataGridView_reserv.AllowUserToAddRows = false;
            dataGridView_reserv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridView_reserv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView_reserv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_reserv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView_reserv.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView_reserv.Dock = DockStyle.Fill;
            dataGridView_reserv.GridColor = Color.FromArgb(231, 229, 255);
            dataGridView_reserv.Location = new Point(0, 0);
            dataGridView_reserv.Name = "dataGridView_reserv";
            dataGridView_reserv.ReadOnly = true;
            dataGridView_reserv.RowHeadersVisible = false;
            dataGridView_reserv.RowHeadersWidth = 51;
            dataGridView_reserv.RowTemplate.DefaultCellStyle.NullValue = null;
            dataGridView_reserv.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView_reserv.Size = new Size(916, 301);
            dataGridView_reserv.TabIndex = 0;
            dataGridView_reserv.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dataGridView_reserv.ThemeStyle.AlternatingRowsStyle.Font = null;
            dataGridView_reserv.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dataGridView_reserv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dataGridView_reserv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dataGridView_reserv.ThemeStyle.BackColor = Color.White;
            dataGridView_reserv.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dataGridView_reserv.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dataGridView_reserv.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView_reserv.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView_reserv.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dataGridView_reserv.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridView_reserv.ThemeStyle.HeaderStyle.Height = 23;
            dataGridView_reserv.ThemeStyle.ReadOnly = true;
            dataGridView_reserv.ThemeStyle.RowsStyle.BackColor = Color.White;
            dataGridView_reserv.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView_reserv.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView_reserv.ThemeStyle.RowsStyle.ForeColor = Color.White;
            dataGridView_reserv.ThemeStyle.RowsStyle.Height = 22;
            dataGridView_reserv.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridView_reserv.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView_reserv);
            panel2.Location = new Point(12, 74);
            panel2.Name = "panel2";
            panel2.Size = new Size(916, 301);
            panel2.TabIndex = 25;
            // 
            // label_exit
            // 
            label_exit.AutoSize = true;
            label_exit.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_exit.ForeColor = Color.White;
            label_exit.Location = new Point(898, 0);
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
            label6.Location = new Point(376, 19);
            label6.Name = "label6";
            label6.Size = new Size(307, 36);
            label6.TabIndex = 1;
            label6.Text = "Manage Reservation";
            // 
            // panel1
            // 
            panel1.Controls.Add(label_exit);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(940, 74);
            panel1.TabIndex = 24;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(530, 442);
            label5.Name = "label5";
            label5.Size = new Size(96, 25);
            label5.TabIndex = 23;
            label5.Text = "Date Out:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(546, 398);
            label4.Name = "label4";
            label4.Size = new Size(80, 25);
            label4.TabIndex = 21;
            label4.Text = "Date In:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(126, 486);
            label3.Name = "label3";
            label3.Size = new Size(119, 25);
            label3.TabIndex = 19;
            label3.Text = "Room Type:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(145, 442);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 17;
            label2.Text = "Guest Id:";
            // 
            // textBox_guestId
            // 
            textBox_guestId.Location = new Point(247, 439);
            textBox_guestId.Name = "textBox_guestId";
            textBox_guestId.Size = new Size(141, 30);
            textBox_guestId.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(141, 398);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 15;
            label1.Text = "Reserv Id:";
            // 
            // textBox_reservId
            // 
            textBox_reservId.Location = new Point(247, 395);
            textBox_reservId.Name = "textBox_reservId";
            textBox_reservId.Size = new Size(141, 30);
            textBox_reservId.TabIndex = 14;
            // 
            // panel_button
            // 
            panel_button.Controls.Add(button_clean);
            panel_button.Controls.Add(button_delete);
            panel_button.Controls.Add(button_update);
            panel_button.Controls.Add(button_save);
            panel_button.Dock = DockStyle.Bottom;
            panel_button.Location = new Point(0, 592);
            panel_button.Name = "panel_button";
            panel_button.Size = new Size(940, 108);
            panel_button.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(141, 530);
            label7.Name = "label7";
            label7.Size = new Size(99, 25);
            label7.TabIndex = 19;
            label7.Text = "Room No:";
            // 
            // comboBox_roomType
            // 
            comboBox_roomType.FormattingEnabled = true;
            comboBox_roomType.Location = new Point(247, 485);
            comboBox_roomType.Name = "comboBox_roomType";
            comboBox_roomType.Size = new Size(141, 33);
            comboBox_roomType.TabIndex = 26;
            // 
            // comboBox_roomNo
            // 
            comboBox_roomNo.FormattingEnabled = true;
            comboBox_roomNo.Location = new Point(247, 527);
            comboBox_roomNo.Name = "comboBox_roomNo";
            comboBox_roomNo.Size = new Size(141, 33);
            comboBox_roomNo.TabIndex = 26;
            // 
            // dateTimePicker_dateIn
            // 
            dateTimePicker_dateIn.CustomFormat = "dd/MM/yyy";
            dateTimePicker_dateIn.Format = DateTimePickerFormat.Custom;
            dateTimePicker_dateIn.Location = new Point(636, 395);
            dateTimePicker_dateIn.Name = "dateTimePicker_dateIn";
            dateTimePicker_dateIn.Size = new Size(200, 30);
            dateTimePicker_dateIn.TabIndex = 27;
            // 
            // dateTimePicker_dateOut
            // 
            dateTimePicker_dateOut.CustomFormat = "dd/MM/yyy";
            dateTimePicker_dateOut.Format = DateTimePickerFormat.Custom;
            dateTimePicker_dateOut.Location = new Point(636, 439);
            dateTimePicker_dateOut.Name = "dateTimePicker_dateOut";
            dateTimePicker_dateOut.Size = new Size(200, 30);
            dateTimePicker_dateOut.TabIndex = 27;
            // 
            // ReservationForm
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(940, 700);
            Controls.Add(dateTimePicker_dateOut);
            Controls.Add(dateTimePicker_dateIn);
            Controls.Add(comboBox_roomNo);
            Controls.Add(comboBox_roomType);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox_guestId);
            Controls.Add(label1);
            Controls.Add(textBox_reservId);
            Controls.Add(panel_button);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "ReservationForm";
            Text = "ReservationForm";
            Load += ReservationForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_reserv).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel_button.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_clean;
        private Button button_delete;
        private Button button_save;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_reserv;
        private Panel panel2;
        private Label label_exit;
        private Label label6;
        private Panel panel1;
        private Button button_update;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox_guestId;
        private Label label1;
        private TextBox textBox_reservId;
        private Panel panel_button;
        private Label label7;
        private ComboBox comboBox_roomType;
        private ComboBox comboBox_roomNo;
        private DateTimePicker dateTimePicker_dateIn;
        private DateTimePicker dateTimePicker_dateOut;
    }
}