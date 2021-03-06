﻿namespace Protocol.Models
{
	public class Character
	{
		// TODO make immutable
		// TODO use builder
		// TODO random generator

		public byte Level { get; set; }
		public string Name { get; set; }
		public Classification Classification { get; set; }
		public Customizations Customization { get; set; }
		public Equipment Equipment { get; set; }
		public Status Status { get; set; }
		public Stats Stats { get; set; }
		public Points Points { get; set; }
		public byte ActiveMainhand { get; set; } // represent differently?
		public byte ActiveOffhand { get; set; } // represent differently?
		public ushort Model { get; set; } // uncertain
		public ushort Region { get; set; }
		public string LocationDescription { get; set; }
		public bool Sitting { get; set; }
		public Coordinates Coordinates { get; set; }
	}
}
