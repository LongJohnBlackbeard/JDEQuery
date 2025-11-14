using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A25 - .
/// </summary>
public class F76A25 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IFTXA1.
        /// </summary>
        public const string IFTXA1 = "IFTXA1";

        /// <summary>
        /// IFTXA2.
        /// </summary>
        public const string IFTXA2 = "IFTXA2";

        /// <summary>
        /// IFURAT.
        /// </summary>
        public const string IFURAT = "IFURAT";

        /// <summary>
        /// IFURC1.
        /// </summary>
        public const string IFURC1 = "IFURC1";

        /// <summary>
        /// IFURRF.
        /// </summary>
        public const string IFURRF = "IFURRF";

        /// <summary>
        /// IFURAB.
        /// </summary>
        public const string IFURAB = "IFURAB";

        /// <summary>
        /// IFURDT.
        /// </summary>
        public const string IFURDT = "IFURDT";

        /// <summary>
        /// IFTORG.
        /// </summary>
        public const string IFTORG = "IFTORG";

        /// <summary>
        /// IFUSER.
        /// </summary>
        public const string IFUSER = "IFUSER";

        /// <summary>
        /// IFPID.
        /// </summary>
        public const string IFPID = "IFPID";

        /// <summary>
        /// IFUPMJ.
        /// </summary>
        public const string IFUPMJ = "IFUPMJ";

        /// <summary>
        /// IFUPMT.
        /// </summary>
        public const string IFUPMT = "IFUPMT";

        /// <summary>
        /// IFCTID.
        /// </summary>
        public const string IFCTID = "IFCTID";
    }

    /// <inheritdoc />
    public override string TableName => "F76A25";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IFTXA1", "IFTXA1", JdeDataType.String, 20, true, true),
        new JdeField("IFTXA2", "IFTXA2", JdeDataType.String, 20),
        new JdeField("IFURAT", "IFURAT", JdeDataType.Numeric),
        new JdeField("IFURC1", "IFURC1", JdeDataType.String, 6),
        new JdeField("IFURRF", "IFURRF", JdeDataType.String, 30),
        new JdeField("IFURAB", "IFURAB", JdeDataType.Numeric),
        new JdeField("IFURDT", "IFURDT", JdeDataType.Numeric),
        new JdeField("IFTORG", "IFTORG", JdeDataType.String, 20),
        new JdeField("IFUSER", "IFUSER", JdeDataType.String, 20),
        new JdeField("IFPID", "IFPID", JdeDataType.String, 20),
        new JdeField("IFUPMJ", "IFUPMJ", JdeDataType.Numeric),
        new JdeField("IFUPMT", "IFUPMT", JdeDataType.Numeric),
        new JdeField("IFCTID", "IFCTID", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A25_0", "Primary Key on IFTXA1", new[] { "IFTXA1" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76A25_2", "Unique Index on IFTXA2", new[] { "IFTXA2" }, isUnique: true)
    };
}
