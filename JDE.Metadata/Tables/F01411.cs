using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F01411 - .
/// </summary>
public class F01411 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ACACTIDS.
        /// </summary>
        public const string ACACTIDS = "ACACTIDS";

        /// <summary>
        /// ACAPLNID.
        /// </summary>
        public const string ACAPLNID = "ACAPLNID";

        /// <summary>
        /// ACACTNM.
        /// </summary>
        public const string ACACTNM = "ACACTNM";

        /// <summary>
        /// ACAN8.
        /// </summary>
        public const string ACAN8 = "ACAN8";

        /// <summary>
        /// ACACTVTYP.
        /// </summary>
        public const string ACACTVTYP = "ACACTVTYP";

        /// <summary>
        /// ACNODY.
        /// </summary>
        public const string ACNODY = "ACNODY";

        /// <summary>
        /// ACENDTM.
        /// </summary>
        public const string ACENDTM = "ACENDTM";

        /// <summary>
        /// ACSTRTM.
        /// </summary>
        public const string ACSTRTM = "ACSTRTM";

        /// <summary>
        /// ACCOMITLVL.
        /// </summary>
        public const string ACCOMITLVL = "ACCOMITLVL";

        /// <summary>
        /// ACACPID.
        /// </summary>
        public const string ACACPID = "ACACPID";

        /// <summary>
        /// ACCOMNTS.
        /// </summary>
        public const string ACCOMNTS = "ACCOMNTS";

        /// <summary>
        /// ACPLNTY.
        /// </summary>
        public const string ACPLNTY = "ACPLNTY";

        /// <summary>
        /// ACUSER.
        /// </summary>
        public const string ACUSER = "ACUSER";

        /// <summary>
        /// ACMKEY.
        /// </summary>
        public const string ACMKEY = "ACMKEY";

        /// <summary>
        /// ACUDTTM.
        /// </summary>
        public const string ACUDTTM = "ACUDTTM";

        /// <summary>
        /// ACENTDBY.
        /// </summary>
        public const string ACENTDBY = "ACENTDBY";

        /// <summary>
        /// ACEDATE.
        /// </summary>
        public const string ACEDATE = "ACEDATE";
    }

    /// <inheritdoc />
    public override string TableName => "F01411";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ACACTIDS", "ACACTIDS", JdeDataType.Numeric, null, true, true),
        new JdeField("ACAPLNID", "ACAPLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("ACACTNM", "ACACTNM", JdeDataType.String, 510),
        new JdeField("ACAN8", "ACAN8", JdeDataType.Numeric),
        new JdeField("ACACTVTYP", "ACACTVTYP", JdeDataType.String, 82),
        new JdeField("ACNODY", "ACNODY", JdeDataType.Numeric),
        new JdeField("ACENDTM", "ACENDTM", JdeDataType.Date),
        new JdeField("ACSTRTM", "ACSTRTM", JdeDataType.Date),
        new JdeField("ACCOMITLVL", "ACCOMITLVL", JdeDataType.Numeric),
        new JdeField("ACACPID", "ACACPID", JdeDataType.Numeric),
        new JdeField("ACCOMNTS", "ACCOMNTS", JdeDataType.String, 3998),
        new JdeField("ACPLNTY", "ACPLNTY", JdeDataType.String, 6),
        new JdeField("ACUSER", "ACUSER", JdeDataType.String, 20),
        new JdeField("ACMKEY", "ACMKEY", JdeDataType.String, 30),
        new JdeField("ACUDTTM", "ACUDTTM", JdeDataType.Date),
        new JdeField("ACENTDBY", "ACENTDBY", JdeDataType.Numeric),
        new JdeField("ACEDATE", "ACEDATE", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F01411_0", "Primary Key on ACACTIDS, ACAPLNID", new[] { "ACACTIDS", "ACAPLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
