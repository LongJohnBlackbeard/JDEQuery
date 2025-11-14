using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74R0402 - .
/// </summary>
public class F74R0402 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// COKCO.
        /// </summary>
        public const string COKCO = "COKCO";

        /// <summary>
        /// CODCT.
        /// </summary>
        public const string CODCT = "CODCT";

        /// <summary>
        /// CODOC.
        /// </summary>
        public const string CODOC = "CODOC";

        /// <summary>
        /// COOKCO.
        /// </summary>
        public const string COOKCO = "COOKCO";

        /// <summary>
        /// COOCTO.
        /// </summary>
        public const string COOCTO = "COOCTO";

        /// <summary>
        /// COODOC.
        /// </summary>
        public const string COODOC = "COODOC";

        /// <summary>
        /// COURRF.
        /// </summary>
        public const string COURRF = "COURRF";

        /// <summary>
        /// COURDT.
        /// </summary>
        public const string COURDT = "COURDT";

        /// <summary>
        /// COURC1.
        /// </summary>
        public const string COURC1 = "COURC1";

        /// <summary>
        /// COURAT.
        /// </summary>
        public const string COURAT = "COURAT";

        /// <summary>
        /// COURAB.
        /// </summary>
        public const string COURAB = "COURAB";

        /// <summary>
        /// COUSER.
        /// </summary>
        public const string COUSER = "COUSER";

        /// <summary>
        /// COPID.
        /// </summary>
        public const string COPID = "COPID";

        /// <summary>
        /// COJOBN.
        /// </summary>
        public const string COJOBN = "COJOBN";

        /// <summary>
        /// COUPMJ.
        /// </summary>
        public const string COUPMJ = "COUPMJ";

        /// <summary>
        /// COUPMT.
        /// </summary>
        public const string COUPMT = "COUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74R0402";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("COKCO", "COKCO", JdeDataType.String, 10, true, true),
        new JdeField("CODCT", "CODCT", JdeDataType.String, 4, true, true),
        new JdeField("CODOC", "CODOC", JdeDataType.Numeric, null, true, true),
        new JdeField("COOKCO", "COOKCO", JdeDataType.String, 10),
        new JdeField("COOCTO", "COOCTO", JdeDataType.String, 4),
        new JdeField("COODOC", "COODOC", JdeDataType.Numeric),
        new JdeField("COURRF", "COURRF", JdeDataType.String, 30),
        new JdeField("COURDT", "COURDT", JdeDataType.Numeric),
        new JdeField("COURC1", "COURC1", JdeDataType.String, 6),
        new JdeField("COURAT", "COURAT", JdeDataType.Numeric),
        new JdeField("COURAB", "COURAB", JdeDataType.Numeric),
        new JdeField("COUSER", "COUSER", JdeDataType.String, 20),
        new JdeField("COPID", "COPID", JdeDataType.String, 20),
        new JdeField("COJOBN", "COJOBN", JdeDataType.String, 20),
        new JdeField("COUPMJ", "COUPMJ", JdeDataType.Numeric),
        new JdeField("COUPMT", "COUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74R0402_0", "Primary Key on CODCT, COKCO, CODOC", new[] { "CODCT", "COKCO", "CODOC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74R0402_2", "Index on COOKCO, COOCTO, COODOC", new[] { "COOKCO", "COOCTO", "COODOC" })
    };
}
