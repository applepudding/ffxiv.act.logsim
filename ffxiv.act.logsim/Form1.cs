using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics; //stopwatch
using System.Text.RegularExpressions; //regex

namespace ffxiv.act.logsim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Stopwatch stopWatch = new Stopwatch();
        private static System.Timers.Timer fightTimer;
        public Thread myThread;
        public bool workerRunning = false;
        string inputFileName;
        string outputFileName;
        long lineCount = 0;

        void log(string value)
        {
            if (!InvokeRequired)
            {
                string result = DateTime.Now + ": " + value;
                list_log.Items.Insert(0, result);
                while (list_log.Items.Count > 100)
                {
                    list_log.Items.RemoveAt(list_log.Items.Count - 1);
                }
            }
            else
            {
                Invoke(new Action<string>(log), value);
            }
        }

        void finishActivity()
        {
            if (!InvokeRequired)
            {
                stopWatch.Stop();
                fightTimer.Enabled = false;
                log("Watch stopped");
                workerRunning = false;
                btn_start.Text = "Start";
                myThread.Abort();


            }
            else
            {
                Invoke(new Action(finishActivity));
            }
        }

        void disposeStuff()
        {
            if (workerRunning)
            {
                myThread.Abort();
            }
            if (fightTimer != null)
            {
                fightTimer.Stop();
                fightTimer.Dispose();
                fightTimer = null;
            }
        } //dispose stuff

        public void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            if (!InvokeRequired)
            {
                TimeSpan ts = stopWatch.Elapsed;
                // Format and display the TimeSpan value.
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds);
                this.lbl_timer.Text = elapsedTime;
                this.lbl_lineWrite.Text = lineCount.ToString();
                //countdown handler
            }
            else
            {
                Invoke(new Action<Object, System.Timers.ElapsedEventArgs>(OnTimedEvent), source, e);
            }
        }



        public void myBackgroudWorker()
        {
            using (FileStream fs = new FileStream(inputFileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    while (workerRunning)
                    {
                        string resultLine = sr.ReadLine();
                        TimeSpan fightStartTime = getReadTime(resultLine);
                        StreamWriter objWriter;
                        while (!sr.EndOfStream) //read file till the end when first running
                        {
                            //C:\Users\melon\AppData\Roaming\Advanced Combat Tracker\FFXIVLogs\Network_20160823.log
                            resultLine = sr.ReadLine();

                            while ((getReadTime(resultLine) - fightStartTime).TotalSeconds > stopWatch.Elapsed.TotalSeconds)
                            {
                                Thread.Sleep(100);
                            }

                            //log(resultLine);
                            lineCount++;
                            objWriter = new StreamWriter(outputFileName, true);
                            objWriter.WriteLine(resultLine);
                            objWriter.Close();
                        }
                        objWriter = new StreamWriter(outputFileName, true);
                        objWriter.WriteLine("=SIMSTOP=");
                        objWriter.Close();
                        finishActivity();

                    }
                }
            }
        }
        TimeSpan getReadTime(string input_readLine)
        {
            string[] subname = Regex.Split(input_readLine, "\\|");

            subname = Regex.Split(subname[1], "T");
            subname = Regex.Split(subname[1], "\\-");
            subname = Regex.Split(subname[0], "\\.");
            subname = Regex.Split(subname[0], "\\:");
            TimeSpan returnTs = new TimeSpan(Int32.Parse(subname[0]), Int32.Parse(subname[1]), Int32.Parse(subname[2]));
            return returnTs;

        }
        void initStuff()
        {
            list_log.Dock = DockStyle.Fill;
            fightTimer = new System.Timers.Timer(1000); // Create a timer with a 1 second interval.
            fightTimer.Elapsed += OnTimedEvent; // Hook up the Elapsed event for the timer. 
            fightTimer.AutoReset = true;
            fightTimer.Enabled = false;

            //delete output.txt file if exist
            if (File.Exists("output.txt"))
            {
                log("Deleting old output.txt");
                File.Delete("output.txt");
            }
            //create new output.txt file
            string path = "output.txt";
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("=logsim.init=");
                sw.Close();
                log("New output.txt created");
            }            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            initStuff();
            log("App started");
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            //this.btn_start.Text = (this.btn_start.Text == "Start") ? "Stop" : "Start";
            if ((this.txt_fileIn.Text == "") || (this.txt_fileOut.Text == "")) return;

            if (!workerRunning)
            {

                inputFileName = this.txt_fileIn.Text;
                outputFileName = this.txt_fileOut.Text;
                StreamWriter objWriter = new StreamWriter(outputFileName, true);
                objWriter.WriteLine("=SIMSTART=");
                objWriter.Close();
                stopWatch.Reset();
                stopWatch.Start();
                fightTimer.Enabled = true;
                log("Watch started");
                workerRunning = true;
                myThread = new Thread(myBackgroudWorker);
                myThread.Start();
                btn_start.Text = "Stop";
                lineCount = 0;

            }
            else
            {
                finishActivity();
                StreamWriter objWriter = new StreamWriter(outputFileName, true);
                objWriter.WriteLine("=SIMSTOP=");
                objWriter.Close();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            disposeStuff();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.txt_fileIn.Text = this.openFileDialog1.FileName;
        }
    }
}
