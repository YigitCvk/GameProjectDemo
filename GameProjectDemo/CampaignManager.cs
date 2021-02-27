using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    class CampaignManager:ICampaingService
    {
        public void KampOner(Campaign campaign)
        {
            Console.WriteLine(" Size Özel Kampanyaları Görmek İçin Lütfen Tıklayın ! ");
        }

        public void KampSelect(Campaign campaign)
        {
            Console.WriteLine(" Seçtiğiniz Kampanya Siparişinize Uygulandı ! ");
        }
    }
}
