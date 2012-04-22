// -----------------------------------------------------------------------
// <copyright file="CompetitorGroup.cs" company="">
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
    public class CompetitorGroup : IComparable<CompetitorGroup>
    {
        public string Name { get; set; }
        public CompetitorGroupType Type { get; set; }

        public CompetitorGroup(string eventIdentity)
        {
            string[] parts = eventIdentity.Split('.');

            if (parts.Length == 2)
            {
                // This is a men's event, there is no prefix on the event identity.
                this.Name = string.Empty;
            }
            else
            {
                // e.g. "Mx" or "W".
                this.Name = parts[0];
            }

            switch (this.Name)
            {
                case "W":
                    this.Type = CompetitorGroupType.Women;
                    break;
                case "Mx":
                    this.Type = CompetitorGroupType.Mixed;
                    break;
                default:
                    this.Type = CompetitorGroupType.Men;
                    break;
            }
        }

        public override string ToString()
        {
            return this.Name;
        }

        #region IComparable<CompetitorGroup> Members

        public int CompareTo(CompetitorGroup other)
        {
            if (this.Type > other.Type)
            {
                return 1;
            }
            else if (this.Type < other.Type)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        #endregion
    }

    public enum CompetitorGroupType
    {
        Men = 1000,
        Mixed = 2000,
        Women = 3000,
    }
}