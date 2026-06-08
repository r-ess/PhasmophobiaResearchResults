namespace GhostGym
{
    public partial class Form1 : Form
    {
        double[] visTableNormal = [0.1, 0.22, 0.18, 0.08, 0.28, 0.2, 0.16, 0.25, 0.18, 0.22];
        double[] totalTableNormal = [0.36, 0.6, 0.46, 1, 0.82, 0.3, 0.48, 0.7, 0.82, 0.45];
        double[] visTablePhantom = [0.1, 0.22, 0.18, 0.08, 0.28, 0.2, 0.16, 0.25, 0.18, 0.22];
        double[] totalTablePhantom = [1.1, 1.87, 1.2, 1.6, 1.8, 1.28, 1.7, 1.42, 2, 1.49];
        double[] visTableOni = [0.34, 0.28, 0.5, 0.46, 0.32, 0.26, 0.4, 0.34, 0.47, 0.3, 0.49, 0.24, 0.45];
        double[] totalTableOni = [0.3, 0.45, 0.4, 0.55, 0.6, 0.32, 0.48, 0.4, 0.55, 0.5];
        double[] visTableDeogen = [0.27, 0.22, 0.25, 0.21, 0.28, 0.23, 0.3, 0.24, 0.29, 0.21, 0.24, 0.28, 0.26];
        double[] totalTableDeogen = [0.3, 0.45, 0.4, 0.55, 0.6, 0.32, 0.48, 0.4, 0.55, 0.5];

        double[] speeds = [2, 1.5, 1, 0.75, 0.5, 0.25, 0.1];
        int idVis = 0, idTotal = 0;
        int photosSuccess = 0;
        int photosTotal = 0;
        bool canTakePhotos = false;

        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 2;
            comboBox2.SelectedIndex = 0;
            checkGoodBox.Visible = false;
            checkBadBox.Visible = false;
            photoButton.Enabled = false;
            accuracyLabel.Visible = false;
            randOffsetCheckBox.Enabled = false;
            SetSelectorButtons();
        }

        int GetVisTimeMS()
        {
            double ret;
            switch (comboBox2.SelectedIndex)
            {
                case 1: // Phantom
                    idVis %= visTablePhantom.Length;
                    ret = visTablePhantom[idVis];
                    break;
                case 2: // Oni
                    idVis %= visTableOni.Length;
                    ret = visTableOni[idVis];
                    break;
                case 3: // Deogen
                    idVis %= visTableDeogen.Length;
                    ret = visTableDeogen[idVis];
                    break;
                default: // Normal
                    idVis %= visTableNormal.Length;
                    ret = visTableNormal[idVis];
                    break;
            }
            return (int)(ret * 1000 / speeds[comboBox1.SelectedIndex]);
        }

        int GetTotalTimeMS()
        {
            double ret;
            switch (comboBox2.SelectedIndex)
            {
                case 1: // Phantom
                    idTotal %= totalTablePhantom.Length;
                    ret = totalTablePhantom[idTotal];
                    break;
                case 2: // Oni
                    idTotal %= totalTableOni.Length;
                    ret = totalTableOni[idTotal];
                    break;
                case 3: // Deogen
                    idTotal %= totalTableDeogen.Length;
                    ret = totalTableDeogen[idTotal];
                    break;
                default: // Normal
                    idTotal %= totalTableNormal.Length;
                    ret = totalTableNormal[idTotal];
                    break;
            }
            return (int)(ret * 1000 / speeds[comboBox1.SelectedIndex]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            if (timer1.Enabled) // stop
            {
                timer1.Stop();
                visTimer1.Stop();
                visTimer2.Stop();
                visTimer3.Stop();
                photoTimer.Stop();
                photoCooldown.Stop();
                button1.Text = "Start";
                comboBox2.Enabled = true;
                photoButton.Enabled = false;
                visEntrySelector.Enabled = true;
                totalEntrySelector.Enabled = true;
                randomCheckBox.Enabled = true;
                randOffsetCheckBox.Enabled = randomCheckBox.Checked;
            }
            else // start
            {
                visEntrySelector.Enabled = false;
                totalEntrySelector.Enabled = false;
                if (randomCheckBox.Checked)
                {
                    var rand = new Random();
                    idVis = rand.Next(0, 10);
                    if (randOffsetCheckBox.Checked)
                    {
                        idTotal = rand.Next(0, 10);
                    }
                    else
                        idTotal = idVis;
                }
                else
                {
                    idVis = (int)visEntrySelector.Value;
                    idTotal = (int)totalEntrySelector.Value;
                }
                visLabel.Text = idVis.ToString();
                totalLabel.Text = idTotal.ToString();
                timer1.Interval = GetTotalTimeMS();
                timer1.Start();
                visTimer1.Interval = GetVisTimeMS();
                visTimer1.Start();
                button1.Text = "Stop";
                comboBox2.Enabled = false;
                randomCheckBox.Enabled = false;
                randOffsetCheckBox.Enabled = false;
                photosSuccess = 0;
                photosTotal = 0;
                checkGoodBox.Visible = false;
                checkBadBox.Visible = false;
                accuracyLabel.Text = "Successful: 0; Total: 0; Accuracy: 0%";
                photoButton.Enabled = true;
                accuracyLabel.Visible = true;
                canTakePhotos = true;
            }
        }

        void SetSelectorButtons()
        {
            visEntrySelector.Minimum = -1;
            totalEntrySelector.Minimum = -1;
            switch (comboBox2.SelectedIndex)
            {
                case 1: // Phantom
                    visEntrySelector.Maximum = visTablePhantom.Length;
                    totalEntrySelector.Maximum = totalTablePhantom.Length;
                    break;
                case 2: // Oni
                    visEntrySelector.Maximum = visTableOni.Length;
                    totalEntrySelector.Maximum = totalTableOni.Length;
                    break;
                case 3: // Deogen
                    visEntrySelector.Maximum = visTableDeogen.Length;
                    totalEntrySelector.Maximum = totalTableDeogen.Length;
                    break;
                default: // Normal
                    visEntrySelector.Maximum = visTableNormal.Length;
                    totalEntrySelector.Maximum = totalTableNormal.Length;
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            idTotal++;
            idVis++;
            timer1.Interval = GetTotalTimeMS();
            timer1.Start();
            pictureBox1.Visible = true;
            if (!visTimer1.Enabled)
            {
                visTimer1.Interval = GetVisTimeMS();
                visTimer1.Start();
            }
            else if (!visTimer2.Enabled)
            {
                visTimer2.Interval = GetVisTimeMS();
                visTimer2.Start();
            }
            else if (!visTimer3.Enabled)
            {
                visTimer3.Interval = GetVisTimeMS();
                visTimer3.Start();
            }
            else
            {
                MessageBox.Show("Available timers ran out!", "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
            visLabel.Text = idVis.ToString();
            totalLabel.Text = idTotal.ToString();
        }
        private void visTimer1_Tick(object sender, EventArgs e)
        {
            visTimer1.Stop();
            pictureBox1.Visible = false;
        }

        private void visTimer2_Tick(object sender, EventArgs e)
        {
            visTimer2.Stop();
            pictureBox1.Visible = false;
        }

        private void visTimer3_Tick(object sender, EventArgs e)
        {
            visTimer3.Stop();
            pictureBox1.Visible = false;
        }

        void TakePhoto()
        {
            if (!canTakePhotos) return;
            photoTimer.Stop();
            canTakePhotos = false;
            photoButton.Enabled = false;
            photosTotal++;
            if (pictureBox1.Visible)
            {
                photosSuccess++;
                checkBadBox.Visible = false;
                checkGoodBox.Visible = true;
            }
            else
            {
                checkBadBox.Visible = true;
                checkGoodBox.Visible = false;
            }
            accuracyLabel.Text = $"Successful: {photosSuccess}; " +
                $"Total: {photosTotal}; " +
                $"Accuracy: {(int)((double)photosSuccess / photosTotal * 100)}%";
            photoCooldown.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SetSelectorButtons();
        }

        private void visEntrySelector_ValueChanged(object sender, EventArgs e)
        {
            if (visEntrySelector.Value >= visEntrySelector.Maximum)
            {
                visEntrySelector.Value = 0;
            }
            else if (visEntrySelector.Value <= -1)
            {
                visEntrySelector.Value = visEntrySelector.Maximum - 1;
            }
        }

        private void totalEntrySelector_ValueChanged(object sender, EventArgs e)
        {
            if (totalEntrySelector.Value >= totalEntrySelector.Maximum)
            {
                totalEntrySelector.Value = 0;
            }
            else if (totalEntrySelector.Value <= -1)
            {
                totalEntrySelector.Value = totalEntrySelector.Maximum - 1;
            }
        }

        private void photoButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left || !canTakePhotos) return;
            photoTimer.Start();
        }

        private void photoButton_Click(object sender, EventArgs e)
        {
            TakePhoto();
        }

        private void photoButton_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void photoTimer_Tick(object sender, EventArgs e)
        {
            TakePhoto();
        }

        private void photoCooldown_Tick(object sender, EventArgs e)
        {
            canTakePhotos = true;
            photoButton.Enabled = true;
            photoCooldown.Stop();
        }

        private void randomCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            randOffsetCheckBox.Enabled = randomCheckBox.Checked;
            if (!randomCheckBox.Checked)
                randOffsetCheckBox.Checked = false;
        }
    }
}
