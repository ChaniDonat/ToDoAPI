﻿using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class Item
{
  public Item( string name)
    {
        Id = 0;
        Name = name;
        IsComplete = false;
    }
    public int Id { get; set; }

    public string? Name { get; set; }

    public bool? IsComplete { get; set; }
}
