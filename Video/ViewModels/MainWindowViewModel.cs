using Livet;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video.ViewModels
{
    class MainWindowViewModel : ViewModel
    {
        public ReactiveProperty<string> TextBoxText { get; set; } = new ReactiveProperty<string>(String.Empty);
        public ReactiveProperty<string> TextBlockText { get; set; } = new ReactiveProperty<string>(String.Empty);

        public MainWindowViewModel()
        {
            Debug.WriteLine("MainWindowViewModel");

            TextBoxText.Subscribe(_ =>
            {
                TextBlockText.Value = TextBoxText.Value;
            });

        }

    }
}
