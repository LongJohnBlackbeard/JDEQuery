using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A26 - .
/// </summary>
public class F76A26 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IGAEVT.
        /// </summary>
        public const string IGAEVT = "IGAEVT";

        /// <summary>
        /// IGACIS.
        /// </summary>
        public const string IGACIS = "IGACIS";

        /// <summary>
        /// IGACI2.
        /// </summary>
        public const string IGACI2 = "IGACI2";

        /// <summary>
        /// IGURAT.
        /// </summary>
        public const string IGURAT = "IGURAT";

        /// <summary>
        /// IGURC1.
        /// </summary>
        public const string IGURC1 = "IGURC1";

        /// <summary>
        /// IGURRF.
        /// </summary>
        public const string IGURRF = "IGURRF";

        /// <summary>
        /// IGURAB.
        /// </summary>
        public const string IGURAB = "IGURAB";

        /// <summary>
        /// IGURDT.
        /// </summary>
        public const string IGURDT = "IGURDT";

        /// <summary>
        /// IGTORG.
        /// </summary>
        public const string IGTORG = "IGTORG";

        /// <summary>
        /// IGUSER.
        /// </summary>
        public const string IGUSER = "IGUSER";

        /// <summary>
        /// IGPID.
        /// </summary>
        public const string IGPID = "IGPID";

        /// <summary>
        /// IGUPMJ.
        /// </summary>
        public const string IGUPMJ = "IGUPMJ";

        /// <summary>
        /// IGUPMT.
        /// </summary>
        public const string IGUPMT = "IGUPMT";

        /// <summary>
        /// IGCTID.
        /// </summary>
        public const string IGCTID = "IGCTID";
    }

    /// <inheritdoc />
    public override string TableName => "F76A26";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IGAEVT", "IGAEVT", JdeDataType.String, 20, true, true),
        new JdeField("IGACIS", "IGACIS", JdeDataType.String, 4, true, true),
        new JdeField("IGACI2", "IGACI2", JdeDataType.String, 4, true, true),
        new JdeField("IGURAT", "IGURAT", JdeDataType.Numeric),
        new JdeField("IGURC1", "IGURC1", JdeDataType.String, 6),
        new JdeField("IGURRF", "IGURRF", JdeDataType.String, 30),
        new JdeField("IGURAB", "IGURAB", JdeDataType.Numeric),
        new JdeField("IGURDT", "IGURDT", JdeDataType.Numeric),
        new JdeField("IGTORG", "IGTORG", JdeDataType.String, 20),
        new JdeField("IGUSER", "IGUSER", JdeDataType.String, 20),
        new JdeField("IGPID", "IGPID", JdeDataType.String, 20),
        new JdeField("IGUPMJ", "IGUPMJ", JdeDataType.Numeric),
        new JdeField("IGUPMT", "IGUPMT", JdeDataType.Numeric),
        new JdeField("IGCTID", "IGCTID", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A26_0", "Primary Key on IGAEVT, IGACIS, IGACI2", new[] { "IGAEVT", "IGACIS", "IGACI2" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76A26_2", "Index on IGAEVT, IGACIS", new[] { "IGAEVT", "IGACIS" })
    };
}
