using System;
using UIKit;
using Foundation;

namespace AVCam
{
    public class AAPLPreviewView : UIView
    {
        public AVCaptureSession session { get; set; }

        public static Class LayerClass()
        {
            // eturn [AVCaptureVideoPreviewLayer class];
        }

        public AVCaptureSession Session()
        {
            // VCaptureVideoPreviewLayer *previewLayer = (AVCaptureVideoPreviewLayer *)self.layer;
        // return previewLayer.session;
        }

        public void SetSession(AVCaptureSession session)
        {
            // VCaptureVideoPreviewLayer *previewLayer = (AVCaptureVideoPreviewLayer *)self.layer;
        // previewLayer.session = session;
        }
    }
}