using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace AlphabetSoundBoard
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        

        public MainPage()
        {
            this.InitializeComponent();
        }

        // The Letter A Is Played
        private void Button_Click_A(object sender, RoutedEventArgs e)
        {
            myMediaElement.Source = new Uri("ms-appx:///Assets/A.wav", UriKind.RelativeOrAbsolute);
            myMediaElement.Play();
        }
        // The Letter B Is Played
        private void Button_Click_B(object sender, RoutedEventArgs e)
        {
            myMediaElementB.Source = new Uri("ms-appx:///Assets/B.wav", UriKind.RelativeOrAbsolute);
            myMediaElementB.Play();
        }
        // The Letter C Is Played
        private void Button_Click_C(object sender, RoutedEventArgs e)
        {
            myMediaElementC.Source = new Uri("ms-appx:///Assets/C.wav", UriKind.RelativeOrAbsolute);
            myMediaElementC.Play();
        }
        // The Letter D Is Played
        private void Button_Click_D(object sender, RoutedEventArgs e)
        {
            myMediaElementD.Source = new Uri("ms-appx:///Assets/D.wav", UriKind.RelativeOrAbsolute);
            myMediaElementD.Play();
        }

        // The Letter E Is Played
        private void Button_Click_E(object sender, RoutedEventArgs e)
        {
            myMediaElementE.Source = new Uri("ms-appx:///Assets/E.wav", UriKind.RelativeOrAbsolute);
            myMediaElementE.Play();
        }

        // The Letter F Is Played
        private void Button_Click_F(object sender, RoutedEventArgs e)
        {
            myMediaElementF.Source = new Uri("ms-appx:///Assets/F.wav", UriKind.RelativeOrAbsolute);
            myMediaElementF.Play();
        }
        // The Letter G Is Played
        private void Button_Click_G(object sender, RoutedEventArgs e)
        {
            myMediaElementG.Source = new Uri("ms-appx:///Assets/G.wav", UriKind.RelativeOrAbsolute);
            myMediaElementG.Play();
        }
        // The Letter H Is Played
        private void Button_Click_H(object sender, RoutedEventArgs e)
        {
            myMediaElementH.Source = new Uri("ms-appx:///Assets/H.wav", UriKind.RelativeOrAbsolute);
            myMediaElementH.Play();
        }
        // The Letter I Is Played
        private void Button_Click_I(object sender, RoutedEventArgs e)
        {
            myMediaElementI.Source = new Uri("ms-appx:///Assets/I.wav", UriKind.RelativeOrAbsolute);
            myMediaElementI.Play();
        }
        // The Letter J Is Played
        private void Button_Click_J(object sender, RoutedEventArgs e)
        {
            myMediaElementJ.Source = new Uri("ms-appx:///Assets/J.wav", UriKind.RelativeOrAbsolute);
            myMediaElementJ.Play();
        }
        // The Letter K Is Played
        private void Button_Click_K(object sender, RoutedEventArgs e)
        {
            myMediaElementK.Source = new Uri("ms-appx:///Assets/K.wav", UriKind.RelativeOrAbsolute);
            myMediaElementK.Play();
        }
        // The Letter L Is Played
        private void Button_Click_L(object sender, RoutedEventArgs e)
        {
            myMediaElementL.Source = new Uri("ms-appx:///Assets/L.wav", UriKind.RelativeOrAbsolute);
            myMediaElementL.Play();
        }

        // The Letter M Is Played
        private void Button_Click_M(object sender, RoutedEventArgs e)
        {
            myMediaElementM.Source = new Uri("ms-appx:///Assets/M.wav", UriKind.RelativeOrAbsolute);
            myMediaElementM.Play();
        }
        // The Letter N Is Played
        private void Button_Click_N(object sender, RoutedEventArgs e)
        {
            myMediaElementN.Source = new Uri("ms-appx:///Assets/N.wav", UriKind.RelativeOrAbsolute);
            myMediaElementN.Play();
        }
        // The Letter O Is Played
        private void Button_Click_O(object sender, RoutedEventArgs e)
        {
            myMediaElementO.Source = new Uri("ms-appx:///Assets/O.wav", UriKind.RelativeOrAbsolute);
            myMediaElementO.Play();
        }

        // The Letter P Is Played
        private void Button_Click_P(object sender, RoutedEventArgs e)
        {
            myMediaElementP.Source = new Uri("ms-appx:///Assets/P.wav", UriKind.RelativeOrAbsolute);
            myMediaElementP.Play();
        }

        // The Letter Q Is Played
        private void Button_Click_Q(object sender, RoutedEventArgs e)
        {
            myMediaElementQ.Source = new Uri("ms-appx:///Assets/Q.wav", UriKind.RelativeOrAbsolute);
            myMediaElementQ.Play();
        }
        // The Letter R Is Played
        private void Button_Click_R(object sender, RoutedEventArgs e)
        {
            myMediaElementR.Source = new Uri("ms-appx:///Assets/R.wav", UriKind.RelativeOrAbsolute);
            myMediaElementR.Play();
        }

        // The Letter S Is Played
        private void Button_Click_S(object sender, RoutedEventArgs e)
        {
            myMediaElementS.Source = new Uri("ms-appx:///Assets/S.wav", UriKind.RelativeOrAbsolute);
            myMediaElementS.Play();
        }

        // The Letter T Is Played
        private void Button_Click_T(object sender, RoutedEventArgs e)
        {
            myMediaElementT.Source = new Uri("ms-appx:///Assets/T.wav", UriKind.RelativeOrAbsolute);
            myMediaElementT.Play();
        }

        // The Letter U Is Played
        private void Button_Click_U(object sender, RoutedEventArgs e)
        {
            myMediaElementU.Source = new Uri("ms-appx:///Assets/U.wav", UriKind.RelativeOrAbsolute);
            myMediaElementU.Play();
        }

        // The Letter V Is Played
        private void Button_Click_V(object sender, RoutedEventArgs e)
        {
            myMediaElementV.Source = new Uri("ms-appx:///Assets/V.wav", UriKind.RelativeOrAbsolute);
            myMediaElementV.Play();
        }
        // The Letter W Is Played
        private void Button_Click_W(object sender, RoutedEventArgs e)
        {
            myMediaElementW.Source = new Uri("ms-appx:///Assets/W.wav", UriKind.RelativeOrAbsolute);
            myMediaElementW.Play();
        }
        // The Letter X Is Played
        private void Button_Click_X(object sender, RoutedEventArgs e)
        {
            myMediaElementX.Source = new Uri("ms-appx:///Assets/X.wav", UriKind.RelativeOrAbsolute);
            myMediaElementX.Play();
        }

        // The Letter Y Is Played
        private void Button_Click_Y(object sender, RoutedEventArgs e)
        {
            myMediaElementY.Source = new Uri("ms-appx:///Assets/Y.wav", UriKind.RelativeOrAbsolute);
            myMediaElementY.Play();
        }
        // The Letter Z Is Played
        private void Button_Click_Z(object sender, RoutedEventArgs e)
        {
            myMediaElementZ.Source = new Uri("ms-appx:///Assets/Z.wav", UriKind.RelativeOrAbsolute);
            myMediaElementZ.Play();
        }

        // The ABC song will begin to play When the button is pressed
        private void Button_Click_PlayButton(object sender, RoutedEventArgs e)
        {
            alphabetPlaySong.Source = new Uri("ms-appx:///Assets/ABCSong.mp3", UriKind.RelativeOrAbsolute);
            alphabetPlaySong.Play();
            
        }


        
    }
}
