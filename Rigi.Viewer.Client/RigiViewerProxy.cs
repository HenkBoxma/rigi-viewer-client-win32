using Rigi.Viewer.Contracts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.ServiceModel;
using System.Threading;

namespace Rigi.Viewer.Client
{
  public sealed class RigiViewerProxy : IRigiViewerServiceCallback
  {
    private IRigiViewerService _proxy;
    private IRigiViewerServiceCallback _callback;
    private DuplexChannelFactory<IRigiViewerService> _channelFactory;
    private bool _isClosed = false;
    private object _locker = new object();
    private Process _viewerProcess; 

    public RigiViewerProxy(StartupOptions options, IRigiViewerServiceCallback callback)
    {
      _callback = callback;

      EventWaitHandle handle = new EventWaitHandle(false,
        EventResetMode.AutoReset,
        "RigiViewerEventWaitHandle"
      );

      // Start a new viewer process 
      ProcessStartInfo startInfo = new ProcessStartInfo(options.ViewerExecutablePath);
      List<string> args = new List<string>(); 
      if (options.CloseWithParentProcess)
      {
        args.Add("-pid");
        args.Add(Process.GetCurrentProcess().Id.ToString()); 
      }
      if (!string.IsNullOrEmpty(options.InitialProjectUrl))
      {
        args.Add("-proj"); 
        args.Add(options.InitialProjectUrl);
      }
      if (!string.IsNullOrEmpty(options.InitialLocale))
      {
        args.Add("-locale");
        args.Add(options.InitialLocale);
      }
      if (!string.IsNullOrEmpty(options.InitialSignature))
      {
        args.Add("-sig");
        args.Add(options.InitialSignature);
      }

      startInfo.Arguments = string.Join(" ", args);       
      _viewerProcess = Process.Start(startInfo);
      _viewerProcess.EnableRaisingEvents = true; 
      _viewerProcess.Exited += OnViewerProcessExited;
      
      handle.WaitOne();      

      InstanceContext context = new InstanceContext(this);

      var binding = new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);
      binding.ReceiveTimeout = TimeSpan.MaxValue;
      binding.CloseTimeout = TimeSpan.MaxValue;
      binding.OpenTimeout = TimeSpan.MaxValue;
      binding.SendTimeout = TimeSpan.MaxValue;

      _channelFactory = new DuplexChannelFactory<IRigiViewerService>(context,
        binding,
        new EndpointAddress("net.pipe://localhost/RigiViewer"));

      _proxy = _channelFactory.CreateChannel();

      _proxy.Subscribe();
    }

    private void OnViewerProcessExited(object sender, EventArgs e)
    {
      ShutDown(); 
    }

    public void SelectString(string projectUrl, string locale, string signature)
    {
      if (!_isClosed)
      {
        _proxy.SelectString(projectUrl, locale, signature);
      }
    }

    public void TranslateMany(List<Translation> translations)
    {
      if (!_isClosed)
      {
        _proxy.TranslateMany(translations);
      }
    }

    public void Translate(Translation translation)
    {
      if (!_isClosed)
      {
        List<Translation> list = new List<Translation>();
        list.Add(translation);
        _proxy.TranslateMany(list);
      }
    }

    void IRigiViewerServiceCallback.OnPublishSignatures(List<string> signatures)
    {
      _callback.OnPublishSignatures(signatures);
    }

    void IRigiViewerServiceCallback.OnStringSelected(string signature)
    {
      _callback.OnStringSelected(signature);
    }

    void IRigiViewerServiceCallback.OnClose()
    {
      ShutDown(); 
    }

    private void ShutDown()
    {
      lock (_locker)
      {
        if (_isClosed)
          return;

        _callback.OnClose();
        try
        {
          _channelFactory.Close();
        }
        catch
        {
          _channelFactory.Abort();
        }
        finally
        {
          _isClosed = true;
        }
      }
    }

  }
}
