﻿namespace OfflineARM.Business.Models.Dictionaries.Interfaces
{
    /// <summary>
    /// Статус заказа
    /// </summary>
    public interface IOrderStatusModel : IBaseBusninessModel
    {
        /// <summary>
        /// Наименование
        /// </summary>
        string Name
        {
            get;
            set;
        }
    }
}
