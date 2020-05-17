using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Покупка с процентной скидкой 
    /// </summary>
    [Serializable]
    public class PurchaseByPercent : IPurchase
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
        /// Приватное поле велечины скидки по проценту
        /// </summary>
        private double _valueOfPercent;

        /// <summary>
        /// Величина скидки по проценту
        /// </summary>
        public double ValueOfPercent
        {
            get
            {
                return _valueOfPercent;
            }
            set
            {
                if (value>100)
                {
                    throw new ArgumentOutOfRangeException("Значение " +
                        "процента скидки не может быть больше 100.");
                }

                _valueOfPercent = SetRules.SetValue("Процент скидки", value);
            }
        }

        /// <summary>
        /// Цена после скидки по проценту
        /// </summary>
        double IPurchase.PriceAfterDiscount
        {
            get
            {
                return Math.Round(_facePrice*(1-_valueOfPercent/100),2);
            }
        }

        /// <summary>
        /// Конструктор класса по умолчанию
        /// </summary>
        public PurchaseByPercent() : this(0) { }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="facePrice">Цена товара до скидки</param>
        public PurchaseByPercent (double facePrice)
        {
            _facePrice = facePrice;
            _valueOfPercent = 0;
        }
    }
}
