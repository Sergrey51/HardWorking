using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Класс, для создания случайной покупки
    /// </summary>
    public static class RandomPurchase
    {
        /// <summary>
        /// Поле случайное
        /// </summary>
        private static Random _randomNumber = new Random();

        /// <summary>
        /// Создание случайной покупки
        /// </summary>
        /// <returns>Ексемпляр покупки</returns>
        public static IPurchase CreatePurchase()
        {
            IPurchase purchase = new PurchaseWithoutDiscount();

            int typePurchase = _randomNumber.Next(0, 3);
            
            if (typePurchase == 0)
            {
                purchase = new PurchaseWithoutDiscount(
                    Convert.ToDouble(_randomNumber.Next(0, 1000000) / 100));
            }

            if (typePurchase == 1)
            {
                double randomFacePrice =
                    Convert.ToDouble(_randomNumber.Next(0, 1000000) / 100);

                purchase = new PurchaseByCertificate(randomFacePrice);

                (purchase as PurchaseByCertificate).ValueOfCertificate =
                    Convert.ToDouble(_randomNumber.Next(
                        0, Convert.ToInt32(randomFacePrice)/100));
            }

            if (typePurchase == 2)
            {
                purchase = new PurchaseByPercent(
                    Convert.ToDouble(_randomNumber.Next(0, 1000000) / 100));

                (purchase as PurchaseByPercent).ValueOfPercent = 
                    Convert.ToDouble(_randomNumber.Next(0, 10001)/100);
            }

            return purchase;
        }
    }
}
