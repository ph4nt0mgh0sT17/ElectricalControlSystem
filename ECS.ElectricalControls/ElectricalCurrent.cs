using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ECS.ElectricalControls
{
    public class ElectricalCurrent
    {
        #region Member fields

        private Color mColor;

        #endregion

        public Color Color
        {
            get => mColor;
            set => mColor = value;
        }
    }
}
