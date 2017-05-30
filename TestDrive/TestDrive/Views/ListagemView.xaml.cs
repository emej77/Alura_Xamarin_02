﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDrive.Model;
using Xamarin.Forms;

namespace TestDrive.Views
{
    public partial class ListagemView : ContentPage
    {
        public List<Veiculo> Veiculos { get; set; }

        public ListagemView()
        {
            InitializeComponent();
            this.Veiculos = new ListagemVeiculos().Veiculos;
            this.BindingContext = this;
        }

        private void ListViewVeiculos_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }
    }
}
