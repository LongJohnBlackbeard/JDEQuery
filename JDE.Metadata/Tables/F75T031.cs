using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75T031 - .
/// </summary>
public class F75T031 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GDDOC.
        /// </summary>
        public const string GDDOC = "GDDOC";

        /// <summary>
        /// GDDCT.
        /// </summary>
        public const string GDDCT = "GDDCT";

        /// <summary>
        /// GDKCO.
        /// </summary>
        public const string GDKCO = "GDKCO";

        /// <summary>
        /// GD75TLINW.
        /// </summary>
        public const string GD75TLINW = "GD75TLINW";

        /// <summary>
        /// GDKCOO.
        /// </summary>
        public const string GDKCOO = "GDKCOO";

        /// <summary>
        /// GDDCTO.
        /// </summary>
        public const string GDDCTO = "GDDCTO";

        /// <summary>
        /// GDDOCO.
        /// </summary>
        public const string GDDOCO = "GDDOCO";

        /// <summary>
        /// GDLNID.
        /// </summary>
        public const string GDLNID = "GDLNID";

        /// <summary>
        /// GDSFX.
        /// </summary>
        public const string GDSFX = "GDSFX";

        /// <summary>
        /// GDTXR1.
        /// </summary>
        public const string GDTXR1 = "GDTXR1";

        /// <summary>
        /// GDTXA1.
        /// </summary>
        public const string GDTXA1 = "GDTXA1";

        /// <summary>
        /// GD75TTXT.
        /// </summary>
        public const string GD75TTXT = "GD75TTXT";

        /// <summary>
        /// GDUPRC.
        /// </summary>
        public const string GDUPRC = "GDUPRC";

        /// <summary>
        /// GD75TALN.
        /// </summary>
        public const string GD75TALN = "GD75TALN";

        /// <summary>
        /// GD75TASL.
        /// </summary>
        public const string GD75TASL = "GD75TASL";

        /// <summary>
        /// GDSTAM.
        /// </summary>
        public const string GDSTAM = "GDSTAM";

        /// <summary>
        /// GD75TADSC.
        /// </summary>
        public const string GD75TADSC = "GD75TADSC";

        /// <summary>
        /// GDAG.
        /// </summary>
        public const string GDAG = "GDAG";

        /// <summary>
        /// GDT75AAP.
        /// </summary>
        public const string GDT75AAP = "GDT75AAP";

        /// <summary>
        /// GDCRCD.
        /// </summary>
        public const string GDCRCD = "GDCRCD";

        /// <summary>
        /// GDCRR.
        /// </summary>
        public const string GDCRR = "GDCRR";

        /// <summary>
        /// GDUSER.
        /// </summary>
        public const string GDUSER = "GDUSER";

        /// <summary>
        /// GDPID.
        /// </summary>
        public const string GDPID = "GDPID";

        /// <summary>
        /// GDJOBN.
        /// </summary>
        public const string GDJOBN = "GDJOBN";

        /// <summary>
        /// GDUPMJ.
        /// </summary>
        public const string GDUPMJ = "GDUPMJ";

        /// <summary>
        /// GDUPMT.
        /// </summary>
        public const string GDUPMT = "GDUPMT";

        /// <summary>
        /// GDYFUTDT.
        /// </summary>
        public const string GDYFUTDT = "GDYFUTDT";

        /// <summary>
        /// GDFFU4.
        /// </summary>
        public const string GDFFU4 = "GDFFU4";

        /// <summary>
        /// GDFUT3.
        /// </summary>
        public const string GDFUT3 = "GDFUT3";

        /// <summary>
        /// GDX2.
        /// </summary>
        public const string GDX2 = "GDX2";

        /// <summary>
        /// GDFUTCH1.
        /// </summary>
        public const string GDFUTCH1 = "GDFUTCH1";
    }

    /// <inheritdoc />
    public override string TableName => "F75T031";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GDDOC", "GDDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("GDDCT", "GDDCT", JdeDataType.String, 4, true, true),
        new JdeField("GDKCO", "GDKCO", JdeDataType.String, 10, true, true),
        new JdeField("GD75TLINW", "GD75TLINW", JdeDataType.Numeric, null, true, true),
        new JdeField("GDKCOO", "GDKCOO", JdeDataType.String, 10),
        new JdeField("GDDCTO", "GDDCTO", JdeDataType.String, 4),
        new JdeField("GDDOCO", "GDDOCO", JdeDataType.Numeric),
        new JdeField("GDLNID", "GDLNID", JdeDataType.Numeric),
        new JdeField("GDSFX", "GDSFX", JdeDataType.String, 6),
        new JdeField("GDTXR1", "GDTXR1", JdeDataType.Numeric),
        new JdeField("GDTXA1", "GDTXA1", JdeDataType.String, 20),
        new JdeField("GD75TTXT", "GD75TTXT", JdeDataType.String, 2),
        new JdeField("GDUPRC", "GDUPRC", JdeDataType.Numeric),
        new JdeField("GD75TALN", "GD75TALN", JdeDataType.Numeric),
        new JdeField("GD75TASL", "GD75TASL", JdeDataType.Numeric),
        new JdeField("GDSTAM", "GDSTAM", JdeDataType.Numeric),
        new JdeField("GD75TADSC", "GD75TADSC", JdeDataType.Numeric),
        new JdeField("GDAG", "GDAG", JdeDataType.Numeric),
        new JdeField("GDT75AAP", "GDT75AAP", JdeDataType.Numeric),
        new JdeField("GDCRCD", "GDCRCD", JdeDataType.String, 6),
        new JdeField("GDCRR", "GDCRR", JdeDataType.Numeric),
        new JdeField("GDUSER", "GDUSER", JdeDataType.String, 20),
        new JdeField("GDPID", "GDPID", JdeDataType.String, 20),
        new JdeField("GDJOBN", "GDJOBN", JdeDataType.String, 20),
        new JdeField("GDUPMJ", "GDUPMJ", JdeDataType.Numeric),
        new JdeField("GDUPMT", "GDUPMT", JdeDataType.Numeric),
        new JdeField("GDYFUTDT", "GDYFUTDT", JdeDataType.Numeric),
        new JdeField("GDFFU4", "GDFFU4", JdeDataType.Numeric),
        new JdeField("GDFUT3", "GDFUT3", JdeDataType.String, 60),
        new JdeField("GDX2", "GDX2", JdeDataType.String, 2),
        new JdeField("GDFUTCH1", "GDFUTCH1", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75T031_0", "Primary Key on GDDOC, GDDCT, GDKCO, GD75TLINW", new[] { "GDDOC", "GDDCT", "GDKCO", "GD75TLINW" }, isUnique: true, isPrimaryKey: true)
    };
}
