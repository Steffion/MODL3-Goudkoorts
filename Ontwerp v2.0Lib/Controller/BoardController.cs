﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Controller
{
    using Model;
    using Ontwerp_v2._0Lib.Controller;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using View;

	public class BoardController
	{
		public virtual BoardView BoardView
		{
			get;
			set;
		}

		public virtual WarehouseController WarehouseController
		{
			get;
			set;
		}

		public virtual ShipController ShipController
		{
			get;
			set;
		}

		public virtual InputController InputController
		{
			get;
			set;
		}

		public virtual StartController StartController
		{
			get;
			set;
		}

		public virtual Board Board
		{
			get;
			set;
		}

        public BoardController()
        {
            Board = new Board();
            BoardView = new BoardView(Board);
        }
	}
}

