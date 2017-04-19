using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using EyeXFramework;
using Tobii.EyeX.Framework;

namespace EyeXtryout1
{
    public partial class Form1 : Form
    {
        private bool _recording;
        private readonly GazePointDataStream _lightlyFilteredGazeDataStream;

        private ConcurrentQueue<GazePointEventArgs> _samples;
        private List<GazePointEventArgs> _samplesList;
        private int _sampleCount;
        private int _sampleInterval = 10;

        private Point _previousPoint;
        private readonly Graphics _graphics;
        private readonly Pen _fattyPen = new Pen(Color.RoyalBlue, 5);
        private readonly Brush _redBrush = new SolidBrush(Color.Red);


        private BackgroundWorker _backgroundWorker;

        public Form1()
        {
            InitializeComponent();

            _samples = new ConcurrentQueue<GazePointEventArgs>();
            _samplesList = new List<GazePointEventArgs>();
            textBoxEssay.Text = ReadFile("sampletext.txt");
            maskedTextBoxSampleInterval.Text = _sampleInterval.ToString();
            buttonRecord.Enabled = true;
            buttonPlay.Enabled = false;
            buttonResetRecording.Enabled = false;
            _graphics = textBoxEssay.CreateGraphics();
            _previousPoint = new Point();
            // Create a data stream: lightly filtered gaze point data.
            // Other choices of data streams include EyePositionDataStream and FixationDataStream.
            _lightlyFilteredGazeDataStream = Program.EyeXHost.CreateGazePointDataStream(GazePointDataMode.LightlyFiltered);
        }

        private void buttonRecord_Click(object sender, EventArgs e)
        {
            if (_recording)
            {
                //_recordSubscription.Dispose();
                _lightlyFilteredGazeDataStream.Next -= _lightlyFilteredGazeDataStream_Next;
                buttonRecord.Text = @"Record";
                _recording = false;
                buttonPlay.Enabled = true;
                buttonResetRecording.Enabled = true;
                maskedTextBoxSampleInterval.Enabled = true;
                return;
            }
            _recording = true;
            buttonPlay.Enabled = false;
            buttonResetRecording.Enabled = false;
            maskedTextBoxSampleInterval.Enabled = false;
            _lightlyFilteredGazeDataStream.Next += _lightlyFilteredGazeDataStream_Next;
            buttonRecord.Text = @"Stop";
        }

        private void _lightlyFilteredGazeDataStream_Next(object sender, GazePointEventArgs e)
        {
            _sampleCount++;
            if (_sampleCount % _sampleInterval == 0)
            {
                _samples.Enqueue(e);
                labelGazePoint.Text = $"Samples recorded: {_samples.Count} Gaze point at ({e.X:0.0}, {e.Y:0.0})";
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (_backgroundWorker != null && _backgroundWorker.IsBusy)
            {
                _backgroundWorker.CancelAsync();
                return;
            }

            buttonRecord.Enabled = false;
            buttonResetRecording.Enabled = false;
            buttonPlay.Text = "Stop";
            _backgroundWorker = new BackgroundWorker();
            _backgroundWorker.WorkerSupportsCancellation = true;
            _backgroundWorker.DoWork += BackgroundWorkerOnDoWork;
            _backgroundWorker.RunWorkerCompleted += BackgroundWorkerOnRunWorkerCompleted;
            _backgroundWorker.RunWorkerAsync();
        }

        private void BackgroundWorkerOnRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs runWorkerCompletedEventArgs)
        {
            buttonRecord.Enabled = true;
            buttonResetRecording.Enabled = true;
            buttonPlay.Text = "Play";
        }

        private void BackgroundWorkerOnDoWork(object sender, DoWorkEventArgs doWorkEventArgs)
        {
            _samplesList = new List<GazePointEventArgs>(_samples.ToArray());

            for (var i = 1; i < _samplesList.Count; i++)
            {
                if (doWorkEventArgs.Cancel)
                    break;

                var sample = _samplesList[i];

                var location = Point.Empty;
                if (textBoxEssay.InvokeRequired)
                {
                    textBoxEssay.Invoke(new MethodInvoker(delegate
                    {
                        location = textBoxEssay.PointToScreen(Point.Empty);
                    }));

                }
                DrawFilledEllipse((int)sample.X - location.X, (int)sample.Y - location.Y);
                Thread.Sleep((int)(_samplesList[i].Timestamp - _samplesList[i - 1].Timestamp));
            }
        }

        private void DrawFilledEllipse(int locationX, int locationY)
        {
            var rectangle = new Rectangle(locationX, locationY, 10, 10);
            _graphics.DrawLine(_fattyPen, new Point(locationX + 5, locationY + 5), _previousPoint);
            _graphics.FillEllipse(_redBrush, rectangle);
            _previousPoint.X = locationX + 5;
            _previousPoint.Y = locationY + 5;
        }

        private void buttonResetRecording_Click(object sender, EventArgs e)
        {
            if (!_recording)
            {
                _samplesList.Clear();
                _samples = new ConcurrentQueue<GazePointEventArgs>();
                buttonPlay.Enabled = false;
                buttonResetRecording.Enabled = false;
            }
        }

        private void buttonResetScreen_Click(object sender, EventArgs e)
        {
            textBoxEssay.Invalidate();
        }

       private static string ReadFile(string fileName)
        {
            string result;
            try
            {
                using (var sr = new StreamReader(fileName))
                {
                    result = sr.ReadToEnd();
                }
            }
            catch (Exception exception)
            {
                result = $"The file could not be read: {exception.Message}";
            }
            return result;
        }

        private void maskedTextBoxSampleInterval_TextChanged(object sender, EventArgs e)
        {
            _sampleInterval = int.Parse(maskedTextBoxSampleInterval.Text);
        }
    }
}
