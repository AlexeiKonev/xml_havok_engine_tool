
namespace WinFormsText
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
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonTexture = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonShading = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.buttonNormalMap = new System.Windows.Forms.Button();
            this.checkTexture = new System.Windows.Forms.CheckBox();
            this.checkNormal = new System.Windows.Forms.CheckBox();
            this.checkShading = new System.Windows.Forms.CheckBox();
            this.checkFbx = new System.Windows.Forms.CheckBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.lvUsers = new System.Windows.Forms.ListView();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.buttonMaterialName = new System.Windows.Forms.Button();
            this.buttonSerialize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(233, 28);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 0;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(342, 276);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 28);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 23);
            this.textBox1.TabIndex = 2;
            // 
            // buttonTexture
            // 
            this.buttonTexture.Location = new System.Drawing.Point(233, 127);
            this.buttonTexture.Name = "buttonTexture";
            this.buttonTexture.Size = new System.Drawing.Size(75, 23);
            this.buttonTexture.TabIndex = 3;
            this.buttonTexture.Text = "Browse";
            this.buttonTexture.UseVisualStyleBackColor = true;
            this.buttonTexture.Click += new System.EventHandler(this.buttonTexture_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(90, 128);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(128, 23);
            this.textBox2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "FBX";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 136);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 15);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Texture";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Shading";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "NormalMap";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(89, 176);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(128, 23);
            this.textBox3.TabIndex = 10;
            // 
            // buttonShading
            // 
            this.buttonShading.Location = new System.Drawing.Point(233, 213);
            this.buttonShading.Name = "buttonShading";
            this.buttonShading.Size = new System.Drawing.Size(75, 23);
            this.buttonShading.TabIndex = 9;
            this.buttonShading.Text = "Browse";
            this.buttonShading.UseVisualStyleBackColor = true;
            this.buttonShading.Click += new System.EventHandler(this.buttonShading_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(90, 218);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(128, 23);
            this.textBox4.TabIndex = 8;
            // 
            // buttonNormalMap
            // 
            this.buttonNormalMap.Location = new System.Drawing.Point(233, 172);
            this.buttonNormalMap.Name = "buttonNormalMap";
            this.buttonNormalMap.Size = new System.Drawing.Size(75, 23);
            this.buttonNormalMap.TabIndex = 7;
            this.buttonNormalMap.Text = "Browse";
            this.buttonNormalMap.UseVisualStyleBackColor = true;
            this.buttonNormalMap.Click += new System.EventHandler(this.buttonNormalMap_Click);
            // 
            // checkTexture
            // 
            this.checkTexture.AutoSize = true;
            this.checkTexture.Location = new System.Drawing.Point(336, 130);
            this.checkTexture.Name = "checkTexture";
            this.checkTexture.Size = new System.Drawing.Size(81, 19);
            this.checkTexture.TabIndex = 13;
            this.checkTexture.Text = ".tga delete";
            this.checkTexture.UseVisualStyleBackColor = true;
            // 
            // checkNormal
            // 
            this.checkNormal.AutoSize = true;
            this.checkNormal.Location = new System.Drawing.Point(336, 177);
            this.checkNormal.Name = "checkNormal";
            this.checkNormal.Size = new System.Drawing.Size(81, 19);
            this.checkNormal.TabIndex = 14;
            this.checkNormal.Text = ".tga delete";
            this.checkNormal.UseVisualStyleBackColor = true;
            // 
            // checkShading
            // 
            this.checkShading.AutoSize = true;
            this.checkShading.Location = new System.Drawing.Point(336, 220);
            this.checkShading.Name = "checkShading";
            this.checkShading.Size = new System.Drawing.Size(81, 19);
            this.checkShading.TabIndex = 15;
            this.checkShading.Text = ".tga delete";
            this.checkShading.UseVisualStyleBackColor = true;
            // 
            // checkFbx
            // 
            this.checkFbx.AutoSize = true;
            this.checkFbx.Location = new System.Drawing.Point(336, 34);
            this.checkFbx.Name = "checkFbx";
            this.checkFbx.Size = new System.Drawing.Size(81, 19);
            this.checkFbx.TabIndex = 16;
            this.checkFbx.Text = ".fbx delete";
            this.checkFbx.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(8, 276);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 17;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // lvUsers
            // 
            this.lvUsers.HideSelection = false;
            this.lvUsers.Location = new System.Drawing.Point(488, 48);
            this.lvUsers.Name = "lvUsers";
            this.lvUsers.Size = new System.Drawing.Size(194, 206);
            this.lvUsers.TabIndex = 18;
            this.lvUsers.UseCompatibleStateImageBehavior = false;
            this.lvUsers.SelectedIndexChanged += new System.EventHandler(this.lvUsers_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(336, 81);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(85, 19);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = ".mat delete";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "MaterialName";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(90, 77);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(128, 23);
            this.textBox5.TabIndex = 20;
            // 
            // buttonMaterialName
            // 
            this.buttonMaterialName.Location = new System.Drawing.Point(233, 77);
            this.buttonMaterialName.Name = "buttonMaterialName";
            this.buttonMaterialName.Size = new System.Drawing.Size(75, 23);
            this.buttonMaterialName.TabIndex = 19;
            this.buttonMaterialName.Text = "Browse";
            this.buttonMaterialName.UseVisualStyleBackColor = true;
            this.buttonMaterialName.Click += new System.EventHandler(this.buttonMaterialName_Click);
            // 
            // buttonSerialize
            // 
            this.buttonSerialize.Location = new System.Drawing.Point(142, 276);
            this.buttonSerialize.Name = "buttonSerialize";
            this.buttonSerialize.Size = new System.Drawing.Size(75, 23);
            this.buttonSerialize.TabIndex = 23;
            this.buttonSerialize.Text = "Serialize";
            this.buttonSerialize.UseVisualStyleBackColor = true;
            this.buttonSerialize.Click += new System.EventHandler(this.buttonSerialize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 372);
            this.Controls.Add(this.buttonSerialize);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.buttonMaterialName);
            this.Controls.Add(this.lvUsers);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.checkFbx);
            this.Controls.Add(this.checkShading);
            this.Controls.Add(this.checkNormal);
            this.Controls.Add(this.checkTexture);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.buttonShading);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.buttonNormalMap);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.buttonTexture);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonBrowse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonTexture;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonShading;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button buttonNormalMap;
        private System.Windows.Forms.CheckBox checkTexture;
        private System.Windows.Forms.CheckBox checkNormal;
        private System.Windows.Forms.CheckBox checkShading;
        private System.Windows.Forms.CheckBox checkFbx;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListView lvUsers;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button buttonMaterialName;
        private System.Windows.Forms.Button buttonSerialize;
    }
}

