using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Emgu.CV;

namespace VisualOdometry
{
    public class VisualOdometer : IDisposable
    {

        public VisualOdometer(Capture capture, CameraParameters cameraParameters, HomographyMatrix birdsEyeViewTransformation, OpticalFlow opticalFlow)
        {

        }


        public void Dispose()
        {
            OdometerSettings.Default.GroundRegionTop = m_GroundRegionTop;
            OdometerSettings.Default.SkyRegionBottom = m_SkyRegionBottom;
            OdometerSettings.Default.Save();

            if (this.OpticalFlow != null)
            {
                this.OpticalFlow.Dispose();
            }
        }
    }
}
