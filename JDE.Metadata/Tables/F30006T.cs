using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F30006T - .
/// </summary>
public class F30006T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IWMCU.
        /// </summary>
        public const string IWMCU = "IWMCU";

        /// <summary>
        /// IWLIC.
        /// </summary>
        public const string IWLIC = "IWLIC";

        /// <summary>
        /// IWWRH2.
        /// </summary>
        public const string IWWRH2 = "IWWRH2";

        /// <summary>
        /// IWWRH3.
        /// </summary>
        public const string IWWRH3 = "IWWRH3";

        /// <summary>
        /// IWWRH4.
        /// </summary>
        public const string IWWRH4 = "IWWRH4";

        /// <summary>
        /// IWWRH5.
        /// </summary>
        public const string IWWRH5 = "IWWRH5";

        /// <summary>
        /// IWWRH6.
        /// </summary>
        public const string IWWRH6 = "IWWRH6";

        /// <summary>
        /// IWCAPU.
        /// </summary>
        public const string IWCAPU = "IWCAPU";

        /// <summary>
        /// IWCPSD.
        /// </summary>
        public const string IWCPSD = "IWCPSD";

        /// <summary>
        /// IWCPMI.
        /// </summary>
        public const string IWCPMI = "IWCPMI";

        /// <summary>
        /// IWCPMA.
        /// </summary>
        public const string IWCPMA = "IWCPMA";

        /// <summary>
        /// IWSHMC.
        /// </summary>
        public const string IWSHMC = "IWSHMC";
    }

    /// <inheritdoc />
    public override string TableName => "F30006T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IWMCU", "IWMCU", JdeDataType.String, 24, true, true),
        new JdeField("IWLIC", "IWLIC", JdeDataType.String, 2),
        new JdeField("IWWRH2", "IWWRH2", JdeDataType.Numeric),
        new JdeField("IWWRH3", "IWWRH3", JdeDataType.Numeric),
        new JdeField("IWWRH4", "IWWRH4", JdeDataType.Numeric),
        new JdeField("IWWRH5", "IWWRH5", JdeDataType.Numeric),
        new JdeField("IWWRH6", "IWWRH6", JdeDataType.Numeric),
        new JdeField("IWCAPU", "IWCAPU", JdeDataType.String, 4),
        new JdeField("IWCPSD", "IWCPSD", JdeDataType.Numeric),
        new JdeField("IWCPMI", "IWCPMI", JdeDataType.Numeric),
        new JdeField("IWCPMA", "IWCPMA", JdeDataType.Numeric),
        new JdeField("IWSHMC", "IWSHMC", JdeDataType.String, 24)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F30006T_0", "Primary Key on IWMCU", new[] { "IWMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
