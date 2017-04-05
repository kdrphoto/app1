﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja1.figury
{
    class figura
    {
        protected Pozycja pozycja = null;
        protected Pozycja Pozycja
        {
            get
            {
                return pozycja;
            }
        }

        public string kolor;

        protected bool CzyPionowo(Pozycja nowaPozycja)
        {
            return Pozycja.Y == nowaPozycja.Y;
        }

        protected bool CzyPoziomo(Pozycja nowaPozycja)
        {
            return Pozycja.X == nowaPozycja.X;
        }

        protected bool CzySkos(Pozycja nowaPozycja)
        {
            return Math.Abs(Pozycja.Y - nowaPozycja.Y) == Math.Abs(Pozycja.X - nowaPozycja.X);
        }

        public virtual bool CzyMoznaPrzesunac(Pozycja nowaPozycja)
        {
            return CzyPionowo(nowaPozycja) || CzyPoziomo(nowaPozycja) || CzySkos(nowaPozycja);
        }

        public figura(Pozycja pozycja, string kolor)
        {
            this.pozycja = pozycja;
            this.kolor = kolor;
        }
    }
}
