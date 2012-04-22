// -----------------------------------------------------------------------
// <copyright file="EventIdentity.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace RowingUtilities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class EventIdentity
    {
        // This class wraps: A CompetitorGroup, a Category, and a BoatClass.
        public CompetitorGroup CompetitorGroup { get; set; }
        public Category Category { get; set; }
        public BoatClass BoatClass { get; set; }

        public EventIdentity(string eventIdentity)
        {
            this.CompetitorGroup = new CompetitorGroup(eventIdentity);
            this.Category = new Category(eventIdentity);
            this.BoatClass = new BoatClass(eventIdentity);
        }
        
        public override string ToString()
        {
            if (string.IsNullOrEmpty(this.CompetitorGroup.ToString()))
            {
                return string.Format("{0}.{1}",
                    this.Category.ToString(),
                    this.BoatClass.ToString());
            }

            return string.Format("{0}.{1}.{2}",
                    this.CompetitorGroup.ToString(),
                    this.Category.ToString(),
                    this.BoatClass.ToString());
        }
    }
}