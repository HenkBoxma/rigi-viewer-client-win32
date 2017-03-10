using System.Collections.Generic;
using System.ServiceModel;

namespace Rigi.Viewer.Contracts
{
  [ServiceContract(CallbackContract = typeof(IRigiViewerServiceCallback))]  
  public interface IRigiViewerService
  {
    /// <summary>
    /// Called by the client to subscribe for notifications from the server. 
    /// </summary>
    [OperationContract(IsOneWay = false)]
    void Subscribe();

    /// <summary>
    /// Called by the client whenever a string with the specified signature has been selected in the translation tool. 
    /// </summary>
    /// <param name="projectUrl">The URL of the project on Rigi server.</param>
    /// <param name="locale">The locale of the string list that is currently used in the translation tool.</param>
    /// <param name="signature">The signature of the string that was selected</param>
    [OperationContract(IsOneWay = true)]
    void SelectString(string projectUrl, string locale, string signature);

    /// <summary>
    /// Called by the client to change the translations of one or more strings in the preview. 
    /// </summary>
    /// <param name="translations"></param>
    [OperationContract(IsOneWay = true)]
    void TranslateMany(List<Translation> translations); 
  }
}