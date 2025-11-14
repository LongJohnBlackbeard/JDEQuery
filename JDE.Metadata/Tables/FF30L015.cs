using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF30L015 - .
/// </summary>
public class FF30L015 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// REDFRID.
        /// </summary>
        public const string REDFRID = "REDFRID";

        /// <summary>
        /// REFSCID.
        /// </summary>
        public const string REFSCID = "REFSCID";

        /// <summary>
        /// REDFDRE.
        /// </summary>
        public const string REDFDRE = "REDFDRE";

        /// <summary>
        /// REDFRDESC.
        /// </summary>
        public const string REDFRDESC = "REDFRDESC";

        /// <summary>
        /// REDFRDESC1.
        /// </summary>
        public const string REDFRDESC1 = "REDFRDESC1";

        /// <summary>
        /// REDFRT.
        /// </summary>
        public const string REDFRT = "REDFRT";

        /// <summary>
        /// REDFMCU.
        /// </summary>
        public const string REDFMCU = "REDFMCU";

        /// <summary>
        /// REWDCT.
        /// </summary>
        public const string REWDCT = "REWDCT";

        /// <summary>
        /// REWDCK.
        /// </summary>
        public const string REWDCK = "REWDCK";

        /// <summary>
        /// REURCD.
        /// </summary>
        public const string REURCD = "REURCD";

        /// <summary>
        /// REURDT.
        /// </summary>
        public const string REURDT = "REURDT";

        /// <summary>
        /// REURAT.
        /// </summary>
        public const string REURAT = "REURAT";

        /// <summary>
        /// REURAB.
        /// </summary>
        public const string REURAB = "REURAB";

        /// <summary>
        /// REURRF.
        /// </summary>
        public const string REURRF = "REURRF";

        /// <summary>
        /// REUSER.
        /// </summary>
        public const string REUSER = "REUSER";

        /// <summary>
        /// REMKEY.
        /// </summary>
        public const string REMKEY = "REMKEY";

        /// <summary>
        /// REPID.
        /// </summary>
        public const string REPID = "REPID";

        /// <summary>
        /// REUUPMJ.
        /// </summary>
        public const string REUUPMJ = "REUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "FF30L015";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("REDFRID", "REDFRID", JdeDataType.Numeric, null, true, true),
        new JdeField("REFSCID", "REFSCID", JdeDataType.Numeric),
        new JdeField("REDFDRE", "REDFDRE", JdeDataType.String, 4),
        new JdeField("REDFRDESC", "REDFRDESC", JdeDataType.String, 60),
        new JdeField("REDFRDESC1", "REDFRDESC1", JdeDataType.String, 60),
        new JdeField("REDFRT", "REDFRT", JdeDataType.String, 4),
        new JdeField("REDFMCU", "REDFMCU", JdeDataType.String, 24),
        new JdeField("REWDCT", "REWDCT", JdeDataType.String, 20),
        new JdeField("REWDCK", "REWDCK", JdeDataType.String, 20),
        new JdeField("REURCD", "REURCD", JdeDataType.String, 4),
        new JdeField("REURDT", "REURDT", JdeDataType.Numeric),
        new JdeField("REURAT", "REURAT", JdeDataType.Numeric),
        new JdeField("REURAB", "REURAB", JdeDataType.Numeric),
        new JdeField("REURRF", "REURRF", JdeDataType.String, 30),
        new JdeField("REUSER", "REUSER", JdeDataType.String, 20),
        new JdeField("REMKEY", "REMKEY", JdeDataType.String, 30),
        new JdeField("REPID", "REPID", JdeDataType.String, 20),
        new JdeField("REUUPMJ", "REUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF30L015_0", "Primary Key on REDFRID", new[] { "REDFRID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF30L015_2", "Index on REFSCID", new[] { "REFSCID" }),
        new JdeIndex("FF30L015_3", "Unique Index on REFSCID, REDFRDESC", new[] { "REFSCID", "REDFRDESC" }, isUnique: true),
        new JdeIndex("FF30L015_5", "Index on REFSCID, REDFDRE", new[] { "REFSCID", "REDFDRE" })
    };
}
