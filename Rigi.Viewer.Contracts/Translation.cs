using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Rigi.Viewer.Contracts
{
  [DataContract]
  public class Translation
  {
    [DataMember]
    public string Signature { get; set; }

    [DataMember]
    public string Text { get; set; }
  }
}
