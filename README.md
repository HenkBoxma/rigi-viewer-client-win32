# rigi-viewer-client-win32
A sample client that demonstrates how to use the Rigi viewer for Windows. 

## Overview 

The Rigi Viewer for Windows provides a simple API for integration with desktop-based translation tools. The Viewer is a stand-alone 
windows application that is deployed with Chromium. All communication is done via Named Pipes using WCF. 

## Endpoints / Client library 

To communicate with the viewer, the library `Rigi.Viewer.Client` can be used. It defines two WCF service contracts: 

- `IRigiViewerService`
  - Defines the operations that can be called by the client. 
  - `Subscribe` is called to subscribe for notifications. 
  - `SelectString` is called when a string was selected in the translation tool. 
  - `TranslateMany` is called to change the translation of one or more strings in the preview. 
- 'IRigiViewerServiceCallback'
  - `OnStringSelected` is called when the user selected a string in the preview. 
  - `OnPublishSignatures` is called whenever Rigi detected new strings in the preview. 
  - `OnClose` is called when the viewer application was shut down by the user. 

`RigiViewerProxy` is a helper class that 

- Starts the Rigi viewer application and establishes a connection via Named Pipes. 
- Implements the interfaces described above. 
