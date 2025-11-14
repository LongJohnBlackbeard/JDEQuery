using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40R142 - .
/// </summary>
public class F40R142 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DCUKID.
        /// </summary>
        public const string DCUKID = "DCUKID";

        /// <summary>
        /// DCDEID.
        /// </summary>
        public const string DCDEID = "DCDEID";

        /// <summary>
        /// DCPARTYTYP.
        /// </summary>
        public const string DCPARTYTYP = "DCPARTYTYP";

        /// <summary>
        /// DCCONTTYP.
        /// </summary>
        public const string DCCONTTYP = "DCCONTTYP";

        /// <summary>
        /// DCPHONETYP.
        /// </summary>
        public const string DCPHONETYP = "DCPHONETYP";

        /// <summary>
        /// DCCONTNUM.
        /// </summary>
        public const string DCCONTNUM = "DCCONTNUM";

        /// <summary>
        /// DCURCD.
        /// </summary>
        public const string DCURCD = "DCURCD";

        /// <summary>
        /// DCURDT.
        /// </summary>
        public const string DCURDT = "DCURDT";

        /// <summary>
        /// DCURAT.
        /// </summary>
        public const string DCURAT = "DCURAT";

        /// <summary>
        /// DCURAB.
        /// </summary>
        public const string DCURAB = "DCURAB";

        /// <summary>
        /// DCURRF.
        /// </summary>
        public const string DCURRF = "DCURRF";

        /// <summary>
        /// DCUSER.
        /// </summary>
        public const string DCUSER = "DCUSER";

        /// <summary>
        /// DCPID.
        /// </summary>
        public const string DCPID = "DCPID";

        /// <summary>
        /// DCJOBN.
        /// </summary>
        public const string DCJOBN = "DCJOBN";

        /// <summary>
        /// DCUPMJ.
        /// </summary>
        public const string DCUPMJ = "DCUPMJ";

        /// <summary>
        /// DCTDAY.
        /// </summary>
        public const string DCTDAY = "DCTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F40R142";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DCUKID", "DCUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("DCDEID", "DCDEID", JdeDataType.Numeric, null, true, true),
        new JdeField("DCPARTYTYP", "DCPARTYTYP", JdeDataType.String, 6, true, true),
        new JdeField("DCCONTTYP", "DCCONTTYP", JdeDataType.String, 6, true, true),
        new JdeField("DCPHONETYP", "DCPHONETYP", JdeDataType.String, 6, true, true),
        new JdeField("DCCONTNUM", "DCCONTNUM", JdeDataType.String, 60),
        new JdeField("DCURCD", "DCURCD", JdeDataType.String, 4),
        new JdeField("DCURDT", "DCURDT", JdeDataType.Numeric),
        new JdeField("DCURAT", "DCURAT", JdeDataType.Numeric),
        new JdeField("DCURAB", "DCURAB", JdeDataType.Numeric),
        new JdeField("DCURRF", "DCURRF", JdeDataType.String, 30),
        new JdeField("DCUSER", "DCUSER", JdeDataType.String, 20),
        new JdeField("DCPID", "DCPID", JdeDataType.String, 20),
        new JdeField("DCJOBN", "DCJOBN", JdeDataType.String, 20),
        new JdeField("DCUPMJ", "DCUPMJ", JdeDataType.Numeric),
        new JdeField("DCTDAY", "DCTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40R142_0", "Primary Key on DCUKID, DCDEID, DCPARTYTYP, DCCONTTYP, DCPHONETYP", new[] { "DCUKID", "DCDEID", "DCPARTYTYP", "DCCONTTYP", "DCPHONETYP" }, isUnique: true, isPrimaryKey: true)
    };
}
