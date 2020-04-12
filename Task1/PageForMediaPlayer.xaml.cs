
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using MediaManager;



namespace Task1
{
    public partial class PageForMediaPlayer : ContentPage
    {
        private string videoUrl = "https://sec.ch9.ms/ch9/e68c/690eebb1-797a-40ef-a841-c63dded4e68c/Cognitive-Services-Emotion_high.mp4";
        public PageForMediaPlayer()
        {
            InitializeComponent();
        }

        private void PlayStopButton(object sender, EventArgs e)
        {
            if (PlayStopButtonText.Text == "Play")
            {

                //CrossMedia.Current.

                CrossMediaManager.Current.Play(videoUrl);

                PlayStopButtonText.Text = "Stop";
            }
            else if (PlayStopButtonText.Text == "Stop")
            {
                //CrossMediaManager.Current.Play(videoUrl, MediaFileType.Video);
                CrossMediaManager.Current.Stop();

                PlayStopButtonText.Text = "Play";
            }
        }
    }
}
