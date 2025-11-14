using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76H005 - .
/// </summary>
public class F76H005 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LCH76LEDT.
        /// </summary>
        public const string LCH76LEDT = "LCH76LEDT";

        /// <summary>
        /// LCDL01.
        /// </summary>
        public const string LCDL01 = "LCDL01";

        /// <summary>
        /// LCH76LDTG.
        /// </summary>
        public const string LCH76LDTG = "LCH76LDTG";

        /// <summary>
        /// LCH76DTX.
        /// </summary>
        public const string LCH76DTX = "LCH76DTX";

        /// <summary>
        /// LCH76IDFR.
        /// </summary>
        public const string LCH76IDFR = "LCH76IDFR";

        /// <summary>
        /// LCUSER.
        /// </summary>
        public const string LCUSER = "LCUSER";

        /// <summary>
        /// LCPID.
        /// </summary>
        public const string LCPID = "LCPID";

        /// <summary>
        /// LCJOBN.
        /// </summary>
        public const string LCJOBN = "LCJOBN";

        /// <summary>
        /// LCUPMJ.
        /// </summary>
        public const string LCUPMJ = "LCUPMJ";

        /// <summary>
        /// LCUPMT.
        /// </summary>
        public const string LCUPMT = "LCUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76H005";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LCH76LEDT", "LCH76LEDT", JdeDataType.String, 6, true, true),
        new JdeField("LCDL01", "LCDL01", JdeDataType.String, 60),
        new JdeField("LCH76LDTG", "LCH76LDTG", JdeDataType.String, 4),
        new JdeField("LCH76DTX", "LCH76DTX", JdeDataType.String, 2),
        new JdeField("LCH76IDFR", "LCH76IDFR", JdeDataType.String, 6),
        new JdeField("LCUSER", "LCUSER", JdeDataType.String, 20),
        new JdeField("LCPID", "LCPID", JdeDataType.String, 20),
        new JdeField("LCJOBN", "LCJOBN", JdeDataType.String, 20),
        new JdeField("LCUPMJ", "LCUPMJ", JdeDataType.Numeric),
        new JdeField("LCUPMT", "LCUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76H005_0", "Primary Key on LCH76LEDT", new[] { "LCH76LEDT" }, isUnique: true, isPrimaryKey: true)
    };
}
