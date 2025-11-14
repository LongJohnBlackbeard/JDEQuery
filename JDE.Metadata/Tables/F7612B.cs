using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F7612B - .
/// </summary>
public class F7612B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FYBNNF.
        /// </summary>
        public const string FYBNNF = "FYBNNF";

        /// <summary>
        /// FYBSER.
        /// </summary>
        public const string FYBSER = "FYBSER";

        /// <summary>
        /// FYDCT.
        /// </summary>
        public const string FYDCT = "FYDCT";

        /// <summary>
        /// FYN001.
        /// </summary>
        public const string FYN001 = "FYN001";

        /// <summary>
        /// FYSEQ.
        /// </summary>
        public const string FYSEQ = "FYSEQ";

        /// <summary>
        /// FYLIN.
        /// </summary>
        public const string FYLIN = "FYLIN";

        /// <summary>
        /// FYWTXT.
        /// </summary>
        public const string FYWTXT = "FYWTXT";

        /// <summary>
        /// FYTORG.
        /// </summary>
        public const string FYTORG = "FYTORG";

        /// <summary>
        /// FYUSER.
        /// </summary>
        public const string FYUSER = "FYUSER";

        /// <summary>
        /// FYPID.
        /// </summary>
        public const string FYPID = "FYPID";

        /// <summary>
        /// FYJOBN.
        /// </summary>
        public const string FYJOBN = "FYJOBN";

        /// <summary>
        /// FYUPMJ.
        /// </summary>
        public const string FYUPMJ = "FYUPMJ";

        /// <summary>
        /// FYTDAY.
        /// </summary>
        public const string FYTDAY = "FYTDAY";

        /// <summary>
        /// FYFCO.
        /// </summary>
        public const string FYFCO = "FYFCO";
    }

    /// <inheritdoc />
    public override string TableName => "F7612B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FYBNNF", "FYBNNF", JdeDataType.Numeric, null, true, true),
        new JdeField("FYBSER", "FYBSER", JdeDataType.String, 4, true, true),
        new JdeField("FYDCT", "FYDCT", JdeDataType.String, 4, true, true),
        new JdeField("FYN001", "FYN001", JdeDataType.Numeric, null, true, true),
        new JdeField("FYSEQ", "FYSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("FYLIN", "FYLIN", JdeDataType.Numeric, null, true, true),
        new JdeField("FYWTXT", "FYWTXT", JdeDataType.String, 160),
        new JdeField("FYTORG", "FYTORG", JdeDataType.String, 20),
        new JdeField("FYUSER", "FYUSER", JdeDataType.String, 20),
        new JdeField("FYPID", "FYPID", JdeDataType.String, 20),
        new JdeField("FYJOBN", "FYJOBN", JdeDataType.String, 20),
        new JdeField("FYUPMJ", "FYUPMJ", JdeDataType.Numeric),
        new JdeField("FYTDAY", "FYTDAY", JdeDataType.Numeric),
        new JdeField("FYFCO", "FYFCO", JdeDataType.String, 10, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F7612B_0", "Primary Key on FYBNNF, FYBSER, FYN001, FYDCT, FYSEQ, FYLIN, FYFCO", new[] { "FYBNNF", "FYBSER", "FYN001", "FYDCT", "FYSEQ", "FYLIN", "FYFCO" }, isUnique: true, isPrimaryKey: true)
    };
}
