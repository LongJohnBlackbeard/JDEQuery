using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4001Z50 - .
/// </summary>
public class F4001Z50 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HCDOCO.
        /// </summary>
        public const string HCDOCO = "HCDOCO";

        /// <summary>
        /// HCDCTO.
        /// </summary>
        public const string HCDCTO = "HCDCTO";

        /// <summary>
        /// HCKCOO.
        /// </summary>
        public const string HCKCOO = "HCKCOO";

        /// <summary>
        /// HCCMLN.
        /// </summary>
        public const string HCCMLN = "HCCMLN";

        /// <summary>
        /// HCSLSM.
        /// </summary>
        public const string HCSLSM = "HCSLSM";

        /// <summary>
        /// HCSLCM.
        /// </summary>
        public const string HCSLCM = "HCSLCM";

        /// <summary>
        /// HCFCA.
        /// </summary>
        public const string HCFCA = "HCFCA";

        /// <summary>
        /// HCAPUN.
        /// </summary>
        public const string HCAPUN = "HCAPUN";

        /// <summary>
        /// HCCCTY.
        /// </summary>
        public const string HCCCTY = "HCCCTY";
    }

    /// <inheritdoc />
    public override string TableName => "F4001Z50";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HCDOCO", "HCDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("HCDCTO", "HCDCTO", JdeDataType.String, 4, true, true),
        new JdeField("HCKCOO", "HCKCOO", JdeDataType.String, 10, true, true),
        new JdeField("HCCMLN", "HCCMLN", JdeDataType.Numeric, null, true, true),
        new JdeField("HCSLSM", "HCSLSM", JdeDataType.Numeric, null, true, true),
        new JdeField("HCSLCM", "HCSLCM", JdeDataType.Numeric),
        new JdeField("HCFCA", "HCFCA", JdeDataType.Numeric),
        new JdeField("HCAPUN", "HCAPUN", JdeDataType.Numeric),
        new JdeField("HCCCTY", "HCCCTY", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4001Z50_0", "Primary Key on HCDOCO, HCDCTO, HCKCOO, HCSLSM, HCCMLN", new[] { "HCDOCO", "HCDCTO", "HCKCOO", "HCSLSM", "HCCMLN" }, isUnique: true, isPrimaryKey: true)
    };
}
