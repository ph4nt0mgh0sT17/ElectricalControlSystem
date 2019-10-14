using System;
using System.Collections.Generic;
using System.Text;

namespace ECS.ElectricalControls
{
    /// <summary>
    /// The neutral conductor where all circuits are ended.
    /// </summary>
    public class NeutralConductor : ElectricalControl
    {
        #region Member fields

        public List<ElectricalCable> mInputCables; // End of the circuits

        #endregion

        #region Constructors

        /// <summary>
        /// The neutral conductor where all circuits are ended. 
        /// </summary>
        public NeutralConductor()
        {
            mInputCables = new List<ElectricalCable>();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Attach the cable.
        /// </summary>
        /// <param name="electricalCable">The <see cref="ElectricalCable"/>.</param>
        public void AttachCable(ElectricalCable electricalCable)
        {
            mInputCables.Add(electricalCable);
        }

        #endregion
    }
}
