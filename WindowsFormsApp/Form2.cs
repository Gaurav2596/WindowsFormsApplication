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

namespace WindowsFormsApp
{
    public partial class btnCreateFolder : Form
    {
        public btnCreateFolder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DP4-2-Aug";
                if (Directory.Exists(path))
                {
                    MessageBox.Show("Folder is already exist");
                }
                else
                {
                    Directory.CreateDirectory(path);
                    MessageBox.Show("Folder is created");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DP4-2-Aug\doc1.txt";
                if (File.Exists(path))
                {
                    MessageBox.Show("File is alreay exist");
                }
                else
                {
                    File.Create(path);
                    MessageBox.Show("File is created");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnwritetofile_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DP4-2-Aug\product.dat";
                FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
                BinaryWriter binaryWriter = new BinaryWriter(fileStream);
                binaryWriter.Write(Convert.ToInt32(txtproductid.Text));
                binaryWriter.Write(txtproductname.Text);
                binaryWriter.Write(Convert.ToDouble(txtproductprice));
                binaryWriter.Close();
                fileStream.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnreload_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DP4-2-Aug\product.dat";
                FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                BinaryReader binaryReader = new BinaryReader(fileStream);
                txtproductid.Text = binaryReader.ReadInt32().ToString();
                txtproductname.Text = binaryReader.ReadString();
                txtproductprice.Text = binaryReader.ReadDouble().ToString();
                binaryReader.Close();
                fileStream.Close();
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreateFolder_Load(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DP4-2-Aug";
                if (Directory.Exists(path))
                {
                    MessageBox.Show("Folder is already exist");
                }
                else
                {
                    Directory.CreateDirectory(path);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
