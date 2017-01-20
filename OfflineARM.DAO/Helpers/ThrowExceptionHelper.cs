﻿using System;

namespace OfflineARM.DAO.Helpers
{
    /// <summary>
    /// Хелпер вброса эксепшна
    /// </summary>
    public static class ThrowExceptionHelper
    {
        /// <summary>
        /// Вброс эксепшена, если пустая строка
        /// </summary>
        /// <param name="arg">Проверяемый аргумент</param>
        /// <param name="message">Сообщение</param>
        public static void ThrowIfNull(this object arg, string message = "")
        {
            if (arg == null)
            {
                throw new ArgumentNullException(message);
            }
        }

        /// <summary>
        /// Вброс эксепшена, если пустая строка
        /// </summary>
        /// <param name="arg">Проверяемый аргумент</param>
        /// <param name="message">Сообщение</param>
        public static void ThrowIfNull(this string arg, string message = "")
        {
            if (string.IsNullOrEmpty(arg))
            {
                throw new ArgumentNullException(message);
            }
        }

        /// <summary>
        /// Вброс эксепшена, если пустая строка
        /// </summary>
        /// <param name="arg">Проверяемый аргумент</param>
        /// <param name="message">Сообщение</param>
        public static void ThrowIfNull(this int arg, string message = "")
        {
            if (arg == 0)
            {
                throw new ArgumentNullException(message);
            }
        }

        /// <summary>
        /// Вброс эксепшена, если пустая строка
        /// </summary>
        /// <param name="arg">Проверяемый аргумент</param>
        /// <param name="message">Сообщение</param>
        public static void ThrowIfNull(this DateTime arg, string message = "")
        {
            if (arg == null || arg == DateTime.MinValue)
            {
                throw new ArgumentNullException(message);
            }
        }
    }
}
