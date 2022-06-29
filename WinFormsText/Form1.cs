using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace WinFormsText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ClearInput();
        }
      
         private void buttonClear_Click(object sender, EventArgs e)
        {

        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            //FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "                   Выберите FBX";
            open.Filter = "Тип Файла(*fbx)|*fbx";

            //if ( folderBrowser.ShowDialog() == DialogResult.OK)
            //{
            //    //textBox1.Text = folderBrowser.SelectedPath;
            //}


            if (open.ShowDialog() == DialogResult.OK)
            {
                //save file name to string
                string temp = open.SafeFileName;
                //remove .fbx and 
                if (checkFbx.Checked)
                {
                  string fbxName=  textBox1.Text = temp.Remove(temp.Length - 4);
                }
                else
                {
                    textBox1.Text = temp;
                }
                
            }
        }

        private void buttonTexture_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "                                      Выберите TGA ФАЙЛ";
            open.Filter = "Тип Файла(*tga)|*tga";
            if (open.ShowDialog() == DialogResult.OK)
            {
                //save file name to string
                string temp = open.SafeFileName;
                //remove .tga  
                if (checkTexture.Checked)
                {
                    textBox2.Text = temp.Remove(temp.Length - 4);
                }
                else
                {
                    //if not checked save full filename with .tga
                    textBox2.Text = temp;
                }
               
             
            }
            
        }

        private void buttonNormalMap_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "                                      Выберите TGA ФАЙЛ";
            open.Filter = "Тип Файла(*tga)|*tga";
            if (open.ShowDialog() == DialogResult.OK)
            {
                //save file name to string
                string temp = open.SafeFileName;
                //remove .tga  
                if (checkNormal.Checked)
                {
                    textBox3.Text = temp.Remove(temp.Length - 4);
                }
                else
                {
                    //if not checked save full filename with .tga
                    textBox3.Text = temp;
                }

            }
        }

        private void buttonShading_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "                                      Выберите TGA ФАЙЛ";
            open.Filter = "Тип Файла(*tga)|*tga";
            if (open.ShowDialog() == DialogResult.OK)
            {
                //save file name to string
                string temp = open.SafeFileName;
                //remove .tga  
                if (checkShading.Checked)
                {
                    textBox4.Text = temp.Remove(temp.Length - 4);
                }
                else
                {
                    //if not checked save full filename with .tga
                    textBox4.Text = temp;
                }

            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Material user = new Material(
                textBox5.Text, textBox2.Text, 
                textBox3.Text, textBox4.Text
                );


            ListViewItem LVI = new ListViewItem(user.Name);
            LVI.Tag = user;
            lvUsers.Items.Add(LVI);
            ClearInput();
        }

        private void buttonMaterialName_Click(object sender, EventArgs e)
        {

        }
        private void ClearInput()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
        }

        private void lvUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvUsers.Items.Count==1)
            {
                Material user = (Material)lvUsers.SelectedItems[0].Tag;
                if(user!=null)
                {
                    textBox5.Text = user.Name;

                    textBox4.Text = user.Shading;
                    textBox2.Text = user.Texture;
                    textBox3.Text = user.NormalMap;

                }
            }
            else if(lvUsers.Items.Count == 0)
            {
                ClearInput();
            }
        }

        private void buttonSerialize_Click(object sender, EventArgs e)
        {
            _templates users = new _templates();
           
            foreach (ListViewItem item in lvUsers.Items)
            {
                if(item.Tag!=null)
                {
                     
                    users.CombineXMesh.Add((Material)item.Tag);
                }
            }
            XmlWriterSettings xmlSettings = new XmlWriterSettings();
            xmlSettings.OmitXmlDeclaration = false;
            xmlSettings.Encoding = Encoding.UTF8;


            SerializeXML(users);
        }
        private void SerializeXML(_templates users)
        {
         
            XmlSerializer xml = new XmlSerializer(typeof(_templates));

            using (FileStream fs = new FileStream( "windmill.xml", FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, users);
            }
            //using (XmlWriter writer = XmlWriter.Create(stream, settings))
        }
    }
}
