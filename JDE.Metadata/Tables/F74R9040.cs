using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74R9040 - .
/// </summary>
public class F74R9040 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CER74REPN.
        /// </summary>
        public const string CER74REPN = "CER74REPN";

        /// <summary>
        /// CER74SECT.
        /// </summary>
        public const string CER74SECT = "CER74SECT";

        /// <summary>
        /// CER74RROW.
        /// </summary>
        public const string CER74RROW = "CER74RROW";

        /// <summary>
        /// CED240.
        /// </summary>
        public const string CED240 = "CED240";

        /// <summary>
        /// CER74CODE.
        /// </summary>
        public const string CER74CODE = "CER74CODE";

        /// <summary>
        /// CEAA.
        /// </summary>
        public const string CEAA = "CEAA";

        /// <summary>
        /// CEAA1.
        /// </summary>
        public const string CEAA1 = "CEAA1";

        /// <summary>
        /// CEAA2.
        /// </summary>
        public const string CEAA2 = "CEAA2";

        /// <summary>
        /// CEAA3.
        /// </summary>
        public const string CEAA3 = "CEAA3";

        /// <summary>
        /// CEAAA.
        /// </summary>
        public const string CEAAA = "CEAAA";

        /// <summary>
        /// CEURAB.
        /// </summary>
        public const string CEURAB = "CEURAB";

        /// <summary>
        /// CEURAT.
        /// </summary>
        public const string CEURAT = "CEURAT";

        /// <summary>
        /// CEURDT.
        /// </summary>
        public const string CEURDT = "CEURDT";

        /// <summary>
        /// CEURCD.
        /// </summary>
        public const string CEURCD = "CEURCD";

        /// <summary>
        /// CEURRF.
        /// </summary>
        public const string CEURRF = "CEURRF";

        /// <summary>
        /// CEUSER.
        /// </summary>
        public const string CEUSER = "CEUSER";

        /// <summary>
        /// CEPID.
        /// </summary>
        public const string CEPID = "CEPID";

        /// <summary>
        /// CEJOBN.
        /// </summary>
        public const string CEJOBN = "CEJOBN";

        /// <summary>
        /// CEUPMJ.
        /// </summary>
        public const string CEUPMJ = "CEUPMJ";

        /// <summary>
        /// CEUPMT.
        /// </summary>
        public const string CEUPMT = "CEUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74R9040";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CER74REPN", "CER74REPN", JdeDataType.String, 40, true, true),
        new JdeField("CER74SECT", "CER74SECT", JdeDataType.String, 4, true, true),
        new JdeField("CER74RROW", "CER74RROW", JdeDataType.String, 8, true, true),
        new JdeField("CED240", "CED240", JdeDataType.String, 480),
        new JdeField("CER74CODE", "CER74CODE", JdeDataType.String, 8),
        new JdeField("CEAA", "CEAA", JdeDataType.Numeric),
        new JdeField("CEAA1", "CEAA1", JdeDataType.Numeric),
        new JdeField("CEAA2", "CEAA2", JdeDataType.Numeric),
        new JdeField("CEAA3", "CEAA3", JdeDataType.Numeric),
        new JdeField("CEAAA", "CEAAA", JdeDataType.Numeric),
        new JdeField("CEURAB", "CEURAB", JdeDataType.Numeric),
        new JdeField("CEURAT", "CEURAT", JdeDataType.Numeric),
        new JdeField("CEURDT", "CEURDT", JdeDataType.Numeric),
        new JdeField("CEURCD", "CEURCD", JdeDataType.String, 4),
        new JdeField("CEURRF", "CEURRF", JdeDataType.String, 30),
        new JdeField("CEUSER", "CEUSER", JdeDataType.String, 20),
        new JdeField("CEPID", "CEPID", JdeDataType.String, 20),
        new JdeField("CEJOBN", "CEJOBN", JdeDataType.String, 20),
        new JdeField("CEUPMJ", "CEUPMJ", JdeDataType.Numeric),
        new JdeField("CEUPMT", "CEUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74R9040_0", "Primary Key on CER74REPN, CER74SECT, CER74RROW", new[] { "CER74REPN", "CER74SECT", "CER74RROW" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74R9040_2", "Index on CER74CODE", new[] { "CER74CODE" })
    };
}
