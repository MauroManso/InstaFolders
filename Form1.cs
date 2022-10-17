using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;

namespace InstaFolders
{
    public partial class FormMainInstaFolder : Form
    {
        
        String folderList= "";

        public FormMainInstaFolder()
        {
            InitializeComponent();
            RefreshChecklist("");
        }

        public void RefreshChecklist(string add)
        {
            if (checkBoxAssets.Checked == true) {
                if (folderList.Contains("mkdir __Assets\n") == false) folderList += "mkdir __Assets\n";
            }
            else folderList.Replace("mkdir __Assets\n", "");


            if (checkBox3DsMax.Checked == true)
            {
                if (folderList.Contains("mkdir 3DsMax\n") == false) folderList += "mkdir 3DsMax\n";
            }
            else folderList.Replace("mkdir 3DsMax\n", "");


            if (checkBoxAfterEffects.Checked == true)
            {
                if (folderList.Contains("mkdir AfterEffects\n") == false) folderList += "mkdir AfterEffects\n";
            }
            else folderList.Replace("mkdir AfterEffects\n", "");


            if (checkBoxBlender.Checked == true)
            {
                if (folderList.Contains("mkdir Blender\n") == false) folderList += "mkdir Blender\n";
            }
            else folderList.Replace("mkdir Blender\n", "");


            if (checkBoxCinema4D.Checked == true)
            {
                if (folderList.Contains("mkdir Cinema4D\n") == false) folderList += "mkdir Cinema4D\n";
            }
            else folderList.Replace("mkdir Cinema4D\n", "");


            if (checkBoxClarisse.Checked == true)
            {
                if (folderList.Contains("mkdir Clarisse\n") == false) folderList += "mkdir Clarisse\n";
            }
            else folderList.Replace("mkdir Clarisse\n", "");


            if (checkBoxDaVinci.Checked == true)
            {
                if (folderList.Contains("mkdir DaVinci\n") == false) folderList += "mkdir DaVinci\n";
            }
            else folderList.Replace("mkdir DaVinci\n", "");


            if (checkBoxHoudini.Checked == true)
            {
                if (folderList.Contains("mkdir Houdini\n") == false) folderList += "mkdir Houdini\n";
            }
            else folderList.Replace("mkdir Houdini\n", "");


            if (checkBoxIlustrator.Checked == true)
            {
                if (folderList.Contains("mkdir Ilustrator\n") == false) folderList += "mkdir Ilustrator\n";
            }
            else folderList.Replace("mkdir Ilustrator\n", "");


            if (checkBoxKrita.Checked == true)
            {
                if (folderList.Contains("mkdir Krita\n") == false) folderList += "mkdir Krita\n";
            }
            else folderList.Replace("mkdir Krita\n", "");


            if (checkBoxMarvelous.Checked == true)
            {
                if (folderList.Contains("mkdir Marvelous\n") == false) folderList += "mkdir Marvelous\n";
            }
            else folderList.Replace("mkdir Marvelous\n", "");


            if (checkBoxMaya.Checked == true)
            {
                if (folderList.Contains("mkdir Maya\n") == false) folderList += "mkdir Maya\n";
            }
            else folderList.Replace("mkdir Maya\n", "");


            if (checkBoxNuke.Checked == true)
            {
                if (folderList.Contains("mkdir Nuke\n") == false) folderList += "mkdir Nuke\n";
            }
            else folderList.Replace("mkdir Nuke\n", "");


            if (checkBoxPhotoshop.Checked == true)
            {
                if (folderList.Contains("mkdir Photoshop\n") == false) folderList += "mkdir Photoshop\n";
            }
            else folderList.Replace("mkdir Photoshop\n", "");


            if (checkBoxPremiere.Checked == true)
            {
                if (folderList.Contains("mkdir Premiere\n") == false) folderList += "mkdir Premiere\n";
            }
            else folderList.Replace("mkdir Premiere\n", "");


            if (checkBoxSpeedTree.Checked == true)
            {
                if (folderList.Contains("mkdir SpeedTree\n") == false) folderList += "mkdir SpeedTree\n";
            }
            else folderList.Replace("mkdir SpeedTree\n", "");


            if (checkBoxSubstance.Checked == true)
            {
                if (folderList.Contains("mkdir Substance\n") == false) folderList += "mkdir Substance\n";
            }
            else folderList.Replace("mkdir Substance\n", "");


            if (checkBoxTerragen.Checked == true)
            {
                if (folderList.Contains("mkdir Terragen\n") == false) folderList += "mkdir Terragen\n";
            }
            else folderList.Replace("mkdir Terragen\n", "");


            if (checkBoxUnreal.Checked == true)
            {
                if (folderList.Contains("mkdir Unreal\n") == false) folderList += "mkdir Unreal\n";
            }
            else folderList.Replace("mkdir Unreal\n", "");


            if (checkBoxZBrush.Checked == true)
            {
                if (folderList.Contains("mkdir ZBrush\n") == false) folderList += "mkdir ZBrush\n";
            }
            else folderList.Replace("mkdir ZBrush\n", "");


            if (add.Length > 1)
            {
                folderList += add;
            }


            richTextBox1.Text = folderList;
        }

        static void ExecuteCommand(string command)
        {
            int exitCode;
            ProcessStartInfo processInfo;
            Process process;

            processInfo = new ProcessStartInfo("cmd.exe", "/c " + command);
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            // *** Redirect the output ***
            processInfo.RedirectStandardError = true;
            processInfo.RedirectStandardOutput = true;

            process = Process.Start(processInfo);
            process.WaitForExit();

            // *** Read the streams ***
            // Warning: This approach can lead to deadlocks, see Edit #2
            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();

            exitCode = process.ExitCode;

            Console.WriteLine("output>>" + (String.IsNullOrEmpty(output) ? "(none)" : output));
            Console.WriteLine("error>>" + (String.IsNullOrEmpty(error) ? "(none)" : error));
            Console.WriteLine("ExitCode: " + exitCode.ToString(), "ExecuteCommand");
            process.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            RefreshChecklist("");
            string projectName = textBoxProjectName.Text;
            string command = "@echo off\r\ncls \r\n\r\nset projectName= \"" + projectName + " \"\r\ncd D:\\\\Projects \r\n\r\nmkdir %projectName%\r\ncd %projectName%\n" + richTextBox1.Text;
            
            richTextBox1.Text = command;

            ExecuteCommand(command);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string folderAdd = "";
            if (textBoxAdd.Text.Length > 1)
            {
                folderAdd = "mkdir " + textBoxAdd.Text + "\n";
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