using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43Q412 - .
/// </summary>
public class F43Q412 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RGEVNU.
        /// </summary>
        public const string RGEVNU = "RGEVNU";

        /// <summary>
        /// RGDCTO.
        /// </summary>
        public const string RGDCTO = "RGDCTO";

        /// <summary>
        /// RGKCOO.
        /// </summary>
        public const string RGKCOO = "RGKCOO";

        /// <summary>
        /// RGEVLN.
        /// </summary>
        public const string RGEVLN = "RGEVLN";

        /// <summary>
        /// RGBIDNUM.
        /// </summary>
        public const string RGBIDNUM = "RGBIDNUM";

        /// <summary>
        /// RGBIDQN.
        /// </summary>
        public const string RGBIDQN = "RGBIDQN";

        /// <summary>
        /// RGAN8.
        /// </summary>
        public const string RGAN8 = "RGAN8";

        /// <summary>
        /// RGTRNB.
        /// </summary>
        public const string RGTRNB = "RGTRNB";

        /// <summary>
        /// RGPBQTY.
        /// </summary>
        public const string RGPBQTY = "RGPBQTY";

        /// <summary>
        /// RGADJPRICE.
        /// </summary>
        public const string RGADJPRICE = "RGADJPRICE";

        /// <summary>
        /// RGFADJPRC.
        /// </summary>
        public const string RGFADJPRC = "RGFADJPRC";

        /// <summary>
        /// RGURCD.
        /// </summary>
        public const string RGURCD = "RGURCD";

        /// <summary>
        /// RGURDT.
        /// </summary>
        public const string RGURDT = "RGURDT";

        /// <summary>
        /// RGURAT.
        /// </summary>
        public const string RGURAT = "RGURAT";

        /// <summary>
        /// RGURAB.
        /// </summary>
        public const string RGURAB = "RGURAB";

        /// <summary>
        /// RGURRF.
        /// </summary>
        public const string RGURRF = "RGURRF";

        /// <summary>
        /// RGTORG.
        /// </summary>
        public const string RGTORG = "RGTORG";

        /// <summary>
        /// RGUSER.
        /// </summary>
        public const string RGUSER = "RGUSER";

        /// <summary>
        /// RGPID.
        /// </summary>
        public const string RGPID = "RGPID";

        /// <summary>
        /// RGJOBN.
        /// </summary>
        public const string RGJOBN = "RGJOBN";

        /// <summary>
        /// RGUPMJ.
        /// </summary>
        public const string RGUPMJ = "RGUPMJ";

        /// <summary>
        /// RGTDAY.
        /// </summary>
        public const string RGTDAY = "RGTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F43Q412";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RGEVNU", "RGEVNU", JdeDataType.Numeric, null, true, true),
        new JdeField("RGDCTO", "RGDCTO", JdeDataType.String, 4, true, true),
        new JdeField("RGKCOO", "RGKCOO", JdeDataType.String, 10, true, true),
        new JdeField("RGEVLN", "RGEVLN", JdeDataType.Numeric, null, true, true),
        new JdeField("RGBIDNUM", "RGBIDNUM", JdeDataType.Numeric, null, true, true),
        new JdeField("RGBIDQN", "RGBIDQN", JdeDataType.Numeric, null, true, true),
        new JdeField("RGAN8", "RGAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("RGTRNB", "RGTRNB", JdeDataType.Numeric, null, true, true),
        new JdeField("RGPBQTY", "RGPBQTY", JdeDataType.Numeric),
        new JdeField("RGADJPRICE", "RGADJPRICE", JdeDataType.Numeric),
        new JdeField("RGFADJPRC", "RGFADJPRC", JdeDataType.Numeric),
        new JdeField("RGURCD", "RGURCD", JdeDataType.String, 4),
        new JdeField("RGURDT", "RGURDT", JdeDataType.Numeric),
        new JdeField("RGURAT", "RGURAT", JdeDataType.Numeric),
        new JdeField("RGURAB", "RGURAB", JdeDataType.Numeric),
        new JdeField("RGURRF", "RGURRF", JdeDataType.String, 30),
        new JdeField("RGTORG", "RGTORG", JdeDataType.String, 20),
        new JdeField("RGUSER", "RGUSER", JdeDataType.String, 20),
        new JdeField("RGPID", "RGPID", JdeDataType.String, 20),
        new JdeField("RGJOBN", "RGJOBN", JdeDataType.String, 20),
        new JdeField("RGUPMJ", "RGUPMJ", JdeDataType.Numeric),
        new JdeField("RGTDAY", "RGTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43Q412_0", "Primary Key on RGEVNU, RGDCTO, RGKCOO, RGEVLN, RGBIDNUM, RGBIDQN, RGAN8, RGTRNB", new[] { "RGEVNU", "RGDCTO", "RGKCOO", "RGEVLN", "RGBIDNUM", "RGBIDQN", "RGAN8", "RGTRNB" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F43Q412_2", "Index on RGEVNU, RGDCTO, RGKCOO, RGBIDNUM, RGAN8", new[] { "RGEVNU", "RGDCTO", "RGKCOO", "RGBIDNUM", "RGAN8" }),
        new JdeIndex("F43Q412_3", "Index on RGEVNU, RGDCTO, RGKCOO, RGAN8, RGBIDNUM, RGEVLN, RGBIDQN, RGTRNB", new[] { "RGEVNU", "RGDCTO", "RGKCOO", "RGAN8", "RGBIDNUM", "RGEVLN", "RGBIDQN", "RGTRNB" })
    };
}
