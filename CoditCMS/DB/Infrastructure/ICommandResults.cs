﻿namespace DB.Infrastructure
{
    public interface ICommandResults
    {
        ICommandResult[] Results { get; }

        bool Success { get; }
    }
}

