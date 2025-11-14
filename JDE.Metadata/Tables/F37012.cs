using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F37012 - .
/// </summary>
public class F37012 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TCMCU.
        /// </summary>
        public const string TCMCU = "TCMCU";

        /// <summary>
        /// TCQTST.
        /// </summary>
        public const string TCQTST = "TCQTST";

        /// <summary>
        /// TCITM.
        /// </summary>
        public const string TCITM = "TCITM";

        /// <summary>
        /// TCUSGRATE.
        /// </summary>
        public const string TCUSGRATE = "TCUSGRATE";

        /// <summary>
        /// TCECQTY.
        /// </summary>
        public const string TCECQTY = "TCECQTY";

        /// <summary>
        /// TCUOM1.
        /// </summary>
        public const string TCUOM1 = "TCUOM1";

        /// <summary>
        /// TCURCD.
        /// </summary>
        public const string TCURCD = "TCURCD";

        /// <summary>
        /// TCURAT.
        /// </summary>
        public const string TCURAT = "TCURAT";

        /// <summary>
        /// TCURRF.
        /// </summary>
        public const string TCURRF = "TCURRF";

        /// <summary>
        /// TCURAB.
        /// </summary>
        public const string TCURAB = "TCURAB";

        /// <summary>
        /// TCUSER.
        /// </summary>
        public const string TCUSER = "TCUSER";

        /// <summary>
        /// TCPID.
        /// </summary>
        public const string TCPID = "TCPID";

        /// <summary>
        /// TCUPMJ.
        /// </summary>
        public const string TCUPMJ = "TCUPMJ";

        /// <summary>
        /// TCTDAY.
        /// </summary>
        public const string TCTDAY = "TCTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F37012";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TCMCU", "TCMCU", JdeDataType.String, 24, true, true),
        new JdeField("TCQTST", "TCQTST", JdeDataType.String, 50, true, true),
        new JdeField("TCITM", "TCITM", JdeDataType.Numeric, null, true, true),
        new JdeField("TCUSGRATE", "TCUSGRATE", JdeDataType.String, 30),
        new JdeField("TCECQTY", "TCECQTY", JdeDataType.Numeric),
        new JdeField("TCUOM1", "TCUOM1", JdeDataType.String, 4),
        new JdeField("TCURCD", "TCURCD", JdeDataType.String, 4),
        new JdeField("TCURAT", "TCURAT", JdeDataType.Numeric),
        new JdeField("TCURRF", "TCURRF", JdeDataType.String, 30),
        new JdeField("TCURAB", "TCURAB", JdeDataType.Numeric),
        new JdeField("TCUSER", "TCUSER", JdeDataType.String, 20),
        new JdeField("TCPID", "TCPID", JdeDataType.String, 20),
        new JdeField("TCUPMJ", "TCUPMJ", JdeDataType.Numeric),
        new JdeField("TCTDAY", "TCTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F37012_0", "Primary Key on TCMCU, TCQTST, TCITM", new[] { "TCMCU", "TCQTST", "TCITM" }, isUnique: true, isPrimaryKey: true)
    };
}
