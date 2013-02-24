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

		public MatchingGameForm () {
			InitializeComponent();
		}
	}
}
