using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75A0003 - .
/// </summary>
public class F75A0003 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZRCCPR.
        /// </summary>
        public const string ZRCCPR = "ZRCCPR";

        /// <summary>
        /// ZREDTF.
        /// </summary>
        public const string ZREDTF = "ZREDTF";

        /// <summary>
        /// ZREDTT.
        /// </summary>
        public const string ZREDTT = "ZREDTT";

        /// <summary>
        /// ZRSCALE.
        /// </summary>
        public const string ZRSCALE = "ZRSCALE";

        /// <summary>
        /// ZRAN8.
        /// </summary>
        public const string ZRAN8 = "ZRAN8";

        /// <summary>
        /// ZRINPUTNO.
        /// </summary>
        public const string ZRINPUTNO = "ZRINPUTNO";

        /// <summary>
        /// ZRRULTYP.
        /// </summary>
        public const string ZRRULTYP = "ZRRULTYP";

        /// <summary>
        /// ZRPAYG.
        /// </summary>
        public const string ZRPAYG = "ZRPAYG";

        /// <summary>
        /// ZRSRESULT.
        /// </summary>
        public const string ZRSRESULT = "ZRSRESULT";

        /// <summary>
        /// ZROUTNO.
        /// </summary>
        public const string ZROUTNO = "ZROUTNO";

        /// <summary>
        /// ZRTHRV.
        /// </summary>
        public const string ZRTHRV = "ZRTHRV";

        /// <summary>
        /// ZRTHRT.
        /// </summary>
        public const string ZRTHRT = "ZRTHRT";

        /// <summary>
        /// ZRINCYTD.
        /// </summary>
        public const string ZRINCYTD = "ZRINCYTD";

        /// <summary>
        /// ZRRINPUTNO.
        /// </summary>
        public const string ZRRINPUTNO = "ZRRINPUTNO";

        /// <summary>
        /// ZROVERRATE.
        /// </summary>
        public const string ZROVERRATE = "ZROVERRATE";

        /// <summary>
        /// ZRRDIN.
        /// </summary>
        public const string ZRRDIN = "ZRRDIN";

        /// <summary>
        /// ZRRTECDE.
        /// </summary>
        public const string ZRRTECDE = "ZRRTECDE";

        /// <summary>
        /// ZRGWAGENO.
        /// </summary>
        public const string ZRGWAGENO = "ZRGWAGENO";

        /// <summary>
        /// ZRLVLCALC.
        /// </summary>
        public const string ZRLVLCALC = "ZRLVLCALC";

        /// <summary>
        /// ZRTARA.
        /// </summary>
        public const string ZRTARA = "ZRTARA";

        /// <summary>
        /// ZRPTAX.
        /// </summary>
        public const string ZRPTAX = "ZRPTAX";

        /// <summary>
        /// ZRINUPREC.
        /// </summary>
        public const string ZRINUPREC = "ZRINUPREC";

        /// <summary>
        /// ZRSPANO01.
        /// </summary>
        public const string ZRSPANO01 = "ZRSPANO01";

        /// <summary>
        /// ZRSPANO02.
        /// </summary>
        public const string ZRSPANO02 = "ZRSPANO02";

        /// <summary>
        /// ZRSPANO03.
        /// </summary>
        public const string ZRSPANO03 = "ZRSPANO03";

        /// <summary>
        /// ZRSPALP01.
        /// </summary>
        public const string ZRSPALP01 = "ZRSPALP01";

        /// <summary>
        /// ZRSPALP02.
        /// </summary>
        public const string ZRSPALP02 = "ZRSPALP02";

        /// <summary>
        /// ZRSPALP03.
        /// </summary>
        public const string ZRSPALP03 = "ZRSPALP03";

        /// <summary>
        /// ZRSPFLG01.
        /// </summary>
        public const string ZRSPFLG01 = "ZRSPFLG01";

        /// <summary>
        /// ZRSPFLG02.
        /// </summary>
        public const string ZRSPFLG02 = "ZRSPFLG02";

        /// <summary>
        /// ZRSPFLG03.
        /// </summary>
        public const string ZRSPFLG03 = "ZRSPFLG03";

        /// <summary>
        /// ZRUPMJ.
        /// </summary>
        public const string ZRUPMJ = "ZRUPMJ";

        /// <summary>
        /// ZRUPMT.
        /// </summary>
        public const string ZRUPMT = "ZRUPMT";

        /// <summary>
        /// ZRPID.
        /// </summary>
        public const string ZRPID = "ZRPID";

        /// <summary>
        /// ZRJOBN.
        /// </summary>
        public const string ZRJOBN = "ZRJOBN";

        /// <summary>
        /// ZRUSER.
        /// </summary>
        public const string ZRUSER = "ZRUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F75A0003";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZRCCPR", "ZRCCPR", JdeDataType.String, 6, true, true),
        new JdeField("ZREDTF", "ZREDTF", JdeDataType.Numeric, null, true, true),
        new JdeField("ZREDTT", "ZREDTT", JdeDataType.Numeric),
        new JdeField("ZRSCALE", "ZRSCALE", JdeDataType.String, 6, true, true),
        new JdeField("ZRAN8", "ZRAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("ZRINPUTNO", "ZRINPUTNO", JdeDataType.Numeric, null, true, true),
        new JdeField("ZRRULTYP", "ZRRULTYP", JdeDataType.String, 6, true, true),
        new JdeField("ZRPAYG", "ZRPAYG", JdeDataType.String, 2),
        new JdeField("ZRSRESULT", "ZRSRESULT", JdeDataType.String, 2),
        new JdeField("ZROUTNO", "ZROUTNO", JdeDataType.Numeric),
        new JdeField("ZRTHRV", "ZRTHRV", JdeDataType.Numeric),
        new JdeField("ZRTHRT", "ZRTHRT", JdeDataType.String, 2),
        new JdeField("ZRINCYTD", "ZRINCYTD", JdeDataType.String, 2),
        new JdeField("ZRRINPUTNO", "ZRRINPUTNO", JdeDataType.Numeric),
        new JdeField("ZROVERRATE", "ZROVERRATE", JdeDataType.Numeric),
        new JdeField("ZRRDIN", "ZRRDIN", JdeDataType.Numeric),
        new JdeField("ZRRTECDE", "ZRRTECDE", JdeDataType.String, 6),
        new JdeField("ZRGWAGENO", "ZRGWAGENO", JdeDataType.Numeric),
        new JdeField("ZRLVLCALC", "ZRLVLCALC", JdeDataType.String, 2),
        new JdeField("ZRTARA", "ZRTARA", JdeDataType.String, 20),
        new JdeField("ZRPTAX", "ZRPTAX", JdeDataType.String, 4),
        new JdeField("ZRINUPREC", "ZRINUPREC", JdeDataType.String, 2),
        new JdeField("ZRSPANO01", "ZRSPANO01", JdeDataType.Numeric),
        new JdeField("ZRSPANO02", "ZRSPANO02", JdeDataType.Numeric),
        new JdeField("ZRSPANO03", "ZRSPANO03", JdeDataType.Numeric),
        new JdeField("ZRSPALP01", "ZRSPALP01", JdeDataType.String, 6),
        new JdeField("ZRSPALP02", "ZRSPALP02", JdeDataType.String, 6),
        new JdeField("ZRSPALP03", "ZRSPALP03", JdeDataType.String, 6),
        new JdeField("ZRSPFLG01", "ZRSPFLG01", JdeDataType.String, 2),
        new JdeField("ZRSPFLG02", "ZRSPFLG02", JdeDataType.String, 2),
        new JdeField("ZRSPFLG03", "ZRSPFLG03", JdeDataType.String, 2),
        new JdeField("ZRUPMJ", "ZRUPMJ", JdeDataType.Numeric),
        new JdeField("ZRUPMT", "ZRUPMT", JdeDataType.Numeric),
        new JdeField("ZRPID", "ZRPID", JdeDataType.String, 20),
        new JdeField("ZRJOBN", "ZRJOBN", JdeDataType.String, 20),
        new JdeField("ZRUSER", "ZRUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75A0003_0", "Primary Key on ZRCCPR, ZREDTF, ZRSCALE, ZRAN8, ZRINPUTNO, ZRRULTYP", new[] { "ZRCCPR", "ZREDTF", "ZRSCALE", "ZRAN8", "ZRINPUTNO", "ZRRULTYP" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75A0003_2", "Index on ZRCCPR, ZREDTF, ZRSCALE, ZRAN8, ZROUTNO", new[] { "ZRCCPR", "ZREDTF", "ZRSCALE", "ZRAN8", "ZROUTNO" })
    };
}
