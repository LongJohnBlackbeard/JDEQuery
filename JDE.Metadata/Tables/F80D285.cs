using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D285 - .
/// </summary>
public class F80D285 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TCPRDJ.
        /// </summary>
        public const string TCPRDJ = "TCPRDJ";

        /// <summary>
        /// TCMCU.
        /// </summary>
        public const string TCMCU = "TCMCU";

        /// <summary>
        /// TCECBR.
        /// </summary>
        public const string TCECBR = "TCECBR";

        /// <summary>
        /// TCATCHBK.
        /// </summary>
        public const string TCATCHBK = "TCATCHBK";

        /// <summary>
        /// TCUSER.
        /// </summary>
        public const string TCUSER = "TCUSER";

        /// <summary>
        /// TCPID.
        /// </summary>
        public const string TCPID = "TCPID";

        /// <summary>
        /// TCMKEY.
        /// </summary>
        public const string TCMKEY = "TCMKEY";

        /// <summary>
        /// TCUTIME.
        /// </summary>
        public const string TCUTIME = "TCUTIME";

        /// <summary>
        /// TCURCD.
        /// </summary>
        public const string TCURCD = "TCURCD";

        /// <summary>
        /// TCURDT.
        /// </summary>
        public const string TCURDT = "TCURDT";

        /// <summary>
        /// TCURAT.
        /// </summary>
        public const string TCURAT = "TCURAT";

        /// <summary>
        /// TCURAB.
        /// </summary>
        public const string TCURAB = "TCURAB";

        /// <summary>
        /// TCURRF.
        /// </summary>
        public const string TCURRF = "TCURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F80D285";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TCPRDJ", "TCPRDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("TCMCU", "TCMCU", JdeDataType.String, 24, true, true),
        new JdeField("TCECBR", "TCECBR", JdeDataType.String, 4, true, true),
        new JdeField("TCATCHBK", "TCATCHBK", JdeDataType.Numeric),
        new JdeField("TCUSER", "TCUSER", JdeDataType.String, 20),
        new JdeField("TCPID", "TCPID", JdeDataType.String, 20),
        new JdeField("TCMKEY", "TCMKEY", JdeDataType.String, 30),
        new JdeField("TCUTIME", "TCUTIME", JdeDataType.Date),
        new JdeField("TCURCD", "TCURCD", JdeDataType.String, 4),
        new JdeField("TCURDT", "TCURDT", JdeDataType.Numeric),
        new JdeField("TCURAT", "TCURAT", JdeDataType.Numeric),
        new JdeField("TCURAB", "TCURAB", JdeDataType.Numeric),
        new JdeField("TCURRF", "TCURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D285_0", "Primary Key on TCPRDJ, TCMCU, TCECBR", new[] { "TCPRDJ", "TCMCU", "TCECBR" }, isUnique: true, isPrimaryKey: true)
    };
}
