using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spotify_API.Views.Constrols
{
    public partial class SearchResult : UserControl
    {
        public SearchResult()
        {
            InitializeComponent();
        }

        public string Image
        {
            get => this.pictureBox1.ImageLocation;
            set => pictureBox1.ImageLocation = value;
        }

        public string Title
        {
            get => this.labelTitle.Text;
            set => labelTitle.Text = value;
        }
    }
}
