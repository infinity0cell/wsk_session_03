namespace session_03.src.logic.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Route
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Route()
        {
            Schedules = new HashSet<Schedule>();
        }

        public int ID { get; set; }

        public int DepartureAirportID { get; set; }

        public int ArrivalAirportID { get; set; }

        public int Distance { get; set; }

        public int FlightTime { get; set; }

        public virtual Airport DepartureAirport { get; set; }

        public virtual Airport ArrivalAirport { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Schedule> Schedules { get; set; }

        public override string ToString()
        {
            return $"{DepartureAirport.IATACode} -> {ArrivalAirport.IATACode}";
        }
    }
}
