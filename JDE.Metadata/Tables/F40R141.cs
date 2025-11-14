using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40R141 - .
/// </summary>
public class F40R141 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DNUKID.
        /// </summary>
        public const string DNUKID = "DNUKID";

        /// <summary>
        /// DNDEID.
        /// </summary>
        public const string DNDEID = "DNDEID";

        /// <summary>
        /// DNPARTYTYP.
        /// </summary>
        public const string DNPARTYTYP = "DNPARTYTYP";

        /// <summary>
        /// DNCONTTYP.
        /// </summary>
        public const string DNCONTTYP = "DNCONTTYP";

        /// <summary>
        /// DNCONTID.
        /// </summary>
        public const string DNCONTID = "DNCONTID";

        /// <summary>
        /// DNURCD.
        /// </summary>
        public const string DNURCD = "DNURCD";

        /// <summary>
        /// DNURDT.
        /// </summary>
        public const string DNURDT = "DNURDT";

        /// <summary>
        /// DNURAT.
        /// </summary>
        public const string DNURAT = "DNURAT";

        /// <summary>
        /// DNURAB.
        /// </summary>
        public const string DNURAB = "DNURAB";

        /// <summary>
        /// DNURRF.
        /// </summary>
        public const string DNURRF = "DNURRF";

        /// <summary>
        /// DNUSER.
        /// </summary>
        public const string DNUSER = "DNUSER";

        /// <summary>
        /// DNPID.
        /// </summary>
        public const string DNPID = "DNPID";

        /// <summary>
        /// DNJOBN.
        /// </summary>
        public const string DNJOBN = "DNJOBN";

        /// <summary>
        /// DNUPMJ.
        /// </summary>
        public const string DNUPMJ = "DNUPMJ";

        /// <summary>
        /// DNTDAY.
        /// </summary>
        public const string DNTDAY = "DNTDAY";

        /// <summary>
        /// DNWHO1.
        /// </summary>
        public const string DNWHO1 = "DNWHO1";
    }

    /// <inheritdoc />
    public override string TableName => "F40R141";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DNUKID", "DNUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("DNDEID", "DNDEID", JdeDataType.Numeric, null, true, true),
        new JdeField("DNPARTYTYP", "DNPARTYTYP", JdeDataType.String, 6, true, true),
        new JdeField("DNCONTTYP", "DNCONTTYP", JdeDataType.String, 6, true, true),
        new JdeField("DNCONTID", "DNCONTID", JdeDataType.String, 70),
        new JdeField("DNURCD", "DNURCD", JdeDataType.String, 4),
        new JdeField("DNURDT", "DNURDT", JdeDataType.Numeric),
        new JdeField("DNURAT", "DNURAT", JdeDataType.Numeric),
        new JdeField("DNURAB", "DNURAB", JdeDataType.Numeric),
        new JdeField("DNURRF", "DNURRF", JdeDataType.String, 30),
        new JdeField("DNUSER", "DNUSER", JdeDataType.String, 20),
        new JdeField("DNPID", "DNPID", JdeDataType.String, 20),
        new JdeField("DNJOBN", "DNJOBN", JdeDataType.String, 20),
        new JdeField("DNUPMJ", "DNUPMJ", JdeDataType.Numeric),
        new JdeField("DNTDAY", "DNTDAY", JdeDataType.Numeric),
        new JdeField("DNWHO1", "DNWHO1", JdeDataType.String, 80)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40R141_0", "Primary Key on DNUKID, DNDEID, DNPARTYTYP, DNCONTTYP", new[] { "DNUKID", "DNDEID", "DNPARTYTYP", "DNCONTTYP" }, isUnique: true, isPrimaryKey: true)
    };
}
