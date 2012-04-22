// -----------------------------------------------------------------------
// <copyright file="BoatClass.cs" company="">
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
    public class BoatClass :  IComparable<BoatClass>
    {
        public string Name { get; set; }
        public BoatClassType Type { get; set; }
        public BoatRowingType RowingType { get; set; }

        public BoatClass(string eventIdentity)
        {
            string[] parts = eventIdentity.Split('.');

            /*
             * 'Worst' case: W.MasA.Nov.2x.
             * In this case, drop the Nov part, MasA is taken in preference.
             */

            if (parts.Length == 4)
            {
                // e.g. the case W.MasA.Nov.2x.
                this.Name = parts[3];
            }
            else if (parts.Length == 2)
            {
                // e.g. SEN.4+.
                this.Name = parts[1];
            }
            else
            {
                // e.g. W.IM3.8+.
                this.Name = parts[2];
            }
            
            if (this.Name.Contains("x"))
            {
                this.RowingType = BoatRowingType.Scull;
            }
            else
            {
                this.RowingType = BoatRowingType.Sweep;
            }

            switch (this.Name)
            {
                case "8+":
                    this.Type = BoatClassType.Coxed_Eight;
                    break;
                case "8x+":
                    this.Type = BoatClassType.Coxed_Octuple;
                    break;
                case "4+":
                    this.Type = BoatClassType.Coxed_Four;
                    break;
                case "4-":
                    this.Type = BoatClassType.Coxless_Four;
                    break;
                case "4x+":
                    this.Type = BoatClassType.Coxed_Quad;
                    break;
                case "4x-":
                    this.Type = BoatClassType.Coxless_Quad;
                    break;
                case "2+":
                    this.Type = BoatClassType.Coxed_Pair;
                    break;
                case "2-":
                    this.Type = BoatClassType.Coxless_Pair;
                    break;
                case "2x":
                    this.Type = BoatClassType.Double;
                    break;
                case "1x":
                    this.Type = BoatClassType.Single;
                    break;
                default:
                    break;
            }
        }

        public override string ToString()
        {
            return this.Name;
        }

        #region IComparable Members

        public int CompareTo(BoatClass other)
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

    public enum BoatRowingType
    {
        Sweep,
        Scull,
    }

    public enum BoatClassType
    {
        Coxed_Eight = 1,
        Coxed_Octuple = 2,
        Coxless_Four = 3,
        Coxless_Quad = 4,
        Coxed_Four = 5,
        Double = 6,
        Coxless_Pair = 7,
        Coxed_Pair = 8,
        Coxed_Quad = 9,
        Single = 10,
    }
}
