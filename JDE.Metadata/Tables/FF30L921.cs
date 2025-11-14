using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF30L921 - .
/// </summary>
public class FF30L921 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CLLNDSID.
        /// </summary>
        public const string CLLNDSID = "CLLNDSID";

        /// <summary>
        /// CLDFITM.
        /// </summary>
        public const string CLDFITM = "CLDFITM";

        /// <summary>
        /// CLDFMCU.
        /// </summary>
        public const string CLDFMCU = "CLDFMCU";

        /// <summary>
        /// CLCPSQ.
        /// </summary>
        public const string CLCPSQ = "CLCPSQ";

        /// <summary>
        /// CLFSCID.
        /// </summary>
        public const string CLFSCID = "CLFSCID";

        /// <summary>
        /// CLPHID.
        /// </summary>
        public const string CLPHID = "CLPHID";

        /// <summary>
        /// CLPPRID.
        /// </summary>
        public const string CLPPRID = "CLPPRID";

        /// <summary>
        /// CLPROID.
        /// </summary>
        public const string CLPROID = "CLPROID";

        /// <summary>
        /// CLCOSQ.
        /// </summary>
        public const string CLCOSQ = "CLCOSQ";

        /// <summary>
        /// CLVALTM.
        /// </summary>
        public const string CLVALTM = "CLVALTM";

        /// <summary>
        /// CLNONTM.
        /// </summary>
        public const string CLNONTM = "CLNONTM";

        /// <summary>
        /// CLURCD.
        /// </summary>
        public const string CLURCD = "CLURCD";

        /// <summary>
        /// CLURDT.
        /// </summary>
        public const string CLURDT = "CLURDT";

        /// <summary>
        /// CLURAT.
        /// </summary>
        public const string CLURAT = "CLURAT";

        /// <summary>
        /// CLURAB.
        /// </summary>
        public const string CLURAB = "CLURAB";

        /// <summary>
        /// CLURRF.
        /// </summary>
        public const string CLURRF = "CLURRF";

        /// <summary>
        /// CLUSER.
        /// </summary>
        public const string CLUSER = "CLUSER";

        /// <summary>
        /// CLMKEY.
        /// </summary>
        public const string CLMKEY = "CLMKEY";

        /// <summary>
        /// CLPID.
        /// </summary>
        public const string CLPID = "CLPID";

        /// <summary>
        /// CLUUPMJ.
        /// </summary>
        public const string CLUUPMJ = "CLUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "FF30L921";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CLLNDSID", "CLLNDSID", JdeDataType.Numeric, null, true, true),
        new JdeField("CLDFITM", "CLDFITM", JdeDataType.Numeric, null, true, true),
        new JdeField("CLDFMCU", "CLDFMCU", JdeDataType.String, 24, true, true),
        new JdeField("CLCPSQ", "CLCPSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("CLFSCID", "CLFSCID", JdeDataType.Numeric),
        new JdeField("CLPHID", "CLPHID", JdeDataType.Numeric),
        new JdeField("CLPPRID", "CLPPRID", JdeDataType.Numeric),
        new JdeField("CLPROID", "CLPROID", JdeDataType.Numeric),
        new JdeField("CLCOSQ", "CLCOSQ", JdeDataType.Numeric),
        new JdeField("CLVALTM", "CLVALTM", JdeDataType.Numeric),
        new JdeField("CLNONTM", "CLNONTM", JdeDataType.Numeric),
        new JdeField("CLURCD", "CLURCD", JdeDataType.String, 4),
        new JdeField("CLURDT", "CLURDT", JdeDataType.Numeric),
        new JdeField("CLURAT", "CLURAT", JdeDataType.Numeric),
        new JdeField("CLURAB", "CLURAB", JdeDataType.Numeric),
        new JdeField("CLURRF", "CLURRF", JdeDataType.String, 30),
        new JdeField("CLUSER", "CLUSER", JdeDataType.String, 20),
        new JdeField("CLMKEY", "CLMKEY", JdeDataType.String, 30),
        new JdeField("CLPID", "CLPID", JdeDataType.String, 20),
        new JdeField("CLUUPMJ", "CLUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF30L921_0", "Primary Key on CLLNDSID, CLDFITM, CLDFMCU, CLCPSQ", new[] { "CLLNDSID", "CLDFITM", "CLDFMCU", "CLCPSQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF30L921_2", "Index on CLFSCID", new[] { "CLFSCID" }),
        new JdeIndex("FF30L921_3", "Index on CLLNDSID, CLDFITM, CLDFMCU, CLPPRID", new[] { "CLLNDSID", "CLDFITM", "CLDFMCU", "CLPPRID" })
    };
}
