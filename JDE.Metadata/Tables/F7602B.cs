using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F7602B - .
/// </summary>
public class F7602B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NJCO.
        /// </summary>
        public const string NJCO = "NJCO";

        /// <summary>
        /// NJBFBC.
        /// </summary>
        public const string NJBFBC = "NJBFBC";

        /// <summary>
        /// NJNNBR.
        /// </summary>
        public const string NJNNBR = "NJNNBR";

        /// <summary>
        /// NJNXTS.
        /// </summary>
        public const string NJNXTS = "NJNXTS";

        /// <summary>
        /// NJSEQ.
        /// </summary>
        public const string NJSEQ = "NJSEQ";

        /// <summary>
        /// NJDTPR.
        /// </summary>
        public const string NJDTPR = "NJDTPR";

        /// <summary>
        /// NJTORG.
        /// </summary>
        public const string NJTORG = "NJTORG";

        /// <summary>
        /// NJUSER.
        /// </summary>
        public const string NJUSER = "NJUSER";

        /// <summary>
        /// NJPID.
        /// </summary>
        public const string NJPID = "NJPID";

        /// <summary>
        /// NJJOBN.
        /// </summary>
        public const string NJJOBN = "NJJOBN";

        /// <summary>
        /// NJUPMJ.
        /// </summary>
        public const string NJUPMJ = "NJUPMJ";

        /// <summary>
        /// NJTDAY.
        /// </summary>
        public const string NJTDAY = "NJTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F7602B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NJCO", "NJCO", JdeDataType.String, 10, true, true),
        new JdeField("NJBFBC", "NJBFBC", JdeDataType.String, 4, true, true),
        new JdeField("NJNNBR", "NJNNBR", JdeDataType.Numeric),
        new JdeField("NJNXTS", "NJNXTS", JdeDataType.Numeric),
        new JdeField("NJSEQ", "NJSEQ", JdeDataType.Numeric),
        new JdeField("NJDTPR", "NJDTPR", JdeDataType.Numeric),
        new JdeField("NJTORG", "NJTORG", JdeDataType.String, 20),
        new JdeField("NJUSER", "NJUSER", JdeDataType.String, 20),
        new JdeField("NJPID", "NJPID", JdeDataType.String, 20),
        new JdeField("NJJOBN", "NJJOBN", JdeDataType.String, 20),
        new JdeField("NJUPMJ", "NJUPMJ", JdeDataType.Numeric),
        new JdeField("NJTDAY", "NJTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F7602B_0", "Primary Key on NJCO, NJBFBC", new[] { "NJCO", "NJBFBC" }, isUnique: true, isPrimaryKey: true)
    };
}
