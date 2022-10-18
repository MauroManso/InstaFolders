using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;
using System.IO;

namespace InstaFolders
{
    public partial class FormMainInstaFolder : Form
    {

        List<string> folderList = new List<string>();

        public FormMainInstaFolder()
        {
            InitializeComponent();
            RefreshChecklist("");
        }

        public void RefreshChecklist(string add)
        {
            if (checkBoxAssets.Checked)
            {
                if (folderList.Contains("__Assets") == false) folderList.Add("__Assets");
            }
            else if (folderList.Contains("__Assets")) folderList.Remove("__Assets");



            if (checkBox3DsMax.Checked)
            {
                if (folderList.Contains("3DsMax") == false) folderList.Add("3DsMax");
            }
            else if (folderList.Contains("3DsMax")) folderList.Remove("3DsMax");


            if (checkBoxAfterEffects.Checked)
            {
                if (folderList.Contains("AfterEffects") == false) folderList.Add("AfterEffects");
            }
            else if (folderList.Contains("AfterEffects")) folderList.Remove("AfterEffects");


            if (checkBoxBlender.Checked)
            {
                if (folderList.Contains("Blender") == false) folderList.Add("Blender");
            }
            else if (folderList.Contains("Blender")) folderList.Remove("Blender");


            if (checkBoxCinema4D.Checked)
            {
                if (folderList.Contains("Cinema4D") == false) folderList.Add("Cinema4D");
            }
            else if (folderList.Contains("Cinema4D")) folderList.Remove("Cinema4D");


            if (checkBoxClarisse.Checked)
            {
                if (folderList.Contains("Clarisse") == false) folderList.Add("Clarisse");
            }
            else if (folderList.Contains("Clarisse")) folderList.Remove("Clarisse");


            if (checkBoxDaVinci.Checked)
            {
                if (folderList.Contains("DaVinci") == false) folderList.Add("DaVinci");
            }
            else if (folderList.Contains("DaVinci")) folderList.Remove("DaVinci");


            if (checkBoxHoudini.Checked)
            {
                if (folderList.Contains("Houdini") == false) folderList.Add("Houdini");
            }
            else if (folderList.Contains("Houdini")) folderList.Remove("Houdini");


            if (checkBoxIlustrator.Checked)
            {
                if (folderList.Contains("Ilustrator") == false) folderList.Add("Ilustrator");
            }
            else if (folderList.Contains("Ilustrator")) folderList.Remove("Ilustrator");


            if (checkBoxKrita.Checked)
            {
                if (folderList.Contains("Krita") == false) folderList.Add("Krita");
            }
            else if (folderList.Contains("Krita")) folderList.Remove("Krita");


            if (checkBoxMarvelous.Checked)
            {
                if (folderList.Contains("Marvelous") == false) folderList.Add("Marvelous");
            }
            else if (folderList.Contains("Marvelous")) folderList.Remove("Marvelous");


            if (checkBoxMaya.Checked)
            {
                if (folderList.Contains("Maya") == false) folderList.Add("Maya");
            }
            else if (folderList.Contains("Maya")) folderList.Remove("Maya");


            if (checkBoxNuke.Checked)
            {
                if (folderList.Contains("Nuke") == false) folderList.Add("Nuke");
            }
            else if (folderList.Contains("Nuke")) folderList.Remove("Nuke");


            if (checkBoxPhotoshop.Checked)
            {
                if (folderList.Contains("Photoshop") == false) folderList.Add("Photoshop");
            }
            else if (folderList.Contains("Photoshop")) folderList.Remove("Photoshop");


            if (checkBoxPremiere.Checked)
            {
                if (folderList.Contains("Premiere") == false) folderList.Add("Premiere");
            }
            else if (folderList.Contains("Premiere")) folderList.Remove("Premiere");


            if (checkBoxSpeedTree.Checked)
            {
                if (folderList.Contains("SpeedTree") == false) folderList.Add("SpeedTree");
            }
            else if (folderList.Contains("SpeedTree")) folderList.Remove("SpeedTree");


            if (checkBoxSubstance.Checked)
            {
                if (folderList.Contains("Substance") == false) folderList.Add("Substance");
            }
            else if (folderList.Contains("Substance")) folderList.Remove("Substance");


            if (checkBoxTerragen.Checked)
            {
                if (folderList.Contains("Terragen") == false) folderList.Add("Terragen");
            }
            else if (folderList.Contains("Terragen")) folderList.Remove("Terragen");


            if (checkBoxUnreal.Checked)
            {
                if (folderList.Contains("Unreal") == false) folderList.Add("Unreal");
            }
            else if (folderList.Contains("Unreal")) folderList.Remove("Unreal");


            if (checkBoxZBrush.Checked)
            {
                if (folderList.Contains("ZBrush") == false) folderList.Add("ZBrush");
            }
            else if (folderList.Contains("ZBrush")) folderList.Remove("ZBrush");


            if(add.Length > 1)
            {
                folderList.Add(add);

            }

            richTextBox1.Clear();
            foreach (string folderName in folderList)
            {
                richTextBox1.Text += folderName + "\n";
            }
                
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            RefreshChecklist("");
            string projectName = textBoxProjectName.Text;

            string dir = @"D:\Projects\" + projectName;
            // If directory does not exist, create it
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            foreach (string folderName in folderList)
            {
                string subdir = @"D:\Projects\" + projectName + @"\" + folderName;
                // If directory does not exist, create it
                if (!Directory.Exists(subdir))
                {
                    Directory.CreateDirectory(subdir);
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string folderAdd = "";
            if (textBoxAdd.Text.Length > 1)
            {
                folderAdd = textBoxAdd.Text;
                RefreshChecklist(folderAdd);
            }
            textBoxAdd.Clear();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBoxAssets_CheckedChanged(object sender, EventArgs e)
        {
            RefreshChecklist("");
        }

        private void checkBox3DsMax_CheckedChanged(object sender, EventArgs e)
        {
            RefreshChecklist("");
        }

        private void checkBoxAfterEffects_CheckedChanged(object sender, EventArgs e)
        {
            RefreshChecklist("");
        }

        private void checkBoxBlender_CheckedChanged(object sender, EventArgs e)
        {
            RefreshChecklist("");
        }

        private void checkBoxCinema4D_CheckedChanged(object sender, EventArgs e)
        {
            RefreshChecklist("");
        }

        private void checkBoxClarisse_CheckedChanged(object sender, EventArgs e)
        {
            RefreshChecklist("");
        }

        private void checkBoxDaVinci_CheckedChanged(object sender, EventArgs e)
        {
            RefreshChecklist("");
        }

        private void checkBoxHoudini_CheckedChanged(object sender, EventArgs e)
        {
            RefreshChecklist("");
        }

        private void checkBoxIlustrator_CheckedChanged(object sender, EventArgs e)
        {
            RefreshChecklist("");
        }

        private void checkBoxKrita_CheckedChanged(object sender, EventArgs e)
        {
            RefreshChecklist("");
        }

        private void checkBoxMarvelous_CheckedChanged(object sender, EventArgs e)
        {
            RefreshChecklist("");
        }

        private void checkBoxMaya_CheckedChanged(object sender, EventArgs e)
        {
            RefreshChecklist("");
        }

        private void checkBoxNuke_CheckedChanged(object sender, EventArgs e)
        {
            RefreshChecklist("");
        }

        private void checkBoxPhotoshop_CheckedChanged(object sender, EventArgs e)
        {
            RefreshChecklist("");
        }

        private void checkBoxPremiere_CheckedChanged(object sender, EventArgs e)
        {
            RefreshChecklist("");
        }

        private void checkBoxSpeedTree_CheckedChanged(object sender, EventArgs e)
        {
            RefreshChecklist("");
        }

        private void checkBoxTerragen_CheckedChanged(object sender, EventArgs e)
        {
            RefreshChecklist("");
        }

        private void checkBoxSubstance_CheckedChanged(object sender, EventArgs e)
        {
            RefreshChecklist("");
        }

        private void checkBoxUnreal_CheckedChanged(object sender, EventArgs e)
        {
            RefreshChecklist("");
        }

        private void checkBoxZBrush_CheckedChanged(object sender, EventArgs e)
        {
            RefreshChecklist("");
        }
    }
}