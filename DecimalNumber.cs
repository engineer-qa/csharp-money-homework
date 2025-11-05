namespace csharp_money_homework;

public readonly struct DecimalNumber
{
    public int Value { get; }

    public DecimalNumber(int value)
    {
        Value = value;
    }

    public string ToBinary()
    {
        if (Value == 0) return "0b0";
        var abs = Math.Abs(Value);
        var core = Convert.ToString(abs, 2);
        return Value < 0 ? $"-0b{core}" : $"0b{core}";
    }

    public string ToOctal()
    {
        if (Value == 0) return "0o0";
        var abs = Math.Abs(Value);
        var core = Convert.ToString(abs, 8);
        return Value < 0 ? $"-0o{core}" : $"0o{core}";
    }

    public string ToHex(bool uppercase = true)
    {
        if (Value == 0) return "0x0";
        var abs = Math.Abs(Value);
        var core = Convert.ToString(abs, 16);
        core = uppercase ? core.ToUpperInvariant() : core.ToLowerInvariant();
        return Value < 0 ? $"-0x{core}" : $"0x{core}";
    }

    public override string ToString() => Value.ToString();
}