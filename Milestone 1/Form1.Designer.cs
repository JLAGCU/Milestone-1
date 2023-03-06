namespace Milestone_1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button_NewEntry = new Button();
            button_ModifyEntry = new Button();
            button_Clear = new Button();
            textBox_GameTitle = new TextBox();
            textBox_GameGenre = new TextBox();
            textBox_GameCost = new TextBox();
            textBox_Quantity = new TextBox();
            textBox_UPC = new TextBox();
            label7 = new Label();
            checkedListBox_SearchOptions = new CheckedListBox();
            button_Search = new Button();
            textBox_Search = new TextBox();
            listBox_Inventory = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Industry-Medium", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(26, 9);
            label1.Name = "label1";
            label1.Size = new Size(276, 31);
            label1.TabIndex = 0;
            label1.Text = "Jared's Game Inventory";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(74, 180);
            label2.Name = "label2";
            label2.Size = new Size(44, 21);
            label2.TabIndex = 1;
            label2.Text = "UPC:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(26, 59);
            label3.Name = "label3";
            label3.Size = new Size(92, 21);
            label3.TabIndex = 2;
            label3.Text = "Game Title:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(25, 120);
            label4.Name = "label4";
            label4.Size = new Size(93, 21);
            label4.TabIndex = 3;
            label4.Text = "Game Cost:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(42, 150);
            label5.Name = "label5";
            label5.Size = new Size(76, 21);
            label5.TabIndex = 4;
            label5.Text = "Quantity:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(14, 90);
            label6.Name = "label6";
            label6.Size = new Size(104, 21);
            label6.TabIndex = 5;
            label6.Text = "Game Genre:";
            // 
            // button_NewEntry
            // 
            button_NewEntry.ForeColor = SystemColors.HotTrack;
            button_NewEntry.Location = new Point(124, 206);
            button_NewEntry.Name = "button_NewEntry";
            button_NewEntry.Size = new Size(75, 23);
            button_NewEntry.TabIndex = 6;
            button_NewEntry.Text = "New Entry";
            button_NewEntry.UseVisualStyleBackColor = true;
            button_NewEntry.Click += button_NewEntry_Click;
            // 
            // button_ModifyEntry
            // 
            button_ModifyEntry.ForeColor = SystemColors.HotTrack;
            button_ModifyEntry.Location = new Point(205, 206);
            button_ModifyEntry.Name = "button_ModifyEntry";
            button_ModifyEntry.Size = new Size(97, 23);
            button_ModifyEntry.TabIndex = 7;
            button_ModifyEntry.Text = "Modify Entry";
            button_ModifyEntry.UseVisualStyleBackColor = true;
            button_ModifyEntry.Click += button_ModifyEntry_Click;
            // 
            // button_Clear
            // 
            button_Clear.ForeColor = SystemColors.HotTrack;
            button_Clear.Location = new Point(124, 235);
            button_Clear.Name = "button_Clear";
            button_Clear.Size = new Size(178, 23);
            button_Clear.TabIndex = 8;
            button_Clear.Text = "Clear";
            button_Clear.UseVisualStyleBackColor = true;
            button_Clear.Click += button_Clear_Click;
            // 
            // textBox_GameTitle
            // 
            textBox_GameTitle.Location = new Point(124, 57);
            textBox_GameTitle.Name = "textBox_GameTitle";
            textBox_GameTitle.Size = new Size(178, 23);
            textBox_GameTitle.TabIndex = 9;
            // 
            // textBox_GameGenre
            // 
            textBox_GameGenre.Location = new Point(124, 88);
            textBox_GameGenre.Name = "textBox_GameGenre";
            textBox_GameGenre.Size = new Size(178, 23);
            textBox_GameGenre.TabIndex = 10;
            // 
            // textBox_GameCost
            // 
            textBox_GameCost.Location = new Point(124, 118);
            textBox_GameCost.Name = "textBox_GameCost";
            textBox_GameCost.Size = new Size(178, 23);
            textBox_GameCost.TabIndex = 11;
            // 
            // textBox_Quantity
            // 
            textBox_Quantity.Location = new Point(124, 148);
            textBox_Quantity.Name = "textBox_Quantity";
            textBox_Quantity.Size = new Size(178, 23);
            textBox_Quantity.TabIndex = 12;
            // 
            // textBox_UPC
            // 
            textBox_UPC.Location = new Point(124, 177);
            textBox_UPC.Name = "textBox_UPC";
            textBox_UPC.Size = new Size(178, 23);
            textBox_UPC.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.HotTrack;
            label7.Location = new Point(332, 57);
            label7.Name = "label7";
            label7.Size = new Size(87, 15);
            label7.TabIndex = 14;
            label7.Text = "Search Options";
            // 
            // checkedListBox_SearchOptions
            // 
            checkedListBox_SearchOptions.ForeColor = SystemColors.HotTrack;
            checkedListBox_SearchOptions.FormattingEnabled = true;
            checkedListBox_SearchOptions.Items.AddRange(new object[] { "Game Name", "UPC" });
            checkedListBox_SearchOptions.Location = new Point(332, 75);
            checkedListBox_SearchOptions.Name = "checkedListBox_SearchOptions";
            checkedListBox_SearchOptions.Size = new Size(97, 40);
            checkedListBox_SearchOptions.TabIndex = 15;
            // 
            // button_Search
            // 
            button_Search.ForeColor = SystemColors.HotTrack;
            button_Search.Location = new Point(619, 92);
            button_Search.Name = "button_Search";
            button_Search.Size = new Size(75, 23);
            button_Search.TabIndex = 17;
            button_Search.Text = "Search";
            button_Search.UseVisualStyleBackColor = true;
            // 
            // textBox_Search
            // 
            textBox_Search.Location = new Point(435, 92);
            textBox_Search.Name = "textBox_Search";
            textBox_Search.Size = new Size(178, 23);
            textBox_Search.TabIndex = 18;
            // 
            // listBox_Inventory
            // 
            listBox_Inventory.ForeColor = SystemColors.HotTrack;
            listBox_Inventory.FormattingEnabled = true;
            listBox_Inventory.ItemHeight = 15;
            listBox_Inventory.Items.AddRange(new object[] { "Game Title     Game Genre     Game Cost     Quantity     UPC", "Game #1        Action               $60.00              5                  0001" });
            listBox_Inventory.Location = new Point(332, 121);
            listBox_Inventory.Name = "listBox_Inventory";
            listBox_Inventory.Size = new Size(362, 139);
            listBox_Inventory.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(714, 281);
            Controls.Add(listBox_Inventory);
            Controls.Add(textBox_Search);
            Controls.Add(button_Search);
            Controls.Add(checkedListBox_SearchOptions);
            Controls.Add(label7);
            Controls.Add(textBox_UPC);
            Controls.Add(textBox_Quantity);
            Controls.Add(textBox_GameCost);
            Controls.Add(textBox_GameGenre);
            Controls.Add(textBox_GameTitle);
            Controls.Add(button_Clear);
            Controls.Add(button_ModifyEntry);
            Controls.Add(button_NewEntry);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Jared's Game Inventory";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button_NewEntry;
        private Button button_ModifyEntry;
        private Button button_Clear;
        private TextBox textBox_GameTitle;
        private TextBox textBox_GameGenre;
        private TextBox textBox_GameCost;
        private TextBox textBox_Quantity;
        private TextBox textBox_UPC;
        private Label label7;
        private CheckedListBox checkedListBox_SearchOptions;
        private Button button_Search;
        private TextBox textBox_Search;
        private ListBox listBox_Inventory;
    }
}