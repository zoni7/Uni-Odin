﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó mediante una herramienta.
//     Los cambios del archivo se perderán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------
namespace VehicleRental.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;

    public partial class Reservation
	{
		public DateTime PickupDate
		{
			get;
			set;
		}

		public DateTime ReturnDate
		{
			get;
			set;
		}

		public int Id
		{
			get;
			set;
		}

        [InverseProperty("PickUpReservations")]
        public virtual BranchOffice PickUpOffice
		{
			get;
			set;
		}

        [InverseProperty("ReturnReservations")]
        public virtual BranchOffice ReturnOffice
		{
			get;
			set;
		}

		public virtual Category Category
		{
			get;
			set;
		}

		public virtual ICollection<Person> Drivers
		{
			get;
			set;
		}

		public virtual Customer Customer
		{
			get;
			set;
		}

	}
}

