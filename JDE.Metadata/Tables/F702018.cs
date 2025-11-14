using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F702018 - .
/// </summary>
public class F702018 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TAKCOO.
        /// </summary>
        public const string TAKCOO = "TAKCOO";

        /// <summary>
        /// TADCTO.
        /// </summary>
        public const string TADCTO = "TADCTO";

        /// <summary>
        /// TADOCO.
        /// </summary>
        public const string TADOCO = "TADOCO";

        /// <summary>
        /// TALNID.
        /// </summary>
        public const string TALNID = "TALNID";

        /// <summary>
        /// TASEQ.
        /// </summary>
        public const string TASEQ = "TASEQ";

        /// <summary>
        /// TAK74TAXC.
        /// </summary>
        public const string TAK74TAXC = "TAK74TAXC";

        /// <summary>
        /// TAK70TXLT.
        /// </summary>
        public const string TAK70TXLT = "TAK70TXLT";

        /// <summary>
        /// TATXR1.
        /// </summary>
        public const string TATXR1 = "TATXR1";

        /// <summary>
        /// TACO.
        /// </summary>
        public const string TACO = "TACO";

        /// <summary>
        /// TACRCD.
        /// </summary>
        public const string TACRCD = "TACRCD";

        /// <summary>
        /// TAK74TAXD.
        /// </summary>
        public const string TAK74TAXD = "TAK74TAXD";

        /// <summary>
        /// TAK74TAXF.
        /// </summary>
        public const string TAK74TAXF = "TAK74TAXF";

        /// <summary>
        /// TABCRC.
        /// </summary>
        public const string TABCRC = "TABCRC";

        /// <summary>
        /// TADCT.
        /// </summary>
        public const string TADCT = "TADCT";

        /// <summary>
        /// TADOC.
        /// </summary>
        public const string TADOC = "TADOC";

        /// <summary>
        /// TAKCO.
        /// </summary>
        public const string TAKCO = "TAKCO";

        /// <summary>
        /// TADGJ.
        /// </summary>
        public const string TADGJ = "TADGJ";

        /// <summary>
        /// TAPOST.
        /// </summary>
        public const string TAPOST = "TAPOST";

        /// <summary>
        /// TAAST.
        /// </summary>
        public const string TAAST = "TAAST";

        /// <summary>
        /// TAUSER.
        /// </summary>
        public const string TAUSER = "TAUSER";

        /// <summary>
        /// TAPID.
        /// </summary>
        public const string TAPID = "TAPID";

        /// <summary>
        /// TAJOBN.
        /// </summary>
        public const string TAJOBN = "TAJOBN";

        /// <summary>
        /// TAUPMJ.
        /// </summary>
        public const string TAUPMJ = "TAUPMJ";

        /// <summary>
        /// TAUPMT.
        /// </summary>
        public const string TAUPMT = "TAUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F702018";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TAKCOO", "TAKCOO", JdeDataType.String, 10, true, true),
        new JdeField("TADCTO", "TADCTO", JdeDataType.String, 4, true, true),
        new JdeField("TADOCO", "TADOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("TALNID", "TALNID", JdeDataType.Numeric, null, true, true),
        new JdeField("TASEQ", "TASEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("TAK74TAXC", "TAK74TAXC", JdeDataType.String, 20),
        new JdeField("TAK70TXLT", "TAK70TXLT", JdeDataType.String, 10),
        new JdeField("TATXR1", "TATXR1", JdeDataType.Numeric),
        new JdeField("TACO", "TACO", JdeDataType.String, 10),
        new JdeField("TACRCD", "TACRCD", JdeDataType.String, 6),
        new JdeField("TAK74TAXD", "TAK74TAXD", JdeDataType.Numeric),
        new JdeField("TAK74TAXF", "TAK74TAXF", JdeDataType.Numeric),
        new JdeField("TABCRC", "TABCRC", JdeDataType.String, 6),
        new JdeField("TADCT", "TADCT", JdeDataType.String, 4),
        new JdeField("TADOC", "TADOC", JdeDataType.Numeric),
        new JdeField("TAKCO", "TAKCO", JdeDataType.String, 10),
        new JdeField("TADGJ", "TADGJ", JdeDataType.Numeric),
        new JdeField("TAPOST", "TAPOST", JdeDataType.String, 2),
        new JdeField("TAAST", "TAAST", JdeDataType.String, 16),
        new JdeField("TAUSER", "TAUSER", JdeDataType.String, 20),
        new JdeField("TAPID", "TAPID", JdeDataType.String, 20),
        new JdeField("TAJOBN", "TAJOBN", JdeDataType.String, 20),
        new JdeField("TAUPMJ", "TAUPMJ", JdeDataType.Numeric),
        new JdeField("TAUPMT", "TAUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F702018_0", "Primary Key on TAKCOO, TADCTO, TADOCO, TALNID, TASEQ", new[] { "TAKCOO", "TADCTO", "TADOCO", "TALNID", "TASEQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F702018_2", "Index on TADCT, TADOC, TAKCO, TADGJ", new[] { "TADCT", "TADOC", "TAKCO", "TADGJ" })
    };
}
