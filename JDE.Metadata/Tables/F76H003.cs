using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76H003 - .
/// </summary>
public class F76H003 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TTTXA1.
        /// </summary>
        public const string TTTXA1 = "TTTXA1";

        /// <summary>
        /// TTH76TXTP.
        /// </summary>
        public const string TTH76TXTP = "TTH76TXTP";

        /// <summary>
        /// TTH76FUA.
        /// </summary>
        public const string TTH76FUA = "TTH76FUA";

        /// <summary>
        /// TTH76FUC.
        /// </summary>
        public const string TTH76FUC = "TTH76FUC";

        /// <summary>
        /// TTH76FUD.
        /// </summary>
        public const string TTH76FUD = "TTH76FUD";

        /// <summary>
        /// TTH76FUR.
        /// </summary>
        public const string TTH76FUR = "TTH76FUR";

        /// <summary>
        /// TTH76FUF.
        /// </summary>
        public const string TTH76FUF = "TTH76FUF";

        /// <summary>
        /// TTUSER.
        /// </summary>
        public const string TTUSER = "TTUSER";

        /// <summary>
        /// TTPID.
        /// </summary>
        public const string TTPID = "TTPID";

        /// <summary>
        /// TTJOBN.
        /// </summary>
        public const string TTJOBN = "TTJOBN";

        /// <summary>
        /// TTUPMJ.
        /// </summary>
        public const string TTUPMJ = "TTUPMJ";

        /// <summary>
        /// TTUPMT.
        /// </summary>
        public const string TTUPMT = "TTUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76H003";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TTTXA1", "TTTXA1", JdeDataType.String, 20, true, true),
        new JdeField("TTH76TXTP", "TTH76TXTP", JdeDataType.String, 6),
        new JdeField("TTH76FUA", "TTH76FUA", JdeDataType.Numeric),
        new JdeField("TTH76FUC", "TTH76FUC", JdeDataType.String, 20),
        new JdeField("TTH76FUD", "TTH76FUD", JdeDataType.Numeric),
        new JdeField("TTH76FUR", "TTH76FUR", JdeDataType.String, 30),
        new JdeField("TTH76FUF", "TTH76FUF", JdeDataType.String, 2),
        new JdeField("TTUSER", "TTUSER", JdeDataType.String, 20),
        new JdeField("TTPID", "TTPID", JdeDataType.String, 20),
        new JdeField("TTJOBN", "TTJOBN", JdeDataType.String, 20),
        new JdeField("TTUPMJ", "TTUPMJ", JdeDataType.Numeric),
        new JdeField("TTUPMT", "TTUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76H003_0", "Primary Key on TTTXA1", new[] { "TTTXA1" }, isUnique: true, isPrimaryKey: true)
    };
}
