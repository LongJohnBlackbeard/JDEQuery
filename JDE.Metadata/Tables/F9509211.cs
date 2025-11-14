using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F9509211 - .
/// </summary>
public class F9509211 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IDOBNM.
        /// </summary>
        public const string IDOBNM = "IDOBNM";

        /// <summary>
        /// IDGNCID1.
        /// </summary>
        public const string IDGNCID1 = "IDGNCID1";

        /// <summary>
        /// IDGNCID4.
        /// </summary>
        public const string IDGNCID4 = "IDGNCID4";

        /// <summary>
        /// IDRCRDTP.
        /// </summary>
        public const string IDRCRDTP = "IDRCRDTP";

        /// <summary>
        /// IDTEXT1.
        /// </summary>
        public const string IDTEXT1 = "IDTEXT1";

        /// <summary>
        /// IDTEXT2.
        /// </summary>
        public const string IDTEXT2 = "IDTEXT2";
    }

    /// <inheritdoc />
    public override string TableName => "F9509211";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IDOBNM", "IDOBNM", JdeDataType.String, 20, true, true),
        new JdeField("IDGNCID1", "IDGNCID1", JdeDataType.Numeric, null, true, true),
        new JdeField("IDGNCID4", "IDGNCID4", JdeDataType.Numeric),
        new JdeField("IDRCRDTP", "IDRCRDTP", JdeDataType.Numeric, null, true, true),
        new JdeField("IDTEXT1", "IDTEXT1", JdeDataType.String, 80),
        new JdeField("IDTEXT2", "IDTEXT2", JdeDataType.String, 80)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F9509211_0", "Primary Key on IDOBNM, IDGNCID1, IDRCRDTP", new[] { "IDOBNM", "IDGNCID1", "IDRCRDTP" }, isUnique: true, isPrimaryKey: true)
    };
}
