using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I017 - .
/// </summary>
public class F75I017 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SOKCOO.
        /// </summary>
        public const string SOKCOO = "SOKCOO";

        /// <summary>
        /// SODOCO.
        /// </summary>
        public const string SODOCO = "SODOCO";

        /// <summary>
        /// SODCTO.
        /// </summary>
        public const string SODCTO = "SODCTO";

        /// <summary>
        /// SOLNID.
        /// </summary>
        public const string SOLNID = "SOLNID";

        /// <summary>
        /// SOAST.
        /// </summary>
        public const string SOAST = "SOAST";

        /// <summary>
        /// SOI75TXRG.
        /// </summary>
        public const string SOI75TXRG = "SOI75TXRG";

        /// <summary>
        /// SOI75TXTY.
        /// </summary>
        public const string SOI75TXTY = "SOI75TXTY";

        /// <summary>
        /// SODOC.
        /// </summary>
        public const string SODOC = "SODOC";

        /// <summary>
        /// SOCO.
        /// </summary>
        public const string SOCO = "SOCO";

        /// <summary>
        /// SOMCU.
        /// </summary>
        public const string SOMCU = "SOMCU";

        /// <summary>
        /// SOLITM.
        /// </summary>
        public const string SOLITM = "SOLITM";

        /// <summary>
        /// SOYEXU.
        /// </summary>
        public const string SOYEXU = "SOYEXU";

        /// <summary>
        /// SOITM.
        /// </summary>
        public const string SOITM = "SOITM";

        /// <summary>
        /// SOUORG.
        /// </summary>
        public const string SOUORG = "SOUORG";

        /// <summary>
        /// SOUOM.
        /// </summary>
        public const string SOUOM = "SOUOM";

        /// <summary>
        /// SOI75RETY.
        /// </summary>
        public const string SOI75RETY = "SOI75RETY";

        /// <summary>
        /// SOFVTR.
        /// </summary>
        public const string SOFVTR = "SOFVTR";

        /// <summary>
        /// SOI75TAXA.
        /// </summary>
        public const string SOI75TAXA = "SOI75TAXA";

        /// <summary>
        /// SOI75TXR.
        /// </summary>
        public const string SOI75TXR = "SOI75TXR";

        /// <summary>
        /// SOSTCD.
        /// </summary>
        public const string SOSTCD = "SOSTCD";

        /// <summary>
        /// SOI75RTSU.
        /// </summary>
        public const string SOI75RTSU = "SOI75RTSU";

        /// <summary>
        /// SOI75CHNB.
        /// </summary>
        public const string SOI75CHNB = "SOI75CHNB";

        /// <summary>
        /// SOAEXP.
        /// </summary>
        public const string SOAEXP = "SOAEXP";

        /// <summary>
        /// SOAA1.
        /// </summary>
        public const string SOAA1 = "SOAA1";

        /// <summary>
        /// SOAA2.
        /// </summary>
        public const string SOAA2 = "SOAA2";

        /// <summary>
        /// SOAA3.
        /// </summary>
        public const string SOAA3 = "SOAA3";

        /// <summary>
        /// SODL01.
        /// </summary>
        public const string SODL01 = "SODL01";

        /// <summary>
        /// SODS01.
        /// </summary>
        public const string SODS01 = "SODS01";

        /// <summary>
        /// SODTE.
        /// </summary>
        public const string SODTE = "SODTE";

        /// <summary>
        /// SOFFU2.
        /// </summary>
        public const string SOFFU2 = "SOFFU2";

        /// <summary>
        /// SOINT01.
        /// </summary>
        public const string SOINT01 = "SOINT01";

        /// <summary>
        /// SOUSER.
        /// </summary>
        public const string SOUSER = "SOUSER";

        /// <summary>
        /// SOJOBN.
        /// </summary>
        public const string SOJOBN = "SOJOBN";

        /// <summary>
        /// SOUPMJ.
        /// </summary>
        public const string SOUPMJ = "SOUPMJ";

        /// <summary>
        /// SOUPMT.
        /// </summary>
        public const string SOUPMT = "SOUPMT";

        /// <summary>
        /// SOPID.
        /// </summary>
        public const string SOPID = "SOPID";
    }

    /// <inheritdoc />
    public override string TableName => "F75I017";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SOKCOO", "SOKCOO", JdeDataType.String, 10, true, true),
        new JdeField("SODOCO", "SODOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("SODCTO", "SODCTO", JdeDataType.String, 4, true, true),
        new JdeField("SOLNID", "SOLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("SOAST", "SOAST", JdeDataType.String, 16, true, true),
        new JdeField("SOI75TXRG", "SOI75TXRG", JdeDataType.String, 10),
        new JdeField("SOI75TXTY", "SOI75TXTY", JdeDataType.String, 10),
        new JdeField("SODOC", "SODOC", JdeDataType.Numeric),
        new JdeField("SOCO", "SOCO", JdeDataType.String, 10),
        new JdeField("SOMCU", "SOMCU", JdeDataType.String, 24),
        new JdeField("SOLITM", "SOLITM", JdeDataType.String, 50),
        new JdeField("SOYEXU", "SOYEXU", JdeDataType.Numeric),
        new JdeField("SOITM", "SOITM", JdeDataType.Numeric),
        new JdeField("SOUORG", "SOUORG", JdeDataType.Numeric),
        new JdeField("SOUOM", "SOUOM", JdeDataType.String, 4),
        new JdeField("SOI75RETY", "SOI75RETY", JdeDataType.String, 6),
        new JdeField("SOFVTR", "SOFVTR", JdeDataType.Numeric),
        new JdeField("SOI75TAXA", "SOI75TAXA", JdeDataType.Numeric),
        new JdeField("SOI75TXR", "SOI75TXR", JdeDataType.Numeric),
        new JdeField("SOSTCD", "SOSTCD", JdeDataType.String, 6),
        new JdeField("SOI75RTSU", "SOI75RTSU", JdeDataType.String, 6),
        new JdeField("SOI75CHNB", "SOI75CHNB", JdeDataType.String, 40),
        new JdeField("SOAEXP", "SOAEXP", JdeDataType.Numeric),
        new JdeField("SOAA1", "SOAA1", JdeDataType.Numeric),
        new JdeField("SOAA2", "SOAA2", JdeDataType.Numeric),
        new JdeField("SOAA3", "SOAA3", JdeDataType.Numeric),
        new JdeField("SODL01", "SODL01", JdeDataType.String, 60),
        new JdeField("SODS01", "SODS01", JdeDataType.String, 160),
        new JdeField("SODTE", "SODTE", JdeDataType.Numeric),
        new JdeField("SOFFU2", "SOFFU2", JdeDataType.String, 2),
        new JdeField("SOINT01", "SOINT01", JdeDataType.Numeric),
        new JdeField("SOUSER", "SOUSER", JdeDataType.String, 20),
        new JdeField("SOJOBN", "SOJOBN", JdeDataType.String, 20),
        new JdeField("SOUPMJ", "SOUPMJ", JdeDataType.Numeric),
        new JdeField("SOUPMT", "SOUPMT", JdeDataType.Numeric),
        new JdeField("SOPID", "SOPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I017_0", "Primary Key on SOKCOO, SODOCO, SODCTO, SOLNID, SOAST", new[] { "SOKCOO", "SODOCO", "SODCTO", "SOLNID", "SOAST" }, isUnique: true, isPrimaryKey: true)
    };
}
