using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F7613B - .
/// </summary>
public class F7613B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LFBNOP.
        /// </summary>
        public const string LFBNOP = "LFBNOP";

        /// <summary>
        /// LFBSOP.
        /// </summary>
        public const string LFBSOP = "LFBSOP";

        /// <summary>
        /// LFB76TSIPI.
        /// </summary>
        public const string LFB76TSIPI = "LFB76TSIPI";

        /// <summary>
        /// LF76BIPILF.
        /// </summary>
        public const string LF76BIPILF = "LF76BIPILF";

        /// <summary>
        /// LFAN8.
        /// </summary>
        public const string LFAN8 = "LFAN8";
    }

    /// <inheritdoc />
    public override string TableName => "F7613B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LFBNOP", "LFBNOP", JdeDataType.Numeric, null, true, true),
        new JdeField("LFBSOP", "LFBSOP", JdeDataType.String, 4, true, true),
        new JdeField("LFB76TSIPI", "LFB76TSIPI", JdeDataType.String, 6, true, true),
        new JdeField("LF76BIPILF", "LF76BIPILF", JdeDataType.String, 6),
        new JdeField("LFAN8", "LFAN8", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F7613B_0", "Primary Key on LFBNOP, LFBSOP, LFB76TSIPI, LFAN8", new[] { "LFBNOP", "LFBSOP", "LFB76TSIPI", "LFAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
