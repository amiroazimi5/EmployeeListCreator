namespace list_Creator__windows_form_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            name_lbl = new Label();
            surname_lbl = new Label();
            age_lbl = new Label();
            name_tb = new TextBox();
            surname_tb = new TextBox();
            age_tb = new TextBox();
            birthday_dtp = new DateTimePicker();
            birthday_lbl = new Label();
            cartificate_lbl = new Label();
            cartificate_cb = new ComboBox();
            gender_lbl = new Label();
            gender_male_rb = new RadioButton();
            gender_famale_rb = new RadioButton();
            address_lbl = new Label();
            address_rtb = new RichTextBox();
            dataGridView1 = new DataGridView();
            add_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // name_lbl
            // 
            resources.ApplyResources(name_lbl, "name_lbl");
            name_lbl.Name = "name_lbl";
            // 
            // surname_lbl
            // 
            resources.ApplyResources(surname_lbl, "surname_lbl");
            surname_lbl.Name = "surname_lbl";
            // 
            // age_lbl
            // 
            resources.ApplyResources(age_lbl, "age_lbl");
            age_lbl.Name = "age_lbl";
            // 
            // name_tb
            // 
            resources.ApplyResources(name_tb, "name_tb");
            name_tb.Name = "name_tb";
            // 
            // surname_tb
            // 
            resources.ApplyResources(surname_tb, "surname_tb");
            surname_tb.Name = "surname_tb";
            // 
            // age_tb
            // 
            resources.ApplyResources(age_tb, "age_tb");
            age_tb.Name = "age_tb";
            // 
            // birthday_dtp
            // 
            resources.ApplyResources(birthday_dtp, "birthday_dtp");
            birthday_dtp.Name = "birthday_dtp";
            // 
            // birthday_lbl
            // 
            resources.ApplyResources(birthday_lbl, "birthday_lbl");
            birthday_lbl.Name = "birthday_lbl";
            // 
            // cartificate_lbl
            // 
            resources.ApplyResources(cartificate_lbl, "cartificate_lbl");
            cartificate_lbl.Name = "cartificate_lbl";
            // 
            // cartificate_cb
            // 
            resources.ApplyResources(cartificate_cb, "cartificate_cb");
            cartificate_cb.FormattingEnabled = true;
            cartificate_cb.Items.AddRange(new object[] { resources.GetString("cartificate_cb.Items"), resources.GetString("cartificate_cb.Items1"), resources.GetString("cartificate_cb.Items2"), resources.GetString("cartificate_cb.Items3"), resources.GetString("cartificate_cb.Items4") });
            cartificate_cb.Name = "cartificate_cb";
            // 
            // gender_lbl
            // 
            resources.ApplyResources(gender_lbl, "gender_lbl");
            gender_lbl.Name = "gender_lbl";
            // 
            // gender_male_rb
            // 
            resources.ApplyResources(gender_male_rb, "gender_male_rb");
            gender_male_rb.Name = "gender_male_rb";
            gender_male_rb.TabStop = true;
            gender_male_rb.UseVisualStyleBackColor = true;
            // 
            // gender_famale_rb
            // 
            resources.ApplyResources(gender_famale_rb, "gender_famale_rb");
            gender_famale_rb.Name = "gender_famale_rb";
            gender_famale_rb.TabStop = true;
            gender_famale_rb.UseVisualStyleBackColor = true;
            // 
            // address_lbl
            // 
            resources.ApplyResources(address_lbl, "address_lbl");
            address_lbl.Name = "address_lbl";
            // 
            // address_rtb
            // 
            resources.ApplyResources(address_rtb, "address_rtb");
            address_rtb.Name = "address_rtb";
            // 
            // dataGridView1
            // 
            resources.ApplyResources(dataGridView1, "dataGridView1");
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // add_btn
            // 
            resources.ApplyResources(add_btn, "add_btn");
            add_btn.Name = "add_btn";
            add_btn.UseVisualStyleBackColor = true;
            add_btn.Click += add_btn_Click;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(add_btn);
            Controls.Add(dataGridView1);
            Controls.Add(address_rtb);
            Controls.Add(address_lbl);
            Controls.Add(gender_famale_rb);
            Controls.Add(gender_male_rb);
            Controls.Add(gender_lbl);
            Controls.Add(cartificate_cb);
            Controls.Add(cartificate_lbl);
            Controls.Add(birthday_lbl);
            Controls.Add(birthday_dtp);
            Controls.Add(age_tb);
            Controls.Add(surname_tb);
            Controls.Add(name_tb);
            Controls.Add(age_lbl);
            Controls.Add(surname_lbl);
            Controls.Add(name_lbl);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label name_lbl;
        private Label surname_lbl;
        private Label age_lbl;
        private TextBox name_tb;
        private TextBox surname_tb;
        private TextBox age_tb;
        private DateTimePicker birthday_dtp;
        private Label birthday_lbl;
        private Label cartificate_lbl;
        private ComboBox cartificate_cb;
        private Label gender_lbl;
        private RadioButton gender_male_rb;
        private RadioButton gender_famale_rb;
        private Label address_lbl;
        private RichTextBox address_rtb;
        private DataGridView dataGridView1;
        private Button add_btn;
    }
}
