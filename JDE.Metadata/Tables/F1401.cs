using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1401 - .
/// </summary>
public class F1401 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BPBPC.
        /// </summary>
        public const string BPBPC = "BPBPC";

        /// <summary>
        /// BPDL01.
        /// </summary>
        public const string BPDL01 = "BPDL01";

        /// <summary>
        /// BPPG01.
        /// </summary>
        public const string BPPG01 = "BPPG01";

        /// <summary>
        /// BPPG02.
        /// </summary>
        public const string BPPG02 = "BPPG02";

        /// <summary>
        /// BPPG03.
        /// </summary>
        public const string BPPG03 = "BPPG03";

        /// <summary>
        /// BPPG04.
        /// </summary>
        public const string BPPG04 = "BPPG04";

        /// <summary>
        /// BPPG05.
        /// </summary>
        public const string BPPG05 = "BPPG05";

        /// <summary>
        /// BPPG06.
        /// </summary>
        public const string BPPG06 = "BPPG06";

        /// <summary>
        /// BPPG07.
        /// </summary>
        public const string BPPG07 = "BPPG07";

        /// <summary>
        /// BPPG08.
        /// </summary>
        public const string BPPG08 = "BPPG08";

        /// <summary>
        /// BPPG09.
        /// </summary>
        public const string BPPG09 = "BPPG09";

        /// <summary>
        /// BPPG10.
        /// </summary>
        public const string BPPG10 = "BPPG10";

        /// <summary>
        /// BPPG11.
        /// </summary>
        public const string BPPG11 = "BPPG11";

        /// <summary>
        /// BPPG12.
        /// </summary>
        public const string BPPG12 = "BPPG12";

        /// <summary>
        /// BPPG13.
        /// </summary>
        public const string BPPG13 = "BPPG13";

        /// <summary>
        /// BPPG14.
        /// </summary>
        public const string BPPG14 = "BPPG14";
    }

    /// <inheritdoc />
    public override string TableName => "F1401";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BPBPC", "BPBPC", JdeDataType.String, 6, true, true),
        new JdeField("BPDL01", "BPDL01", JdeDataType.String, 60),
        new JdeField("BPPG01", "BPPG01", JdeDataType.Numeric),
        new JdeField("BPPG02", "BPPG02", JdeDataType.Numeric),
        new JdeField("BPPG03", "BPPG03", JdeDataType.Numeric),
        new JdeField("BPPG04", "BPPG04", JdeDataType.Numeric),
        new JdeField("BPPG05", "BPPG05", JdeDataType.Numeric),
        new JdeField("BPPG06", "BPPG06", JdeDataType.Numeric),
        new JdeField("BPPG07", "BPPG07", JdeDataType.Numeric),
        new JdeField("BPPG08", "BPPG08", JdeDataType.Numeric),
        new JdeField("BPPG09", "BPPG09", JdeDataType.Numeric),
        new JdeField("BPPG10", "BPPG10", JdeDataType.Numeric),
        new JdeField("BPPG11", "BPPG11", JdeDataType.Numeric),
        new JdeField("BPPG12", "BPPG12", JdeDataType.Numeric),
        new JdeField("BPPG13", "BPPG13", JdeDataType.Numeric),
        new JdeField("BPPG14", "BPPG14", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1401_0", "Primary Key on BPBPC", new[] { "BPBPC" }, isUnique: true, isPrimaryKey: true)
    };
}
