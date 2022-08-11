namespace Activity_14
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
            this.speciesListbox = new System.Windows.Forms.ListBox();
            this.speciesLabel = new System.Windows.Forms.Label();
            this.classGroup = new System.Windows.Forms.GroupBox();
            this.wizardRB = new System.Windows.Forms.RadioButton();
            this.warlockRB = new System.Windows.Forms.RadioButton();
            this.sorcererRB = new System.Windows.Forms.RadioButton();
            this.rogueRB = new System.Windows.Forms.RadioButton();
            this.rangerRB = new System.Windows.Forms.RadioButton();
            this.paladinRB = new System.Windows.Forms.RadioButton();
            this.monkRB = new System.Windows.Forms.RadioButton();
            this.fighterRB = new System.Windows.Forms.RadioButton();
            this.druidRB = new System.Windows.Forms.RadioButton();
            this.clericRB = new System.Windows.Forms.RadioButton();
            this.bardRB = new System.Windows.Forms.RadioButton();
            this.bloodhunterRB = new System.Windows.Forms.RadioButton();
            this.barbarianRB = new System.Windows.Forms.RadioButton();
            this.artificerRB = new System.Windows.Forms.RadioButton();
            this.otherOptionsGroup = new System.Windows.Forms.GroupBox();
            this.backgroundCB = new System.Windows.Forms.CheckBox();
            this.statsCB = new System.Windows.Forms.CheckBox();
            this.characterBox = new System.Windows.Forms.GroupBox();
            this.backgroundLabel = new System.Windows.Forms.Label();
            this.chaLabel = new System.Windows.Forms.Label();
            this.wisLabel = new System.Windows.Forms.Label();
            this.intLabel = new System.Windows.Forms.Label();
            this.conLabel = new System.Windows.Forms.Label();
            this.dexLabel = new System.Windows.Forms.Label();
            this.strLabel = new System.Windows.Forms.Label();
            this.charismaLabel = new System.Windows.Forms.Label();
            this.wisdomLabel = new System.Windows.Forms.Label();
            this.intelligenceLabel = new System.Windows.Forms.Label();
            this.constitutionLabel = new System.Windows.Forms.Label();
            this.dexterityLabel = new System.Windows.Forms.Label();
            this.strengthLabel = new System.Windows.Forms.Label();
            this.characterLabel = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.classGroup.SuspendLayout();
            this.otherOptionsGroup.SuspendLayout();
            this.characterBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // speciesListbox
            // 
            this.speciesListbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(222)))), ((int)(((byte)(157)))));
            this.speciesListbox.FormattingEnabled = true;
            this.speciesListbox.ItemHeight = 15;
            this.speciesListbox.Items.AddRange(new object[] {
            "Aarakocra",
            "Aasimar",
            "Air Genasi",
            "Bugbear",
            "Centaur",
            "Changeling",
            "Deep Gnome",
            "Dhampir",
            "Dragonborn",
            "Duergar",
            "Dwarf",
            "Earth Genasi",
            "Eladrin",
            "Elf",
            "Fairy",
            "Firbolg",
            "Fire Genasi",
            "Githyanki",
            "Githzerai",
            "Gnome",
            "Goblin",
            "Goliath",
            "Half-Elf",
            "Half-Orc",
            "Halfling",
            "Harengon",
            "Hexblood",
            "Hobgoblin",
            "Human",
            "Kalashtar",
            "Kenku",
            "Kobold",
            "Leonin",
            "Lizardfolk",
            "Loxodon",
            "Minotaur",
            "Orc",
            "Owlin",
            "Reborn",
            "Satyr",
            "Sea Elf",
            "Shadar-Kai",
            "Shifter",
            "Simic Hybrid",
            "Tabaxi",
            "Tiefling",
            "Tortle",
            "Triton",
            "Vedalken",
            "Warforged",
            "Water Genasi",
            "Yuan-ti"});
            this.speciesListbox.Location = new System.Drawing.Point(55, 39);
            this.speciesListbox.MultiColumn = true;
            this.speciesListbox.Name = "speciesListbox";
            this.speciesListbox.Size = new System.Drawing.Size(208, 139);
            this.speciesListbox.Sorted = true;
            this.speciesListbox.TabIndex = 0;
            // 
            // speciesLabel
            // 
            this.speciesLabel.AutoSize = true;
            this.speciesLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(235)))), ((int)(((byte)(222)))), ((int)(((byte)(157)))));
            this.speciesLabel.Location = new System.Drawing.Point(55, 21);
            this.speciesLabel.Name = "speciesLabel";
            this.speciesLabel.Size = new System.Drawing.Size(83, 15);
            this.speciesLabel.TabIndex = 1;
            this.speciesLabel.Text = "Select Species:";
            // 
            // classGroup
            // 
            this.classGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(235)))), ((int)(((byte)(222)))), ((int)(((byte)(157)))));
            this.classGroup.Controls.Add(this.wizardRB);
            this.classGroup.Controls.Add(this.warlockRB);
            this.classGroup.Controls.Add(this.sorcererRB);
            this.classGroup.Controls.Add(this.rogueRB);
            this.classGroup.Controls.Add(this.rangerRB);
            this.classGroup.Controls.Add(this.paladinRB);
            this.classGroup.Controls.Add(this.monkRB);
            this.classGroup.Controls.Add(this.fighterRB);
            this.classGroup.Controls.Add(this.druidRB);
            this.classGroup.Controls.Add(this.clericRB);
            this.classGroup.Controls.Add(this.bardRB);
            this.classGroup.Controls.Add(this.bloodhunterRB);
            this.classGroup.Controls.Add(this.barbarianRB);
            this.classGroup.Controls.Add(this.artificerRB);
            this.classGroup.Location = new System.Drawing.Point(55, 197);
            this.classGroup.Name = "classGroup";
            this.classGroup.Size = new System.Drawing.Size(208, 218);
            this.classGroup.TabIndex = 2;
            this.classGroup.TabStop = false;
            this.classGroup.Text = "Select Class:";
            // 
            // wizardRB
            // 
            this.wizardRB.AutoSize = true;
            this.wizardRB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.wizardRB.Location = new System.Drawing.Point(109, 178);
            this.wizardRB.Name = "wizardRB";
            this.wizardRB.Size = new System.Drawing.Size(61, 19);
            this.wizardRB.TabIndex = 13;
            this.wizardRB.Text = "Wizard";
            this.wizardRB.UseVisualStyleBackColor = false;
            // 
            // warlockRB
            // 
            this.warlockRB.AutoSize = true;
            this.warlockRB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.warlockRB.Location = new System.Drawing.Point(17, 178);
            this.warlockRB.Name = "warlockRB";
            this.warlockRB.Size = new System.Drawing.Size(68, 19);
            this.warlockRB.TabIndex = 12;
            this.warlockRB.Text = "Warlock";
            this.warlockRB.UseVisualStyleBackColor = false;
            // 
            // sorcererRB
            // 
            this.sorcererRB.AutoSize = true;
            this.sorcererRB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sorcererRB.Location = new System.Drawing.Point(109, 153);
            this.sorcererRB.Name = "sorcererRB";
            this.sorcererRB.Size = new System.Drawing.Size(68, 19);
            this.sorcererRB.TabIndex = 11;
            this.sorcererRB.Text = "Sorcerer";
            this.sorcererRB.UseVisualStyleBackColor = false;
            // 
            // rogueRB
            // 
            this.rogueRB.AutoSize = true;
            this.rogueRB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rogueRB.Location = new System.Drawing.Point(17, 153);
            this.rogueRB.Name = "rogueRB";
            this.rogueRB.Size = new System.Drawing.Size(59, 19);
            this.rogueRB.TabIndex = 10;
            this.rogueRB.Text = "Rogue";
            this.rogueRB.UseVisualStyleBackColor = false;
            // 
            // rangerRB
            // 
            this.rangerRB.AutoSize = true;
            this.rangerRB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rangerRB.Location = new System.Drawing.Point(109, 128);
            this.rangerRB.Name = "rangerRB";
            this.rangerRB.Size = new System.Drawing.Size(62, 19);
            this.rangerRB.TabIndex = 9;
            this.rangerRB.Text = "Ranger";
            this.rangerRB.UseVisualStyleBackColor = false;
            // 
            // paladinRB
            // 
            this.paladinRB.AutoSize = true;
            this.paladinRB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.paladinRB.Location = new System.Drawing.Point(17, 128);
            this.paladinRB.Name = "paladinRB";
            this.paladinRB.Size = new System.Drawing.Size(64, 19);
            this.paladinRB.TabIndex = 8;
            this.paladinRB.Text = "Paladin";
            this.paladinRB.UseVisualStyleBackColor = false;
            // 
            // monkRB
            // 
            this.monkRB.AutoSize = true;
            this.monkRB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.monkRB.Location = new System.Drawing.Point(109, 103);
            this.monkRB.Name = "monkRB";
            this.monkRB.Size = new System.Drawing.Size(56, 19);
            this.monkRB.TabIndex = 7;
            this.monkRB.Text = "Monk";
            this.monkRB.UseVisualStyleBackColor = false;
            // 
            // fighterRB
            // 
            this.fighterRB.AutoSize = true;
            this.fighterRB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fighterRB.Location = new System.Drawing.Point(17, 103);
            this.fighterRB.Name = "fighterRB";
            this.fighterRB.Size = new System.Drawing.Size(62, 19);
            this.fighterRB.TabIndex = 6;
            this.fighterRB.Text = "Fighter";
            this.fighterRB.UseVisualStyleBackColor = false;
            // 
            // druidRB
            // 
            this.druidRB.AutoSize = true;
            this.druidRB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.druidRB.Location = new System.Drawing.Point(109, 78);
            this.druidRB.Name = "druidRB";
            this.druidRB.Size = new System.Drawing.Size(54, 19);
            this.druidRB.TabIndex = 5;
            this.druidRB.Text = "Druid";
            this.druidRB.UseVisualStyleBackColor = false;
            // 
            // clericRB
            // 
            this.clericRB.AutoSize = true;
            this.clericRB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clericRB.Location = new System.Drawing.Point(17, 78);
            this.clericRB.Name = "clericRB";
            this.clericRB.Size = new System.Drawing.Size(55, 19);
            this.clericRB.TabIndex = 4;
            this.clericRB.Text = "Cleric";
            this.clericRB.UseVisualStyleBackColor = false;
            // 
            // bardRB
            // 
            this.bardRB.AutoSize = true;
            this.bardRB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bardRB.Location = new System.Drawing.Point(17, 53);
            this.bardRB.Name = "bardRB";
            this.bardRB.Size = new System.Drawing.Size(49, 19);
            this.bardRB.TabIndex = 3;
            this.bardRB.Text = "Bard";
            this.bardRB.UseVisualStyleBackColor = false;
            // 
            // bloodhunterRB
            // 
            this.bloodhunterRB.AutoSize = true;
            this.bloodhunterRB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bloodhunterRB.Location = new System.Drawing.Point(109, 53);
            this.bloodhunterRB.Name = "bloodhunterRB";
            this.bloodhunterRB.Size = new System.Drawing.Size(91, 19);
            this.bloodhunterRB.TabIndex = 2;
            this.bloodhunterRB.Text = "Bloodhunter";
            this.bloodhunterRB.UseVisualStyleBackColor = false;
            // 
            // barbarianRB
            // 
            this.barbarianRB.AutoSize = true;
            this.barbarianRB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.barbarianRB.Location = new System.Drawing.Point(109, 28);
            this.barbarianRB.Name = "barbarianRB";
            this.barbarianRB.Size = new System.Drawing.Size(75, 19);
            this.barbarianRB.TabIndex = 1;
            this.barbarianRB.Text = "Barbarian";
            this.barbarianRB.UseVisualStyleBackColor = false;
            // 
            // artificerRB
            // 
            this.artificerRB.AutoSize = true;
            this.artificerRB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.artificerRB.Checked = true;
            this.artificerRB.Location = new System.Drawing.Point(17, 28);
            this.artificerRB.Name = "artificerRB";
            this.artificerRB.Size = new System.Drawing.Size(67, 19);
            this.artificerRB.TabIndex = 0;
            this.artificerRB.TabStop = true;
            this.artificerRB.Text = "Artificer";
            this.artificerRB.UseVisualStyleBackColor = false;
            // 
            // otherOptionsGroup
            // 
            this.otherOptionsGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(235)))), ((int)(((byte)(222)))), ((int)(((byte)(157)))));
            this.otherOptionsGroup.Controls.Add(this.backgroundCB);
            this.otherOptionsGroup.Controls.Add(this.statsCB);
            this.otherOptionsGroup.Location = new System.Drawing.Point(55, 421);
            this.otherOptionsGroup.Name = "otherOptionsGroup";
            this.otherOptionsGroup.Size = new System.Drawing.Size(208, 75);
            this.otherOptionsGroup.TabIndex = 3;
            this.otherOptionsGroup.TabStop = false;
            this.otherOptionsGroup.Text = "Other Options:";
            // 
            // backgroundCB
            // 
            this.backgroundCB.AutoSize = true;
            this.backgroundCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.backgroundCB.Location = new System.Drawing.Point(15, 47);
            this.backgroundCB.Name = "backgroundCB";
            this.backgroundCB.Size = new System.Drawing.Size(152, 19);
            this.backgroundCB.TabIndex = 1;
            this.backgroundCB.Text = "Randomize Background";
            this.backgroundCB.UseVisualStyleBackColor = false;
            // 
            // statsCB
            // 
            this.statsCB.AutoSize = true;
            this.statsCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.statsCB.Location = new System.Drawing.Point(15, 22);
            this.statsCB.Name = "statsCB";
            this.statsCB.Size = new System.Drawing.Size(113, 19);
            this.statsCB.TabIndex = 0;
            this.statsCB.Text = "Randomize Stats";
            this.statsCB.UseVisualStyleBackColor = false;
            // 
            // characterBox
            // 
            this.characterBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(235)))), ((int)(((byte)(222)))), ((int)(((byte)(157)))));
            this.characterBox.Controls.Add(this.backgroundLabel);
            this.characterBox.Controls.Add(this.chaLabel);
            this.characterBox.Controls.Add(this.wisLabel);
            this.characterBox.Controls.Add(this.intLabel);
            this.characterBox.Controls.Add(this.conLabel);
            this.characterBox.Controls.Add(this.dexLabel);
            this.characterBox.Controls.Add(this.strLabel);
            this.characterBox.Controls.Add(this.charismaLabel);
            this.characterBox.Controls.Add(this.wisdomLabel);
            this.characterBox.Controls.Add(this.intelligenceLabel);
            this.characterBox.Controls.Add(this.constitutionLabel);
            this.characterBox.Controls.Add(this.dexterityLabel);
            this.characterBox.Controls.Add(this.strengthLabel);
            this.characterBox.Controls.Add(this.characterLabel);
            this.characterBox.Location = new System.Drawing.Point(326, 39);
            this.characterBox.Name = "characterBox";
            this.characterBox.Size = new System.Drawing.Size(260, 376);
            this.characterBox.TabIndex = 4;
            this.characterBox.TabStop = false;
            this.characterBox.Text = "Your Character!";
            // 
            // backgroundLabel
            // 
            this.backgroundLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.backgroundLabel.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backgroundLabel.Location = new System.Drawing.Point(7, 261);
            this.backgroundLabel.Name = "backgroundLabel";
            this.backgroundLabel.Size = new System.Drawing.Size(247, 112);
            this.backgroundLabel.TabIndex = 13;
            this.backgroundLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // chaLabel
            // 
            this.chaLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chaLabel.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chaLabel.Location = new System.Drawing.Point(172, 200);
            this.chaLabel.Name = "chaLabel";
            this.chaLabel.Size = new System.Drawing.Size(82, 43);
            this.chaLabel.TabIndex = 12;
            this.chaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wisLabel
            // 
            this.wisLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.wisLabel.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.wisLabel.Location = new System.Drawing.Point(88, 200);
            this.wisLabel.Name = "wisLabel";
            this.wisLabel.Size = new System.Drawing.Size(78, 43);
            this.wisLabel.TabIndex = 11;
            this.wisLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // intLabel
            // 
            this.intLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.intLabel.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.intLabel.Location = new System.Drawing.Point(7, 200);
            this.intLabel.Name = "intLabel";
            this.intLabel.Size = new System.Drawing.Size(75, 43);
            this.intLabel.TabIndex = 10;
            this.intLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // conLabel
            // 
            this.conLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.conLabel.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.conLabel.Location = new System.Drawing.Point(172, 139);
            this.conLabel.Name = "conLabel";
            this.conLabel.Size = new System.Drawing.Size(82, 43);
            this.conLabel.TabIndex = 9;
            this.conLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dexLabel
            // 
            this.dexLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dexLabel.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dexLabel.Location = new System.Drawing.Point(88, 139);
            this.dexLabel.Name = "dexLabel";
            this.dexLabel.Size = new System.Drawing.Size(78, 43);
            this.dexLabel.TabIndex = 8;
            this.dexLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // strLabel
            // 
            this.strLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.strLabel.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.strLabel.Location = new System.Drawing.Point(7, 139);
            this.strLabel.Name = "strLabel";
            this.strLabel.Size = new System.Drawing.Size(75, 43);
            this.strLabel.TabIndex = 7;
            this.strLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // charismaLabel
            // 
            this.charismaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.charismaLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.charismaLabel.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.charismaLabel.Location = new System.Drawing.Point(172, 182);
            this.charismaLabel.Name = "charismaLabel";
            this.charismaLabel.Size = new System.Drawing.Size(82, 19);
            this.charismaLabel.TabIndex = 6;
            this.charismaLabel.Text = "Charisma";
            this.charismaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.charismaLabel.Visible = false;
            // 
            // wisdomLabel
            // 
            this.wisdomLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wisdomLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.wisdomLabel.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wisdomLabel.Location = new System.Drawing.Point(88, 182);
            this.wisdomLabel.Name = "wisdomLabel";
            this.wisdomLabel.Size = new System.Drawing.Size(78, 19);
            this.wisdomLabel.TabIndex = 5;
            this.wisdomLabel.Text = "Wisdom";
            this.wisdomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.wisdomLabel.Visible = false;
            // 
            // intelligenceLabel
            // 
            this.intelligenceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.intelligenceLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.intelligenceLabel.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.intelligenceLabel.Location = new System.Drawing.Point(7, 182);
            this.intelligenceLabel.Name = "intelligenceLabel";
            this.intelligenceLabel.Size = new System.Drawing.Size(75, 19);
            this.intelligenceLabel.TabIndex = 4;
            this.intelligenceLabel.Text = "Intelligence";
            this.intelligenceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.intelligenceLabel.Visible = false;
            // 
            // constitutionLabel
            // 
            this.constitutionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.constitutionLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.constitutionLabel.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.constitutionLabel.Location = new System.Drawing.Point(172, 120);
            this.constitutionLabel.Name = "constitutionLabel";
            this.constitutionLabel.Size = new System.Drawing.Size(83, 19);
            this.constitutionLabel.TabIndex = 3;
            this.constitutionLabel.Text = "Constitution";
            this.constitutionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.constitutionLabel.Visible = false;
            // 
            // dexterityLabel
            // 
            this.dexterityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dexterityLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dexterityLabel.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dexterityLabel.Location = new System.Drawing.Point(88, 120);
            this.dexterityLabel.Name = "dexterityLabel";
            this.dexterityLabel.Size = new System.Drawing.Size(78, 19);
            this.dexterityLabel.TabIndex = 2;
            this.dexterityLabel.Text = "Dexterity";
            this.dexterityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dexterityLabel.Visible = false;
            // 
            // strengthLabel
            // 
            this.strengthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.strengthLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.strengthLabel.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.strengthLabel.Location = new System.Drawing.Point(7, 120);
            this.strengthLabel.Name = "strengthLabel";
            this.strengthLabel.Size = new System.Drawing.Size(75, 19);
            this.strengthLabel.TabIndex = 1;
            this.strengthLabel.Text = "Strength";
            this.strengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.strengthLabel.Visible = false;
            // 
            // characterLabel
            // 
            this.characterLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.characterLabel.Font = new System.Drawing.Font("Old English Text MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.characterLabel.Location = new System.Drawing.Point(6, 30);
            this.characterLabel.Name = "characterLabel";
            this.characterLabel.Size = new System.Drawing.Size(248, 63);
            this.characterLabel.TabIndex = 0;
            this.characterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // generateButton
            // 
            this.generateButton.BackColor = System.Drawing.SystemColors.Info;
            this.generateButton.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.generateButton.Location = new System.Drawing.Point(362, 429);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(185, 67);
            this.generateButton.TabIndex = 5;
            this.generateButton.Text = "Generate Character!";
            this.generateButton.UseVisualStyleBackColor = false;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Activity_14.Properties.Resources._126399_parchment_paper_texture_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(623, 508);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.characterBox);
            this.Controls.Add(this.otherOptionsGroup);
            this.Controls.Add(this.classGroup);
            this.Controls.Add(this.speciesLabel);
            this.Controls.Add(this.speciesListbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dungeons & Dragons Character Designer";
            this.classGroup.ResumeLayout(false);
            this.classGroup.PerformLayout();
            this.otherOptionsGroup.ResumeLayout(false);
            this.otherOptionsGroup.PerformLayout();
            this.characterBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox speciesListbox;
        private Label speciesLabel;
        private GroupBox classGroup;
        private RadioButton druidRB;
        private RadioButton clericRB;
        private RadioButton bardRB;
        private RadioButton bloodhunterRB;
        private RadioButton barbarianRB;
        private RadioButton artificerRB;
        private RadioButton wizardRB;
        private RadioButton warlockRB;
        private RadioButton sorcererRB;
        private RadioButton rogueRB;
        private RadioButton rangerRB;
        private RadioButton paladinRB;
        private RadioButton monkRB;
        private RadioButton fighterRB;
        private GroupBox otherOptionsGroup;
        private CheckBox backgroundCB;
        private CheckBox statsCB;
        private GroupBox characterBox;
        private Label characterLabel;
        private Label chaLabel;
        private Label wisLabel;
        private Label intLabel;
        private Label conLabel;
        private Label dexLabel;
        private Label strLabel;
        private Label charismaLabel;
        private Label wisdomLabel;
        private Label intelligenceLabel;
        private Label constitutionLabel;
        private Label dexterityLabel;
        private Label strengthLabel;
        private Label backgroundLabel;
        private Button generateButton;
    }
}