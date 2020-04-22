using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Покупка без скидки
    /// </summary>
    public class PurchaseWithoutDiscount : IPurchase
    {
        /// <summary>
        /// Приватное поле цена до скидки
        /// </summary>
        private double _facePrice;

        /// <summary>
        /// Цена до скидки
        /// </summary>
        double IPurchase.FacePrice
        {
            get
            {
                return _facePrice;
            }
            set
            {
                _facePrice = SetRules.SetValue("Цена", value);
            }
        }

        /// <summary>
        /// Цена после скидки по сертифекату
        /// </summary>
        double IPurchase.PriceAfterDiscount
        {
            get
            {
                return _facePrice;
            }
        }
    }
}
