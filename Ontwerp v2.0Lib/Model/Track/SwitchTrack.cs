﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Model
{
    using Ontwerp_v2._0Lib.Model;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public enum SwitchType
    {
        FROM_UP, FROM_DOWN, TO_UP, TO_DOWN
    }

	public class SwitchTrack : Track
	{
        public SwitchType SwitchType
        {
            get;
            set;
        }

        public int Id
        {
            get;
            set;
        }

        public SwitchTrack(SwitchType switchType, int id) 
            : base(Direction.UP)
        {
            SwitchType = switchType;
            Id = id;
        }
	}
}

