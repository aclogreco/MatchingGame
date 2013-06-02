using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchingGame {
	public partial class MatchingGameForm : Form {
		// Use this random object to choose random items for the squares.
		Random random = new Random();

		// Each of these letters is an interesting icon in the Webdings font,
		// and each letter appears twice in the list.
		List<string> icons = new List<string>() {
			"!", "!", "N", "N", ",", ",", "k", "k",
			"b", "b", "v", "v", "w", "w", "z", "z"
		};

		/// <summary>
		/// Assign each icon from the list of icons to a random square.
		/// </summary>
		private void AssignIconsToSquares () {
			// The TableLayoutPanel has 16 labels,
			// and the icon list has 16 icons,
			// so an icon is pulled at random from the list
			// and added to each label
			foreach (Control control in tableLayoutPanel1.Controls) {
				Label iconLabel = control as Label;

				if (iconLabel != null) {
					int randomNumber = random.Next(icons.Count);
					iconLabel.Text = icons[randomNumber];
					// iconLabel.ForeColor = iconLabel.BackColor;
					icons.RemoveAt(randomNumber);
				}
			}
		}

		public MatchingGameForm () {
			InitializeComponent();
		}
	}
}
