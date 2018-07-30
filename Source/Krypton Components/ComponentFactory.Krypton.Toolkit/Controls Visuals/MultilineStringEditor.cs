using System;
using System.Drawing;
using System.Windows.Forms;

namespace ComponentFactory.Krypton.Toolkit {
    /// <summary>
    /// Multiline String Editor Window.
    /// </summary>
    public class MultilineStringEditor : Form {
        private bool saveChanges = true;
        private KryptonTextBox textBox = new KryptonTextBox();
        private KryptonTextBox owner;

        /// <summary>
        /// Initializes a new instance of the MultilineStringEditor class.
        /// </summary>
        /// <param name="owner"></param>
        public MultilineStringEditor(KryptonTextBox owner) : base() {
            SuspendLayout();
            textBox.Dock = DockStyle.Fill;
            textBox.Multiline = true;
            textBox.KeyDown += new KeyEventHandler(OnKeyDownTextBox);
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 262);
            ControlBox = false;
            Controls.Add(textBox);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            this.owner = owner;
            ResumeLayout(false);
        }

        /// <summary>
        /// Shows the multiline string editor.
        /// </summary>
        public void ShowEditor() {
            Location = owner.PointToScreen(Point.Empty);
            textBox.Text = owner.Text;
            Show();
        }

        /// <summary>
        /// Closes the multiline string editor.
        /// </summary>
        /// <param name="e">
        /// Event arguments.
        /// </param>
        protected override void OnDeactivate(EventArgs e) {
            base.OnDeactivate(e);
            CloseEditor();
        }

        private void CloseEditor() {
            if (saveChanges)
                owner.Text = textBox.Text;
            Close();
        }

        private void OnKeyDownTextBox(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                saveChanges = false;
                CloseEditor();
            }
        }
    }
}
