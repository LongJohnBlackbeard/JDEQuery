using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF34R013 - .
/// </summary>
public class FF34R013 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DTCCHN.
        /// </summary>
        public const string DTCCHN = "DTCCHN";

        /// <summary>
        /// DTLNID.
        /// </summary>
        public const string DTLNID = "DTLNID";

        /// <summary>
        /// DTDFITM.
        /// </summary>
        public const string DTDFITM = "DTDFITM";

        /// <summary>
        /// DTDFUITM.
        /// </summary>
        public const string DTDFUITM = "DTDFUITM";

        /// <summary>
        /// DTDFUPQT.
        /// </summary>
        public const string DTDFUPQT = "DTDFUPQT";

        /// <summary>
        /// DTDPLNQT.
        /// </summary>
        public const string DTDPLNQT = "DTDPLNQT";

        /// <summary>
        /// DTSHFT.
        /// </summary>
        public const string DTSHFT = "DTSHFT";

        /// <summary>
        /// DTDFMCU.
        /// </summary>
        public const string DTDFMCU = "DTDFMCU";
    }

    /// <inheritdoc />
    public override string TableName => "FF34R013";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DTCCHN", "DTCCHN", JdeDataType.String, 90, true, true),
        new JdeField("DTLNID", "DTLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("DTDFITM", "DTDFITM", JdeDataType.Numeric),
        new JdeField("DTDFUITM", "DTDFUITM", JdeDataType.String, 52),
        new JdeField("DTDFUPQT", "DTDFUPQT", JdeDataType.Numeric),
        new JdeField("DTDPLNQT", "DTDPLNQT", JdeDataType.Numeric),
        new JdeField("DTSHFT", "DTSHFT", JdeDataType.String, 2),
        new JdeField("DTDFMCU", "DTDFMCU", JdeDataType.String, 24)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF34R013_0", "Primary Key on DTCCHN, DTLNID", new[] { "DTCCHN", "DTLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
