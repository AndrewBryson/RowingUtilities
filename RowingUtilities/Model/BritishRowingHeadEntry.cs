// -----------------------------------------------------------------------
// <copyright file="BritishRowingHeadEntry.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace RowingUtilities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using FileHelpers;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    [DelimitedRecord(","), IgnoreFirst(1)]
    public class BritishRowingHeadEntry
    {
        [FieldQuoted('"', QuoteMode.AlwaysQuoted)]
        public int CrewID;

        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string CrewName;

        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public int EventID;

        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string EventIdentityInternal;

        public EventIdentity EventIdentity 
        {
            get
            {
                return new EventIdentity(this.EventIdentityInternal);
            }
        }
        
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string Composite;

        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string CompositeCode;

        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string SubmittingClub;

        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string SubmittingClubIndex;

        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string SubmittingAdministratorName;

        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string SubmittingAdministratorEmail;

        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string EntriesSecretary;

        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string EntriesSecretaryEmail;

        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string EmergencyContactName;

        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string EmergencyContactHomeTelephone;

        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string EmergencyContactMobileTelephone;

        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string EmergencyContactWorkTelephone;

        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string EmergencyContactEmail;

        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        [FieldConverter(ConverterKind.Date, @"dd/MM/yyyy")]
        public DateTime? DateSubmitted;
        public string Paid;

        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        [FieldConverter(ConverterKind.Date, "dd/MM/yyyy")]
        public DateTime? PaymentDate;

        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string PaymentType;

        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string Refunded;

        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string Accepted;

        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string Rejected;

        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string Withdrawn;

        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string Scratched;

        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string ClubNotes;

        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string CompetitionsNotes;

        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string CompetitionAdministrationUserFieldOne;

        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string CompetitionAdministrationUserFieldTwo;

        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string BoatID;

        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string BoatName;

        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string BoatCode;

        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string BoatingPermissionsClubName;

        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string BoatingPermissionsClubIndexCode;

        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string BoatingPermissionsClubEmail;

        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string CoachName;

        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string DivisionAssigned;

        public int EntryWeighting
        {
            get
            {
                return
                    (int)this.EventIdentity.CompetitorGroup.Type +
                    (int)this.EventIdentity.Category.Type +
                    (int)this.EventIdentity.BoatClass.Type;
            }
        }
    }
}
