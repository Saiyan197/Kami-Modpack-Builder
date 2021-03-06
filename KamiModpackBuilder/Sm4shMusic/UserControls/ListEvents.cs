﻿using KamiModpackBuilder.Sm4shMusic.EventHandlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KamiModpackBuilder.Sm4shMusic.UserControls
{
    public delegate void ItemSelected(object sender, ListEntryArgs e);
    public delegate void ItemAdded(object sender, ListEntryArgs e);
    public delegate void ItemRemoved(object sender, ListEntryArgs e);
    public delegate void ItemMoving(object sender, MoveItemArgs e);
}
