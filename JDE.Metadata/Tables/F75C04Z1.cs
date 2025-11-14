using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75C04Z1 - .
/// </summary>
public class F75C04Z1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CTJOBS.
        /// </summary>
        public const string CTJOBS = "CTJOBS";

        /// <summary>
        /// CTJOBN.
        /// </summary>
        public const string CTJOBN = "CTJOBN";

        /// <summary>
        /// CTUKID.
        /// </summary>
        public const string CTUKID = "CTUKID";

        /// <summary>
        /// CTDTA1.
        /// </summary>
        public const string CTDTA1 = "CTDTA1";
    }

    /// <inheritdoc />
    public override string TableName => "F75C04Z1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CTJOBS", "CTJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("CTJOBN", "CTJOBN", JdeDataType.String, 20, true, true),
        new JdeField("CTUKID", "CTUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("CTDTA1", "CTDTA1", JdeDataType.String, 512)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75C04Z1_0", "Primary Key on CTJOBS, CTJOBN, CTUKID", new[] { "CTJOBS", "CTJOBN", "CTUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
