﻿using System;

namespace DB.Exceptions
{
    public class CommandHandlerNotFoundException : Exception
    {
        public CommandHandlerNotFoundException(Type type) : base(string.Format("Не найден обработчик комманды для типа: {0}", type))
        {
        }
    }
}

