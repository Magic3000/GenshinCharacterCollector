
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GenshinCharacterCollector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.expBookLabel = new System.Windows.Forms.Label();
            this.expBookPlusButton = new System.Windows.Forms.Button();
            this.expBookMinusButton = new System.Windows.Forms.Button();
            this.expBookTimeLeft = new System.Windows.Forms.Label();
            this.bossItemMinusButton = new System.Windows.Forms.Button();
            this.bossItemPlusButton = new System.Windows.Forms.Button();
            this.bossItemsLabel = new System.Windows.Forms.Label();
            this.flowerMinusButton = new System.Windows.Forms.Button();
            this.flowerPlusButton = new System.Windows.Forms.Button();
            this.flowersLabel = new System.Windows.Forms.Label();
            this.goldGemMinusButton = new System.Windows.Forms.Button();
            this.goldGemPlusButton = new System.Windows.Forms.Button();
            this.goldGemLabel = new System.Windows.Forms.Label();
            this.purpleGemMinusButton = new System.Windows.Forms.Button();
            this.purpleGemPlusButton = new System.Windows.Forms.Button();
            this.purpleGemLabel = new System.Windows.Forms.Label();
            this.thirdMaterialMinusButton = new System.Windows.Forms.Button();
            this.thirdMaterialPlusButton = new System.Windows.Forms.Button();
            this.thirdMaterialLabel = new System.Windows.Forms.Label();
            this.firstMaterialMinusButton = new System.Windows.Forms.Button();
            this.firstMaterialPlusButton = new System.Windows.Forms.Button();
            this.firstMaterialLabel = new System.Windows.Forms.Label();
            this.greenGemMinusButton = new System.Windows.Forms.Button();
            this.greenGemPlusButton = new System.Windows.Forms.Button();
            this.greenGemLabel = new System.Windows.Forms.Label();
            this.blueGemMinusButton = new System.Windows.Forms.Button();
            this.blueGemPlusButton = new System.Windows.Forms.Button();
            this.blueGemLabel = new System.Windows.Forms.Label();
            this.secondMaterialMinusButton = new System.Windows.Forms.Button();
            this.secondMaterialPlusButton = new System.Windows.Forms.Button();
            this.secondMaterialLabel = new System.Windows.Forms.Label();
            this.changeLang = new System.Windows.Forms.Button();
            this.firstMaterialImage = new System.Windows.Forms.PictureBox();
            this.greenGemImage = new System.Windows.Forms.PictureBox();
            this.blueGemImage = new System.Windows.Forms.PictureBox();
            this.secondMaterialImage = new System.Windows.Forms.PictureBox();
            this.thirdMaterialImage = new System.Windows.Forms.PictureBox();
            this.purpleGemImage = new System.Windows.Forms.PictureBox();
            this.goldGemImage = new System.Windows.Forms.PictureBox();
            this.flowerImage = new System.Windows.Forms.PictureBox();
            this.bossItemImage = new System.Windows.Forms.PictureBox();
            this.expBooxImage = new System.Windows.Forms.PictureBox();
            this.characterImage = new System.Windows.Forms.PictureBox();
            this.charactersDropMenu = new System.Windows.Forms.ComboBox();
            this.firstTalentMaterialMinusButton = new System.Windows.Forms.Button();
            this.firstTalentMaterialPlusButton = new System.Windows.Forms.Button();
            this.firstTalentMaterialLabel = new System.Windows.Forms.Label();
            this.firstTalentMaterialImage = new System.Windows.Forms.PictureBox();
            this.greenTalentMinusButton = new System.Windows.Forms.Button();
            this.greenTalentPlusButton = new System.Windows.Forms.Button();
            this.greenTalentLabel = new System.Windows.Forms.Label();
            this.greenTalentImage = new System.Windows.Forms.PictureBox();
            this.blueTalentMinusButton = new System.Windows.Forms.Button();
            this.blueTalentPlusButton = new System.Windows.Forms.Button();
            this.blueTalentLabel = new System.Windows.Forms.Label();
            this.blueTalentImage = new System.Windows.Forms.PictureBox();
            this.secondTalentMaterialMinusButton = new System.Windows.Forms.Button();
            this.secondTalentMaterialPlusButton = new System.Windows.Forms.Button();
            this.secondTalentMaterialLabel = new System.Windows.Forms.Label();
            this.secondTalentMaterialImage = new System.Windows.Forms.PictureBox();
            this.thirdTalentMaterialMinusButton = new System.Windows.Forms.Button();
            this.thirdTalentMaterialPlusButton = new System.Windows.Forms.Button();
            this.thirdTalentMaterialLabel = new System.Windows.Forms.Label();
            this.thirdTalentMaterialImage = new System.Windows.Forms.PictureBox();
            this.purpleTalentMinusButton = new System.Windows.Forms.Button();
            this.purpleTalentPlusButton = new System.Windows.Forms.Button();
            this.purpleTalentLabel = new System.Windows.Forms.Label();
            this.purpleTalentImage = new System.Windows.Forms.PictureBox();
            this.crownMinusButton = new System.Windows.Forms.Button();
            this.crownPlusButton = new System.Windows.Forms.Button();
            this.crownLabel = new System.Windows.Forms.Label();
            this.crownImage = new System.Windows.Forms.PictureBox();
            this.talentBossItemMinusButton = new System.Windows.Forms.Button();
            this.talentBossItemPlusButton = new System.Windows.Forms.Button();
            this.talentBossItemLabel = new System.Windows.Forms.Label();
            this.talentBossItemImage = new System.Windows.Forms.PictureBox();
            this.calculateChanceText = new System.Windows.Forms.TextBox();
            this.calculateChanceButton = new System.Windows.Forms.Button();
            this.calculateChanceLabel = new System.Windows.Forms.Label();
            this.moraText = new System.Windows.Forms.TextBox();
            this.moraLabel = new System.Windows.Forms.Label();
            this.moraTypeDropMenu = new System.Windows.Forms.ComboBox();
            this.moraTimeLeft = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.firstMaterialImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenGemImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueGemImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondMaterialImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdMaterialImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purpleGemImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldGemImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowerImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bossItemImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expBooxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstTalentMaterialImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTalentImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueTalentImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondTalentMaterialImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdTalentMaterialImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purpleTalentImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crownImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.talentBossItemImage)).BeginInit();
            this.SuspendLayout();
            // 
            // expBookLabel
            // 
            this.expBookLabel.AutoSize = true;
            this.expBookLabel.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.expBookLabel.Location = new System.Drawing.Point(1588, 703);
            this.expBookLabel.Name = "expBookLabel";
            this.expBookLabel.Size = new System.Drawing.Size(99, 39);
            this.expBookLabel.TabIndex = 4;
            this.expBookLabel.Text = "0/432";
            this.expBookLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // expBookPlusButton
            // 
            this.expBookPlusButton.BackColor = System.Drawing.Color.White;
            this.expBookPlusButton.FlatAppearance.BorderSize = 0;
            this.expBookPlusButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.expBookPlusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.expBookPlusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expBookPlusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.expBookPlusButton.ForeColor = System.Drawing.Color.Black;
            this.expBookPlusButton.Location = new System.Drawing.Point(1693, 599);
            this.expBookPlusButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.expBookPlusButton.Name = "expBookPlusButton";
            this.expBookPlusButton.Size = new System.Drawing.Size(50, 50);
            this.expBookPlusButton.TabIndex = 5;
            this.expBookPlusButton.Text = "+";
            this.expBookPlusButton.UseVisualStyleBackColor = false;
            this.expBookPlusButton.Click += new System.EventHandler(this.expBookPlusButton_Click);
            // 
            // expBookMinusButton
            // 
            this.expBookMinusButton.BackColor = System.Drawing.Color.White;
            this.expBookMinusButton.FlatAppearance.BorderSize = 0;
            this.expBookMinusButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.expBookMinusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.expBookMinusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expBookMinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.expBookMinusButton.ForeColor = System.Drawing.Color.Black;
            this.expBookMinusButton.Location = new System.Drawing.Point(1693, 649);
            this.expBookMinusButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.expBookMinusButton.Name = "expBookMinusButton";
            this.expBookMinusButton.Size = new System.Drawing.Size(50, 50);
            this.expBookMinusButton.TabIndex = 6;
            this.expBookMinusButton.Text = "-";
            this.expBookMinusButton.UseVisualStyleBackColor = false;
            this.expBookMinusButton.Click += new System.EventHandler(this.expBookMinusButton_Click);
            // 
            // expBookTimeLeft
            // 
            this.expBookTimeLeft.AutoSize = true;
            this.expBookTimeLeft.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.expBookTimeLeft.Location = new System.Drawing.Point(1531, 742);
            this.expBookTimeLeft.Name = "expBookTimeLeft";
            this.expBookTimeLeft.Size = new System.Drawing.Size(119, 39);
            this.expBookTimeLeft.TabIndex = 7;
            this.expBookTimeLeft.Text = "0d 0hrs";
            this.expBookTimeLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bossItemMinusButton
            // 
            this.bossItemMinusButton.BackColor = System.Drawing.Color.White;
            this.bossItemMinusButton.FlatAppearance.BorderSize = 0;
            this.bossItemMinusButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bossItemMinusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bossItemMinusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bossItemMinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.bossItemMinusButton.ForeColor = System.Drawing.Color.Black;
            this.bossItemMinusButton.Location = new System.Drawing.Point(1693, 501);
            this.bossItemMinusButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bossItemMinusButton.Name = "bossItemMinusButton";
            this.bossItemMinusButton.Size = new System.Drawing.Size(50, 50);
            this.bossItemMinusButton.TabIndex = 11;
            this.bossItemMinusButton.Text = "-";
            this.bossItemMinusButton.UseVisualStyleBackColor = false;
            this.bossItemMinusButton.Click += new System.EventHandler(this.bossItemMinusButton_Click);
            // 
            // bossItemPlusButton
            // 
            this.bossItemPlusButton.BackColor = System.Drawing.Color.White;
            this.bossItemPlusButton.FlatAppearance.BorderSize = 0;
            this.bossItemPlusButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bossItemPlusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bossItemPlusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bossItemPlusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.bossItemPlusButton.ForeColor = System.Drawing.Color.Black;
            this.bossItemPlusButton.Location = new System.Drawing.Point(1693, 452);
            this.bossItemPlusButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bossItemPlusButton.Name = "bossItemPlusButton";
            this.bossItemPlusButton.Size = new System.Drawing.Size(50, 50);
            this.bossItemPlusButton.TabIndex = 10;
            this.bossItemPlusButton.Text = "+";
            this.bossItemPlusButton.UseVisualStyleBackColor = false;
            this.bossItemPlusButton.Click += new System.EventHandler(this.bossItemPlusButton_Click);
            // 
            // bossItemsLabel
            // 
            this.bossItemsLabel.AutoSize = true;
            this.bossItemsLabel.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.bossItemsLabel.Location = new System.Drawing.Point(1605, 556);
            this.bossItemsLabel.Name = "bossItemsLabel";
            this.bossItemsLabel.Size = new System.Drawing.Size(82, 39);
            this.bossItemsLabel.TabIndex = 9;
            this.bossItemsLabel.Text = "0/46";
            this.bossItemsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flowerMinusButton
            // 
            this.flowerMinusButton.BackColor = System.Drawing.Color.White;
            this.flowerMinusButton.FlatAppearance.BorderSize = 0;
            this.flowerMinusButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.flowerMinusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.flowerMinusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flowerMinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.flowerMinusButton.ForeColor = System.Drawing.Color.Black;
            this.flowerMinusButton.Location = new System.Drawing.Point(1531, 649);
            this.flowerMinusButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowerMinusButton.Name = "flowerMinusButton";
            this.flowerMinusButton.Size = new System.Drawing.Size(50, 50);
            this.flowerMinusButton.TabIndex = 15;
            this.flowerMinusButton.Text = "-";
            this.flowerMinusButton.UseVisualStyleBackColor = false;
            this.flowerMinusButton.Click += new System.EventHandler(this.flowerMinusButton_Click);
            // 
            // flowerPlusButton
            // 
            this.flowerPlusButton.BackColor = System.Drawing.Color.White;
            this.flowerPlusButton.FlatAppearance.BorderSize = 0;
            this.flowerPlusButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.flowerPlusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.flowerPlusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flowerPlusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.flowerPlusButton.ForeColor = System.Drawing.Color.Black;
            this.flowerPlusButton.Location = new System.Drawing.Point(1531, 599);
            this.flowerPlusButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowerPlusButton.Name = "flowerPlusButton";
            this.flowerPlusButton.Size = new System.Drawing.Size(50, 50);
            this.flowerPlusButton.TabIndex = 14;
            this.flowerPlusButton.Text = "+";
            this.flowerPlusButton.UseVisualStyleBackColor = false;
            this.flowerPlusButton.Click += new System.EventHandler(this.flowerPlusButton_Click);
            // 
            // flowersLabel
            // 
            this.flowersLabel.AutoSize = true;
            this.flowersLabel.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.flowersLabel.Location = new System.Drawing.Point(1430, 703);
            this.flowersLabel.Name = "flowersLabel";
            this.flowersLabel.Size = new System.Drawing.Size(95, 39);
            this.flowersLabel.TabIndex = 13;
            this.flowersLabel.Text = "0/168";
            this.flowersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // goldGemMinusButton
            // 
            this.goldGemMinusButton.BackColor = System.Drawing.Color.White;
            this.goldGemMinusButton.FlatAppearance.BorderSize = 0;
            this.goldGemMinusButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.goldGemMinusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.goldGemMinusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goldGemMinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.goldGemMinusButton.ForeColor = System.Drawing.Color.Black;
            this.goldGemMinusButton.Location = new System.Drawing.Point(1531, 501);
            this.goldGemMinusButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.goldGemMinusButton.Name = "goldGemMinusButton";
            this.goldGemMinusButton.Size = new System.Drawing.Size(50, 50);
            this.goldGemMinusButton.TabIndex = 19;
            this.goldGemMinusButton.Text = "-";
            this.goldGemMinusButton.UseVisualStyleBackColor = false;
            this.goldGemMinusButton.Click += new System.EventHandler(this.goldGemMinusButton_Click);
            // 
            // goldGemPlusButton
            // 
            this.goldGemPlusButton.BackColor = System.Drawing.Color.White;
            this.goldGemPlusButton.FlatAppearance.BorderSize = 0;
            this.goldGemPlusButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.goldGemPlusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.goldGemPlusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goldGemPlusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.goldGemPlusButton.ForeColor = System.Drawing.Color.Black;
            this.goldGemPlusButton.Location = new System.Drawing.Point(1531, 452);
            this.goldGemPlusButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.goldGemPlusButton.Name = "goldGemPlusButton";
            this.goldGemPlusButton.Size = new System.Drawing.Size(50, 50);
            this.goldGemPlusButton.TabIndex = 18;
            this.goldGemPlusButton.Text = "+";
            this.goldGemPlusButton.UseVisualStyleBackColor = false;
            this.goldGemPlusButton.Click += new System.EventHandler(this.goldGemPlusButton_Click);
            // 
            // goldGemLabel
            // 
            this.goldGemLabel.AutoSize = true;
            this.goldGemLabel.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.goldGemLabel.Location = new System.Drawing.Point(1464, 556);
            this.goldGemLabel.Name = "goldGemLabel";
            this.goldGemLabel.Size = new System.Drawing.Size(65, 39);
            this.goldGemLabel.TabIndex = 17;
            this.goldGemLabel.Text = "0/6";
            this.goldGemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // purpleGemMinusButton
            // 
            this.purpleGemMinusButton.BackColor = System.Drawing.Color.White;
            this.purpleGemMinusButton.FlatAppearance.BorderSize = 0;
            this.purpleGemMinusButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.purpleGemMinusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.purpleGemMinusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purpleGemMinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.purpleGemMinusButton.ForeColor = System.Drawing.Color.Black;
            this.purpleGemMinusButton.Location = new System.Drawing.Point(1531, 354);
            this.purpleGemMinusButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.purpleGemMinusButton.Name = "purpleGemMinusButton";
            this.purpleGemMinusButton.Size = new System.Drawing.Size(50, 50);
            this.purpleGemMinusButton.TabIndex = 23;
            this.purpleGemMinusButton.Text = "-";
            this.purpleGemMinusButton.UseVisualStyleBackColor = false;
            this.purpleGemMinusButton.Click += new System.EventHandler(this.purpleGemMinusButton_Click);
            // 
            // purpleGemPlusButton
            // 
            this.purpleGemPlusButton.BackColor = System.Drawing.Color.White;
            this.purpleGemPlusButton.FlatAppearance.BorderSize = 0;
            this.purpleGemPlusButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.purpleGemPlusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.purpleGemPlusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purpleGemPlusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.purpleGemPlusButton.ForeColor = System.Drawing.Color.Black;
            this.purpleGemPlusButton.Location = new System.Drawing.Point(1531, 305);
            this.purpleGemPlusButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.purpleGemPlusButton.Name = "purpleGemPlusButton";
            this.purpleGemPlusButton.Size = new System.Drawing.Size(50, 50);
            this.purpleGemPlusButton.TabIndex = 22;
            this.purpleGemPlusButton.Text = "+";
            this.purpleGemPlusButton.UseVisualStyleBackColor = false;
            this.purpleGemPlusButton.Click += new System.EventHandler(this.purpleGemPlusButton_Click);
            // 
            // purpleGemLabel
            // 
            this.purpleGemLabel.AutoSize = true;
            this.purpleGemLabel.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.purpleGemLabel.Location = new System.Drawing.Point(1460, 409);
            this.purpleGemLabel.Name = "purpleGemLabel";
            this.purpleGemLabel.Size = new System.Drawing.Size(65, 39);
            this.purpleGemLabel.TabIndex = 21;
            this.purpleGemLabel.Text = "0/9";
            this.purpleGemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // thirdMaterialMinusButton
            // 
            this.thirdMaterialMinusButton.BackColor = System.Drawing.Color.White;
            this.thirdMaterialMinusButton.FlatAppearance.BorderSize = 0;
            this.thirdMaterialMinusButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.thirdMaterialMinusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.thirdMaterialMinusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.thirdMaterialMinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.thirdMaterialMinusButton.ForeColor = System.Drawing.Color.Black;
            this.thirdMaterialMinusButton.Location = new System.Drawing.Point(1693, 354);
            this.thirdMaterialMinusButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.thirdMaterialMinusButton.Name = "thirdMaterialMinusButton";
            this.thirdMaterialMinusButton.Size = new System.Drawing.Size(50, 50);
            this.thirdMaterialMinusButton.TabIndex = 27;
            this.thirdMaterialMinusButton.Text = "-";
            this.thirdMaterialMinusButton.UseVisualStyleBackColor = false;
            this.thirdMaterialMinusButton.Click += new System.EventHandler(this.thirdMaterialMinusButton_Click);
            // 
            // thirdMaterialPlusButton
            // 
            this.thirdMaterialPlusButton.BackColor = System.Drawing.Color.White;
            this.thirdMaterialPlusButton.FlatAppearance.BorderSize = 0;
            this.thirdMaterialPlusButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.thirdMaterialPlusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.thirdMaterialPlusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.thirdMaterialPlusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.thirdMaterialPlusButton.ForeColor = System.Drawing.Color.Black;
            this.thirdMaterialPlusButton.Location = new System.Drawing.Point(1693, 305);
            this.thirdMaterialPlusButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.thirdMaterialPlusButton.Name = "thirdMaterialPlusButton";
            this.thirdMaterialPlusButton.Size = new System.Drawing.Size(50, 50);
            this.thirdMaterialPlusButton.TabIndex = 26;
            this.thirdMaterialPlusButton.Text = "+";
            this.thirdMaterialPlusButton.UseVisualStyleBackColor = false;
            this.thirdMaterialPlusButton.Click += new System.EventHandler(this.thirdMaterialPlusButton_Click);
            // 
            // thirdMaterialLabel
            // 
            this.thirdMaterialLabel.AutoSize = true;
            this.thirdMaterialLabel.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.thirdMaterialLabel.Location = new System.Drawing.Point(1605, 409);
            this.thirdMaterialLabel.Name = "thirdMaterialLabel";
            this.thirdMaterialLabel.Size = new System.Drawing.Size(82, 39);
            this.thirdMaterialLabel.TabIndex = 25;
            this.thirdMaterialLabel.Text = "0/36";
            this.thirdMaterialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // firstMaterialMinusButton
            // 
            this.firstMaterialMinusButton.BackColor = System.Drawing.Color.White;
            this.firstMaterialMinusButton.FlatAppearance.BorderSize = 0;
            this.firstMaterialMinusButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.firstMaterialMinusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.firstMaterialMinusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.firstMaterialMinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.firstMaterialMinusButton.ForeColor = System.Drawing.Color.Black;
            this.firstMaterialMinusButton.Location = new System.Drawing.Point(1693, 61);
            this.firstMaterialMinusButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstMaterialMinusButton.Name = "firstMaterialMinusButton";
            this.firstMaterialMinusButton.Size = new System.Drawing.Size(50, 50);
            this.firstMaterialMinusButton.TabIndex = 43;
            this.firstMaterialMinusButton.Text = "-";
            this.firstMaterialMinusButton.UseVisualStyleBackColor = false;
            this.firstMaterialMinusButton.Click += new System.EventHandler(this.firstMaterialMinusButton_Click);
            // 
            // firstMaterialPlusButton
            // 
            this.firstMaterialPlusButton.BackColor = System.Drawing.Color.White;
            this.firstMaterialPlusButton.FlatAppearance.BorderSize = 0;
            this.firstMaterialPlusButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.firstMaterialPlusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.firstMaterialPlusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.firstMaterialPlusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.firstMaterialPlusButton.ForeColor = System.Drawing.Color.Black;
            this.firstMaterialPlusButton.Location = new System.Drawing.Point(1693, 13);
            this.firstMaterialPlusButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstMaterialPlusButton.Name = "firstMaterialPlusButton";
            this.firstMaterialPlusButton.Size = new System.Drawing.Size(50, 50);
            this.firstMaterialPlusButton.TabIndex = 42;
            this.firstMaterialPlusButton.Text = "+";
            this.firstMaterialPlusButton.UseVisualStyleBackColor = false;
            this.firstMaterialPlusButton.Click += new System.EventHandler(this.firstMaterialPlusButton_Click);
            // 
            // firstMaterialLabel
            // 
            this.firstMaterialLabel.AutoSize = true;
            this.firstMaterialLabel.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.firstMaterialLabel.Location = new System.Drawing.Point(1609, 116);
            this.firstMaterialLabel.Name = "firstMaterialLabel";
            this.firstMaterialLabel.Size = new System.Drawing.Size(78, 39);
            this.firstMaterialLabel.TabIndex = 41;
            this.firstMaterialLabel.Text = "0/18";
            this.firstMaterialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // greenGemMinusButton
            // 
            this.greenGemMinusButton.BackColor = System.Drawing.Color.White;
            this.greenGemMinusButton.FlatAppearance.BorderSize = 0;
            this.greenGemMinusButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.greenGemMinusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.greenGemMinusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.greenGemMinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.greenGemMinusButton.ForeColor = System.Drawing.Color.Black;
            this.greenGemMinusButton.Location = new System.Drawing.Point(1531, 61);
            this.greenGemMinusButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.greenGemMinusButton.Name = "greenGemMinusButton";
            this.greenGemMinusButton.Size = new System.Drawing.Size(50, 50);
            this.greenGemMinusButton.TabIndex = 39;
            this.greenGemMinusButton.Text = "-";
            this.greenGemMinusButton.UseVisualStyleBackColor = false;
            this.greenGemMinusButton.Click += new System.EventHandler(this.greenGemMinusButton_Click);
            // 
            // greenGemPlusButton
            // 
            this.greenGemPlusButton.BackColor = System.Drawing.Color.White;
            this.greenGemPlusButton.FlatAppearance.BorderSize = 0;
            this.greenGemPlusButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.greenGemPlusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.greenGemPlusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.greenGemPlusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.greenGemPlusButton.ForeColor = System.Drawing.Color.Black;
            this.greenGemPlusButton.Location = new System.Drawing.Point(1531, 13);
            this.greenGemPlusButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.greenGemPlusButton.Name = "greenGemPlusButton";
            this.greenGemPlusButton.Size = new System.Drawing.Size(50, 50);
            this.greenGemPlusButton.TabIndex = 38;
            this.greenGemPlusButton.Text = "+";
            this.greenGemPlusButton.UseVisualStyleBackColor = false;
            this.greenGemPlusButton.Click += new System.EventHandler(this.greenGemPlusButton_Click);
            // 
            // greenGemLabel
            // 
            this.greenGemLabel.AutoSize = true;
            this.greenGemLabel.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.greenGemLabel.Location = new System.Drawing.Point(1464, 116);
            this.greenGemLabel.Name = "greenGemLabel";
            this.greenGemLabel.Size = new System.Drawing.Size(61, 39);
            this.greenGemLabel.TabIndex = 37;
            this.greenGemLabel.Text = "0/1";
            this.greenGemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // blueGemMinusButton
            // 
            this.blueGemMinusButton.BackColor = System.Drawing.Color.White;
            this.blueGemMinusButton.FlatAppearance.BorderSize = 0;
            this.blueGemMinusButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.blueGemMinusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.blueGemMinusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blueGemMinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.blueGemMinusButton.ForeColor = System.Drawing.Color.Black;
            this.blueGemMinusButton.Location = new System.Drawing.Point(1531, 208);
            this.blueGemMinusButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.blueGemMinusButton.Name = "blueGemMinusButton";
            this.blueGemMinusButton.Size = new System.Drawing.Size(50, 50);
            this.blueGemMinusButton.TabIndex = 35;
            this.blueGemMinusButton.Text = "-";
            this.blueGemMinusButton.UseVisualStyleBackColor = false;
            this.blueGemMinusButton.Click += new System.EventHandler(this.blueGemMinusButton_Click);
            // 
            // blueGemPlusButton
            // 
            this.blueGemPlusButton.BackColor = System.Drawing.Color.White;
            this.blueGemPlusButton.FlatAppearance.BorderSize = 0;
            this.blueGemPlusButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.blueGemPlusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.blueGemPlusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blueGemPlusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.blueGemPlusButton.ForeColor = System.Drawing.Color.Black;
            this.blueGemPlusButton.Location = new System.Drawing.Point(1531, 159);
            this.blueGemPlusButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.blueGemPlusButton.Name = "blueGemPlusButton";
            this.blueGemPlusButton.Size = new System.Drawing.Size(50, 50);
            this.blueGemPlusButton.TabIndex = 34;
            this.blueGemPlusButton.Text = "+";
            this.blueGemPlusButton.UseVisualStyleBackColor = false;
            this.blueGemPlusButton.Click += new System.EventHandler(this.blueGemPlusButton_Click);
            // 
            // blueGemLabel
            // 
            this.blueGemLabel.AutoSize = true;
            this.blueGemLabel.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.blueGemLabel.Location = new System.Drawing.Point(1460, 262);
            this.blueGemLabel.Name = "blueGemLabel";
            this.blueGemLabel.Size = new System.Drawing.Size(65, 39);
            this.blueGemLabel.TabIndex = 33;
            this.blueGemLabel.Text = "0/9";
            this.blueGemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // secondMaterialMinusButton
            // 
            this.secondMaterialMinusButton.BackColor = System.Drawing.Color.White;
            this.secondMaterialMinusButton.FlatAppearance.BorderSize = 0;
            this.secondMaterialMinusButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.secondMaterialMinusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.secondMaterialMinusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.secondMaterialMinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.secondMaterialMinusButton.ForeColor = System.Drawing.Color.Black;
            this.secondMaterialMinusButton.Location = new System.Drawing.Point(1693, 208);
            this.secondMaterialMinusButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.secondMaterialMinusButton.Name = "secondMaterialMinusButton";
            this.secondMaterialMinusButton.Size = new System.Drawing.Size(50, 50);
            this.secondMaterialMinusButton.TabIndex = 31;
            this.secondMaterialMinusButton.Text = "-";
            this.secondMaterialMinusButton.UseVisualStyleBackColor = false;
            this.secondMaterialMinusButton.Click += new System.EventHandler(this.secondMaterialMinusButton_Click);
            // 
            // secondMaterialPlusButton
            // 
            this.secondMaterialPlusButton.BackColor = System.Drawing.Color.White;
            this.secondMaterialPlusButton.FlatAppearance.BorderSize = 0;
            this.secondMaterialPlusButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.secondMaterialPlusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.secondMaterialPlusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.secondMaterialPlusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.secondMaterialPlusButton.ForeColor = System.Drawing.Color.Black;
            this.secondMaterialPlusButton.Location = new System.Drawing.Point(1693, 159);
            this.secondMaterialPlusButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.secondMaterialPlusButton.Name = "secondMaterialPlusButton";
            this.secondMaterialPlusButton.Size = new System.Drawing.Size(50, 50);
            this.secondMaterialPlusButton.TabIndex = 30;
            this.secondMaterialPlusButton.Text = "+";
            this.secondMaterialPlusButton.UseVisualStyleBackColor = false;
            this.secondMaterialPlusButton.Click += new System.EventHandler(this.secondMaterialPlusButton_Click);
            // 
            // secondMaterialLabel
            // 
            this.secondMaterialLabel.AutoSize = true;
            this.secondMaterialLabel.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.secondMaterialLabel.Location = new System.Drawing.Point(1605, 262);
            this.secondMaterialLabel.Name = "secondMaterialLabel";
            this.secondMaterialLabel.Size = new System.Drawing.Size(82, 39);
            this.secondMaterialLabel.TabIndex = 29;
            this.secondMaterialLabel.Text = "0/30";
            this.secondMaterialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // changeLang
            // 
            this.changeLang.BackColor = System.Drawing.Color.Transparent;
            this.changeLang.FlatAppearance.BorderSize = 0;
            this.changeLang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.changeLang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.changeLang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeLang.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.changeLang.ForeColor = System.Drawing.Color.Black;
            this.changeLang.Location = new System.Drawing.Point(24, 825);
            this.changeLang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.changeLang.Name = "changeLang";
            this.changeLang.Size = new System.Drawing.Size(180, 53);
            this.changeLang.TabIndex = 45;
            this.changeLang.Text = "Eng";
            this.changeLang.UseVisualStyleBackColor = false;
            this.changeLang.Click += new System.EventHandler(this.changeLang_Click);
            // 
            // firstMaterialImage
            // 
            this.firstMaterialImage.BackColor = System.Drawing.Color.Transparent;
            this.firstMaterialImage.Location = new System.Drawing.Point(1587, 12);
            this.firstMaterialImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstMaterialImage.Name = "firstMaterialImage";
            this.firstMaterialImage.Size = new System.Drawing.Size(100, 100);
            this.firstMaterialImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.firstMaterialImage.TabIndex = 40;
            this.firstMaterialImage.TabStop = false;
            // 
            // greenGemImage
            // 
            this.greenGemImage.BackColor = System.Drawing.Color.Transparent;
            this.greenGemImage.Location = new System.Drawing.Point(1425, 12);
            this.greenGemImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.greenGemImage.Name = "greenGemImage";
            this.greenGemImage.Size = new System.Drawing.Size(100, 100);
            this.greenGemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.greenGemImage.TabIndex = 36;
            this.greenGemImage.TabStop = false;
            // 
            // blueGemImage
            // 
            this.blueGemImage.BackColor = System.Drawing.Color.Transparent;
            this.blueGemImage.Location = new System.Drawing.Point(1425, 159);
            this.blueGemImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.blueGemImage.Name = "blueGemImage";
            this.blueGemImage.Size = new System.Drawing.Size(100, 100);
            this.blueGemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.blueGemImage.TabIndex = 32;
            this.blueGemImage.TabStop = false;
            // 
            // secondMaterialImage
            // 
            this.secondMaterialImage.BackColor = System.Drawing.Color.Transparent;
            this.secondMaterialImage.Location = new System.Drawing.Point(1587, 159);
            this.secondMaterialImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.secondMaterialImage.Name = "secondMaterialImage";
            this.secondMaterialImage.Size = new System.Drawing.Size(100, 100);
            this.secondMaterialImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.secondMaterialImage.TabIndex = 28;
            this.secondMaterialImage.TabStop = false;
            // 
            // thirdMaterialImage
            // 
            this.thirdMaterialImage.BackColor = System.Drawing.Color.Transparent;
            this.thirdMaterialImage.Location = new System.Drawing.Point(1587, 305);
            this.thirdMaterialImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.thirdMaterialImage.Name = "thirdMaterialImage";
            this.thirdMaterialImage.Size = new System.Drawing.Size(100, 100);
            this.thirdMaterialImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.thirdMaterialImage.TabIndex = 24;
            this.thirdMaterialImage.TabStop = false;
            // 
            // purpleGemImage
            // 
            this.purpleGemImage.BackColor = System.Drawing.Color.Transparent;
            this.purpleGemImage.Location = new System.Drawing.Point(1425, 305);
            this.purpleGemImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.purpleGemImage.Name = "purpleGemImage";
            this.purpleGemImage.Size = new System.Drawing.Size(100, 100);
            this.purpleGemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.purpleGemImage.TabIndex = 20;
            this.purpleGemImage.TabStop = false;
            // 
            // goldGemImage
            // 
            this.goldGemImage.BackColor = System.Drawing.Color.Transparent;
            this.goldGemImage.Location = new System.Drawing.Point(1425, 452);
            this.goldGemImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.goldGemImage.Name = "goldGemImage";
            this.goldGemImage.Size = new System.Drawing.Size(100, 100);
            this.goldGemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.goldGemImage.TabIndex = 16;
            this.goldGemImage.TabStop = false;
            // 
            // flowerImage
            // 
            this.flowerImage.BackColor = System.Drawing.Color.Transparent;
            this.flowerImage.Location = new System.Drawing.Point(1425, 599);
            this.flowerImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowerImage.Name = "flowerImage";
            this.flowerImage.Size = new System.Drawing.Size(100, 100);
            this.flowerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.flowerImage.TabIndex = 12;
            this.flowerImage.TabStop = false;
            // 
            // bossItemImage
            // 
            this.bossItemImage.BackColor = System.Drawing.Color.Transparent;
            this.bossItemImage.Location = new System.Drawing.Point(1587, 452);
            this.bossItemImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bossItemImage.Name = "bossItemImage";
            this.bossItemImage.Size = new System.Drawing.Size(100, 100);
            this.bossItemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bossItemImage.TabIndex = 8;
            this.bossItemImage.TabStop = false;
            // 
            // expBooxImage
            // 
            this.expBooxImage.BackColor = System.Drawing.Color.Transparent;
            this.expBooxImage.Location = new System.Drawing.Point(1587, 599);
            this.expBooxImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.expBooxImage.Name = "expBooxImage";
            this.expBooxImage.Size = new System.Drawing.Size(100, 100);
            this.expBooxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.expBooxImage.TabIndex = 3;
            this.expBooxImage.TabStop = false;
            // 
            // characterImage
            // 
            this.characterImage.Image = global::GenshinCharacterCollector.Properties.Resources._2021_03_02_MomentOfBloom;
            this.characterImage.Location = new System.Drawing.Point(195, 12);
            this.characterImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.characterImage.Name = "characterImage";
            this.characterImage.Size = new System.Drawing.Size(0, 0);
            this.characterImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.characterImage.TabIndex = 1;
            this.characterImage.TabStop = false;
            // 
            // charactersDropMenu
            // 
            this.charactersDropMenu.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.charactersDropMenu.FormattingEnabled = true;
            this.charactersDropMenu.Items.AddRange(new object[] {
            "Hu-Tao",
            "Xiao",
            "Ganyu"});
            this.charactersDropMenu.Location = new System.Drawing.Point(24, 12);
            this.charactersDropMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.charactersDropMenu.Name = "charactersDropMenu";
            this.charactersDropMenu.Size = new System.Drawing.Size(180, 47);
            this.charactersDropMenu.TabIndex = 46;
            this.charactersDropMenu.Text = "Characters";
            this.charactersDropMenu.SelectedIndexChanged += new System.EventHandler(this.charactersDropMenu_SelectedIndexChanged);
            // 
            // firstTalentMaterialMinusButton
            // 
            this.firstTalentMaterialMinusButton.BackColor = System.Drawing.Color.White;
            this.firstTalentMaterialMinusButton.FlatAppearance.BorderSize = 0;
            this.firstTalentMaterialMinusButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.firstTalentMaterialMinusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.firstTalentMaterialMinusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.firstTalentMaterialMinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.firstTalentMaterialMinusButton.ForeColor = System.Drawing.Color.Black;
            this.firstTalentMaterialMinusButton.Location = new System.Drawing.Point(329, 795);
            this.firstTalentMaterialMinusButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstTalentMaterialMinusButton.Name = "firstTalentMaterialMinusButton";
            this.firstTalentMaterialMinusButton.Size = new System.Drawing.Size(50, 50);
            this.firstTalentMaterialMinusButton.TabIndex = 86;
            this.firstTalentMaterialMinusButton.Text = "-";
            this.firstTalentMaterialMinusButton.UseVisualStyleBackColor = false;
            this.firstTalentMaterialMinusButton.Click += new System.EventHandler(this.firstTalentMaterialMinusButton_Click);
            // 
            // firstTalentMaterialPlusButton
            // 
            this.firstTalentMaterialPlusButton.BackColor = System.Drawing.Color.White;
            this.firstTalentMaterialPlusButton.FlatAppearance.BorderSize = 0;
            this.firstTalentMaterialPlusButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.firstTalentMaterialPlusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.firstTalentMaterialPlusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.firstTalentMaterialPlusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.firstTalentMaterialPlusButton.ForeColor = System.Drawing.Color.Black;
            this.firstTalentMaterialPlusButton.Location = new System.Drawing.Point(329, 747);
            this.firstTalentMaterialPlusButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstTalentMaterialPlusButton.Name = "firstTalentMaterialPlusButton";
            this.firstTalentMaterialPlusButton.Size = new System.Drawing.Size(50, 50);
            this.firstTalentMaterialPlusButton.TabIndex = 85;
            this.firstTalentMaterialPlusButton.Text = "+";
            this.firstTalentMaterialPlusButton.UseVisualStyleBackColor = false;
            this.firstTalentMaterialPlusButton.Click += new System.EventHandler(this.firstTalentMaterialPlusButton_Click);
            // 
            // firstTalentMaterialLabel
            // 
            this.firstTalentMaterialLabel.AutoSize = true;
            this.firstTalentMaterialLabel.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.firstTalentMaterialLabel.Location = new System.Drawing.Point(245, 850);
            this.firstTalentMaterialLabel.Name = "firstTalentMaterialLabel";
            this.firstTalentMaterialLabel.Size = new System.Drawing.Size(78, 39);
            this.firstTalentMaterialLabel.TabIndex = 84;
            this.firstTalentMaterialLabel.Text = "0/18";
            this.firstTalentMaterialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // firstTalentMaterialImage
            // 
            this.firstTalentMaterialImage.BackColor = System.Drawing.Color.Transparent;
            this.firstTalentMaterialImage.Location = new System.Drawing.Point(223, 746);
            this.firstTalentMaterialImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstTalentMaterialImage.Name = "firstTalentMaterialImage";
            this.firstTalentMaterialImage.Size = new System.Drawing.Size(100, 100);
            this.firstTalentMaterialImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.firstTalentMaterialImage.TabIndex = 83;
            this.firstTalentMaterialImage.TabStop = false;
            // 
            // greenTalentMinusButton
            // 
            this.greenTalentMinusButton.BackColor = System.Drawing.Color.White;
            this.greenTalentMinusButton.FlatAppearance.BorderSize = 0;
            this.greenTalentMinusButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.greenTalentMinusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.greenTalentMinusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.greenTalentMinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.greenTalentMinusButton.ForeColor = System.Drawing.Color.Black;
            this.greenTalentMinusButton.Location = new System.Drawing.Point(329, 648);
            this.greenTalentMinusButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.greenTalentMinusButton.Name = "greenTalentMinusButton";
            this.greenTalentMinusButton.Size = new System.Drawing.Size(50, 50);
            this.greenTalentMinusButton.TabIndex = 82;
            this.greenTalentMinusButton.Text = "-";
            this.greenTalentMinusButton.UseVisualStyleBackColor = false;
            this.greenTalentMinusButton.Click += new System.EventHandler(this.greenTalentMinusButton_Click);
            // 
            // greenTalentPlusButton
            // 
            this.greenTalentPlusButton.BackColor = System.Drawing.Color.White;
            this.greenTalentPlusButton.FlatAppearance.BorderSize = 0;
            this.greenTalentPlusButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.greenTalentPlusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.greenTalentPlusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.greenTalentPlusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.greenTalentPlusButton.ForeColor = System.Drawing.Color.Black;
            this.greenTalentPlusButton.Location = new System.Drawing.Point(329, 600);
            this.greenTalentPlusButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.greenTalentPlusButton.Name = "greenTalentPlusButton";
            this.greenTalentPlusButton.Size = new System.Drawing.Size(50, 50);
            this.greenTalentPlusButton.TabIndex = 81;
            this.greenTalentPlusButton.Text = "+";
            this.greenTalentPlusButton.UseVisualStyleBackColor = false;
            this.greenTalentPlusButton.Click += new System.EventHandler(this.greenTalentPlusButton_Click);
            // 
            // greenTalentLabel
            // 
            this.greenTalentLabel.AutoSize = true;
            this.greenTalentLabel.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.greenTalentLabel.Location = new System.Drawing.Point(258, 703);
            this.greenTalentLabel.Name = "greenTalentLabel";
            this.greenTalentLabel.Size = new System.Drawing.Size(65, 39);
            this.greenTalentLabel.TabIndex = 80;
            this.greenTalentLabel.Text = "0/9";
            this.greenTalentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // greenTalentImage
            // 
            this.greenTalentImage.BackColor = System.Drawing.Color.Transparent;
            this.greenTalentImage.Location = new System.Drawing.Point(223, 599);
            this.greenTalentImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.greenTalentImage.Name = "greenTalentImage";
            this.greenTalentImage.Size = new System.Drawing.Size(100, 100);
            this.greenTalentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.greenTalentImage.TabIndex = 79;
            this.greenTalentImage.TabStop = false;
            // 
            // blueTalentMinusButton
            // 
            this.blueTalentMinusButton.BackColor = System.Drawing.Color.White;
            this.blueTalentMinusButton.FlatAppearance.BorderSize = 0;
            this.blueTalentMinusButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.blueTalentMinusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.blueTalentMinusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blueTalentMinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.blueTalentMinusButton.ForeColor = System.Drawing.Color.Black;
            this.blueTalentMinusButton.Location = new System.Drawing.Point(491, 648);
            this.blueTalentMinusButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.blueTalentMinusButton.Name = "blueTalentMinusButton";
            this.blueTalentMinusButton.Size = new System.Drawing.Size(50, 50);
            this.blueTalentMinusButton.TabIndex = 78;
            this.blueTalentMinusButton.Text = "-";
            this.blueTalentMinusButton.UseVisualStyleBackColor = false;
            this.blueTalentMinusButton.Click += new System.EventHandler(this.blueTalentMinusButton_Click);
            // 
            // blueTalentPlusButton
            // 
            this.blueTalentPlusButton.BackColor = System.Drawing.Color.White;
            this.blueTalentPlusButton.FlatAppearance.BorderSize = 0;
            this.blueTalentPlusButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.blueTalentPlusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.blueTalentPlusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blueTalentPlusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.blueTalentPlusButton.ForeColor = System.Drawing.Color.Black;
            this.blueTalentPlusButton.Location = new System.Drawing.Point(491, 599);
            this.blueTalentPlusButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.blueTalentPlusButton.Name = "blueTalentPlusButton";
            this.blueTalentPlusButton.Size = new System.Drawing.Size(50, 50);
            this.blueTalentPlusButton.TabIndex = 77;
            this.blueTalentPlusButton.Text = "+";
            this.blueTalentPlusButton.UseVisualStyleBackColor = false;
            this.blueTalentPlusButton.Click += new System.EventHandler(this.blueTalentPlusButton_Click);
            // 
            // blueTalentLabel
            // 
            this.blueTalentLabel.AutoSize = true;
            this.blueTalentLabel.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.blueTalentLabel.Location = new System.Drawing.Point(403, 703);
            this.blueTalentLabel.Name = "blueTalentLabel";
            this.blueTalentLabel.Size = new System.Drawing.Size(82, 39);
            this.blueTalentLabel.TabIndex = 76;
            this.blueTalentLabel.Text = "0/63";
            this.blueTalentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // blueTalentImage
            // 
            this.blueTalentImage.BackColor = System.Drawing.Color.Transparent;
            this.blueTalentImage.Location = new System.Drawing.Point(385, 599);
            this.blueTalentImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.blueTalentImage.Name = "blueTalentImage";
            this.blueTalentImage.Size = new System.Drawing.Size(100, 100);
            this.blueTalentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.blueTalentImage.TabIndex = 75;
            this.blueTalentImage.TabStop = false;
            // 
            // secondTalentMaterialMinusButton
            // 
            this.secondTalentMaterialMinusButton.BackColor = System.Drawing.Color.White;
            this.secondTalentMaterialMinusButton.FlatAppearance.BorderSize = 0;
            this.secondTalentMaterialMinusButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.secondTalentMaterialMinusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.secondTalentMaterialMinusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.secondTalentMaterialMinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.secondTalentMaterialMinusButton.ForeColor = System.Drawing.Color.Black;
            this.secondTalentMaterialMinusButton.Location = new System.Drawing.Point(491, 795);
            this.secondTalentMaterialMinusButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.secondTalentMaterialMinusButton.Name = "secondTalentMaterialMinusButton";
            this.secondTalentMaterialMinusButton.Size = new System.Drawing.Size(50, 50);
            this.secondTalentMaterialMinusButton.TabIndex = 74;
            this.secondTalentMaterialMinusButton.Text = "-";
            this.secondTalentMaterialMinusButton.UseVisualStyleBackColor = false;
            this.secondTalentMaterialMinusButton.Click += new System.EventHandler(this.secondTalentMaterialMinusButton_Click);
            // 
            // secondTalentMaterialPlusButton
            // 
            this.secondTalentMaterialPlusButton.BackColor = System.Drawing.Color.White;
            this.secondTalentMaterialPlusButton.FlatAppearance.BorderSize = 0;
            this.secondTalentMaterialPlusButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.secondTalentMaterialPlusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.secondTalentMaterialPlusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.secondTalentMaterialPlusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.secondTalentMaterialPlusButton.ForeColor = System.Drawing.Color.Black;
            this.secondTalentMaterialPlusButton.Location = new System.Drawing.Point(491, 746);
            this.secondTalentMaterialPlusButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.secondTalentMaterialPlusButton.Name = "secondTalentMaterialPlusButton";
            this.secondTalentMaterialPlusButton.Size = new System.Drawing.Size(50, 50);
            this.secondTalentMaterialPlusButton.TabIndex = 73;
            this.secondTalentMaterialPlusButton.Text = "+";
            this.secondTalentMaterialPlusButton.UseVisualStyleBackColor = false;
            this.secondTalentMaterialPlusButton.Click += new System.EventHandler(this.secondTalentMaterialPlusButton_Click);
            // 
            // secondTalentMaterialLabel
            // 
            this.secondTalentMaterialLabel.AutoSize = true;
            this.secondTalentMaterialLabel.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.secondTalentMaterialLabel.Location = new System.Drawing.Point(403, 850);
            this.secondTalentMaterialLabel.Name = "secondTalentMaterialLabel";
            this.secondTalentMaterialLabel.Size = new System.Drawing.Size(82, 39);
            this.secondTalentMaterialLabel.TabIndex = 72;
            this.secondTalentMaterialLabel.Text = "0/66";
            this.secondTalentMaterialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // secondTalentMaterialImage
            // 
            this.secondTalentMaterialImage.BackColor = System.Drawing.Color.Transparent;
            this.secondTalentMaterialImage.Location = new System.Drawing.Point(385, 746);
            this.secondTalentMaterialImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.secondTalentMaterialImage.Name = "secondTalentMaterialImage";
            this.secondTalentMaterialImage.Size = new System.Drawing.Size(100, 100);
            this.secondTalentMaterialImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.secondTalentMaterialImage.TabIndex = 71;
            this.secondTalentMaterialImage.TabStop = false;
            // 
            // thirdTalentMaterialMinusButton
            // 
            this.thirdTalentMaterialMinusButton.BackColor = System.Drawing.Color.White;
            this.thirdTalentMaterialMinusButton.FlatAppearance.BorderSize = 0;
            this.thirdTalentMaterialMinusButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.thirdTalentMaterialMinusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.thirdTalentMaterialMinusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.thirdTalentMaterialMinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.thirdTalentMaterialMinusButton.ForeColor = System.Drawing.Color.Black;
            this.thirdTalentMaterialMinusButton.Location = new System.Drawing.Point(653, 796);
            this.thirdTalentMaterialMinusButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.thirdTalentMaterialMinusButton.Name = "thirdTalentMaterialMinusButton";
            this.thirdTalentMaterialMinusButton.Size = new System.Drawing.Size(50, 50);
            this.thirdTalentMaterialMinusButton.TabIndex = 70;
            this.thirdTalentMaterialMinusButton.Text = "-";
            this.thirdTalentMaterialMinusButton.UseVisualStyleBackColor = false;
            this.thirdTalentMaterialMinusButton.Click += new System.EventHandler(this.thirdTalentMaterialMinusButton_Click);
            // 
            // thirdTalentMaterialPlusButton
            // 
            this.thirdTalentMaterialPlusButton.BackColor = System.Drawing.Color.White;
            this.thirdTalentMaterialPlusButton.FlatAppearance.BorderSize = 0;
            this.thirdTalentMaterialPlusButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.thirdTalentMaterialPlusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.thirdTalentMaterialPlusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.thirdTalentMaterialPlusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.thirdTalentMaterialPlusButton.ForeColor = System.Drawing.Color.Black;
            this.thirdTalentMaterialPlusButton.Location = new System.Drawing.Point(653, 747);
            this.thirdTalentMaterialPlusButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.thirdTalentMaterialPlusButton.Name = "thirdTalentMaterialPlusButton";
            this.thirdTalentMaterialPlusButton.Size = new System.Drawing.Size(50, 50);
            this.thirdTalentMaterialPlusButton.TabIndex = 69;
            this.thirdTalentMaterialPlusButton.Text = "+";
            this.thirdTalentMaterialPlusButton.UseVisualStyleBackColor = false;
            this.thirdTalentMaterialPlusButton.Click += new System.EventHandler(this.thirdTalentMaterialPlusButton_Click);
            // 
            // thirdTalentMaterialLabel
            // 
            this.thirdTalentMaterialLabel.AutoSize = true;
            this.thirdTalentMaterialLabel.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.thirdTalentMaterialLabel.Location = new System.Drawing.Point(565, 851);
            this.thirdTalentMaterialLabel.Name = "thirdTalentMaterialLabel";
            this.thirdTalentMaterialLabel.Size = new System.Drawing.Size(82, 39);
            this.thirdTalentMaterialLabel.TabIndex = 68;
            this.thirdTalentMaterialLabel.Text = "0/93";
            this.thirdTalentMaterialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // thirdTalentMaterialImage
            // 
            this.thirdTalentMaterialImage.BackColor = System.Drawing.Color.Transparent;
            this.thirdTalentMaterialImage.Location = new System.Drawing.Point(547, 747);
            this.thirdTalentMaterialImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.thirdTalentMaterialImage.Name = "thirdTalentMaterialImage";
            this.thirdTalentMaterialImage.Size = new System.Drawing.Size(100, 100);
            this.thirdTalentMaterialImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.thirdTalentMaterialImage.TabIndex = 67;
            this.thirdTalentMaterialImage.TabStop = false;
            // 
            // purpleTalentMinusButton
            // 
            this.purpleTalentMinusButton.BackColor = System.Drawing.Color.White;
            this.purpleTalentMinusButton.FlatAppearance.BorderSize = 0;
            this.purpleTalentMinusButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.purpleTalentMinusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.purpleTalentMinusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purpleTalentMinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.purpleTalentMinusButton.ForeColor = System.Drawing.Color.Black;
            this.purpleTalentMinusButton.Location = new System.Drawing.Point(653, 649);
            this.purpleTalentMinusButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.purpleTalentMinusButton.Name = "purpleTalentMinusButton";
            this.purpleTalentMinusButton.Size = new System.Drawing.Size(50, 50);
            this.purpleTalentMinusButton.TabIndex = 66;
            this.purpleTalentMinusButton.Text = "-";
            this.purpleTalentMinusButton.UseVisualStyleBackColor = false;
            this.purpleTalentMinusButton.Click += new System.EventHandler(this.purpleTalentMinusButton_Click);
            // 
            // purpleTalentPlusButton
            // 
            this.purpleTalentPlusButton.BackColor = System.Drawing.Color.White;
            this.purpleTalentPlusButton.FlatAppearance.BorderSize = 0;
            this.purpleTalentPlusButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.purpleTalentPlusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.purpleTalentPlusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purpleTalentPlusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.purpleTalentPlusButton.ForeColor = System.Drawing.Color.Black;
            this.purpleTalentPlusButton.Location = new System.Drawing.Point(653, 600);
            this.purpleTalentPlusButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.purpleTalentPlusButton.Name = "purpleTalentPlusButton";
            this.purpleTalentPlusButton.Size = new System.Drawing.Size(50, 50);
            this.purpleTalentPlusButton.TabIndex = 65;
            this.purpleTalentPlusButton.Text = "+";
            this.purpleTalentPlusButton.UseVisualStyleBackColor = false;
            this.purpleTalentPlusButton.Click += new System.EventHandler(this.purpleTalentPlusButton_Click);
            // 
            // purpleTalentLabel
            // 
            this.purpleTalentLabel.AutoSize = true;
            this.purpleTalentLabel.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.purpleTalentLabel.Location = new System.Drawing.Point(556, 703);
            this.purpleTalentLabel.Name = "purpleTalentLabel";
            this.purpleTalentLabel.Size = new System.Drawing.Size(91, 39);
            this.purpleTalentLabel.TabIndex = 64;
            this.purpleTalentLabel.Text = "0/114";
            this.purpleTalentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // purpleTalentImage
            // 
            this.purpleTalentImage.BackColor = System.Drawing.Color.Transparent;
            this.purpleTalentImage.Location = new System.Drawing.Point(547, 600);
            this.purpleTalentImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.purpleTalentImage.Name = "purpleTalentImage";
            this.purpleTalentImage.Size = new System.Drawing.Size(100, 100);
            this.purpleTalentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.purpleTalentImage.TabIndex = 63;
            this.purpleTalentImage.TabStop = false;
            // 
            // crownMinusButton
            // 
            this.crownMinusButton.BackColor = System.Drawing.Color.White;
            this.crownMinusButton.FlatAppearance.BorderSize = 0;
            this.crownMinusButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.crownMinusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.crownMinusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crownMinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.crownMinusButton.ForeColor = System.Drawing.Color.Black;
            this.crownMinusButton.Location = new System.Drawing.Point(815, 649);
            this.crownMinusButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.crownMinusButton.Name = "crownMinusButton";
            this.crownMinusButton.Size = new System.Drawing.Size(50, 50);
            this.crownMinusButton.TabIndex = 62;
            this.crownMinusButton.Text = "-";
            this.crownMinusButton.UseVisualStyleBackColor = false;
            this.crownMinusButton.Click += new System.EventHandler(this.crownMinusButton_Click);
            // 
            // crownPlusButton
            // 
            this.crownPlusButton.BackColor = System.Drawing.Color.White;
            this.crownPlusButton.FlatAppearance.BorderSize = 0;
            this.crownPlusButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.crownPlusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.crownPlusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crownPlusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.crownPlusButton.ForeColor = System.Drawing.Color.Black;
            this.crownPlusButton.Location = new System.Drawing.Point(815, 600);
            this.crownPlusButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.crownPlusButton.Name = "crownPlusButton";
            this.crownPlusButton.Size = new System.Drawing.Size(50, 50);
            this.crownPlusButton.TabIndex = 61;
            this.crownPlusButton.Text = "+";
            this.crownPlusButton.UseVisualStyleBackColor = false;
            this.crownPlusButton.Click += new System.EventHandler(this.crownPlusButton_Click);
            // 
            // crownLabel
            // 
            this.crownLabel.AutoSize = true;
            this.crownLabel.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.crownLabel.Location = new System.Drawing.Point(744, 704);
            this.crownLabel.Name = "crownLabel";
            this.crownLabel.Size = new System.Drawing.Size(65, 39);
            this.crownLabel.TabIndex = 60;
            this.crownLabel.Text = "0/3";
            this.crownLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // crownImage
            // 
            this.crownImage.BackColor = System.Drawing.Color.Transparent;
            this.crownImage.Location = new System.Drawing.Point(709, 600);
            this.crownImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.crownImage.Name = "crownImage";
            this.crownImage.Size = new System.Drawing.Size(100, 100);
            this.crownImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.crownImage.TabIndex = 59;
            this.crownImage.TabStop = false;
            // 
            // talentBossItemMinusButton
            // 
            this.talentBossItemMinusButton.BackColor = System.Drawing.Color.White;
            this.talentBossItemMinusButton.FlatAppearance.BorderSize = 0;
            this.talentBossItemMinusButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.talentBossItemMinusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.talentBossItemMinusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.talentBossItemMinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.talentBossItemMinusButton.ForeColor = System.Drawing.Color.Black;
            this.talentBossItemMinusButton.Location = new System.Drawing.Point(815, 796);
            this.talentBossItemMinusButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.talentBossItemMinusButton.Name = "talentBossItemMinusButton";
            this.talentBossItemMinusButton.Size = new System.Drawing.Size(50, 50);
            this.talentBossItemMinusButton.TabIndex = 54;
            this.talentBossItemMinusButton.Text = "-";
            this.talentBossItemMinusButton.UseVisualStyleBackColor = false;
            this.talentBossItemMinusButton.Click += new System.EventHandler(this.talentBossItemMinusButton_Click);
            // 
            // talentBossItemPlusButton
            // 
            this.talentBossItemPlusButton.BackColor = System.Drawing.Color.White;
            this.talentBossItemPlusButton.FlatAppearance.BorderSize = 0;
            this.talentBossItemPlusButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.talentBossItemPlusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.talentBossItemPlusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.talentBossItemPlusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.talentBossItemPlusButton.ForeColor = System.Drawing.Color.Black;
            this.talentBossItemPlusButton.Location = new System.Drawing.Point(815, 747);
            this.talentBossItemPlusButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.talentBossItemPlusButton.Name = "talentBossItemPlusButton";
            this.talentBossItemPlusButton.Size = new System.Drawing.Size(50, 50);
            this.talentBossItemPlusButton.TabIndex = 53;
            this.talentBossItemPlusButton.Text = "+";
            this.talentBossItemPlusButton.UseVisualStyleBackColor = false;
            this.talentBossItemPlusButton.Click += new System.EventHandler(this.talentBossItemPlusButton_Click);
            // 
            // talentBossItemLabel
            // 
            this.talentBossItemLabel.AutoSize = true;
            this.talentBossItemLabel.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.talentBossItemLabel.Location = new System.Drawing.Point(731, 850);
            this.talentBossItemLabel.Name = "talentBossItemLabel";
            this.talentBossItemLabel.Size = new System.Drawing.Size(78, 39);
            this.talentBossItemLabel.TabIndex = 52;
            this.talentBossItemLabel.Text = "0/18";
            this.talentBossItemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // talentBossItemImage
            // 
            this.talentBossItemImage.BackColor = System.Drawing.Color.Transparent;
            this.talentBossItemImage.Location = new System.Drawing.Point(709, 747);
            this.talentBossItemImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.talentBossItemImage.Name = "talentBossItemImage";
            this.talentBossItemImage.Size = new System.Drawing.Size(100, 100);
            this.talentBossItemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.talentBossItemImage.TabIndex = 51;
            this.talentBossItemImage.TabStop = false;
            // 
            // calculateChanceText
            // 
            this.calculateChanceText.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.calculateChanceText.Location = new System.Drawing.Point(210, 12);
            this.calculateChanceText.Name = "calculateChanceText";
            this.calculateChanceText.Size = new System.Drawing.Size(130, 47);
            this.calculateChanceText.TabIndex = 87;
            this.calculateChanceText.Text = "Primos";
            // 
            // calculateChanceButton
            // 
            this.calculateChanceButton.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.calculateChanceButton.Location = new System.Drawing.Point(346, 9);
            this.calculateChanceButton.Name = "calculateChanceButton";
            this.calculateChanceButton.Size = new System.Drawing.Size(50, 50);
            this.calculateChanceButton.TabIndex = 88;
            this.calculateChanceButton.Text = ">";
            this.calculateChanceButton.UseVisualStyleBackColor = true;
            this.calculateChanceButton.Click += new System.EventHandler(this.calculateChanceButton_Click);
            // 
            // calculateChanceLabel
            // 
            this.calculateChanceLabel.AutoSize = true;
            this.calculateChanceLabel.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.calculateChanceLabel.Location = new System.Drawing.Point(406, 13);
            this.calculateChanceLabel.Name = "calculateChanceLabel";
            this.calculateChanceLabel.Size = new System.Drawing.Size(0, 39);
            this.calculateChanceLabel.TabIndex = 89;
            // 
            // moraText
            // 
            this.moraText.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.moraText.Location = new System.Drawing.Point(1503, 784);
            this.moraText.Name = "moraText";
            this.moraText.Size = new System.Drawing.Size(225, 47);
            this.moraText.TabIndex = 90;
            this.moraText.Text = "Mora";
            this.moraText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.moraText_KeyPress);
            // 
            // moraLabel
            // 
            this.moraLabel.AutoSize = true;
            this.moraLabel.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.moraLabel.Location = new System.Drawing.Point(1262, 832);
            this.moraLabel.Name = "moraLabel";
            this.moraLabel.Size = new System.Drawing.Size(147, 39);
            this.moraLabel.TabIndex = 91;
            this.moraLabel.Text = "totalMora";
            this.moraLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // moraTypeDropMenu
            // 
            this.moraTypeDropMenu.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.moraTypeDropMenu.FormattingEnabled = true;
            this.moraTypeDropMenu.Items.AddRange(new object[] {
            "Level",
            "Talents",
            "Level&Talents"});
            this.moraTypeDropMenu.Location = new System.Drawing.Point(1269, 784);
            this.moraTypeDropMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.moraTypeDropMenu.Name = "moraTypeDropMenu";
            this.moraTypeDropMenu.Size = new System.Drawing.Size(228, 47);
            this.moraTypeDropMenu.TabIndex = 92;
            this.moraTypeDropMenu.Text = "Type of mora";
            this.moraTypeDropMenu.SelectedIndexChanged += new System.EventHandler(this.moraTypeDropMenu_SelectedIndexChanged);
            // 
            // moraBookTimeLeft
            // 
            this.moraTimeLeft.AutoSize = true;
            this.moraTimeLeft.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.moraTimeLeft.Location = new System.Drawing.Point(1531, 834);
            this.moraTimeLeft.Name = "moraBookTimeLeft";
            this.moraTimeLeft.Size = new System.Drawing.Size(119, 39);
            this.moraTimeLeft.TabIndex = 93;
            this.moraTimeLeft.Text = "0d 0hrs";
            this.moraTimeLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1761, 891);
            this.Controls.Add(this.moraTimeLeft);
            this.Controls.Add(this.moraTypeDropMenu);
            this.Controls.Add(this.moraLabel);
            this.Controls.Add(this.moraText);
            this.Controls.Add(this.calculateChanceLabel);
            this.Controls.Add(this.calculateChanceButton);
            this.Controls.Add(this.calculateChanceText);
            this.Controls.Add(this.firstTalentMaterialMinusButton);
            this.Controls.Add(this.firstTalentMaterialPlusButton);
            this.Controls.Add(this.firstTalentMaterialLabel);
            this.Controls.Add(this.firstTalentMaterialImage);
            this.Controls.Add(this.greenTalentMinusButton);
            this.Controls.Add(this.greenTalentPlusButton);
            this.Controls.Add(this.greenTalentLabel);
            this.Controls.Add(this.greenTalentImage);
            this.Controls.Add(this.blueTalentMinusButton);
            this.Controls.Add(this.blueTalentPlusButton);
            this.Controls.Add(this.blueTalentLabel);
            this.Controls.Add(this.blueTalentImage);
            this.Controls.Add(this.secondTalentMaterialMinusButton);
            this.Controls.Add(this.secondTalentMaterialPlusButton);
            this.Controls.Add(this.secondTalentMaterialLabel);
            this.Controls.Add(this.secondTalentMaterialImage);
            this.Controls.Add(this.thirdTalentMaterialMinusButton);
            this.Controls.Add(this.thirdTalentMaterialPlusButton);
            this.Controls.Add(this.thirdTalentMaterialLabel);
            this.Controls.Add(this.thirdTalentMaterialImage);
            this.Controls.Add(this.purpleTalentMinusButton);
            this.Controls.Add(this.purpleTalentPlusButton);
            this.Controls.Add(this.purpleTalentLabel);
            this.Controls.Add(this.purpleTalentImage);
            this.Controls.Add(this.crownMinusButton);
            this.Controls.Add(this.crownPlusButton);
            this.Controls.Add(this.crownLabel);
            this.Controls.Add(this.crownImage);
            this.Controls.Add(this.talentBossItemMinusButton);
            this.Controls.Add(this.talentBossItemPlusButton);
            this.Controls.Add(this.talentBossItemLabel);
            this.Controls.Add(this.talentBossItemImage);
            this.Controls.Add(this.charactersDropMenu);
            this.Controls.Add(this.changeLang);
            this.Controls.Add(this.firstMaterialMinusButton);
            this.Controls.Add(this.firstMaterialPlusButton);
            this.Controls.Add(this.firstMaterialLabel);
            this.Controls.Add(this.firstMaterialImage);
            this.Controls.Add(this.greenGemMinusButton);
            this.Controls.Add(this.greenGemPlusButton);
            this.Controls.Add(this.greenGemLabel);
            this.Controls.Add(this.greenGemImage);
            this.Controls.Add(this.blueGemMinusButton);
            this.Controls.Add(this.blueGemPlusButton);
            this.Controls.Add(this.blueGemLabel);
            this.Controls.Add(this.blueGemImage);
            this.Controls.Add(this.secondMaterialMinusButton);
            this.Controls.Add(this.secondMaterialPlusButton);
            this.Controls.Add(this.secondMaterialLabel);
            this.Controls.Add(this.secondMaterialImage);
            this.Controls.Add(this.thirdMaterialMinusButton);
            this.Controls.Add(this.thirdMaterialPlusButton);
            this.Controls.Add(this.thirdMaterialLabel);
            this.Controls.Add(this.thirdMaterialImage);
            this.Controls.Add(this.purpleGemMinusButton);
            this.Controls.Add(this.purpleGemPlusButton);
            this.Controls.Add(this.purpleGemLabel);
            this.Controls.Add(this.purpleGemImage);
            this.Controls.Add(this.goldGemMinusButton);
            this.Controls.Add(this.goldGemPlusButton);
            this.Controls.Add(this.goldGemLabel);
            this.Controls.Add(this.goldGemImage);
            this.Controls.Add(this.flowerMinusButton);
            this.Controls.Add(this.flowerPlusButton);
            this.Controls.Add(this.flowersLabel);
            this.Controls.Add(this.flowerImage);
            this.Controls.Add(this.bossItemMinusButton);
            this.Controls.Add(this.bossItemPlusButton);
            this.Controls.Add(this.bossItemsLabel);
            this.Controls.Add(this.bossItemImage);
            this.Controls.Add(this.expBookTimeLeft);
            this.Controls.Add(this.expBookMinusButton);
            this.Controls.Add(this.expBookPlusButton);
            this.Controls.Add(this.expBookLabel);
            this.Controls.Add(this.expBooxImage);
            this.Controls.Add(this.characterImage);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Genshin Character Collector";
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.firstMaterialImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenGemImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueGemImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondMaterialImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdMaterialImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purpleGemImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldGemImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowerImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bossItemImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expBooxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstTalentMaterialImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTalentImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueTalentImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondTalentMaterialImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdTalentMaterialImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purpleTalentImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crownImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.talentBossItemImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void SetIcon()
        {
            if (File.Exists("Resources/GCC_icon.ico"))
                this.Icon = new Icon("Resources/GCC_icon.ico");
            else
                MessageBox.Show("Application Icon not found, check Resources", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #endregion
        private System.Windows.Forms.PictureBox characterImage;
        private System.Windows.Forms.PictureBox expBooxImage;
        private System.Windows.Forms.Label expBookLabel;
        private System.Windows.Forms.Button expBookPlusButton;
        private System.Windows.Forms.Button expBookMinusButton;
        private System.Windows.Forms.Label expBookTimeLeft;
        private System.Windows.Forms.Button bossItemMinusButton;
        private System.Windows.Forms.Button bossItemPlusButton;
        private System.Windows.Forms.Label bossItemsLabel;
        private System.Windows.Forms.PictureBox bossItemImage;
        private System.Windows.Forms.Button flowerMinusButton;
        private System.Windows.Forms.Button flowerPlusButton;
        private System.Windows.Forms.Label flowersLabel;
        private System.Windows.Forms.PictureBox flowerImage;
        private System.Windows.Forms.Button goldGemMinusButton;
        private System.Windows.Forms.Button goldGemPlusButton;
        private System.Windows.Forms.Label goldGemLabel;
        private System.Windows.Forms.PictureBox goldGemImage;
        private System.Windows.Forms.Button purpleGemMinusButton;
        private System.Windows.Forms.Button purpleGemPlusButton;
        private System.Windows.Forms.Label purpleGemLabel;
        private System.Windows.Forms.PictureBox purpleGemImage;
        private System.Windows.Forms.Button thirdMaterialMinusButton;
        private System.Windows.Forms.Button thirdMaterialPlusButton;
        private System.Windows.Forms.Label thirdMaterialLabel;
        private System.Windows.Forms.PictureBox thirdMaterialImage;
        private System.Windows.Forms.Button firstMaterialMinusButton;
        private System.Windows.Forms.Button firstMaterialPlusButton;
        private System.Windows.Forms.Label firstMaterialLabel;
        private System.Windows.Forms.PictureBox firstMaterialImage;
        private System.Windows.Forms.Button greenGemMinusButton;
        private System.Windows.Forms.Button greenGemPlusButton;
        private System.Windows.Forms.Label greenGemLabel;
        private System.Windows.Forms.PictureBox greenGemImage;
        private System.Windows.Forms.Button blueGemMinusButton;
        private System.Windows.Forms.Button blueGemPlusButton;
        private System.Windows.Forms.Label blueGemLabel;
        private System.Windows.Forms.PictureBox blueGemImage;
        private System.Windows.Forms.Button secondMaterialMinusButton;
        private System.Windows.Forms.Button secondMaterialPlusButton;
        private System.Windows.Forms.Label secondMaterialLabel;
        private System.Windows.Forms.PictureBox secondMaterialImage;
        private Button changeLang;
        private ComboBox charactersDropMenu;
        private Button firstTalentMaterialMinusButton;
        private Button firstTalentMaterialPlusButton;
        private Label firstTalentMaterialLabel;
        private PictureBox firstTalentMaterialImage;
        private Button greenTalentMinusButton;
        private Button greenTalentPlusButton;
        private Label greenTalentLabel;
        private PictureBox greenTalentImage;
        private Button blueTalentMinusButton;
        private Button blueTalentPlusButton;
        private Label blueTalentLabel;
        private PictureBox blueTalentImage;
        private Button secondTalentMaterialMinusButton;
        private Button secondTalentMaterialPlusButton;
        private Label secondTalentMaterialLabel;
        private PictureBox secondTalentMaterialImage;
        private Button thirdTalentMaterialMinusButton;
        private Button thirdTalentMaterialPlusButton;
        private Label thirdTalentMaterialLabel;
        private PictureBox thirdTalentMaterialImage;
        private Button purpleTalentMinusButton;
        private Button purpleTalentPlusButton;
        private Label purpleTalentLabel;
        private PictureBox purpleTalentImage;
        private Button crownMinusButton;
        private Button crownPlusButton;
        private Label crownLabel;
        private PictureBox crownImage;
        private Button talentBossItemMinusButton;
        private Button talentBossItemPlusButton;
        private Label talentBossItemLabel;
        private PictureBox talentBossItemImage;
        private TextBox calculateChanceText;
        private Button calculateChanceButton;
        private Label calculateChanceLabel;
        private TextBox moraText;
        private Label moraLabel;
        private ComboBox moraTypeDropMenu;
        private Label moraTimeLeft;
    }
}

