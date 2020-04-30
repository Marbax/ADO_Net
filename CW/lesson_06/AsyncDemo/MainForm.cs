using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AsyncDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OperationAsync(int opId, int iterations, int delay, RichTextBox output, ProgressBar pb, Button btn)
        {
            btn.Invoke((MethodInvoker)delegate { btn.Enabled = false; });
            output.Invoke((MethodInvoker)delegate { output.Text = $"Id = {opId} - ran\r\n";}); 
            Thread.Sleep(delay);
            pb.Invoke((MethodInvoker)delegate {pb.Maximum = iterations; }); 

            int counter = 0;
            for (int i = 0; i < iterations; i++)
            {
                counter = i + 1;
                int curThread = Thread.CurrentThread.ManagedThreadId;
                output.Invoke((MethodInvoker)delegate { output.Text += $"Thread = {curThread} \t\tOperation {counter}/{iterations} completed\r\n";});
                pb.Invoke((MethodInvoker)delegate { pb.Value++;}); 
                Thread.Sleep(delay);
            }

            output.Invoke((MethodInvoker)delegate { output.Text = $"Operation {opId} - completed sucessfully\r\n"; });
            output.Invoke((MethodInvoker)delegate { output.Text += $"Ops = {counter}/{iterations}\r\n";});
            output.Invoke((MethodInvoker)delegate { output.Text += $"Time spent = {(counter * delay / 1000.0f):f}";});
        }


        private async void bOp1_Click(object sender, EventArgs e)
        {
            await Task.Run(() => OperationAsync(1, 25, 500, rtbAsyncOutputFirst, pbOp1, bOp1));
        }

        private async void bOp2_Click(object sender, EventArgs e)
        {
            await Task.Run(() => OperationAsync(1, 25, 500, rtbAsyncOutputSecond, pbOp2, bOp2));
        }

        private void bReset_Click(object sender, EventArgs e)
        {
            rtbAsyncOutputFirst.Clear();
            rtbAsyncOutputSecond.Clear();
            pbOp1.Value = pbOp2.Value = 0;
            bOp1.Enabled = bOp2.Enabled = true;
        }
    }
}
