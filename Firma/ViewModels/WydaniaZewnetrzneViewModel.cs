﻿using Firma.Models.Entities;
using Firma.Models.EntitiesForView;
using Firma.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.ViewModels
{
    public class WydaniaZewnetrzneViewModel : WszystkieViewModel<WydanieZewnetrzneForAllView>
    {
        #region Konstruktor
        public WydaniaZewnetrzneViewModel():base("Wydania Zewnetrzne")
        {
        }
        #endregion

        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<WydanieZewnetrzneForAllView>
                (
                    from wz in JJFirmaEntities.WydaniaZewnetrzne
                    where wz.CzyAktywny == true
                    select new WydanieZewnetrzneForAllView
                    {
                        Numer = wz.Numer,
                        DataWydania = wz.DataWydania,
                        NazwaMagazynu = wz.Magazyny.Nazwa,
                        NazwaKontrahenta = wz.Kontrahenci.Nazwa1,
                        NipKontrahenta = wz.Kontrahenci.Nip
                    }
                );
        }
        #endregion

    }
}