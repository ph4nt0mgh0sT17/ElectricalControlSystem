using System;
using System.Collections.Generic;
using System.Text;

namespace ElectricalControls
{
    /// <summary>
    /// An electrical lead to electrical controls.
    /// </summary>
    public class ElectricalLead : ElectricalControl
    {
        #region Member fields

        public List<ElectricalCable> mOutputCables;

        #endregion

        #region Constructors

        /// <summary>
        /// Creates an electrical lead with no input <see cref="ElectricalCable"/>.
        /// </summary>
        public ElectricalLead()
        {
            mOutputCables = new List<ElectricalCable>();
        }

        #endregion

    }
}
