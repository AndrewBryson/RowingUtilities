// -----------------------------------------------------------------------
// <copyright file="Category.cs" company="">
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
    public class Category : IComparable<Category>
    {
        public string Name { get; set; }
        public CategoryType Type { get; set; }

        public Category(string eventIdentity)
        {
            string[] parts = eventIdentity.Split('.');

            if (parts.Length == 2)
            {
                this.Name = parts[0];
            }
            else
            {
                this.Name = parts[1];
            }

            this.Type = (CategoryType) Enum.Parse(typeof(CategoryType), this.Name, true);
        }

        public override string ToString()
        {
            return this.Name;
        }

        #region IComparable Members

        public int CompareTo(Category other)
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

    public enum CategoryType
    {
        ELI = 10,
        SEN = 20,
        IM1 = 30,
        IM2 = 40,
        MasA = 50,
        MasB = 60,
        MasC = 70,
        IM3 = 80,
        J18 = 90,
        J17 = 100,
        Nov = 110,
        J16 = 120,
        MasD = 130,
        MasE = 140,
        MasF = 150,
        MasG = 160,
        MasH = 170,
        MasI = 180,
        J15 = 190,
        J14 = 200,
        J13 = 210,
        J12 = 220,
        J11 = 230,
    }
}
