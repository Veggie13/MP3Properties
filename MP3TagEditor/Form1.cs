using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP3TagEditor
{
    public partial class Form1 : Form
    {
        private string _filename;

        public Form1()
        {
            InitializeComponent();
        }

        private void _btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                DefaultExt = "mp3",
                Filter = "MP3 Files|*.mp3",
                Multiselect = false
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _filename = ofd.FileName;
                var file = TagLib.File.Create(ofd.FileName);
                _txtArtists.Text = string.Join(";", file.Tag.Artists);
                _txtAlbumArtists.Text = string.Join(";", file.Tag.AlbumArtists);
                _txtAlbum.Text = file.Tag.Album;
                _txtTitle.Text = file.Tag.Title;
            }
        }

        private void _btnSave_Click(object sender, EventArgs e)
        {
            var file = TagLib.File.Create(_filename);
            file.Tag.Artists = _txtArtists.Text.Split(';');
            file.Tag.AlbumArtists = _txtAlbumArtists.Text.Split(';');
            file.Tag.Album = _txtAlbum.Text;
            file.Tag.Title = _txtTitle.Text;
            file.Save();
        }

        private void _btnAuto_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex("(.+) - (.+)");
            string name = Path.GetFileNameWithoutExtension(_filename);
            if (regex.IsMatch(name))
            {
                var match = regex.Match(name);
                string title = match.Groups[2].Value;
                string artist = match.Groups[1].Value;

                _txtArtists.Text = artist;
                _txtAlbumArtists.Text = artist;
                _txtAlbum.Text = "";
                _txtTitle.Text = title;
            }
        }
    }
}
