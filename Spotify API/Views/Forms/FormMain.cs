using Spotify_API.Helpers;
using Spotify_API.Models;
using Spotify_API.Views.Constrols;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;

namespace Spotify_API
{
    public partial class FormMain : Form
    {
        private Timer timer = new Timer();

        public FormMain()
        {
            InitializeComponent();
            this.textBoxSeatch.KeyUp += delegate
            {
                timer.Stop();
                timer.Start();
            };

            timer.Interval = 1000;
            timer.Tick += delegate
            {
                SeatchEvent(this.textBoxSeatch);
                timer.Stop();
            };
        }

        private void FormLoadEvent(object sender, EventArgs e)
        {
            Task.Run(async () => await SearchHelper.GetTokenAsync());

            this.comboBox1.SelectedIndex = 0;
        }

        private void SeatchEvent(object sender)
        {
            var result = SearchHelper.SearchArtist((sender as TextBox).Text ?? "", comboBox1.Text);

            if (result == null)
            {
                return;
            }

            panel2.Controls.Clear();

            foreach (var item in Enumerable.Reverse(result.artists.items).ToArray())
            {
                var c = new SearchResult()
                {
                    Image = item.images.Any() ? item.images[0].url : "https://user-images.githubusercontent.com/24848110/33519396-7e56363c-d79d-11e7-969b-09782f5ccbab.png",
                    Popularity = $"{item.popularity}% popularidad",
                    Title = item.name,
                    Followers = $"{item.followers.total.ToString("N")} seguidores"
                };
                c.Dock = DockStyle.Top;
                panel2.Controls.Add(c);
            }
        }
    }
}
