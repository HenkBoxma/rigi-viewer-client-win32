using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Rigi.Viewer.Contracts
{
  /// <summary>
  /// Defines server notifications
  /// </summary>
  public interface IRigiViewerServiceCallback
  {
    /// <summary>
    /// A notification from the server that indicates that a string with the specified signature has been selected in the preview. 
    /// </summary>
    /// <param name="signature"></param>
    [OperationContract(IsOneWay = true)]
    void OnStringSelected(string signature);

    /// <summary>
    /// A notification from the server that indicates that the specified signatures have been detected in the preview. 
    /// </summary>
    /// <param name="signatures"></param>
    [OperationContract(IsOneWay = true)]
    void OnPublishSignatures(List<string> signatures);

    /// <summary>
    /// A notification from the server that indicates that the viewer process is about to be shut down and the connection is closed. 
    /// </summary>
    [OperationContract(IsOneWay = true)]
    void OnClose();
  }
}