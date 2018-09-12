using System;
using System.Drawing;

namespace ComponentFactory.Krypton.Toolkit {
    /// <summary>
    /// Hovered Selection Changed event data.
    /// </summary>
    public class HoveredSelectionChangedEventArgs : EventArgs {
        #region Instance Fields
        private Rectangle _bounds;
        private int _index;
        private object _item;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the HoveredSelectionChangedEventArgs class.
        /// </summary>
        /// <param name="bounds">The bounds of the selected dropdown item.</param>
        /// <param name="index">The index within the dropdown items collection.</param>
        /// <param name="item">The item within the dropdown items collection.</param>
        public HoveredSelectionChangedEventArgs(Rectangle bounds, int index, object item) {
            _bounds = bounds;
            _index = index;
            _item = item;
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets the bounds.
        /// </summary>
        public Rectangle Bounds {
            get { return _bounds; }
        }

        /// <summary>
        /// Gets the item index.
        /// </summary>
        public int Index {
            get { return _index; }
        }

        /// <summary>
        /// Gets the item.
        /// </summary>
        public object Item {
            get { return _item; }
        }
        #endregion
    }
}
