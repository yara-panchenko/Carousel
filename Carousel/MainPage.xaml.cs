﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Carousel
{
    public partial class MainPage : CarouselPage
    {

        public MainPage()
        {
            InitializeComponent();         
        }
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("Флегматик", "неспешен, невозмутим, имеет устойчивые стремления и настроение, внешне скуп на проявление эмоций и чувств. Он проявляет упорство и настойчивость в работе, оставаясь спокойным и уравновешенным. В работе он производителен, компенсируя свою неспешность прилежанием.", "OK");
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            DisplayAlert("Меланхолик", "человек легко ранимый, склонный к постоянному переживанию различных событий, он мало реагирует на внешние факторы. Свои астенические переживания он не может сдерживать усилием воли, он чересчур впечатлителен, легко эмоционально раним.", "OK");
        }

        private void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            DisplayAlert("Холерик", "быстрый, страстный, порывистый, однако совершенно неуравновешенный, с резко меняющимся настроением с эмоциональными вспышками, быстро истощаемый. У него нет равновесия нервных процессов, это его резко отличает от сангвиника. Холерик, увлекаясь, безалаберно растрачивает свои силы и быстро истощается.", "OK");
        }

        private void TapGestureRecognizer_Tapped_3(object sender, EventArgs e)
        {
            DisplayAlert("Сангвиник", "живой, горячий, подвижный человек, с частой сменой настроения, впечатлений, с быстрой реакцией на все события, происходящие вокруг него, довольно легко примиряющийся со своими неудачами и неприятностями. Обычно сангвиники обладают выразительной мимикой. Он очень продуктивен в работе, когда ему интересно, приходя в сильное возбуждение от этого, если работа не интересна, он относится к ней безразлично, ему становится скучно.", "OK");
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://testometrika.com/personality-and-temper/the-formula-of-temperament-a-belov/");
            await Browser.OpenAsync(uri);
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://testometrika.com/personality-and-temper/the-formula-of-temperament-a-belov/");
            await Browser.OpenAsync(uri);
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://testometrika.com/personality-and-temper/the-formula-of-temperament-a-belov/");
            await Browser.OpenAsync(uri);
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://testometrika.com/personality-and-temper/the-formula-of-temperament-a-belov/");
            await Browser.OpenAsync(uri);
        }
    }
}
