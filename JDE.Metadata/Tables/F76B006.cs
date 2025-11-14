using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B006 - .
/// </summary>
public class F76B006 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BBUKID.
        /// </summary>
        public const string BBUKID = "BBUKID";

        /// <summary>
        /// BBMCU.
        /// </summary>
        public const string BBMCU = "BBMCU";

        /// <summary>
        /// BBDGJ.
        /// </summary>
        public const string BBDGJ = "BBDGJ";

        /// <summary>
        /// BBDL01.
        /// </summary>
        public const string BBDL01 = "BBDL01";

        /// <summary>
        /// BBRDOR.
        /// </summary>
        public const string BBRDOR = "BBRDOR";

        /// <summary>
        /// BBTORG.
        /// </summary>
        public const string BBTORG = "BBTORG";

        /// <summary>
        /// BBUSER.
        /// </summary>
        public const string BBUSER = "BBUSER";

        /// <summary>
        /// BBPID.
        /// </summary>
        public const string BBPID = "BBPID";

        /// <summary>
        /// BBJOBN.
        /// </summary>
        public const string BBJOBN = "BBJOBN";

        /// <summary>
        /// BBUPMJ.
        /// </summary>
        public const string BBUPMJ = "BBUPMJ";

        /// <summary>
        /// BBUPMT.
        /// </summary>
        public const string BBUPMT = "BBUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B006";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BBUKID", "BBUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("BBMCU", "BBMCU", JdeDataType.String, 24),
        new JdeField("BBDGJ", "BBDGJ", JdeDataType.Numeric),
        new JdeField("BBDL01", "BBDL01", JdeDataType.String, 60),
        new JdeField("BBRDOR", "BBRDOR", JdeDataType.String, 2),
        new JdeField("BBTORG", "BBTORG", JdeDataType.String, 20),
        new JdeField("BBUSER", "BBUSER", JdeDataType.String, 20),
        new JdeField("BBPID", "BBPID", JdeDataType.String, 20),
        new JdeField("BBJOBN", "BBJOBN", JdeDataType.String, 20),
        new JdeField("BBUPMJ", "BBUPMJ", JdeDataType.Numeric),
        new JdeField("BBUPMT", "BBUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B006_0", "Primary Key on BBUKID", new[] { "BBUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76B006_2", "Unique Index on BBMCU", new[] { "BBMCU" }, isUnique: true)
    };
}
