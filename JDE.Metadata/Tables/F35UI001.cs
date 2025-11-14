using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F35UI001 - .
/// </summary>
public class F35UI001 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MAJOBS.
        /// </summary>
        public const string MAJOBS = "MAJOBS";

        /// <summary>
        /// MACTID.
        /// </summary>
        public const string MACTID = "MACTID";

        /// <summary>
        /// MAMCU.
        /// </summary>
        public const string MAMCU = "MAMCU";

        /// <summary>
        /// MABRSQ.
        /// </summary>
        public const string MABRSQ = "MABRSQ";

        /// <summary>
        /// MAPQOH.
        /// </summary>
        public const string MAPQOH = "MAPQOH";

        /// <summary>
        /// MATRQT.
        /// </summary>
        public const string MATRQT = "MATRQT";

        /// <summary>
        /// MAEV01.
        /// </summary>
        public const string MAEV01 = "MAEV01";

        /// <summary>
        /// MAPRPX.
        /// </summary>
        public const string MAPRPX = "MAPRPX";
    }

    /// <inheritdoc />
    public override string TableName => "F35UI001";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MAJOBS", "MAJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("MACTID", "MACTID", JdeDataType.String, 30, true, true),
        new JdeField("MAMCU", "MAMCU", JdeDataType.String, 24, true, true),
        new JdeField("MABRSQ", "MABRSQ", JdeDataType.Numeric),
        new JdeField("MAPQOH", "MAPQOH", JdeDataType.Numeric),
        new JdeField("MATRQT", "MATRQT", JdeDataType.Numeric),
        new JdeField("MAEV01", "MAEV01", JdeDataType.String, 2),
        new JdeField("MAPRPX", "MAPRPX", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F35UI001_0", "Primary Key on MAJOBS, MACTID, MAMCU", new[] { "MAJOBS", "MACTID", "MAMCU" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F35UI001_2", "Index on MABRSQ", new[] { "MABRSQ" }),
        new JdeIndex("F35UI001_3", "Index on MAJOBS, MACTID, MABRSQ", new[] { "MAJOBS", "MACTID", "MABRSQ" })
    };
}
