using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Demo04
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void BtnDownload_OnClicked(object sender, EventArgs e)
        {
            var progress = GetProgress();

            await Progress.ProgressTo(progress, 500, Easing.CubicIn);
        }

        private void BtnDownload02_OnClicked(object sender, EventArgs e)
        {
            var p = GetProgress();
            Progress.Progress = p;
        }

        private double GetProgress()
        {
            var progress = Progress.Progress;
            progress += 0.2;
            if (progress > 1) progress = 0;
            return progress;
        }
    }
}
