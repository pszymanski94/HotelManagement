namespace Hotel
{
    partial class ReservationAccommodation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationAccommodation));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Name_Box = new System.Windows.Forms.TextBox();
            this.Subname_Box = new System.Windows.Forms.TextBox();
            this.Email_Box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Phone_Box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.TypPokoju = new System.Windows.Forms.ComboBox();
            this.roomDescriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jiPPZ509DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jiPPZ509DataSet1 = new Hotel.JiPPZ509DataSet1();
            this.jiPPZ509DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aBCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.roomDescriptionTableAdapter = new Hotel.JiPPZ509DataSet1TableAdapters.RoomDescriptionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.roomDescriptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jiPPZ509DataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jiPPZ509DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jiPPZ509DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBCBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Marker", 26.25F);
            this.label1.Location = new System.Drawing.Point(207, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rezerwacja noclegów";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(17, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Imię:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F);
            this.label3.Location = new System.Drawing.Point(362, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nazwisko:";
            // 
            // Name_Box
            // 
            this.Name_Box.Location = new System.Drawing.Point(90, 91);
            this.Name_Box.Name = "Name_Box";
            this.Name_Box.Size = new System.Drawing.Size(165, 20);
            this.Name_Box.TabIndex = 3;
            // 
            // Subname_Box
            // 
            this.Subname_Box.Location = new System.Drawing.Point(467, 91);
            this.Subname_Box.Name = "Subname_Box";
            this.Subname_Box.Size = new System.Drawing.Size(192, 20);
            this.Subname_Box.TabIndex = 4;
            this.Subname_Box.TextChanged += new System.EventHandler(this.Subname_Box_TextChanged);
            // 
            // Email_Box
            // 
            this.Email_Box.Location = new System.Drawing.Point(92, 143);
            this.Email_Box.Name = "Email_Box";
            this.Email_Box.Size = new System.Drawing.Size(165, 20);
            this.Email_Box.TabIndex = 5;
            this.Email_Box.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F);
            this.label4.Location = new System.Drawing.Point(19, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "E-mail:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F);
            this.label5.Location = new System.Drawing.Point(362, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Telefon:";
            // 
            // Phone_Box
            // 
            this.Phone_Box.Location = new System.Drawing.Point(467, 138);
            this.Phone_Box.Name = "Phone_Box";
            this.Phone_Box.Size = new System.Drawing.Size(192, 20);
            this.Phone_Box.TabIndex = 8;
            this.Phone_Box.TextChanged += new System.EventHandler(this.Phone_Box_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F);
            this.label6.Location = new System.Drawing.Point(17, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Data przyjazdu:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(156, 192);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(165, 20);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F);
            this.label7.Location = new System.Drawing.Point(17, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "Typ pokoju:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(252, 525);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 49);
            this.button1.TabIndex = 26;
            this.button1.Text = "Rezerwuj!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "Nazwa";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(156, 329);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 21);
            this.comboBox1.TabIndex = 28;
            this.comboBox1.ValueMember = "Nazwa";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F);
            this.label10.Location = new System.Drawing.Point(362, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 24);
            this.label10.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label13.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F);
            this.label13.Location = new System.Drawing.Point(32, 434);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 24);
            this.label13.TabIndex = 42;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label14.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F);
            this.label14.Location = new System.Drawing.Point(12, 443);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(154, 24);
            this.label14.TabIndex = 43;
            this.label14.Text = "Sposób płatności:";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 481);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(68, 17);
            this.radioButton1.TabIndex = 44;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Gotówka";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(90, 481);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(50, 17);
            this.radioButton2.TabIndex = 45;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Karta";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F);
            this.label8.Location = new System.Drawing.Point(17, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 24);
            this.label8.TabIndex = 46;
            this.label8.Text = "Wybierz pokój:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label11.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F);
            this.label11.Location = new System.Drawing.Point(17, 237);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 24);
            this.label11.TabIndex = 50;
            this.label11.Text = "Data wyjazdu:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(156, 241);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(165, 20);
            this.dateTimePicker2.TabIndex = 51;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // TypPokoju
            // 
            this.TypPokoju.DataSource = this.roomDescriptionBindingSource;
            this.TypPokoju.DisplayMember = "Description";
            this.TypPokoju.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypPokoju.FormattingEnabled = true;
            this.TypPokoju.Location = new System.Drawing.Point(156, 279);
            this.TypPokoju.Name = "TypPokoju";
            this.TypPokoju.Size = new System.Drawing.Size(184, 21);
            this.TypPokoju.TabIndex = 52;
            this.TypPokoju.ValueMember = "IDType";
            this.TypPokoju.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // roomDescriptionBindingSource
            // 
            this.roomDescriptionBindingSource.DataMember = "RoomDescription";
            this.roomDescriptionBindingSource.DataSource = this.jiPPZ509DataSet1BindingSource;
            // 
            // jiPPZ509DataSet1BindingSource
            // 
            this.jiPPZ509DataSet1BindingSource.DataSource = this.jiPPZ509DataSet1;
            this.jiPPZ509DataSet1BindingSource.Position = 0;
            // 
            // jiPPZ509DataSet1
            // 
            this.jiPPZ509DataSet1.DataSetName = "JiPPZ509DataSet1";
            this.jiPPZ509DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(156, 481);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(77, 17);
            this.radioButton3.TabIndex = 53;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Przedpłata";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // roomDescriptionTableAdapter
            // 
            this.roomDescriptionTableAdapter.ClearBeforeFill = true;
            // 
            // ReservationAccommodation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(671, 596);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.TypPokoju);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Phone_Box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Email_Box);
            this.Controls.Add(this.Subname_Box);
            this.Controls.Add(this.Name_Box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "ReservationAccommodation";
            this.Text = "Rezerwacja noclegów";
            this.Load += new System.EventHandler(this.Rezerwacja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomDescriptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jiPPZ509DataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jiPPZ509DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jiPPZ509DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBCBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Name_Box;
        private System.Windows.Forms.TextBox Subname_Box;
        private System.Windows.Forms.TextBox Email_Box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Phone_Box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox TypPokoju;
        private System.Windows.Forms.BindingSource aBCBindingSource;
       
        
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.BindingSource jiPPZ509DataSetBindingSource;

        private JiPPZ509DataSet1 jiPPZ509DataSet1;
        private System.Windows.Forms.BindingSource jiPPZ509DataSet1BindingSource;
        private System.Windows.Forms.BindingSource roomDescriptionBindingSource;
        private JiPPZ509DataSet1TableAdapters.RoomDescriptionTableAdapter roomDescriptionTableAdapter;
    }
}