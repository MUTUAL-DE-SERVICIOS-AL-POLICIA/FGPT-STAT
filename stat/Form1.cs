using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

   private void Button1_Click(object sender, EventArgs e)
   {
      Dictionary<string, string> afiliado_id = new Dictionary<string, string>();
			Dictionary<string, string> afiliado_hand = new Dictionary<string, string>();
			Dictionary<string, string> afiliado_fingerLeft_index = new Dictionary<string, string>();
			Dictionary<string, string> afiliado_fingerLeft_little = new Dictionary<string, string>();
			Dictionary<string, string> afiliado_fingerLeft_middle = new Dictionary<string, string>();
			Dictionary<string, string> afiliado_fingerLeft_ring = new Dictionary<string, string>();
			Dictionary<string, string> afiliado_fingerLeft_thumb = new Dictionary<string, string>();
			//
			Dictionary<string, string> afiliado_fingerRight_index = new Dictionary<string, string>();
			Dictionary<string, string> afiliado_fingerRight_little = new Dictionary<string, string>();
			Dictionary<string, string> afiliado_fingerRight_middle = new Dictionary<string, string>();
			Dictionary<string, string> afiliado_fingerRight_ring = new Dictionary<string, string>();
			Dictionary<string, string> afiliado_fingerRight_thumb = new Dictionary<string, string>();
			//
			Dictionary<string, string> afiliado_img_perfil = new Dictionary<string, string>();
			//
			Dictionary<string, string> afiliado_img_leftfour = new Dictionary<string, string>();
			Dictionary<string, string> afiliado_img_rightfour = new Dictionary<string, string>();
			Dictionary<string, string> afiliado_img_thumbs = new Dictionary<string, string>();

			 //Dictionary<string, string> afiliado_id = new Dictionary<string, string>();
				string path_fingerprint = "\\\\192.168.2.120\\pvt\\fingerprint";
				string path_picture = "\\\\192.168.2.120\\pvt\\picture";
				//REMOTE
				string path_remote_user = "pvt";
				string path_remote_password = "s4turn0";

				//verificar la red
				bool newtworkConnectionExist = false;
						try
						{
								using (new NetworkConnection(path_fingerprint, new NetworkCredential(path_remote_user, path_remote_password)))
								{
										//_directoryPath = "\\\\192.168.2.120\\utic\\PVT\\fingerprint\\3.txt";
										//File.Copy("D:\\2.txt", _directoryPath);                
										//   MessageBox.Show("hola");
								}
								newtworkConnectionExist = true;
						}
						catch (Exception ex)
						{
								//MessageBox.Show(ex.Message);
						}
						if (!newtworkConnectionExist)
						{
								MessageBox.Show("No se pudo conectar a la direccion 192.168.2.120 verifique la conexion de red");
								return;
						}




			//DATASYSTEM
			string file_name = "";
   string[] file_split;
   //
   string f_id = "";
			string f_hand = "";
			string f_finger = "";

						//DirectoryInfo d = new DirectoryInfo(@"fingerprint");//Assuming Test is your Folder
						DirectoryInfo d = new DirectoryInfo(path_fingerprint);//Assuming Test is your Folder
						

									FileInfo[] Files = d.GetFiles("*.wsq"); //Getting Text files
      string str = "";
      foreach (FileInfo file in Files)
      {
        file_name = file.Name;
        file_name = file_name.Replace(".wsq", "");
        file_split = file_name.Split("_".ToCharArray());

				//Data
				f_id = file_split[0];
				f_hand = file_split[1];
				f_finger = file_split[2];

				afiliado_id[f_id] = f_id;
				afiliado_hand[f_id] = f_hand;


				if (f_hand == "left") {
					switch (f_finger) {

						case "index":
							afiliado_fingerLeft_index[f_id] = f_finger;
						break;
						case "little":
						  afiliado_fingerLeft_little[f_id] = f_finger;
						break;
						case "middle":
							afiliado_fingerLeft_middle[f_id] = f_finger;
							break;
						case "ring":
							afiliado_fingerLeft_ring[f_id] = f_finger;
							break;
						case "thumb":
							afiliado_fingerLeft_thumb[f_id] = f_finger;
						break;
					}
				}

				if (f_hand == "right")
				{
					switch (f_finger)
					{

						case "index":
							afiliado_fingerRight_index[f_id] = f_finger;
							break;
						case "little":
							afiliado_fingerRight_little[f_id] = f_finger;
							break;
						case "middle":
							afiliado_fingerRight_middle[f_id] = f_finger;
						break;
						case "ring":
							afiliado_fingerRight_ring[f_id] = f_finger;
							break;
						case "thumb":
							afiliado_fingerRight_thumb[f_id] = f_finger;
						break;
					}
				}
				//GET DATA
				//afiliado_id = ""+file_split[0]+"";
			}













			//PICTURE PERFIL
			file_name = "";
			file_split = new string[] {};
						//
						//DirectoryInfo dp = new DirectoryInfo(@"picture");//Assuming Test is your Folder
						DirectoryInfo dp = new DirectoryInfo(path_picture);//Assuming Test is your Folder
						
						Files = dp.GetFiles("*.jpg"); //Getting Text files
			//FORDATA
			f_id = "";
			//
			foreach (FileInfo file in Files)
			{
				file_name = file.Name;
				file_name = file_name.Replace(".jpg", "");
				file_split = file_name.Split("_".ToCharArray());

				//Data
				f_id = file_split[0];

				afiliado_img_perfil[f_id] = f_id;
			}












			//MessageBox.Show(afiliado_id.Count.ToString());
			//afiliado_id.Count.ToString

			dataGridView1.ColumnCount = 13;
			//

			//HEADER
			dataGridView1.Columns[0].HeaderText = "#";
			dataGridView1.Columns[1].HeaderText = "Afiliado";
			//
			dataGridView1.Columns[2].HeaderText = "IZQ MEÑIQUE";
			dataGridView1.Columns[2].Width = 50;
			dataGridView1.Columns[3].HeaderText = "IZQ ANULAR";
			dataGridView1.Columns[3].Width = 50;
			dataGridView1.Columns[4].HeaderText = "IZQ MEDIO";
			dataGridView1.Columns[4].Width = 50;
			dataGridView1.Columns[5].HeaderText = "IZQ INDICE";
			dataGridView1.Columns[5].Width = 50;
			//
			dataGridView1.Columns[6].HeaderText = "DER MEÑIQUE";
			dataGridView1.Columns[6].Width = 50;
			dataGridView1.Columns[7].HeaderText = "DER ANULAR";
			dataGridView1.Columns[7].Width = 50;
			dataGridView1.Columns[8].HeaderText = "DER MEDIO";
			dataGridView1.Columns[8].Width = 50;
			dataGridView1.Columns[9].HeaderText = "DER INDICE";
			dataGridView1.Columns[9].Width = 50;
			//
			dataGridView1.Columns[10].HeaderText = "IZQ PULGAR";
			dataGridView1.Columns[10].Width = 50;
			dataGridView1.Columns[11].HeaderText = "DER PULGAR";
			dataGridView1.Columns[11].Width = 50;
			//
			dataGridView1.Columns[12].HeaderText = "FOTO";
			dataGridView1.Columns[12].Width = 50;

			//
			string left_little = "";
			string left_ring = "";
			string left_middle = "";
			string left_index = "";
			string left_thumb = "";
			//
			string right_little = "";
			string right_ring = "";
			string right_middle = "";
			string right_index = "";
			string right_thumb = "";
			//
			string b_fotoperfil = "";

			int i = 0;
			string k, v;
      foreach (KeyValuePair<string, string> kv in afiliado_id)
      {


				k = kv.Key.ToString();
				v = kv.Key.ToString();

				//MessageBox.Show(i.ToString());



				left_little = "";
				left_ring = "";
				left_middle = "";
				left_index = "";
				left_thumb = "";
				//
				if (afiliado_fingerLeft_little.ContainsKey(k)) {
					left_little = "X";
				}
				if (afiliado_fingerLeft_ring.ContainsKey(k))
				{
					left_ring = "X";
				}
				if (afiliado_fingerLeft_middle.ContainsKey(k))
				{
					left_middle = "X";
				}
				if (afiliado_fingerLeft_index.ContainsKey(k))
				{
					left_index = "X";
				}
				if (afiliado_fingerLeft_thumb.ContainsKey(k))
				{
					left_thumb = "X";
				}

				right_little = "";
				right_ring = "";
				right_middle = "";
				right_index = "";
				right_thumb = "";
				//
				if (afiliado_fingerRight_little.ContainsKey(k))
				{
					right_little = "X";
				}
				if (afiliado_fingerRight_ring.ContainsKey(k))
				{
					right_ring = "X";
				}
				if (afiliado_fingerRight_middle.ContainsKey(k))
				{
					right_middle = "X";
				}
				if (afiliado_fingerRight_index.ContainsKey(k))
				{
					right_index = "X";
				}
				if (afiliado_fingerRight_thumb.ContainsKey(k))
				{
					right_thumb = "X";
				}

				//FOTO PERFIL
				b_fotoperfil = "";
				if (afiliado_img_perfil.ContainsKey(k))
				{
					b_fotoperfil = "X";
				}

				DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[i].Clone();
				row.Cells[0].Value = i+1;
				row.Cells[1].Value = k;
				//
				row.Cells[2].Value = left_little;
				row.Cells[3].Value = left_ring;
				row.Cells[4].Value = left_middle;
				row.Cells[5].Value = left_index;
				//
				row.Cells[6].Value = right_little;
				row.Cells[7].Value = right_ring;
				row.Cells[8].Value = right_middle;
				row.Cells[9].Value = right_index;
				//
				row.Cells[10].Value = left_thumb;
				row.Cells[11].Value = right_thumb;
				//
				row.Cells[12].Value = b_fotoperfil;			


				dataGridView1.Rows.Add(row);

				i++;

			}








  }
    }
}
