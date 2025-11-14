using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76C0F11 - .
/// </summary>
public class F76C0F11 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FDC76FMT.
        /// </summary>
        public const string FDC76FMT = "FDC76FMT";

        /// <summary>
        /// FDC76SND.
        /// </summary>
        public const string FDC76SND = "FDC76SND";

        /// <summary>
        /// FDSEQ.
        /// </summary>
        public const string FDSEQ = "FDSEQ";

        /// <summary>
        /// FDGPTX.
        /// </summary>
        public const string FDGPTX = "FDGPTX";
    }

    /// <inheritdoc />
    public override string TableName => "F76C0F11";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FDC76FMT", "FDC76FMT", JdeDataType.String, 10, true, true),
        new JdeField("FDC76SND", "FDC76SND", JdeDataType.Numeric, null, true, true),
        new JdeField("FDSEQ", "FDSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("FDGPTX", "FDGPTX", JdeDataType.String, 3000)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76C0F11_0", "Primary Key on FDC76FMT, FDC76SND, FDSEQ", new[] { "FDC76FMT", "FDC76SND", "FDSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
