﻿using System;
using System.Collections.Generic;
using System.Threading;

namespace OfflineARM.Controller.Holders
{
    /// <summary>
	/// Базовый класс простого хранилища типа "словарь"
	/// </summary>
	/// <typeparam name="KEY">Тип ключа словаря</typeparam>
	/// <typeparam name="VALUE">Тип значения словаря</typeparam>
	public class GenericSimpleHolder<KEY, VALUE>
    {
        #region Поля

        /// <summary>
        /// Коллекция
        /// </summary>
        protected Dictionary<KEY, VALUE> _collection = new Dictionary<KEY, VALUE>();

        /// <summary>
        /// Примитив синхронизации
        /// </summary>
        protected ReaderWriterLockSlim _lock;

        /// <summary>
        /// Флаг необходимости поддержки уникальности добавляемых значений.
        /// true, если нельзя добавлять дважды один и тот же ключ.
        /// false, если можно добавлять один и тот же ключ несколько раз, заменяя значение.
        /// </summary>
        protected bool _denyValueReplacement;

        #endregion

        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="useReaderWriterLock">Флаг необходимости использовать примитив блокировки</param>
        /// <param name="denyValueReplacement"></param>
        protected GenericSimpleHolder(bool useReaderWriterLock = false, bool denyValueReplacement = true)
        {
            if (useReaderWriterLock)
            {
                this._lock = new ReaderWriterLockSlim();
            }
            this._denyValueReplacement = denyValueReplacement;
        }

        #endregion

        #region Методы

        /// <summary>
        /// Задаёт значение для ключа
        /// </summary>
        /// <param name="key">Ключ</param>
        /// <param name="value">Значение</param>
        protected void SetValue(KEY key, VALUE value)
        {
            using (ReaderWriterLockService.GetWriter(this._lock, true))
            {
                if (this._denyValueReplacement && this._collection.ContainsKey(key))
                {
                    throw new InvalidOperationException(string.Format(ControllerResources.HolderCannotReplaceValueFormat, key, this.GetType()));
                }
                this._collection[key] = value;
            }
        }

        /// <summary>
        /// Задаёт значение для ключа
        /// </summary>
        /// <param name="key">Ключ</param>
        protected void Remove(KEY key)
        {
            using (ReaderWriterLockService.GetWriter(this._lock, true))
            {
                this._collection.Remove(key);
            }
        }

        /// <summary>
        /// Возвращает значение для ключа
        /// </summary>
        /// <param name="key">Ключ</param>
        /// <returns>Значение</returns>
        protected VALUE GetValue(KEY key)
        {
            using (ReaderWriterLockService.GetReader(this._lock, true))
            {
                VALUE value;
                if (this._collection.TryGetValue(key, out value))
                {
                    return value;
                }
                return default(VALUE);
            }
        }

        /// <summary>
        /// Возвращает значение для ключа
        /// </summary>
        /// <param name="key">Ключ</param>
        /// <param name="value">Значение</param>
        /// <returns>Значение</returns>
        protected bool TryGetValue(KEY key, out VALUE value)
        {
            using (ReaderWriterLockService.GetReader(this._lock, true))
            {
                return this._collection.TryGetValue(key, out value);
            }
        }

        /// <summary>
        /// Возвращает ключ по значению
        /// </summary>
        /// <param name="value">Значение</param>
        /// <returns>Ключ</returns>
        protected KEY GetKey(VALUE value)
        {
            using (ReaderWriterLockService.GetReader(this._lock, true))
            {
                foreach (KeyValuePair<KEY, VALUE> pair in this._collection)
                {
                    if (pair.Value.Equals(value))
                    {
                        return pair.Key;
                    }
                }
                return default(KEY);
            }
        }

        #endregion
    }
}
