using System.Windows.Forms;

namespace QuickStop.Client.Controls
{
    /// <summary>
    /// A Reskinned <see cref="RadioButton"/>, providing the same functions.
    /// </summary>
    public class RadioToggleButton : RadioButton
    {
        /// <summary>
        /// Initializes a new Instance of <see cref="RadioToggleButton"/>.
        /// </summary>
        public RadioToggleButton() : base()
        {
            Appearance = Appearance.Button;
        }
    }
}
