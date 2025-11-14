using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F12854 - .
/// </summary>
public class F12854 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LZPSPC.
        /// </summary>
        public const string LZPSPC = "LZPSPC";

        /// <summary>
        /// LZDL01.
        /// </summary>
        public const string LZDL01 = "LZDL01";

        /// <summary>
        /// LZPG01.
        /// </summary>
        public const string LZPG01 = "LZPG01";

        /// <summary>
        /// LZPG02.
        /// </summary>
        public const string LZPG02 = "LZPG02";

        /// <summary>
        /// LZPG03.
        /// </summary>
        public const string LZPG03 = "LZPG03";

        /// <summary>
        /// LZPG04.
        /// </summary>
        public const string LZPG04 = "LZPG04";

        /// <summary>
        /// LZPG05.
        /// </summary>
        public const string LZPG05 = "LZPG05";

        /// <summary>
        /// LZPG06.
        /// </summary>
        public const string LZPG06 = "LZPG06";

        /// <summary>
        /// LZPG07.
        /// </summary>
        public const string LZPG07 = "LZPG07";

        /// <summary>
        /// LZPG08.
        /// </summary>
        public const string LZPG08 = "LZPG08";

        /// <summary>
        /// LZPG09.
        /// </summary>
        public const string LZPG09 = "LZPG09";

        /// <summary>
        /// LZPG10.
        /// </summary>
        public const string LZPG10 = "LZPG10";

        /// <summary>
        /// LZPG11.
        /// </summary>
        public const string LZPG11 = "LZPG11";

        /// <summary>
        /// LZPG12.
        /// </summary>
        public const string LZPG12 = "LZPG12";

        /// <summary>
        /// LZPG13.
        /// </summary>
        public const string LZPG13 = "LZPG13";

        /// <summary>
        /// LZPG14.
        /// </summary>
        public const string LZPG14 = "LZPG14";
    }

    /// <inheritdoc />
    public override string TableName => "F12854";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LZPSPC", "LZPSPC", JdeDataType.String, 6, true, true),
        new JdeField("LZDL01", "LZDL01", JdeDataType.String, 60),
        new JdeField("LZPG01", "LZPG01", JdeDataType.Numeric),
        new JdeField("LZPG02", "LZPG02", JdeDataType.Numeric),
        new JdeField("LZPG03", "LZPG03", JdeDataType.Numeric),
        new JdeField("LZPG04", "LZPG04", JdeDataType.Numeric),
        new JdeField("LZPG05", "LZPG05", JdeDataType.Numeric),
        new JdeField("LZPG06", "LZPG06", JdeDataType.Numeric),
        new JdeField("LZPG07", "LZPG07", JdeDataType.Numeric),
        new JdeField("LZPG08", "LZPG08", JdeDataType.Numeric),
        new JdeField("LZPG09", "LZPG09", JdeDataType.Numeric),
        new JdeField("LZPG10", "LZPG10", JdeDataType.Numeric),
        new JdeField("LZPG11", "LZPG11", JdeDataType.Numeric),
        new JdeField("LZPG12", "LZPG12", JdeDataType.Numeric),
        new JdeField("LZPG13", "LZPG13", JdeDataType.Numeric),
        new JdeField("LZPG14", "LZPG14", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F12854_0", "Primary Key on LZPSPC", new[] { "LZPSPC" }, isUnique: true, isPrimaryKey: true)
    };
}
