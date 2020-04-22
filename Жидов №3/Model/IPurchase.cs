using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Интерфейс совершения покупки
    /// </summary>
    public interface IPurchase
    {
        /// <summary>
        /// Цена до скидки
        /// </summary>
        double FacePrice { get; set; }

        /// <summary>
        /// Цена после скидки
        /// </summary>
        double PriceAfterDiscount { get; }
    }
}