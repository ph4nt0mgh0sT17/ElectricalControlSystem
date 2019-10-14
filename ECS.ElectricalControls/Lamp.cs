using System;

namespace ECS.ElectricalControls
{
    /// <summary>
    /// The electrical control Lamp.
    /// </summary>
    public class Lamp : ElectricalControl
    {
        #region Member fields

        // Electrical cables
        ElectricalCable mInputCable; // Connected cable leading into the lamp
        ElectricalCable mOutputCable; // Cable leading out of the lamp

        // Charasteristics
        private string mName;

        #endregion

        #region Constructors

        /// <summary>
        /// Creates an lamp with no cables and default name.
        /// </summary>
        public Lamp()
        {
            mInputCable = null;
            mOutputCable = null;

            mName = "Untitled";
        }

        /// <summary>
        /// Creates an lamp with no <see cref="ElectricalCable"/> and given <b>name</b>.
        /// </summary>
        /// <param name="name"></param>
        public Lamp(string name)
        {
            mInputCable = null;
            mOutputCable = null;

            mName = name;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name
        {
            get => mName;
            set => mName = value;
        }

        /// <summary>
        /// Gets the input cable.
        /// </summary>
        public ElectricalCable InputCable
        {
            get => mInputCable;
        }

        /// <summary>
        /// Gets the output cable.
        /// </summary>
        public ElectricalCable OutputCable
        {
            get => mOutputCable;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Unattaches the input cable.
        /// </summary>
        public void UnattachInputCable()
        {
            mInputCable = null;
        }

        /// <summary>
        /// Unattached the output cable.
        /// </summary>
        public void UnattachOutputCable()
        {
            mOutputCable = null;
        }

        #endregion

    }
}
