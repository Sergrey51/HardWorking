using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model
{
    /// <summary>
    /// Класс со скидкой по сертефикату
    /// </summary>
    [Serializable]
    public class PurchaseByCertificate : IPurchase
    {
        /// <summary>
        /// Приватное поле цена до скидки
        /// </summary>
        private double _facePrice;
        
        /// <summary>
        /// Цена до скидки
        /// </summary>
        public double FacePrice
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
        /// Приватное поле велечины скидки по сертифекату
        /// </summary>
        private double _valueOfCertificate;

        /// <summary>
        /// Величина скидки по сертифекату
        /// </summary>
        public double ValueOfCertificate
        {
            get
            {
                return _valueOfCertificate;
            }
            set
            {
                _valueOfCertificate = SetRules.SetValue("Скидка", value);
            }
        }

        /// <summary>
        /// Цена после скидки по сертифекату
        /// </summary>
        public double PriceAfterDiscount
        {
            get
            {
                return (_facePrice > _valueOfCertificate)
                    ? _facePrice - _valueOfCertificate
                    : 0;
            }
        }

        /// <summary>
        /// Конструктор класса по умолчанию
        /// </summary>
        public PurchaseByCertificate() : this(0) { }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="facePrice">Цена товара до скидки</param>
        public PurchaseByCertificate(double facePrice)
        {
            _facePrice = facePrice;
            _valueOfCertificate = 0;
        }
    }
}
