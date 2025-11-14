using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FD3N0002 - .
/// </summary>
public class FD3N0002 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NNPTNUMTP.
        /// </summary>
        public const string NNPTNUMTP = "NNPTNUMTP";

        /// <summary>
        /// NNPTLSTNUM.
        /// </summary>
        public const string NNPTLSTNUM = "NNPTLSTNUM";

        /// <summary>
        /// NNPTINCR.
        /// </summary>
        public const string NNPTINCR = "NNPTINCR";

        /// <summary>
        /// NNPTHIVAL.
        /// </summary>
        public const string NNPTHIVAL = "NNPTHIVAL";

        /// <summary>
        /// NNPTDTRST.
        /// </summary>
        public const string NNPTDTRST = "NNPTDTRST";

        /// <summary>
        /// NNPTLSTDT.
        /// </summary>
        public const string NNPTLSTDT = "NNPTLSTDT";
    }

    /// <inheritdoc />
    public override string TableName => "FD3N0002";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NNPTNUMTP", "NNPTNUMTP", JdeDataType.String, 20, true, true),
        new JdeField("NNPTLSTNUM", "NNPTLSTNUM", JdeDataType.Numeric),
        new JdeField("NNPTINCR", "NNPTINCR", JdeDataType.Numeric),
        new JdeField("NNPTHIVAL", "NNPTHIVAL", JdeDataType.Numeric),
        new JdeField("NNPTDTRST", "NNPTDTRST", JdeDataType.String, 2),
        new JdeField("NNPTLSTDT", "NNPTLSTDT", JdeDataType.String, 16)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FD3N0002_0", "Primary Key on NNPTNUMTP", new[] { "NNPTNUMTP" }, isUnique: true, isPrimaryKey: true)
    };
}
