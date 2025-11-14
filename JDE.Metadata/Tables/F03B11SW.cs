using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03B11SW - .
/// </summary>
public class F03B11SW : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CSUSER.
        /// </summary>
        public const string CSUSER = "CSUSER";

        /// <summary>
        /// CSUKID.
        /// </summary>
        public const string CSUKID = "CSUKID";

        /// <summary>
        /// CSAN8.
        /// </summary>
        public const string CSAN8 = "CSAN8";

        /// <summary>
        /// CSCO.
        /// </summary>
        public const string CSCO = "CSCO";

        /// <summary>
        /// CSCRCD.
        /// </summary>
        public const string CSCRCD = "CSCRCD";

        /// <summary>
        /// CSBCRC.
        /// </summary>
        public const string CSBCRC = "CSBCRC";

        /// <summary>
        /// CSAG.
        /// </summary>
        public const string CSAG = "CSAG";

        /// <summary>
        /// CSAAP.
        /// </summary>
        public const string CSAAP = "CSAAP";

        /// <summary>
        /// CSACR.
        /// </summary>
        public const string CSACR = "CSACR";

        /// <summary>
        /// CSFAP.
        /// </summary>
        public const string CSFAP = "CSFAP";

        /// <summary>
        /// CSCDEC.
        /// </summary>
        public const string CSCDEC = "CSCDEC";
    }

    /// <inheritdoc />
    public override string TableName => "F03B11SW";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CSUSER", "CSUSER", JdeDataType.String, 20, true, true),
        new JdeField("CSUKID", "CSUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("CSAN8", "CSAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("CSCO", "CSCO", JdeDataType.String, 10, true, true),
        new JdeField("CSCRCD", "CSCRCD", JdeDataType.String, 6, true, true),
        new JdeField("CSBCRC", "CSBCRC", JdeDataType.String, 6, true, true),
        new JdeField("CSAG", "CSAG", JdeDataType.Numeric),
        new JdeField("CSAAP", "CSAAP", JdeDataType.Numeric),
        new JdeField("CSACR", "CSACR", JdeDataType.Numeric),
        new JdeField("CSFAP", "CSFAP", JdeDataType.Numeric),
        new JdeField("CSCDEC", "CSCDEC", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03B11SW_0", "Primary Key on CSUSER, CSUKID, CSAN8, CSCRCD, CSBCRC, CSCO", new[] { "CSUSER", "CSUKID", "CSAN8", "CSCRCD", "CSBCRC", "CSCO" }, isUnique: true, isPrimaryKey: true)
    };
}
