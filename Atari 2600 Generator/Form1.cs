using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Game_Gear_Generator
{
    public partial class Form1 : Form
    {
        List<String> _html;
        public Form1()
        {
            InitializeComponent();
            _html = new List<string>();
            _html.Add("<html>");
            _html.Add("<body>");
            _html.Add("<object type=\"application/x-java-applet\" archive=\"{0}\" code=\"jstella.applet.JStellaApplet.class\" width=\"{1}\" height=\"{2}\">");//Emulador i Resolucio
            _html.Add("<param name=\"ROM\" value=\"{0}\">");//Rom
            _html.Add("<param name=\"OPTIONSPANELENABLED\" value=\"{0}\">"); //Menu TRUE FALSE
            _html.Add("<param name=\"PADDLEMODE\" value=\"\">");//Paddle mode si es posa s'activa
            _html.Add("</object>");
            _html.Add("</html>");
            _html.Add("</body>");

        }


        private void Form_Load(object sender, EventArgs e)
        {
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(Form_DragEnter);
            this.DragDrop += new DragEventHandler(Form_DragDrop);
        }

        void Form_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy; // Okay
            else
                e.Effect = DragDropEffects.None; // Unknown data, ignore it
        }


        void Form_DragDrop(object sender, DragEventArgs e)
        {
            string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (FileList.Length == 1)
                if (Directory.Exists(FileList[0]))
                    FileList = Directory.GetFiles(FileList[0]);


            pictureBox1.Visible = false;


            if (checkBoxRenombrar.Checked)
            {
                label3.Visible = true;
                label3.Text = "Renombrant...";
                int renomrats;
                FileList = renombrar(FileList,out renomrats);

            }



            label3.Visible = true;
            label3.Text = "Generant...";
            int generats = Generar(FileList);

           

            if (FileList.Length == 1)
            {
                MessageBox.Show(String.Format("Generat {0} archiu HTML a la seguent ruta: \r {1}", FileList.Length, Path.GetDirectoryName(FileList[0])));
            }
            else
            {
                MessageBox.Show(String.Format("Generat {0} archius HTML a la seguent ruta: \r {1}", FileList.Length, Path.GetDirectoryName(FileList[0])));
            }

            pictureBox1.Visible = true;
            label3.Visible = false;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            var source = sender as TextBox;
            String t = source.Text;
            foreach (char ch in t)
            {
                if (char.IsDigit(ch) == false)
                {
                    source.Text = String.Empty;
                    MessageBox.Show("Nomes numeros!!");
                    return;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private int Generar(String[] FileList)
        {

            int generats=0;

            foreach (string file in FileList)
            {
                if (file == null) continue;
                String ext = Path.GetExtension(file);
                if (ext == ".txt" || ext == ".zip" || ext == ".htm" || ext == ".html" || ext == ".exe" || ext == ".jpg" || ext == ".png")
                    continue;

                string rom = Path.GetFileName(file);
                string path = Path.GetDirectoryName(file);
                string name = Path.GetFileNameWithoutExtension(file);
                string htmlPath = Path.Combine(path, name);
                htmlPath += ".html";

                var stream = File.CreateText(htmlPath);

                short cont = 0;
                foreach (string str in _html)
                {
                    String myStr = str;
                    switch (cont)
                    {
                        case 2: //Resolucio i EMulador

                            if (String.IsNullOrWhiteSpace(textBoxResX.Text))
                            {
                                MessageBox.Show("Resolucio X no pot esta vuida, introdueix un numero i torna a arrastrar les ROMs");
                                return 0;
                            }
                            else if (String.IsNullOrWhiteSpace(textBoxResY.Text))
                            {
                                MessageBox.Show("Resolucio Y no pot esta vuida, introdueix un numero i torna a arrastrar les ROMs");
                                File.Delete(htmlPath);
                                return 0;
                            }

                            myStr = String.Format(str, textEmulador.Text, textBoxResX.Text, textBoxResY.Text);
                            break;

                        case 3://ROM
                            myStr = String.Format(str, rom);
                            break;



                        case 4://Menu
                            string menu;
                            if (checkBoxOptionMEnu.Checked) menu = "TRUE";
                            else menu = "FALSE";
                            myStr = String.Format(str, menu);
                            break;

                        case 5:
                            if (radioPaddleAuto.Checked)
                            {
                                string filename = file.ToLower();

                                if (filename.Contains("paddle") == false)
                                {
                                    cont++;
                                    continue;
                                    //MyStr = String.Empty;
                                }
                            }

                            else if (radioPaddleOff.Checked)
                            {
                                cont++;
                                continue;
                                //MyStr = String.Empty;
                            }

                            break;
                    }

                    stream.WriteLine(myStr);
                    cont++;
                }

                stream.Close();
                generats++;
            }
            return generats; 
        }

        private String[] renombrar(String[] archiusArenombrar, out int contRenombrats)
        {

            String[] ret = new String[archiusArenombrar.Length];

            //OpenFileDialog ofd = new OpenFileDialog();
            //ofd.Multiselect = true;
            //ofd.Filter = "Roms d'Atari (*.bin)|*.bin|Qualsevol alrchiu (*.*)|*.*";
            //ofd.ShowDialog(this);
            //String[] files = ofd.FileNames;
            String[] files = archiusArenombrar;


            int contTOtal = 0;
             contRenombrats = 0;
            foreach (string file in files)
            {

                ret[contTOtal] = file;
                string filename = Path.GetFileNameWithoutExtension(file);
                string path = Path.GetDirectoryName(file);
                string extension = Path.GetExtension(file);

                if (filename.StartsWith("19"))
                {
                    if (Char.IsDigit(filename[2]) && Char.IsDigit(filename[3]))
                        continue;
                }



                for (int i = 0; i < filename.Length; i++)
                {
                    char c = filename[i];

                    if (i == filename.Length - 3) break;
                    if (Char.IsDigit(c))
                    {
                        char[] str = new char[4];

                        str[0] = filename[i];
                        str[1] = filename[i + 1];
                        str[2] = filename[i + 2];
                        str[3] = filename[i + 3];

                        if (str[0] != '1') continue;
                        if (str[1] != '9') continue;
                        if (Char.IsDigit(str[2]) == false) continue;
                        if (Char.IsDigit(str[3]) == false) continue;


                        if (i < 0)
                            if (Char.IsDigit(filename[i - 1]) == true) continue;

                        if (i + 4 < filename.Length)
                            if (Char.IsDigit(filename[i + 4]) == true) continue;


                        String any = new String(str);
                        String newName = path + "\\" + any + " - " + filename + "." + extension;
                        File.Move(file, newName);
                        ret[contTOtal] = newName;
                        contRenombrats++;
                        break;
                    }

                }
                contTOtal++;
            }

            return ret;

        }
    }
}
