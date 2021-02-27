using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    interface IGameService
    {
        void Ekle(Games games);
        void Sil(Games games);
    }
}
