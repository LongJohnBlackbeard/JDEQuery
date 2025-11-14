using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D104 - .
/// </summary>
public class F80D104 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ALALISTID.
        /// </summary>
        public const string ALALISTID = "ALALISTID";

        /// <summary>
        /// ALAN8.
        /// </summary>
        public const string ALAN8 = "ALAN8";

        /// <summary>
        /// ALURCD.
        /// </summary>
        public const string ALURCD = "ALURCD";

        /// <summary>
        /// ALURDT.
        /// </summary>
        public const string ALURDT = "ALURDT";

        /// <summary>
        /// ALURAT.
        /// </summary>
        public const string ALURAT = "ALURAT";

        /// <summary>
        /// ALURAB.
        /// </summary>
        public const string ALURAB = "ALURAB";

        /// <summary>
        /// ALURRF.
        /// </summary>
        public const string ALURRF = "ALURRF";

        /// <summary>
        /// ALUSER.
        /// </summary>
        public const string ALUSER = "ALUSER";

        /// <summary>
        /// ALMKEY.
        /// </summary>
        public const string ALMKEY = "ALMKEY";

        /// <summary>
        /// ALPID.
        /// </summary>
        public const string ALPID = "ALPID";

        /// <summary>
        /// ALUUPMJ.
        /// </summary>
        public const string ALUUPMJ = "ALUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F80D104";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ALALISTID", "ALALISTID", JdeDataType.String, 24, true, true),
        new JdeField("ALAN8", "ALAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("ALURCD", "ALURCD", JdeDataType.String, 4),
        new JdeField("ALURDT", "ALURDT", JdeDataType.Numeric),
        new JdeField("ALURAT", "ALURAT", JdeDataType.Numeric),
        new JdeField("ALURAB", "ALURAB", JdeDataType.Numeric),
        new JdeField("ALURRF", "ALURRF", JdeDataType.String, 30),
        new JdeField("ALUSER", "ALUSER", JdeDataType.String, 20),
        new JdeField("ALMKEY", "ALMKEY", JdeDataType.String, 30),
        new JdeField("ALPID", "ALPID", JdeDataType.String, 20),
        new JdeField("ALUUPMJ", "ALUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D104_0", "Primary Key on ALALISTID, ALAN8", new[] { "ALALISTID", "ALAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
