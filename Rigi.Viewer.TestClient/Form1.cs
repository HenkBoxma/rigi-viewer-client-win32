using Rigi.Viewer.Client;
using Rigi.Viewer.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rigi.Viewer.TestClient
{
  public partial class Form1 : Form, IRigiViewerServiceCallback
  {
    private RigiViewerProxy _proxy; 

    public Form1()
    {
      InitializeComponent();
    }

    public void OnPublishSignatures(List<string> signatures)
    {
      WriteOutput("[Server notification] Signatures detected: " + String.Join(";",signatures.ToArray()));
    }

    public void OnStringSelected(string signature)
    {
      WriteOutput("[Server notification] String selected: " + signature); 
    }

    public void OnClose()
    {
      SetStatus("Connection was closed by server."); 
    }

    private void button2_Click(object sender, EventArgs e)
    {
      if (_proxy != null)
      {
        string signature = txtSignature.Text.Trim();
        WriteOutput("[Client request] Select string: " + signature); 
        _proxy.SelectString(this.txtProjectUrl.Text, "de", signature);
      }
    }

    private void WriteOutput(string message)
    {
      output.Text += message;
      output.Text += Environment.NewLine;
      output.Text += Environment.NewLine;
      output.SelectionStart = output.Text.Length;
      output.ScrollToCaret(); 
    }

    private void SetStatus(string status)
    {
      this.status.Text = status; 
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      SetStatus(string.Empty); 
    }

    private void button3_Click(object sender, EventArgs e)
    {
      var translation = new Translation();
      translation.Signature = txtSigTranslate.Text.Trim();
      translation.Text = txtTranslation.Text;
      WriteOutput(string.Format("[Client request] Translate: {0}  =>  {1}", translation.Signature, translation.Text)); 
      _proxy.Translate(translation); 
    }

    private void button4_Click(object sender, EventArgs e)
    {
      var options = new StartupOptions();      
      // TODO: Change the path to the rigi viewer here!
      string viewerPath = @"D:\L10NProjects_Github\rigi\viewer\src\Rigi.Viewer\bin\Debug\Rigi.Viewer.exe";

      string viewerPathCurDir = Path.Combine(Path.GetDirectoryName(typeof(Form1).Assembly.Location),
        "Rigi.Viewer.exe");

      if (File.Exists(viewerPathCurDir))
        viewerPath = viewerPathCurDir; 

      options.ViewerExecutablePath = viewerPath; 
      _proxy = new RigiViewerProxy(options, this);
      SetStatus("Successfully connected.");
    }

    private void button1_Click(object sender, EventArgs e)
    {
      output.Text = string.Empty; 
    }
  }
}
