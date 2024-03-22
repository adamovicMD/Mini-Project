namespace MiniProject
{
    partial class Form1
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
            RoomType = new ComboBox();
            AvailabilityRoom = new ComboBox();
            Cleaning = new ComboBox();
            textBox1 = new TextBox();
            button1 = new Button();
            clear = new Button();
            checkIn = new Button();
            dataGridView1 = new DataGridView();
            usernameLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // RoomType
            // 
            RoomType.FormattingEnabled = true;
            RoomType.Items.AddRange(new object[] { "Single", "Double", "Suite" });
            RoomType.Location = new Point(74, 152);
            RoomType.Name = "RoomType";
            RoomType.Size = new Size(121, 23);
            RoomType.TabIndex = 0;
            RoomType.Text = "ROOMTYPE";
            RoomType.SelectedIndexChanged += RoomType_SelectedIndexChanged;
            // 
            // AvailabilityRoom
            // 
            AvailabilityRoom.FormattingEnabled = true;
            AvailabilityRoom.Items.AddRange(new object[] { "Available", "Occupied" });
            AvailabilityRoom.Location = new Point(392, 152);
            AvailabilityRoom.Name = "AvailabilityRoom";
            AvailabilityRoom.Size = new Size(121, 23);
            AvailabilityRoom.TabIndex = 1;
            AvailabilityRoom.Text = "AVAILABILITY";
            // 
            // Cleaning
            // 
            Cleaning.FormattingEnabled = true;
            Cleaning.Items.AddRange(new object[] { "Clean", "Dirty" });
            Cleaning.Location = new Point(681, 152);
            Cleaning.Name = "Cleaning";
            Cleaning.Size = new Size(121, 23);
            Cleaning.TabIndex = 2;
            Cleaning.Text = "STATUS";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.DarkSalmon;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Constantia", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(301, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(323, 50);
            textBox1.TabIndex = 3;
            textBox1.Text = "Istanbul Hotel";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.Location = new Point(74, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // clear
            // 
            clear.Location = new Point(192, 415);
            clear.Name = "clear";
            clear.Size = new Size(75, 23);
            clear.TabIndex = 5;
            clear.Text = "clear filters";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // checkIn
            // 
            checkIn.Location = new Point(727, 415);
            checkIn.Name = "checkIn";
            checkIn.Size = new Size(75, 23);
            checkIn.TabIndex = 6;
            checkIn.Text = "check-in";
            checkIn.UseVisualStyleBackColor = true;
            checkIn.Click += checkIn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(74, 194);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(728, 215);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.BackColor = Color.DarkSalmon;
            usernameLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            usernameLabel.Location = new Point(431, 88);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(53, 21);
            usernameLabel.TabIndex = 8;
            usernameLabel.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.day_trips_from_istanbul_copy1;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(860, 484);
            Controls.Add(usernameLabel);
            Controls.Add(dataGridView1);
            Controls.Add(checkIn);
            Controls.Add(clear);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(Cleaning);
            Controls.Add(AvailabilityRoom);
            Controls.Add(RoomType);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox RoomType;
        private ComboBox AvailabilityRoom;
        private ComboBox Cleaning;
        private TextBox textBox1;
        private Button button1;
        private Button clear;
        private Button checkIn;
        private DataGridView dataGridView1;
        private Label usernameLabel;
    }
}