using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76VLV02 - .
/// </summary>
public class F76VLV02 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// COPYID.
        /// </summary>
        public const string COPYID = "COPYID";

        /// <summary>
        /// COKCO.
        /// </summary>
        public const string COKCO = "COKCO";

        /// <summary>
        /// COAN8.
        /// </summary>
        public const string COAN8 = "COAN8";

        /// <summary>
        /// CODCT.
        /// </summary>
        public const string CODCT = "CODCT";

        /// <summary>
        /// CODOC.
        /// </summary>
        public const string CODOC = "CODOC";

        /// <summary>
        /// COAAAJ.
        /// </summary>
        public const string COAAAJ = "COAAAJ";
    }

    /// <inheritdoc />
    public override string TableName => "F76VLV02";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("COPYID", "COPYID", JdeDataType.Numeric, null, true, true),
        new JdeField("COKCO", "COKCO", JdeDataType.String, 10, true, true),
        new JdeField("COAN8", "COAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("CODCT", "CODCT", JdeDataType.String, 4, true, true),
        new JdeField("CODOC", "CODOC", JdeDataType.Numeric, null, true, true),
        new JdeField("COAAAJ", "COAAAJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76VLV02_0", "Primary Key on COPYID, COKCO, COAN8, CODCT, CODOC", new[] { "COPYID", "COKCO", "COAN8", "CODCT", "CODOC" }, isUnique: true, isPrimaryKey: true)
    };
}
