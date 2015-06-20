﻿using NAudio.Wave;
using System;
using System.Windows.Forms;
using System.Xml;

namespace LiveSplit.UI.Components
{
    public partial class SoundSettings : UserControl
    {
        public String Split { get; set; }
        public String SplitAheadGaining { get; set; }
        public String SplitAheadLosing { get; set; }
        public String SplitBehindGaining { get; set; }
        public String SplitBehindLosing { get; set; }
        public String BestSegment { get; set; }
        public String UndoSplit { get; set; }
        public String SkipSplit { get; set; }
        public String PersonalBest { get; set; }
        public String NotAPersonalBest { get; set; }
        public String Reset { get; set; }
        public String Pause { get; set; }
        public String Resume { get; set; }
        public String StartTimer { get; set; }

        public int OutputDevice { get; set; }

        public int GeneralVolume { get; set; }
        public int SplitVolume { get; set; }
        public int SplitAheadGainingVolume { get; set; }
        public int SplitAheadLosingVolume { get; set; }
        public int SplitBehindGainingVolume { get; set; }
        public int SplitBehindLosingVolume { get; set; }
        public int BestSegmentVolume { get; set; }
        public int UndoSplitVolume { get; set; }
        public int SkipSplitVolume { get; set; }
        public int PersonalBestVolume { get; set; }
        public int NotAPersonalBestVolume { get; set; }
        public int ResetVolume { get; set; }
        public int PauseVolume { get; set; }
        public int ResumeVolume { get; set; }
        public int StartTimerVolume { get; set; }

        public SoundSettings()
        {
            InitializeComponent();

            Split =
            SplitAheadGaining =
            SplitAheadLosing =
            SplitBehindGaining =
            SplitBehindLosing =
            BestSegment =
            UndoSplit =
            SkipSplit =
            PersonalBest =
            NotAPersonalBest =
            Reset =
            Pause =
            Resume =
            StartTimer = "";

            OutputDevice = 0;

            GeneralVolume =
            SplitVolume =
            SplitAheadGainingVolume =
            SplitAheadLosingVolume =
            SplitBehindGainingVolume =
            SplitBehindLosingVolume =
            BestSegmentVolume =
            UndoSplitVolume =
            SkipSplitVolume =
            PersonalBestVolume =
            NotAPersonalBestVolume =
            ResetVolume =
            PauseVolume =
            ResumeVolume =
            StartTimerVolume = 100;

            for (int i = 0; i < WaveOut.DeviceCount; ++i)
                cbOutputDevice.Items.Add(WaveOut.GetCapabilities(i));

            txtSplitPath.DataBindings.Add("Text", this, "Split");
            txtSplitAheadGaining.DataBindings.Add("Text", this, "SplitAheadGaining");
            txtSplitAheadLosing.DataBindings.Add("Text", this, "SplitAheadLosing");
            txtSplitBehindGaining.DataBindings.Add("Text", this, "SplitBehindGaining");
            txtSplitBehindLosing.DataBindings.Add("Text", this, "SplitBehindLosing");
            txtBestSegment.DataBindings.Add("Text", this, "BestSegment");
            txtUndo.DataBindings.Add("Text", this, "UndoSplit");
            txtSkip.DataBindings.Add("Text", this, "SkipSplit");
            txtPersonalBest.DataBindings.Add("Text", this, "PersonalBest");
            txtNotAPersonalBest.DataBindings.Add("Text", this, "NotAPersonalBest");
            txtReset.DataBindings.Add("Text", this, "Reset");
            txtPause.DataBindings.Add("Text", this, "Pause");
            txtResume.DataBindings.Add("Text", this, "Resume");
            txtStartTimer.DataBindings.Add("Text", this, "StartTimer");

            cbOutputDevice.DataBindings.Add("SelectedIndex", this, "OutputDevice");

            tbGeneralVolume.DataBindings.Add("Value", this, "GeneralVolume");
            tbSplitVolume.DataBindings.Add("Value", this, "SplitVolume");
            tbSplitAheadGainingVolume.DataBindings.Add("Value", this, "SplitAheadGainingVolume");
            tbSplitAheadLosingVolume.DataBindings.Add("Value", this, "SplitAheadLosingVolume");
            tbSplitBehindGainingVolume.DataBindings.Add("Value", this, "SplitBehindGainingVolume");
            tbSplitBehindLosingVolume.DataBindings.Add("Value", this, "SplitBehindLosingVolume");
            tbBestSegmentVolume.DataBindings.Add("Value", this, "BestSegmentVolume");
            tbUndoVolume.DataBindings.Add("Value", this, "UndoSplitVolume");
            tbSkipVolume.DataBindings.Add("Value", this, "SkipSplitVolume");
            tbPersonalBestVolume.DataBindings.Add("Value", this, "PersonalBestVolume");
            tbNotAPersonalBestVolume.DataBindings.Add("Value", this, "NotAPersonalBestVolume");
            tbResetVolume.DataBindings.Add("Value", this, "ResetVolume");
            tbPauseVolume.DataBindings.Add("Value", this, "PauseVolume");
            tbResumeVolume.DataBindings.Add("Value", this, "ResumeVolume");
            tbStartTimerVolume.DataBindings.Add("Value", this, "StartTimerVolume");
        }

        public void SetSettings(XmlNode node)
        {
            var element = (XmlElement)node;

            Split = SettingsHelper.ParseString(element["Split"]);
            SplitAheadGaining = SettingsHelper.ParseString(element["SplitAheadGaining"]);
            SplitAheadLosing = SettingsHelper.ParseString(element["SplitAheadLosing"]);
            SplitBehindGaining = SettingsHelper.ParseString(element["SplitBehindGaining"]);
            SplitBehindLosing = SettingsHelper.ParseString(element["SplitBehindLosing"]);
            BestSegment = SettingsHelper.ParseString(element["BestSegment"]);
            UndoSplit = SettingsHelper.ParseString(element["UndoSplit"]);
            SkipSplit = SettingsHelper.ParseString(element["SkipSplit"]);
            PersonalBest = SettingsHelper.ParseString(element["PersonalBest"]);
            NotAPersonalBest = SettingsHelper.ParseString(element["NotAPersonalBest"]);
            Reset = SettingsHelper.ParseString(element["Reset"]);
            Pause = SettingsHelper.ParseString(element["Pause"]);
            Resume = SettingsHelper.ParseString(element["Resume"]);
            StartTimer = SettingsHelper.ParseString(element["StartTimer"]);

            OutputDevice = SettingsHelper.ParseInt(element["OutputDevice"]);

            SplitVolume = SettingsHelper.ParseInt(element["SplitVolume"], 100);
            SplitAheadGainingVolume = SettingsHelper.ParseInt(element["SplitAheadGainingVolume"], 100);
            SplitAheadLosingVolume = SettingsHelper.ParseInt(element["SplitAheadLosingVolume"], 100);
            SplitBehindGainingVolume = SettingsHelper.ParseInt(element["SplitBehindGainingVolume"], 100);
            SplitBehindLosingVolume = SettingsHelper.ParseInt(element["SplitBehindLosingVolume"], 100);
            BestSegmentVolume = SettingsHelper.ParseInt(element["BestSegmentVolume"], 100);
            UndoSplitVolume = SettingsHelper.ParseInt(element["UndoSplitVolume"], 100);
            SkipSplitVolume = SettingsHelper.ParseInt(element["SkipSplitVolume"], 100);
            PersonalBestVolume = SettingsHelper.ParseInt(element["PersonalBestVolume"], 100);
            NotAPersonalBestVolume = SettingsHelper.ParseInt(element["NotAPersonalBestVolume"], 100);
            ResetVolume = SettingsHelper.ParseInt(element["ResetVolume"], 100);
            PauseVolume = SettingsHelper.ParseInt(element["PauseVolume"], 100);
            ResumeVolume = SettingsHelper.ParseInt(element["ResumeVolume"], 100);
            StartTimerVolume = SettingsHelper.ParseInt(element["StartTimerVolume"], 100);
            GeneralVolume = SettingsHelper.ParseInt(element["GeneralVolume"], 100);
        }

        public XmlNode GetSettings(XmlDocument document)
        {
            var parent = document.CreateElement("Settings");

            parent.AppendChild(SettingsHelper.ToElement(document, "Version", "1.6"));

            parent.AppendChild(SettingsHelper.ToElement(document, "Split", Split));
            parent.AppendChild(SettingsHelper.ToElement(document, "SplitAheadGaining", SplitAheadGaining));
            parent.AppendChild(SettingsHelper.ToElement(document, "SplitAheadLosing", SplitAheadLosing));
            parent.AppendChild(SettingsHelper.ToElement(document, "SplitBehindGaining", SplitBehindGaining));
            parent.AppendChild(SettingsHelper.ToElement(document, "SplitBehindLosing", SplitBehindLosing));
            parent.AppendChild(SettingsHelper.ToElement(document, "BestSegment", BestSegment));
            parent.AppendChild(SettingsHelper.ToElement(document, "UndoSplit", UndoSplit));
            parent.AppendChild(SettingsHelper.ToElement(document, "SkipSplit", SkipSplit));
            parent.AppendChild(SettingsHelper.ToElement(document, "PersonalBest", PersonalBest));
            parent.AppendChild(SettingsHelper.ToElement(document, "NotAPersonalBest", NotAPersonalBest));
            parent.AppendChild(SettingsHelper.ToElement(document, "Reset", Reset));
            parent.AppendChild(SettingsHelper.ToElement(document, "Pause", Pause));
            parent.AppendChild(SettingsHelper.ToElement(document, "Resume", Resume));
            parent.AppendChild(SettingsHelper.ToElement(document, "StartTimer", StartTimer));

            parent.AppendChild(SettingsHelper.ToElement(document, "OutputDevice", OutputDevice));

            parent.AppendChild(SettingsHelper.ToElement(document, "SplitVolume", SplitVolume));
            parent.AppendChild(SettingsHelper.ToElement(document, "SplitAheadGainingVolume", SplitAheadGainingVolume));
            parent.AppendChild(SettingsHelper.ToElement(document, "SplitAheadLosingVolume", SplitAheadLosingVolume));
            parent.AppendChild(SettingsHelper.ToElement(document, "SplitBehindGainingVolume", SplitBehindGainingVolume));
            parent.AppendChild(SettingsHelper.ToElement(document, "SplitBehindLosingVolume", SplitBehindLosingVolume));
            parent.AppendChild(SettingsHelper.ToElement(document, "BestSegmentVolume", BestSegmentVolume));
            parent.AppendChild(SettingsHelper.ToElement(document, "UndoSplitVolume", UndoSplitVolume));
            parent.AppendChild(SettingsHelper.ToElement(document, "SkipSplitVolume", SkipSplitVolume));
            parent.AppendChild(SettingsHelper.ToElement(document, "PersonalBestVolume", PersonalBestVolume));
            parent.AppendChild(SettingsHelper.ToElement(document, "NotAPersonalBestVolume", NotAPersonalBestVolume));
            parent.AppendChild(SettingsHelper.ToElement(document, "ResetVolume", ResetVolume));
            parent.AppendChild(SettingsHelper.ToElement(document, "PauseVolume", PauseVolume));
            parent.AppendChild(SettingsHelper.ToElement(document, "ResumeVolume", ResumeVolume));
            parent.AppendChild(SettingsHelper.ToElement(document, "StartTimerVolume", StartTimerVolume));
            parent.AppendChild(SettingsHelper.ToElement(document, "GeneralVolume", GeneralVolume));

            return parent;
        }

        protected String BrowseForPath(TextBox textBox, Action<string> callback)
        {
            var path = textBox.Text;
            var fileDialog = new OpenFileDialog()
            {
                FileName = path,
                Filter = "Audio Files|*.mp3;*.wav;*.aiff;*.wma|All Files|*.*"
            };

            var result = fileDialog.ShowDialog();

            if (result == DialogResult.OK)
                path = fileDialog.FileName;

            textBox.Text = path;
            callback(path);

            return path;
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            BrowseForPath(txtSplitPath, (x) => Split = x);
        }

        private void btnAheadGaining_Click(object sender, EventArgs e)
        {
            BrowseForPath(txtSplitAheadGaining, (x) => SplitAheadGaining = x);
        }

        private void btnAheadLosing_Click(object sender, EventArgs e)
        {
            BrowseForPath(txtSplitAheadLosing, (x) => SplitAheadLosing = x);
        }

        private void btnBehindGaining_Click(object sender, EventArgs e)
        {
            BrowseForPath(txtSplitBehindGaining, (x) => SplitBehindGaining = x);
        }

        private void btnBehindLosing_Click(object sender, EventArgs e)
        {
            BrowseForPath(txtSplitBehindLosing, (x) => SplitBehindLosing = x);
        }

        private void btnBestSegment_Click(object sender, EventArgs e)
        {
            BrowseForPath(txtBestSegment, (x) => BestSegment = x);
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            BrowseForPath(txtUndo, (x) => UndoSplit = x);
        }

        private void btnSkipSplit_Click(object sender, EventArgs e)
        {
            BrowseForPath(txtSkip, (x) => SkipSplit = x);
        }

        private void btnPersonalBest_Click(object sender, EventArgs e)
        {
            BrowseForPath(txtPersonalBest, (x) => PersonalBest = x);
        }

        private void btnNotAPersonalBest_Click(object sender, EventArgs e)
        {
            BrowseForPath(txtNotAPersonalBest, (x) => NotAPersonalBest = x);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            BrowseForPath(txtReset, (x) => Reset = x);
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            BrowseForPath(txtPause, (x) => Pause = x);
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            BrowseForPath(txtResume, (x) => Resume = x);
        }

        private void btnStartTimer_Click(object sender, EventArgs e)
        {
            BrowseForPath(txtStartTimer, (x) => StartTimer = x);
        }

        private void VolumeTrackBarScrollHandler(object sender, EventArgs e)
        {
            TrackBar trackBar = (TrackBar)sender;

            ttVolume.SetToolTip(trackBar, trackBar.Value.ToString());
        }
    }
}
