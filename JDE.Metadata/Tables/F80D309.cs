using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D309 - .
/// </summary>
public class F80D309 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MSMETRIC.
        /// </summary>
        public const string MSMETRIC = "MSMETRIC";

        /// <summary>
        /// MSSEQ.
        /// </summary>
        public const string MSSEQ = "MSSEQ";

        /// <summary>
        /// MSSERS.
        /// </summary>
        public const string MSSERS = "MSSERS";

        /// <summary>
        /// MSURCD.
        /// </summary>
        public const string MSURCD = "MSURCD";

        /// <summary>
        /// MSURDT.
        /// </summary>
        public const string MSURDT = "MSURDT";

        /// <summary>
        /// MSURAT.
        /// </summary>
        public const string MSURAT = "MSURAT";

        /// <summary>
        /// MSURAB.
        /// </summary>
        public const string MSURAB = "MSURAB";

        /// <summary>
        /// MSURRF.
        /// </summary>
        public const string MSURRF = "MSURRF";

        /// <summary>
        /// MSUSER.
        /// </summary>
        public const string MSUSER = "MSUSER";

        /// <summary>
        /// MSMKEY.
        /// </summary>
        public const string MSMKEY = "MSMKEY";

        /// <summary>
        /// MSPID.
        /// </summary>
        public const string MSPID = "MSPID";

        /// <summary>
        /// MSUUPMJ.
        /// </summary>
        public const string MSUUPMJ = "MSUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F80D309";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MSMETRIC", "MSMETRIC", JdeDataType.Numeric, null, true, true),
        new JdeField("MSSEQ", "MSSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("MSSERS", "MSSERS", JdeDataType.String, 8),
        new JdeField("MSURCD", "MSURCD", JdeDataType.String, 4),
        new JdeField("MSURDT", "MSURDT", JdeDataType.Numeric),
        new JdeField("MSURAT", "MSURAT", JdeDataType.Numeric),
        new JdeField("MSURAB", "MSURAB", JdeDataType.Numeric),
        new JdeField("MSURRF", "MSURRF", JdeDataType.String, 30),
        new JdeField("MSUSER", "MSUSER", JdeDataType.String, 20),
        new JdeField("MSMKEY", "MSMKEY", JdeDataType.String, 30),
        new JdeField("MSPID", "MSPID", JdeDataType.String, 20),
        new JdeField("MSUUPMJ", "MSUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D309_0", "Primary Key on MSMETRIC, MSSEQ", new[] { "MSMETRIC", "MSSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
