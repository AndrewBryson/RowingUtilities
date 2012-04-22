using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FileHelpers;
using System.IO;

namespace RowingUtilities
{
    public class HeadEventDraw
    {
        public List<BritishRowingHeadEntry> Entry { get; set; }
        FileHelperEngine engine;

        public HeadEventDraw()
        {
            this.engine = new FileHelperEngine(typeof(BritishRowingHeadEntry));
            this.Entry = new List<BritishRowingHeadEntry>();
        }

        public void LoadFromFile(string filename)
        {
            BritishRowingHeadEntry[] entry = (BritishRowingHeadEntry[])engine.ReadFile(filename);
            this.Entry = new List<BritishRowingHeadEntry>(entry);
        }

        public void LoadFromString(string input)
        {
            BritishRowingHeadEntry[] entry = (BritishRowingHeadEntry[])engine.ReadString(input);
            this.Entry = new List<BritishRowingHeadEntry>(entry);
        }

        public void LoadFromStream(StreamReader inputStream)
        {
            BritishRowingHeadEntry[] entry = (BritishRowingHeadEntry[])engine.ReadStream(inputStream);
            this.Entry = new List<BritishRowingHeadEntry>(entry);
        }

        public void SaveToFile(string filename)
        {
            this.engine.WriteFile(filename, this.Entry);
        }

        public string GetAsString()
        {
            return this.engine.WriteString(this.Entry);
        }

        public void SaveToStream(StreamWriter targetStream)
        {
            this.engine.WriteStream(targetStream, this.Entry);
        }

        public void SortDraw()
        {
            var result = from events in this.Entry
                         .OrderBy(d => d.DivisionAssigned)
                         .ThenBy(x => x.EventIdentity.BoatClass)
                         .ThenBy(z => z.EventIdentity.Category)
                         .ThenBy(y => y.EventIdentity.CompetitorGroup)
                         select events;

            this.Entry = result.ToList();
        }
    }
}
