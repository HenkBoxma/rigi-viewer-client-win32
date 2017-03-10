using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rigi.Viewer.Client
{
  public class StartupOptions
  {
    public StartupOptions()
    {      
    }

    /// <summary>
    /// Absolute path to the Rigi viewer executable. 
    /// </summary>
    public string ViewerExecutablePath { get; set; }

    /// <summary>
    /// Determines if the viewer should be closed when the parent process terminates.
    /// </summary>
    public bool CloseWithParentProcess { get; set; }

    public string InitialSignature { get; set; }

    public string InitialProjectUrl { get; set; }

    public string InitialLocale { get; set; }
  }
}
