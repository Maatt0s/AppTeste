using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiApp1.ViewModels
{
    public partial class CoinViewModel : ObservableObject
    {
        public String _ladoEscolhido { get; set; } = String.Empty;
        public String _imagem { get; set; } = String.Empty;
        public String _resultado { get; set; } = String.Empty;

    }
}
