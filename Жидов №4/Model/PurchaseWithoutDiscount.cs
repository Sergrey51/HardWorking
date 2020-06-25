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
    [Serializable]
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

        /// <summary>
        /// Конструктор класса по умолчанию
        /// </summary>
        public PurchaseWithoutDiscount() : this(0) { }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="facePrice">Цена товара до скидки</param>
        public PurchaseWithoutDiscount(double facePrice)
        {
            _facePrice = facePrice;
        }

        /// <summary>
        /// Описание операции
        /// </summary>
        public string Description
        {
            get
            {
                return $"Покупка без скидки.";
            }
        }
    }
}
