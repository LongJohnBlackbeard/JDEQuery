using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B35 - .
/// </summary>
public class F31B35 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OMOWNRCOD.
        /// </summary>
        public const string OMOWNRCOD = "OMOWNRCOD";

        /// <summary>
        /// OMAN8.
        /// </summary>
        public const string OMAN8 = "OMAN8";

        /// <summary>
        /// OMOWNCAT.
        /// </summary>
        public const string OMOWNCAT = "OMOWNCAT";

        /// <summary>
        /// OMOWNRID.
        /// </summary>
        public const string OMOWNRID = "OMOWNRID";

        /// <summary>
        /// OMSCODE.
        /// </summary>
        public const string OMSCODE = "OMSCODE";

        /// <summary>
        /// OMUSER.
        /// </summary>
        public const string OMUSER = "OMUSER";

        /// <summary>
        /// OMPID.
        /// </summary>
        public const string OMPID = "OMPID";

        /// <summary>
        /// OMJOBN.
        /// </summary>
        public const string OMJOBN = "OMJOBN";

        /// <summary>
        /// OMUPMJ.
        /// </summary>
        public const string OMUPMJ = "OMUPMJ";

        /// <summary>
        /// OMUPMT.
        /// </summary>
        public const string OMUPMT = "OMUPMT";

        /// <summary>
        /// OMURCD.
        /// </summary>
        public const string OMURCD = "OMURCD";

        /// <summary>
        /// OMURDT.
        /// </summary>
        public const string OMURDT = "OMURDT";

        /// <summary>
        /// OMURRF.
        /// </summary>
        public const string OMURRF = "OMURRF";

        /// <summary>
        /// OMURAT.
        /// </summary>
        public const string OMURAT = "OMURAT";

        /// <summary>
        /// OMURAB.
        /// </summary>
        public const string OMURAB = "OMURAB";

        /// <summary>
        /// OMWOG.
        /// </summary>
        public const string OMWOG = "OMWOG";

        /// <summary>
        /// OMTDAY.
        /// </summary>
        public const string OMTDAY = "OMTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F31B35";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OMOWNRCOD", "OMOWNRCOD", JdeDataType.String, 12, true, true),
        new JdeField("OMAN8", "OMAN8", JdeDataType.Numeric),
        new JdeField("OMOWNCAT", "OMOWNCAT", JdeDataType.String, 6),
        new JdeField("OMOWNRID", "OMOWNRID", JdeDataType.String, 2),
        new JdeField("OMSCODE", "OMSCODE", JdeDataType.String, 2),
        new JdeField("OMUSER", "OMUSER", JdeDataType.String, 20),
        new JdeField("OMPID", "OMPID", JdeDataType.String, 20),
        new JdeField("OMJOBN", "OMJOBN", JdeDataType.String, 20),
        new JdeField("OMUPMJ", "OMUPMJ", JdeDataType.Numeric),
        new JdeField("OMUPMT", "OMUPMT", JdeDataType.Numeric),
        new JdeField("OMURCD", "OMURCD", JdeDataType.String, 4),
        new JdeField("OMURDT", "OMURDT", JdeDataType.Numeric),
        new JdeField("OMURRF", "OMURRF", JdeDataType.String, 30),
        new JdeField("OMURAT", "OMURAT", JdeDataType.Numeric),
        new JdeField("OMURAB", "OMURAB", JdeDataType.Numeric),
        new JdeField("OMWOG", "OMWOG", JdeDataType.String, 6),
        new JdeField("OMTDAY", "OMTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B35_0", "Primary Key on OMOWNRCOD", new[] { "OMOWNRCOD" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B35_2", "Index on OMAN8", new[] { "OMAN8" })
    };
}
