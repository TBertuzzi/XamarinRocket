using System;
using System.Diagnostics;
namespace XamarinRocket
{
    public class ProgressHelpers
    {
        // Reference Values(Standard Pixel 1 Device)
        private const float refHeight = 1080;//1677;
        private const float refWidth = 632;//940;

        // Derived Proportinate Values
        private float deviceHeight = 1; // Initializing to 1
        private float deviceWidth = 1;  // Initializing to 1


        public ProgressHelpers() { }


        public void SetDevice(int deviceHeight, int deviceWidth)
        {
            this.deviceHeight = deviceHeight;
            this.deviceWidth = deviceWidth;
        }


        public float GetFactoredValue(int value)
        {

            float refRatio = refHeight / refWidth;
            float devRatio = deviceHeight / deviceWidth;

            float factoredValue = value * (refRatio / devRatio);

            return factoredValue;
        }

        public float GetFactoredHeight(int value)
        {
            return (float)((value / refHeight) * deviceHeight);
        }


        public float GetFactoredWidth(int value)
        {
            return (float)((value / refWidth) * deviceWidth);
        }

        public int GetSweepAngle(int goal, int achieved)
        {
            int SweepAngle = 260;
            float factor = (float)achieved / goal;

            return (int)(SweepAngle * factor);

        }

    }
}
