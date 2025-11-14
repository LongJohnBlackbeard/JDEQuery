using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0022 - .
/// </summary>
public class F0022 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VACO.
        /// </summary>
        public const string VACO = "VACO";

        /// <summary>
        /// VATXD1.
        /// </summary>
        public const string VATXD1 = "VATXD1";

        /// <summary>
        /// VATXD2.
        /// </summary>
        public const string VATXD2 = "VATXD2";

        /// <summary>
        /// VABALE.
        /// </summary>
        public const string VABALE = "VABALE";

        /// <summary>
        /// VATLR1.
        /// </summary>
        public const string VATLR1 = "VATLR1";

        /// <summary>
        /// VATLR2.
        /// </summary>
        public const string VATLR2 = "VATLR2";

        /// <summary>
        /// VATLA1.
        /// </summary>
        public const string VATLA1 = "VATLA1";

        /// <summary>
        /// VATLA2.
        /// </summary>
        public const string VATLA2 = "VATLA2";

        /// <summary>
        /// VATXSY.
        /// </summary>
        public const string VATXSY = "VATXSY";

        /// <summary>
        /// VAUNTX.
        /// </summary>
        public const string VAUNTX = "VAUNTX";

        /// <summary>
        /// VATAXL.
        /// </summary>
        public const string VATAXL = "VATAXL";
    }

    /// <inheritdoc />
    public override string TableName => "F0022";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VACO", "VACO", JdeDataType.String, 10, true, true),
        new JdeField("VATXD1", "VATXD1", JdeDataType.String, 2),
        new JdeField("VATXD2", "VATXD2", JdeDataType.String, 2),
        new JdeField("VABALE", "VABALE", JdeDataType.String, 2),
        new JdeField("VATLR1", "VATLR1", JdeDataType.Numeric),
        new JdeField("VATLR2", "VATLR2", JdeDataType.Numeric),
        new JdeField("VATLA1", "VATLA1", JdeDataType.Numeric),
        new JdeField("VATLA2", "VATLA2", JdeDataType.Numeric),
        new JdeField("VATXSY", "VATXSY", JdeDataType.String, 2, true, true),
        new JdeField("VAUNTX", "VAUNTX", JdeDataType.String, 2),
        new JdeField("VATAXL", "VATAXL", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0022_0", "Primary Key on VACO, VATXSY", new[] { "VACO", "VATXSY" }, isUnique: true, isPrimaryKey: true)
    };
}
