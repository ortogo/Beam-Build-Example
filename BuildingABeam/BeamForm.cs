using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildingABeam
{
    public partial class BeamForm : Form
    {

        private ProjectDocument RingBeam = new ProjectDocument();
        public BeamForm()
        {
            InitializeComponent();
            CustomInitialize();
            UpdateParameters();
        }

        private void CustomInitialize()
        {
            BeamLength.TextChanged += DimensionChanged;
            ExternalDiameter.TextChanged += DimensionChanged;
            Depth.TextChanged += DimensionChanged;
            BeamLength.KeyPress += HandleKeyPress;
            ExternalDiameter.KeyPress += HandleKeyPress;
            Depth.KeyPress += HandleKeyPress;
            SelectBeam.Filter = ProjectDocument.docName + "|"
                + ProjectDocument.docName + "|Любые(*.*)|*.*";
        }

        private void RealtimeCheckNumberInput(char key)
        {

        }

        private void DimensionChanged(object sender, EventArgs e)
        {
            UpdateParameters();
        }

        private void UpdateParameters()
        {
            try
            {
                RingBeam.externalDiameter = Double.Parse(ExternalDiameter.Text);
                RingBeam.depth = Double.Parse(Depth.Text);
                RingBeam.length = Double.Parse(BeamLength.Text);
            }
            catch (Exception ex)
            {
                return;
            }
            RingBeam.volume = (Math.Pow(RingBeam.externalDiameter, 2)
                    - Math.Pow(RingBeam.externalDiameter - RingBeam.depth * 2, 2))
                    * Math.PI * RingBeam.length / 4000000000;

            string nl = Environment.NewLine;
            BeamParams.Text = $"Объем {RingBeam.volume}м куб{nl}";
        }

        private void Build_Click(object sender, EventArgs e)
        {
            if (PathToBeam.Text.EndsWith(ProjectDocument.docName))
            {
                BlockInput();
                RingBeam.pathToBeam = PathToBeam.Text;
                RingBeam.Build(UpdateState);
                UnblockInput();
            } else
            {
                MessageBox.Show("Выберите " + ProjectDocument.docName);
            }
        }

        public void UpdateState(int progress, string message)
        {
            if (progress > 0 && progressBar1.Value < 100)
            {
                progressBar1.Value += 1;
            }
            progressBar1.Value = progress;
            buildstate.Text = message;
        }

        private void HandleKeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            string numbers = "0123456789,.";
            TextBox tb = (TextBox)sender;

            if (key >= 26)
            {

                if (numbers.IndexOf(key) >= 0)
                {
                    if (tb.Text.IndexOf(',') >= 0 && (key == ',' || key == '.'))
                    {
                        e.Handled = true;
                    } else if (key== '.')
                    {
                        e.KeyChar = ',';
                        base.OnKeyPress(e);
                    }
                } else
                {
                    e.Handled = true;
                }
                
            }
            else
            {
                base.OnKeyPress(e);
            }

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void BlockInput(bool state=true)
        {
            BeamLength.ReadOnly = state;
            Depth.ReadOnly = state;
            ExternalDiameter.ReadOnly = state;
            Build.Enabled = !state;
        }

        private void UnblockInput()
        {
            BlockInput(false);
        }

        private void OpenSelectDialog_Click(object sender, EventArgs e)
        {
            if (SelectBeam.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = SelectBeam.FileName;

            PathToBeam.Text = filename;
        }
    }
}
