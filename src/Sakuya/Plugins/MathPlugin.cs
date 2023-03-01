﻿using Flandre.Core.Messaging;
using Flandre.Framework.Attributes;
using Flandre.Framework.Common;

namespace Sakuya.Plugins;

public sealed class MathPlugin : Plugin
{
    [Command("square")]
    [RegexShortcut( /* lang=regex */ @"^([\+\-]?\d*)的二次方(是多少)?$", "$1")]
    public MessageContent OnSquare(CommandContext ctx, int num)
    {
        return $"{num} 的二次方为 {Math.Pow(num, 2)}。";
    }
}