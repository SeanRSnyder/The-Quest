namespace The_Quest
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.player = new System.Windows.Forms.PictureBox();
            this.bat = new System.Windows.Forms.PictureBox();
            this.ghost = new System.Windows.Forms.PictureBox();
            this.ghoul = new System.Windows.Forms.PictureBox();
            this.bluePotion = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.moveDown = new System.Windows.Forms.Button();
            this.moveRight = new System.Windows.Forms.Button();
            this.moveLeft = new System.Windows.Forms.Button();
            this.moveUp = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.attackDown = new System.Windows.Forms.Button();
            this.attackRight = new System.Windows.Forms.Button();
            this.attackLeft = new System.Windows.Forms.Button();
            this.attackUp = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.playerHitPoints = new System.Windows.Forms.Label();
            this.batHitPoints = new System.Windows.Forms.Label();
            this.ghostHitPoints = new System.Windows.Forms.Label();
            this.ghoulHitPoints = new System.Windows.Forms.Label();
            this.redPotion = new System.Windows.Forms.PictureBox();
            this.sword = new System.Windows.Forms.PictureBox();
            this.bow = new System.Windows.Forms.PictureBox();
            this.mace = new System.Windows.Forms.PictureBox();
            this.SwordInv = new System.Windows.Forms.PictureBox();
            this.BowInv = new System.Windows.Forms.PictureBox();
            this.MaceInv = new System.Windows.Forms.PictureBox();
            this.BluePotionInv = new System.Windows.Forms.PictureBox();
            this.RedPotionInv = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghoul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotion)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.redPotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwordInv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BowInv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaceInv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BluePotionInv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedPotionInv)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("player.BackgroundImage")));
            this.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player.Location = new System.Drawing.Point(146, 108);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(60, 50);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // bat
            // 
            this.bat.BackColor = System.Drawing.Color.Transparent;
            this.bat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bat.BackgroundImage")));
            this.bat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bat.Location = new System.Drawing.Point(215, 108);
            this.bat.Name = "bat";
            this.bat.Size = new System.Drawing.Size(60, 50);
            this.bat.TabIndex = 1;
            this.bat.TabStop = false;
            this.bat.Visible = false;
            // 
            // ghost
            // 
            this.ghost.BackColor = System.Drawing.Color.Transparent;
            this.ghost.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ghost.BackgroundImage")));
            this.ghost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ghost.Location = new System.Drawing.Point(298, 108);
            this.ghost.Name = "ghost";
            this.ghost.Size = new System.Drawing.Size(60, 50);
            this.ghost.TabIndex = 2;
            this.ghost.TabStop = false;
            this.ghost.Visible = false;
            // 
            // ghoul
            // 
            this.ghoul.BackColor = System.Drawing.Color.Transparent;
            this.ghoul.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ghoul.BackgroundImage")));
            this.ghoul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ghoul.Location = new System.Drawing.Point(375, 108);
            this.ghoul.Name = "ghoul";
            this.ghoul.Size = new System.Drawing.Size(60, 50);
            this.ghoul.TabIndex = 3;
            this.ghoul.TabStop = false;
            this.ghoul.Visible = false;
            // 
            // bluePotion
            // 
            this.bluePotion.BackColor = System.Drawing.Color.Transparent;
            this.bluePotion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bluePotion.BackgroundImage")));
            this.bluePotion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bluePotion.Location = new System.Drawing.Point(450, 108);
            this.bluePotion.Name = "bluePotion";
            this.bluePotion.Size = new System.Drawing.Size(60, 50);
            this.bluePotion.TabIndex = 4;
            this.bluePotion.TabStop = false;
            this.bluePotion.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.moveDown);
            this.groupBox1.Controls.Add(this.moveRight);
            this.groupBox1.Controls.Add(this.moveLeft);
            this.groupBox1.Controls.Add(this.moveUp);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(539, 515);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Move";
            // 
            // moveDown
            // 
            this.moveDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveDown.Location = new System.Drawing.Point(61, 71);
            this.moveDown.Name = "moveDown";
            this.moveDown.Size = new System.Drawing.Size(31, 23);
            this.moveDown.TabIndex = 3;
            this.moveDown.Text = "↓";
            this.moveDown.UseVisualStyleBackColor = true;
            this.moveDown.Click += new System.EventHandler(this.moveDown_Click);
            // 
            // moveRight
            // 
            this.moveRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveRight.Location = new System.Drawing.Point(98, 48);
            this.moveRight.Name = "moveRight";
            this.moveRight.Size = new System.Drawing.Size(31, 23);
            this.moveRight.TabIndex = 2;
            this.moveRight.Text = "→";
            this.moveRight.UseVisualStyleBackColor = true;
            this.moveRight.Click += new System.EventHandler(this.moveRight_Click);
            // 
            // moveLeft
            // 
            this.moveLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveLeft.Location = new System.Drawing.Point(22, 48);
            this.moveLeft.Name = "moveLeft";
            this.moveLeft.Size = new System.Drawing.Size(31, 23);
            this.moveLeft.TabIndex = 1;
            this.moveLeft.Text = "←";
            this.moveLeft.UseVisualStyleBackColor = true;
            this.moveLeft.Click += new System.EventHandler(this.moveLeft_Click);
            // 
            // moveUp
            // 
            this.moveUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveUp.Location = new System.Drawing.Point(62, 21);
            this.moveUp.Name = "moveUp";
            this.moveUp.Size = new System.Drawing.Size(31, 23);
            this.moveUp.TabIndex = 0;
            this.moveUp.Text = "↑";
            this.moveUp.UseVisualStyleBackColor = true;
            this.moveUp.Click += new System.EventHandler(this.moveUp_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.attackDown);
            this.groupBox2.Controls.Add(this.attackRight);
            this.groupBox2.Controls.Add(this.attackLeft);
            this.groupBox2.Controls.Add(this.attackUp);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(680, 515);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(121, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Attack";
            // 
            // attackDown
            // 
            this.attackDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attackDown.Location = new System.Drawing.Point(41, 71);
            this.attackDown.Name = "attackDown";
            this.attackDown.Size = new System.Drawing.Size(31, 23);
            this.attackDown.TabIndex = 4;
            this.attackDown.Text = "↓";
            this.attackDown.UseVisualStyleBackColor = true;
            this.attackDown.Click += new System.EventHandler(this.attackDown_Click);
            // 
            // attackRight
            // 
            this.attackRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attackRight.Location = new System.Drawing.Point(78, 48);
            this.attackRight.Name = "attackRight";
            this.attackRight.Size = new System.Drawing.Size(31, 23);
            this.attackRight.TabIndex = 3;
            this.attackRight.Text = "→";
            this.attackRight.UseVisualStyleBackColor = true;
            this.attackRight.Click += new System.EventHandler(this.attackRight_Click);
            // 
            // attackLeft
            // 
            this.attackLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attackLeft.Location = new System.Drawing.Point(6, 48);
            this.attackLeft.Name = "attackLeft";
            this.attackLeft.Size = new System.Drawing.Size(31, 23);
            this.attackLeft.TabIndex = 2;
            this.attackLeft.Text = "←";
            this.attackLeft.UseVisualStyleBackColor = true;
            this.attackLeft.Click += new System.EventHandler(this.attackLeft_Click);
            // 
            // attackUp
            // 
            this.attackUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attackUp.Location = new System.Drawing.Point(41, 21);
            this.attackUp.Name = "attackUp";
            this.attackUp.Size = new System.Drawing.Size(31, 23);
            this.attackUp.TabIndex = 1;
            this.attackUp.Text = "↑";
            this.attackUp.UseVisualStyleBackColor = true;
            this.attackUp.Click += new System.EventHandler(this.attackUp_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.playerHitPoints, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.batHitPoints, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ghostHitPoints, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ghoulHitPoints, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(539, 398);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(204, 82);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bat";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ghost";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ghoul";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerHitPoints
            // 
            this.playerHitPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerHitPoints.AutoSize = true;
            this.playerHitPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerHitPoints.Location = new System.Drawing.Point(102, 0);
            this.playerHitPoints.Margin = new System.Windows.Forms.Padding(0);
            this.playerHitPoints.Name = "playerHitPoints";
            this.playerHitPoints.Size = new System.Drawing.Size(102, 20);
            this.playerHitPoints.TabIndex = 4;
            this.playerHitPoints.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // batHitPoints
            // 
            this.batHitPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.batHitPoints.AutoSize = true;
            this.batHitPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batHitPoints.Location = new System.Drawing.Point(102, 20);
            this.batHitPoints.Margin = new System.Windows.Forms.Padding(0);
            this.batHitPoints.Name = "batHitPoints";
            this.batHitPoints.Size = new System.Drawing.Size(102, 20);
            this.batHitPoints.TabIndex = 5;
            this.batHitPoints.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ghostHitPoints
            // 
            this.ghostHitPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ghostHitPoints.AutoSize = true;
            this.ghostHitPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ghostHitPoints.Location = new System.Drawing.Point(105, 40);
            this.ghostHitPoints.Name = "ghostHitPoints";
            this.ghostHitPoints.Size = new System.Drawing.Size(96, 20);
            this.ghostHitPoints.TabIndex = 6;
            this.ghostHitPoints.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ghoulHitPoints
            // 
            this.ghoulHitPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ghoulHitPoints.AutoSize = true;
            this.ghoulHitPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ghoulHitPoints.Location = new System.Drawing.Point(105, 60);
            this.ghoulHitPoints.Name = "ghoulHitPoints";
            this.ghoulHitPoints.Size = new System.Drawing.Size(96, 22);
            this.ghoulHitPoints.TabIndex = 7;
            this.ghoulHitPoints.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // redPotion
            // 
            this.redPotion.BackColor = System.Drawing.Color.Transparent;
            this.redPotion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("redPotion.BackgroundImage")));
            this.redPotion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.redPotion.Location = new System.Drawing.Point(166, 186);
            this.redPotion.Name = "redPotion";
            this.redPotion.Size = new System.Drawing.Size(60, 50);
            this.redPotion.TabIndex = 8;
            this.redPotion.TabStop = false;
            this.redPotion.Visible = false;
            // 
            // sword
            // 
            this.sword.BackColor = System.Drawing.Color.Transparent;
            this.sword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sword.BackgroundImage")));
            this.sword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sword.Location = new System.Drawing.Point(232, 186);
            this.sword.Name = "sword";
            this.sword.Size = new System.Drawing.Size(60, 50);
            this.sword.TabIndex = 9;
            this.sword.TabStop = false;
            this.sword.Visible = false;
            // 
            // bow
            // 
            this.bow.BackColor = System.Drawing.Color.Transparent;
            this.bow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bow.BackgroundImage")));
            this.bow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bow.Location = new System.Drawing.Point(298, 186);
            this.bow.Name = "bow";
            this.bow.Size = new System.Drawing.Size(60, 50);
            this.bow.TabIndex = 10;
            this.bow.TabStop = false;
            this.bow.Visible = false;
            // 
            // mace
            // 
            this.mace.BackColor = System.Drawing.Color.Transparent;
            this.mace.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mace.BackgroundImage")));
            this.mace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mace.Location = new System.Drawing.Point(375, 186);
            this.mace.Name = "mace";
            this.mace.Size = new System.Drawing.Size(60, 50);
            this.mace.TabIndex = 11;
            this.mace.TabStop = false;
            this.mace.Visible = false;
            // 
            // SwordInv
            // 
            this.SwordInv.BackColor = System.Drawing.Color.Transparent;
            this.SwordInv.Image = ((System.Drawing.Image)(resources.GetObject("SwordInv.Image")));
            this.SwordInv.Location = new System.Drawing.Point(119, 515);
            this.SwordInv.Name = "SwordInv";
            this.SwordInv.Size = new System.Drawing.Size(50, 50);
            this.SwordInv.TabIndex = 16;
            this.SwordInv.TabStop = false;
            this.SwordInv.Visible = false;
            this.SwordInv.Click += new System.EventHandler(this.SwordInv_Click);
            // 
            // BowInv
            // 
            this.BowInv.BackColor = System.Drawing.Color.Transparent;
            this.BowInv.Image = global::The_Quest.Properties.Resources.bow;
            this.BowInv.Location = new System.Drawing.Point(192, 515);
            this.BowInv.Name = "BowInv";
            this.BowInv.Size = new System.Drawing.Size(50, 50);
            this.BowInv.TabIndex = 17;
            this.BowInv.TabStop = false;
            this.BowInv.Visible = false;
            this.BowInv.Click += new System.EventHandler(this.BowInv_Click);
            // 
            // MaceInv
            // 
            this.MaceInv.BackColor = System.Drawing.Color.Transparent;
            this.MaceInv.Image = ((System.Drawing.Image)(resources.GetObject("MaceInv.Image")));
            this.MaceInv.Location = new System.Drawing.Point(258, 515);
            this.MaceInv.Name = "MaceInv";
            this.MaceInv.Size = new System.Drawing.Size(50, 50);
            this.MaceInv.TabIndex = 18;
            this.MaceInv.TabStop = false;
            this.MaceInv.Visible = false;
            this.MaceInv.Click += new System.EventHandler(this.MaceInv_Click);
            // 
            // BluePotionInv
            // 
            this.BluePotionInv.BackColor = System.Drawing.Color.Transparent;
            this.BluePotionInv.Image = ((System.Drawing.Image)(resources.GetObject("BluePotionInv.Image")));
            this.BluePotionInv.Location = new System.Drawing.Point(327, 515);
            this.BluePotionInv.Name = "BluePotionInv";
            this.BluePotionInv.Size = new System.Drawing.Size(50, 50);
            this.BluePotionInv.TabIndex = 19;
            this.BluePotionInv.TabStop = false;
            this.BluePotionInv.Visible = false;
            this.BluePotionInv.Click += new System.EventHandler(this.BluePotionInv_Click);
            // 
            // RedPotionInv
            // 
            this.RedPotionInv.BackColor = System.Drawing.Color.Transparent;
            this.RedPotionInv.Image = ((System.Drawing.Image)(resources.GetObject("RedPotionInv.Image")));
            this.RedPotionInv.Location = new System.Drawing.Point(398, 515);
            this.RedPotionInv.Name = "RedPotionInv";
            this.RedPotionInv.Size = new System.Drawing.Size(50, 50);
            this.RedPotionInv.TabIndex = 20;
            this.RedPotionInv.TabStop = false;
            this.RedPotionInv.Visible = false;
            this.RedPotionInv.Click += new System.EventHandler(this.RedPotionInv_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(905, 645);
            this.Controls.Add(this.player);
            this.Controls.Add(this.bat);
            this.Controls.Add(this.ghost);
            this.Controls.Add(this.ghoul);
            this.Controls.Add(this.RedPotionInv);
            this.Controls.Add(this.BluePotionInv);
            this.Controls.Add(this.MaceInv);
            this.Controls.Add(this.BowInv);
            this.Controls.Add(this.SwordInv);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.redPotion);
            this.Controls.Add(this.sword);
            this.Controls.Add(this.bow);
            this.Controls.Add(this.mace);
            this.Controls.Add(this.bluePotion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "The Quest";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghoul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotion)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.redPotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwordInv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BowInv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaceInv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BluePotionInv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedPotionInv)).EndInit();
            this.ResumeLayout(false);

        }

       

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox bat;
        private System.Windows.Forms.PictureBox ghost;
        private System.Windows.Forms.PictureBox ghoul;
        private System.Windows.Forms.PictureBox bluePotion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label playerHitPoints;
        private System.Windows.Forms.Label batHitPoints;
        private System.Windows.Forms.Label ghostHitPoints;
        private System.Windows.Forms.Label ghoulHitPoints;
        private System.Windows.Forms.Button moveDown;
        private System.Windows.Forms.Button moveRight;
        private System.Windows.Forms.Button moveLeft;
        private System.Windows.Forms.Button moveUp;
        private System.Windows.Forms.Button attackDown;
        private System.Windows.Forms.Button attackRight;
        private System.Windows.Forms.Button attackLeft;
        private System.Windows.Forms.Button attackUp;
        private System.Windows.Forms.PictureBox redPotion;
        private System.Windows.Forms.PictureBox sword;
        private System.Windows.Forms.PictureBox bow;
        private System.Windows.Forms.PictureBox mace;
        private System.Windows.Forms.PictureBox SwordInv;
        private System.Windows.Forms.PictureBox BowInv;
        private System.Windows.Forms.PictureBox MaceInv;
        private System.Windows.Forms.PictureBox BluePotionInv;
        private System.Windows.Forms.PictureBox RedPotionInv;
        private System.Windows.Forms.Timer timer1;
    }
}

