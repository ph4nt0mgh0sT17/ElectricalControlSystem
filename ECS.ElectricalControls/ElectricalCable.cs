using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ECS.ElectricalControls
{
    /// <summary>
    /// The electric cable that contains <see cref="ElectricalCurrent"/>.
    /// </summary>
    public class ElectricalCable
    {
        #region Member fields

        private ElectricalCurrent mElectricalCurrent;

        #endregion

        /// <summary>
        /// Creates an electric cable with no <see cref="ElectricalCurrent"/>.
        /// </summary>
        public ElectricalCable()
        {
            mElectricalCurrent = null;
        }

        /// <summary>
        /// Creates an electrical cable with a <see cref="ElectricalCurrent"/>.
        /// </summary>
        /// <param name="current">The <see cref="ElectricalCurrent"/>.</param>
        public ElectricalCable(ElectricalCurrent current)
        {
            mElectricalCurrent = current;
        }

        /// <summary>
        /// Gets the color of the cable.
        /// </summary>
        public Color CableColor
        {
            get => mElectricalCurrent.Color;
        }
    }
}
