using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Emgu.CV;

namespace VisualOdometry
{
    public class CameraParameters
    {
        public IntrinsicCameraParameters m_IntrinsicCameraParameters { get; private set; }

        public Intrinsic m_Intrinsic { get; private set; }

        public Distortion m_Distortion { get; private set; }

        public CameraParameters(IntrinsicCameraParameters intrinsicCameraParameters)
        {
            this.m_IntrinsicCameraParameters = intrinsicCameraParameters;
            this.m_Intrinsic = new Intrinsic(intrinsicCameraParameters);
            this.m_Distortion = new Distortion(intrinsicCameraParameters);
        }
    }

    public class Intrinsic
    {
        private IntrinsicCameraParameters m_IntrinsicCamParam;
        public Intrinsic(IntrinsicCameraParameters intrinsicCamParam)
        {
            m_IntrinsicCamParam = intrinsicCamParam;
        }
    }

    public class Distortion
    {
        private IntrinsicCameraParameters m_IntrinsicCamParam;
        public Distortion(IntrinsicCameraParameters intrinsicCamParam)
        {
            m_IntrinsicCamParam = intrinsicCamParam;
        }
    }
}
