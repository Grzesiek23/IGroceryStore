﻿using IGroceryStore.Users.Core.Exceptions;

namespace IGroceryStore.Users.Core.ValueObjects;

public record FirstName
{
    public string Value { get; }
    
    public FirstName(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            throw new InvalidFirstNameException(value);
        }
        Value = value;
    }
    
    public static implicit operator string(FirstName lastName) => lastName.Value;
    public static implicit operator FirstName(string value) => new(value);
}