using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42008 - .
/// </summary>
public class F42008 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HCCTYP.
        /// </summary>
        public const string HCCTYP = "HCCTYP";

        /// <summary>
        /// HCHCOD.
        /// </summary>
        public const string HCHCOD = "HCHCOD";

        /// <summary>
        /// HCRPER.
        /// </summary>
        public const string HCRPER = "HCRPER";

        /// <summary>
        /// HCMCU.
        /// </summary>
        public const string HCMCU = "HCMCU";

        /// <summary>
        /// HCTYPC.
        /// </summary>
        public const string HCTYPC = "HCTYPC";

        /// <summary>
        /// HCLTYP.
        /// </summary>
        public const string HCLTYP = "HCLTYP";

        /// <summary>
        /// HCLLC.
        /// </summary>
        public const string HCLLC = "HCLLC";

        /// <summary>
        /// HCULC.
        /// </summary>
        public const string HCULC = "HCULC";

        /// <summary>
        /// HCPWRD.
        /// </summary>
        public const string HCPWRD = "HCPWRD";

        /// <summary>
        /// HCDSC1.
        /// </summary>
        public const string HCDSC1 = "HCDSC1";

        /// <summary>
        /// HCPPL.
        /// </summary>
        public const string HCPPL = "HCPPL";

        /// <summary>
        /// HCAPB.
        /// </summary>
        public const string HCAPB = "HCAPB";
    }

    /// <inheritdoc />
    public override string TableName => "F42008";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HCCTYP", "HCCTYP", JdeDataType.String, 4),
        new JdeField("HCHCOD", "HCHCOD", JdeDataType.String, 4, true, true),
        new JdeField("HCRPER", "HCRPER", JdeDataType.Numeric),
        new JdeField("HCMCU", "HCMCU", JdeDataType.String, 24, true, true),
        new JdeField("HCTYPC", "HCTYPC", JdeDataType.String, 4),
        new JdeField("HCLTYP", "HCLTYP", JdeDataType.String, 4),
        new JdeField("HCLLC", "HCLLC", JdeDataType.Numeric),
        new JdeField("HCULC", "HCULC", JdeDataType.Numeric),
        new JdeField("HCPWRD", "HCPWRD", JdeDataType.String, 20),
        new JdeField("HCDSC1", "HCDSC1", JdeDataType.String, 60),
        new JdeField("HCPPL", "HCPPL", JdeDataType.Numeric),
        new JdeField("HCAPB", "HCAPB", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42008_0", "Primary Key on HCHCOD, HCMCU", new[] { "HCHCOD", "HCMCU" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F42008_2", "Index on HCRPER, HCMCU", new[] { "HCRPER", "HCMCU" })
    };
}
