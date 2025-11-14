using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40P02 - .
/// </summary>
public class F40P02 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PSPRSTAT.
        /// </summary>
        public const string PSPRSTAT = "PSPRSTAT";

        /// <summary>
        /// PSPRSDSC.
        /// </summary>
        public const string PSPRSDSC = "PSPRSDSC";

        /// <summary>
        /// PSPRSACT.
        /// </summary>
        public const string PSPRSACT = "PSPRSACT";

        /// <summary>
        /// PSURAT.
        /// </summary>
        public const string PSURAT = "PSURAT";

        /// <summary>
        /// PSURAB.
        /// </summary>
        public const string PSURAB = "PSURAB";

        /// <summary>
        /// PSURRF.
        /// </summary>
        public const string PSURRF = "PSURRF";

        /// <summary>
        /// PSURCD.
        /// </summary>
        public const string PSURCD = "PSURCD";

        /// <summary>
        /// PSURDT.
        /// </summary>
        public const string PSURDT = "PSURDT";

        /// <summary>
        /// PSUSER.
        /// </summary>
        public const string PSUSER = "PSUSER";

        /// <summary>
        /// PSPID.
        /// </summary>
        public const string PSPID = "PSPID";

        /// <summary>
        /// PSJOBN.
        /// </summary>
        public const string PSJOBN = "PSJOBN";

        /// <summary>
        /// PSUPMJ.
        /// </summary>
        public const string PSUPMJ = "PSUPMJ";

        /// <summary>
        /// PSTDAY.
        /// </summary>
        public const string PSTDAY = "PSTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F40P02";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PSPRSTAT", "PSPRSTAT", JdeDataType.String, 4, true, true),
        new JdeField("PSPRSDSC", "PSPRSDSC", JdeDataType.String, 60),
        new JdeField("PSPRSACT", "PSPRSACT", JdeDataType.String, 2),
        new JdeField("PSURAT", "PSURAT", JdeDataType.Numeric),
        new JdeField("PSURAB", "PSURAB", JdeDataType.Numeric),
        new JdeField("PSURRF", "PSURRF", JdeDataType.String, 30),
        new JdeField("PSURCD", "PSURCD", JdeDataType.String, 4),
        new JdeField("PSURDT", "PSURDT", JdeDataType.Numeric),
        new JdeField("PSUSER", "PSUSER", JdeDataType.String, 20),
        new JdeField("PSPID", "PSPID", JdeDataType.String, 20),
        new JdeField("PSJOBN", "PSJOBN", JdeDataType.String, 20),
        new JdeField("PSUPMJ", "PSUPMJ", JdeDataType.Numeric),
        new JdeField("PSTDAY", "PSTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40P02_0", "Primary Key on PSPRSTAT", new[] { "PSPRSTAT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40P02_2", "Index on PSPRSACT", new[] { "PSPRSACT" })
    };
}
