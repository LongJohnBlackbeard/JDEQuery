using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW55 - .
/// </summary>
public class FCW55 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CMC9MOSA.
        /// </summary>
        public const string CMC9MOSA = "CMC9MOSA";

        /// <summary>
        /// CMC9DSC1.
        /// </summary>
        public const string CMC9DSC1 = "CMC9DSC1";

        /// <summary>
        /// CMUSER.
        /// </summary>
        public const string CMUSER = "CMUSER";

        /// <summary>
        /// CMPID.
        /// </summary>
        public const string CMPID = "CMPID";

        /// <summary>
        /// CMJOBN.
        /// </summary>
        public const string CMJOBN = "CMJOBN";

        /// <summary>
        /// CMUPMJ.
        /// </summary>
        public const string CMUPMJ = "CMUPMJ";

        /// <summary>
        /// CMTDAY.
        /// </summary>
        public const string CMTDAY = "CMTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "FCW55";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CMC9MOSA", "CMC9MOSA", JdeDataType.String, 20, true, true),
        new JdeField("CMC9DSC1", "CMC9DSC1", JdeDataType.String, 60),
        new JdeField("CMUSER", "CMUSER", JdeDataType.String, 20),
        new JdeField("CMPID", "CMPID", JdeDataType.String, 20),
        new JdeField("CMJOBN", "CMJOBN", JdeDataType.String, 20),
        new JdeField("CMUPMJ", "CMUPMJ", JdeDataType.Numeric),
        new JdeField("CMTDAY", "CMTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW55_0", "Primary Key on CMC9MOSA", new[] { "CMC9MOSA" }, isUnique: true, isPrimaryKey: true)
    };
}
