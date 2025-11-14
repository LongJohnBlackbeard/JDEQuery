using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA14D - .
/// </summary>
public class F90CA14D : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TDTERRID.
        /// </summary>
        public const string TDTERRID = "TDTERRID";

        /// <summary>
        /// TDADDZ.
        /// </summary>
        public const string TDADDZ = "TDADDZ";

        /// <summary>
        /// TDCTY1.
        /// </summary>
        public const string TDCTY1 = "TDCTY1";

        /// <summary>
        /// TDCOUN.
        /// </summary>
        public const string TDCOUN = "TDCOUN";

        /// <summary>
        /// TDSTSUDT.
        /// </summary>
        public const string TDSTSUDT = "TDSTSUDT";

        /// <summary>
        /// TDACTIND.
        /// </summary>
        public const string TDACTIND = "TDACTIND";

        /// <summary>
        /// TDUSER.
        /// </summary>
        public const string TDUSER = "TDUSER";

        /// <summary>
        /// TDPID.
        /// </summary>
        public const string TDPID = "TDPID";

        /// <summary>
        /// TDVID.
        /// </summary>
        public const string TDVID = "TDVID";

        /// <summary>
        /// TDMKEY.
        /// </summary>
        public const string TDMKEY = "TDMKEY";

        /// <summary>
        /// TDUDTTM.
        /// </summary>
        public const string TDUDTTM = "TDUDTTM";

        /// <summary>
        /// TDENTDBY.
        /// </summary>
        public const string TDENTDBY = "TDENTDBY";

        /// <summary>
        /// TDEDATE.
        /// </summary>
        public const string TDEDATE = "TDEDATE";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA14D";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TDTERRID", "TDTERRID", JdeDataType.Numeric, null, true, true),
        new JdeField("TDADDZ", "TDADDZ", JdeDataType.String, 24, true, true),
        new JdeField("TDCTY1", "TDCTY1", JdeDataType.String, 50),
        new JdeField("TDCOUN", "TDCOUN", JdeDataType.String, 50),
        new JdeField("TDSTSUDT", "TDSTSUDT", JdeDataType.Date),
        new JdeField("TDACTIND", "TDACTIND", JdeDataType.String, 2),
        new JdeField("TDUSER", "TDUSER", JdeDataType.String, 20),
        new JdeField("TDPID", "TDPID", JdeDataType.String, 20),
        new JdeField("TDVID", "TDVID", JdeDataType.String, 20),
        new JdeField("TDMKEY", "TDMKEY", JdeDataType.String, 30),
        new JdeField("TDUDTTM", "TDUDTTM", JdeDataType.Date),
        new JdeField("TDENTDBY", "TDENTDBY", JdeDataType.Numeric),
        new JdeField("TDEDATE", "TDEDATE", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA14D_0", "Primary Key on TDTERRID, TDADDZ", new[] { "TDTERRID", "TDADDZ" }, isUnique: true, isPrimaryKey: true)
    };
}
