using System;
using System.Windows.Forms;
using System.IO;
using System.CodeDom.Compiler;
using Microsoft.CSharp;
using Microsoft.Win32;

namespace CustomMessageApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            string title = titleTextBox.Text;
            string message = messageTextBox.Text;
            MessageBox.Show(message, title, MessageBoxButtons.OK);
        }

        private void errorButton_Click(object sender, EventArgs e)
        {
            string title = titleTextBox.Text;
            string message = messageTextBox.Text;
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            string title = titleTextBox.Text;
            string message = messageTextBox.Text;
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void criticalButton_Click(object sender, EventArgs e)
        {
            string title = titleTextBox.Text;
            string message = messageTextBox.Text;
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void compileButton_Click(object sender, EventArgs e)
        {
            string title = titleTextBox.Text;
            string message = messageTextBox.Text;

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Executable Files (*.exe)|*.exe",
                Title = "Save Executable File"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                string sourceCode = GenerateSourceCode(title, message);

                CompileExecutable(sourceCode, filePath);

                var result = MessageBox.Show("Would you like this .exe to run on system startup?", "Startup Option", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    SetStartup(filePath);
                }

                MessageBox.Show("Executable file created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string GenerateSourceCode(string title, string message)
        {
            return $@"
using System;
using System.Windows.Forms;

namespace GeneratedMessageApp
{{
    public class Program
    {{
        [STAThread]
        public static void Main()
        {{
            MessageBox.Show(""{message}"", ""{title}"", MessageBoxButtons.OK);
        }}
    }}
}}";
        }

        private void CompileExecutable(string sourceCode, string outputPath)
        {
            CSharpCodeProvider provider = new CSharpCodeProvider();
            CompilerParameters parameters = new CompilerParameters
            {
                GenerateExecutable = true,
                OutputAssembly = outputPath
            };

            parameters.ReferencedAssemblies.Add("System.dll");
            parameters.ReferencedAssemblies.Add("System.Windows.Forms.dll");

            CompilerResults results = provider.CompileAssemblyFromSource(parameters, sourceCode);

            if (results.Errors.Count > 0)
            {
                string errors = string.Join("\n", results.Errors);
                MessageBox.Show($"Compilation failed:\n{errors}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetStartup(string exePath)
        {
            string appName = Path.GetFileNameWithoutExtension(exePath);
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
            key.SetValue(appName, exePath);
        }
    }
}
