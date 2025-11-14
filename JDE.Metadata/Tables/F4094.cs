using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4094 - .
/// </summary>
public class F4094 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// KIPRGR.
        /// </summary>
        public const string KIPRGR = "KIPRGR";

        /// <summary>
        /// KIIGP1.
        /// </summary>
        public const string KIIGP1 = "KIIGP1";

        /// <summary>
        /// KIIGP2.
        /// </summary>
        public const string KIIGP2 = "KIIGP2";

        /// <summary>
        /// KIIGP3.
        /// </summary>
        public const string KIIGP3 = "KIIGP3";

        /// <summary>
        /// KIIGP4.
        /// </summary>
        public const string KIIGP4 = "KIIGP4";

        /// <summary>
        /// KICPGP.
        /// </summary>
        public const string KICPGP = "KICPGP";

        /// <summary>
        /// KICGP1.
        /// </summary>
        public const string KICGP1 = "KICGP1";

        /// <summary>
        /// KICGP2.
        /// </summary>
        public const string KICGP2 = "KICGP2";

        /// <summary>
        /// KICGP3.
        /// </summary>
        public const string KICGP3 = "KICGP3";

        /// <summary>
        /// KICGP4.
        /// </summary>
        public const string KICGP4 = "KICGP4";

        /// <summary>
        /// KIICID.
        /// </summary>
        public const string KIICID = "KIICID";
    }

    /// <inheritdoc />
    public override string TableName => "F4094";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("KIPRGR", "KIPRGR", JdeDataType.String, 16, true, true),
        new JdeField("KIIGP1", "KIIGP1", JdeDataType.String, 12, true, true),
        new JdeField("KIIGP2", "KIIGP2", JdeDataType.String, 12, true, true),
        new JdeField("KIIGP3", "KIIGP3", JdeDataType.String, 12, true, true),
        new JdeField("KIIGP4", "KIIGP4", JdeDataType.String, 12, true, true),
        new JdeField("KICPGP", "KICPGP", JdeDataType.String, 16, true, true),
        new JdeField("KICGP1", "KICGP1", JdeDataType.String, 6, true, true),
        new JdeField("KICGP2", "KICGP2", JdeDataType.String, 6, true, true),
        new JdeField("KICGP3", "KICGP3", JdeDataType.String, 6, true, true),
        new JdeField("KICGP4", "KICGP4", JdeDataType.String, 6, true, true),
        new JdeField("KIICID", "KIICID", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4094_0", "Primary Key on KIPRGR, KIIGP1, KIIGP2, KIIGP3, KIIGP4, KICPGP, KICGP1, KICGP2, KICGP3, KICGP4", new[] { "KIPRGR", "KIIGP1", "KIIGP2", "KIIGP3", "KIIGP4", "KICPGP", "KICGP1", "KICGP2", "KICGP3", "KICGP4" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4094_2", "Index on KIICID", new[] { "KIICID" })
    };
}
