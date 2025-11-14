using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76H007 - .
/// </summary>
public class F76H007 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LIH76LECO.
        /// </summary>
        public const string LIH76LECO = "LIH76LECO";

        /// <summary>
        /// LIH76LEDT.
        /// </summary>
        public const string LIH76LEDT = "LIH76LEDT";

        /// <summary>
        /// LIH76IDFR.
        /// </summary>
        public const string LIH76IDFR = "LIH76IDFR";

        /// <summary>
        /// LIUSER.
        /// </summary>
        public const string LIUSER = "LIUSER";

        /// <summary>
        /// LIPID.
        /// </summary>
        public const string LIPID = "LIPID";

        /// <summary>
        /// LIJOBN.
        /// </summary>
        public const string LIJOBN = "LIJOBN";

        /// <summary>
        /// LIUPMJ.
        /// </summary>
        public const string LIUPMJ = "LIUPMJ";

        /// <summary>
        /// LIUPMT.
        /// </summary>
        public const string LIUPMT = "LIUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76H007";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LIH76LECO", "LIH76LECO", JdeDataType.String, 10, true, true),
        new JdeField("LIH76LEDT", "LIH76LEDT", JdeDataType.String, 6, true, true),
        new JdeField("LIH76IDFR", "LIH76IDFR", JdeDataType.String, 6),
        new JdeField("LIUSER", "LIUSER", JdeDataType.String, 20),
        new JdeField("LIPID", "LIPID", JdeDataType.String, 20),
        new JdeField("LIJOBN", "LIJOBN", JdeDataType.String, 20),
        new JdeField("LIUPMJ", "LIUPMJ", JdeDataType.Numeric),
        new JdeField("LIUPMT", "LIUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76H007_0", "Primary Key on LIH76LECO, LIH76LEDT", new[] { "LIH76LECO", "LIH76LEDT" }, isUnique: true, isPrimaryKey: true)
    };
}
