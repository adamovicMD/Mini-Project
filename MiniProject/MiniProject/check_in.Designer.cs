namespace MiniProject
{
    partial class check_in
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
            guestName = new TextBox();
            phoneNumber = new TextBox();
            checkInDate = new DateTimePicker();
            checkOutDate = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            RoomNumber = new ComboBox();
            label3 = new Label();
            reserve = new Button();
            SuspendLayout();
            // 
            // guestName
            // 
            guestName.ForeColor = SystemColors.WindowFrame;
            guestName.Location = new Point(32, 60);
            guestName.Name = "guestName";
            guestName.Size = new Size(200, 23);
            guestName.TabIndex = 0;
            guestName.Text = "name";
            // 
            // phoneNumber
            // 
            phoneNumber.ForeColor = SystemColors.WindowFrame;
            phoneNumber.Location = new Point(251, 60);
            phoneNumber.Name = "phoneNumber";
            phoneNumber.Size = new Size(200, 23);
            phoneNumber.TabIndex = 1;
            phoneNumber.Text = "phone number";
            // 
            // checkInDate
            // 
            checkInDate.Location = new Point(32, 133);
            checkInDate.Name = "checkInDate";
            checkInDate.Size = new Size(200, 23);
            checkInDate.TabIndex = 2;
            // 
            // checkOutDate
            // 
            checkOutDate.Location = new Point(251, 133);
            checkOutDate.Name = "checkOutDate";
            checkOutDate.Size = new Size(200, 23);
            checkOutDate.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 115);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 4;
            label1.Text = "check-in";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(251, 115);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 5;
            label2.Text = "check-out";
            // 
            // RoomNumber
            // 
            RoomNumber.FormattingEnabled = true;
            RoomNumber.Items.AddRange(new object[] { "101", "102", "103", "104", "105", "106", "107", "108", "109" });
            RoomNumber.Location = new Point(32, 201);
            RoomNumber.Name = "RoomNumber";
            RoomNumber.Size = new Size(121, 23);
            RoomNumber.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 183);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 7;
            label3.Text = "roomNo";
            // 
            // reserve
            // 
            reserve.Location = new Point(183, 201);
            reserve.Name = "reserve";
            reserve.Size = new Size(75, 23);
            reserve.TabIndex = 8;
            reserve.Text = "reserve";
            reserve.UseVisualStyleBackColor = true;
            reserve.Click += reserve_Click;
            // 
            // check_in
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 257);
            Controls.Add(reserve);
            Controls.Add(label3);
            Controls.Add(RoomNumber);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(checkOutDate);
            Controls.Add(checkInDate);
            Controls.Add(phoneNumber);
            Controls.Add(guestName);
            Name = "check_in";
            Text = "check_in";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox guestName;
        private TextBox phoneNumber;
        private DateTimePicker checkInDate;
        private DateTimePicker checkOutDate;
        private Label label1;
        private Label label2;
        private ComboBox RoomNumber;
        private Label label3;
        private Button reserve;
    }
}