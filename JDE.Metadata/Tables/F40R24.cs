using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40R24 - .
/// </summary>
public class F40R24 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CLMCU.
        /// </summary>
        public const string CLMCU = "CLMCU";

        /// <summary>
        /// CLAN8.
        /// </summary>
        public const string CLAN8 = "CLAN8";

        /// <summary>
        /// CLSHAN.
        /// </summary>
        public const string CLSHAN = "CLSHAN";

        /// <summary>
        /// CLCUMBYST.
        /// </summary>
        public const string CLCUMBYST = "CLCUMBYST";

        /// <summary>
        /// CLTRKCUM.
        /// </summary>
        public const string CLTRKCUM = "CLTRKCUM";

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
        /// CLPID.
        /// </summary>
        public const string CLPID = "CLPID";

        /// <summary>
        /// CLJOBN.
        /// </summary>
        public const string CLJOBN = "CLJOBN";

        /// <summary>
        /// CLUPMJ.
        /// </summary>
        public const string CLUPMJ = "CLUPMJ";

        /// <summary>
        /// CLTDAY.
        /// </summary>
        public const string CLTDAY = "CLTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F40R24";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CLMCU", "CLMCU", JdeDataType.String, 24, true, true),
        new JdeField("CLAN8", "CLAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("CLSHAN", "CLSHAN", JdeDataType.Numeric, null, true, true),
        new JdeField("CLCUMBYST", "CLCUMBYST", JdeDataType.String, 2),
        new JdeField("CLTRKCUM", "CLTRKCUM", JdeDataType.String, 2),
        new JdeField("CLURCD", "CLURCD", JdeDataType.String, 4),
        new JdeField("CLURDT", "CLURDT", JdeDataType.Numeric),
        new JdeField("CLURAT", "CLURAT", JdeDataType.Numeric),
        new JdeField("CLURAB", "CLURAB", JdeDataType.Numeric),
        new JdeField("CLURRF", "CLURRF", JdeDataType.String, 30),
        new JdeField("CLUSER", "CLUSER", JdeDataType.String, 20),
        new JdeField("CLPID", "CLPID", JdeDataType.String, 20),
        new JdeField("CLJOBN", "CLJOBN", JdeDataType.String, 20),
        new JdeField("CLUPMJ", "CLUPMJ", JdeDataType.Numeric),
        new JdeField("CLTDAY", "CLTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40R24_0", "Primary Key on CLMCU, CLAN8, CLSHAN", new[] { "CLMCU", "CLAN8", "CLSHAN" }, isUnique: true, isPrimaryKey: true)
    };
}
