using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1514W - .
/// </summary>
public class F1514W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NWEFTB.
        /// </summary>
        public const string NWEFTB = "NWEFTB";

        /// <summary>
        /// NWEFTE.
        /// </summary>
        public const string NWEFTE = "NWEFTE";

        /// <summary>
        /// NWRNTA.
        /// </summary>
        public const string NWRNTA = "NWRNTA";

        /// <summary>
        /// NWSEQ.
        /// </summary>
        public const string NWSEQ = "NWSEQ";

        /// <summary>
        /// NWEV01.
        /// </summary>
        public const string NWEV01 = "NWEV01";

        /// <summary>
        /// NWJOBN.
        /// </summary>
        public const string NWJOBN = "NWJOBN";

        /// <summary>
        /// NWUPMT.
        /// </summary>
        public const string NWUPMT = "NWUPMT";

        /// <summary>
        /// NWARTY.
        /// </summary>
        public const string NWARTY = "NWARTY";
    }

    /// <inheritdoc />
    public override string TableName => "F1514W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NWEFTB", "NWEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("NWEFTE", "NWEFTE", JdeDataType.Numeric, null, true, true),
        new JdeField("NWRNTA", "NWRNTA", JdeDataType.Numeric),
        new JdeField("NWSEQ", "NWSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("NWEV01", "NWEV01", JdeDataType.String, 2, true, true),
        new JdeField("NWJOBN", "NWJOBN", JdeDataType.String, 20, true, true),
        new JdeField("NWUPMT", "NWUPMT", JdeDataType.Numeric, null, true, true),
        new JdeField("NWARTY", "NWARTY", JdeDataType.String, 6, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1514W_0", "Primary Key on NWARTY, NWEFTB, NWEV01, NWEFTE, NWJOBN, NWUPMT, NWSEQ", new[] { "NWARTY", "NWEFTB", "NWEV01", "NWEFTE", "NWJOBN", "NWUPMT", "NWSEQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F1514W_2", "Index on NWEFTB, NWEFTE", new[] { "NWEFTB", "NWEFTE" }),
        new JdeIndex("F1514W_3", "Index on NWEFTE", new[] { "NWEFTE" })
    };
}
