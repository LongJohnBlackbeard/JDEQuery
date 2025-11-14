using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76H010 - .
/// </summary>
public class F76H010 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LCH76LECO.
        /// </summary>
        public const string LCH76LECO = "LCH76LECO";

        /// <summary>
        /// LCCO.
        /// </summary>
        public const string LCCO = "LCCO";

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
    public override string TableName => "F76H010";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LCH76LECO", "LCH76LECO", JdeDataType.String, 10),
        new JdeField("LCCO", "LCCO", JdeDataType.String, 10, true, true),
        new JdeField("LCUSER", "LCUSER", JdeDataType.String, 20),
        new JdeField("LCPID", "LCPID", JdeDataType.String, 20),
        new JdeField("LCJOBN", "LCJOBN", JdeDataType.String, 20),
        new JdeField("LCUPMJ", "LCUPMJ", JdeDataType.Numeric),
        new JdeField("LCUPMT", "LCUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76H010_0", "Primary Key on LCCO", new[] { "LCCO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76H010_2", "Index on LCH76LECO, LCCO", new[] { "LCH76LECO", "LCCO" })
    };
}
