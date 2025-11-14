using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4602 - .
/// </summary>
public class F4602 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IFITM.
        /// </summary>
        public const string IFITM = "IFITM";

        /// <summary>
        /// IFMCU.
        /// </summary>
        public const string IFMCU = "IFMCU";

        /// <summary>
        /// IFLOCN.
        /// </summary>
        public const string IFLOCN = "IFLOCN";

        /// <summary>
        /// IFLOTN.
        /// </summary>
        public const string IFLOTN = "IFLOTN";

        /// <summary>
        /// IFLDSQ.
        /// </summary>
        public const string IFLDSQ = "IFLDSQ";

        /// <summary>
        /// IFSTUN.
        /// </summary>
        public const string IFSTUN = "IFSTUN";

        /// <summary>
        /// IFUML1.
        /// </summary>
        public const string IFUML1 = "IFUML1";

        /// <summary>
        /// IFUGL1.
        /// </summary>
        public const string IFUGL1 = "IFUGL1";

        /// <summary>
        /// IFEUL1.
        /// </summary>
        public const string IFEUL1 = "IFEUL1";

        /// <summary>
        /// IFPPL1.
        /// </summary>
        public const string IFPPL1 = "IFPPL1";

        /// <summary>
        /// IFTQL1.
        /// </summary>
        public const string IFTQL1 = "IFTQL1";

        /// <summary>
        /// IFEQL1.
        /// </summary>
        public const string IFEQL1 = "IFEQL1";

        /// <summary>
        /// IFHPL1.
        /// </summary>
        public const string IFHPL1 = "IFHPL1";

        /// <summary>
        /// IFWPL1.
        /// </summary>
        public const string IFWPL1 = "IFWPL1";

        /// <summary>
        /// IFDPL1.
        /// </summary>
        public const string IFDPL1 = "IFDPL1";

        /// <summary>
        /// IFCPL1.
        /// </summary>
        public const string IFCPL1 = "IFCPL1";

        /// <summary>
        /// IFEPL1.
        /// </summary>
        public const string IFEPL1 = "IFEPL1";

        /// <summary>
        /// IFUML2.
        /// </summary>
        public const string IFUML2 = "IFUML2";

        /// <summary>
        /// IFUGL2.
        /// </summary>
        public const string IFUGL2 = "IFUGL2";

        /// <summary>
        /// IFEUL2.
        /// </summary>
        public const string IFEUL2 = "IFEUL2";

        /// <summary>
        /// IFQPL2.
        /// </summary>
        public const string IFQPL2 = "IFQPL2";

        /// <summary>
        /// IFPPL2.
        /// </summary>
        public const string IFPPL2 = "IFPPL2";

        /// <summary>
        /// IFTQL2.
        /// </summary>
        public const string IFTQL2 = "IFTQL2";

        /// <summary>
        /// IFEQL2.
        /// </summary>
        public const string IFEQL2 = "IFEQL2";

        /// <summary>
        /// IFHPL2.
        /// </summary>
        public const string IFHPL2 = "IFHPL2";

        /// <summary>
        /// IFWPL2.
        /// </summary>
        public const string IFWPL2 = "IFWPL2";

        /// <summary>
        /// IFDPL2.
        /// </summary>
        public const string IFDPL2 = "IFDPL2";

        /// <summary>
        /// IFCPL2.
        /// </summary>
        public const string IFCPL2 = "IFCPL2";

        /// <summary>
        /// IFEPL2.
        /// </summary>
        public const string IFEPL2 = "IFEPL2";

        /// <summary>
        /// IFUML3.
        /// </summary>
        public const string IFUML3 = "IFUML3";

        /// <summary>
        /// IFUGL3.
        /// </summary>
        public const string IFUGL3 = "IFUGL3";

        /// <summary>
        /// IFEUL3.
        /// </summary>
        public const string IFEUL3 = "IFEUL3";

        /// <summary>
        /// IFQPL3.
        /// </summary>
        public const string IFQPL3 = "IFQPL3";

        /// <summary>
        /// IFPPL3.
        /// </summary>
        public const string IFPPL3 = "IFPPL3";

        /// <summary>
        /// IFTQL3.
        /// </summary>
        public const string IFTQL3 = "IFTQL3";

        /// <summary>
        /// IFEQL3.
        /// </summary>
        public const string IFEQL3 = "IFEQL3";

        /// <summary>
        /// IFHPL3.
        /// </summary>
        public const string IFHPL3 = "IFHPL3";

        /// <summary>
        /// IFWPL3.
        /// </summary>
        public const string IFWPL3 = "IFWPL3";

        /// <summary>
        /// IFDPL3.
        /// </summary>
        public const string IFDPL3 = "IFDPL3";

        /// <summary>
        /// IFCPL3.
        /// </summary>
        public const string IFCPL3 = "IFCPL3";

        /// <summary>
        /// IFEPL3.
        /// </summary>
        public const string IFEPL3 = "IFEPL3";

        /// <summary>
        /// IFUML4.
        /// </summary>
        public const string IFUML4 = "IFUML4";

        /// <summary>
        /// IFUGL4.
        /// </summary>
        public const string IFUGL4 = "IFUGL4";

        /// <summary>
        /// IFEUL4.
        /// </summary>
        public const string IFEUL4 = "IFEUL4";

        /// <summary>
        /// IFQPL4.
        /// </summary>
        public const string IFQPL4 = "IFQPL4";

        /// <summary>
        /// IFPPL4.
        /// </summary>
        public const string IFPPL4 = "IFPPL4";

        /// <summary>
        /// IFTQL4.
        /// </summary>
        public const string IFTQL4 = "IFTQL4";

        /// <summary>
        /// IFEQL4.
        /// </summary>
        public const string IFEQL4 = "IFEQL4";

        /// <summary>
        /// IFHPL4.
        /// </summary>
        public const string IFHPL4 = "IFHPL4";

        /// <summary>
        /// IFWPL4.
        /// </summary>
        public const string IFWPL4 = "IFWPL4";

        /// <summary>
        /// IFDPL4.
        /// </summary>
        public const string IFDPL4 = "IFDPL4";

        /// <summary>
        /// IFCPL4.
        /// </summary>
        public const string IFCPL4 = "IFCPL4";

        /// <summary>
        /// IFEPL4.
        /// </summary>
        public const string IFEPL4 = "IFEPL4";

        /// <summary>
        /// IFUML5.
        /// </summary>
        public const string IFUML5 = "IFUML5";

        /// <summary>
        /// IFUGL5.
        /// </summary>
        public const string IFUGL5 = "IFUGL5";

        /// <summary>
        /// IFEUL5.
        /// </summary>
        public const string IFEUL5 = "IFEUL5";

        /// <summary>
        /// IFQPL5.
        /// </summary>
        public const string IFQPL5 = "IFQPL5";

        /// <summary>
        /// IFTQL5.
        /// </summary>
        public const string IFTQL5 = "IFTQL5";

        /// <summary>
        /// IFEQL5.
        /// </summary>
        public const string IFEQL5 = "IFEQL5";

        /// <summary>
        /// IFHPL5.
        /// </summary>
        public const string IFHPL5 = "IFHPL5";

        /// <summary>
        /// IFWPL5.
        /// </summary>
        public const string IFWPL5 = "IFWPL5";

        /// <summary>
        /// IFDPL5.
        /// </summary>
        public const string IFDPL5 = "IFDPL5";

        /// <summary>
        /// IFCPL5.
        /// </summary>
        public const string IFCPL5 = "IFCPL5";

        /// <summary>
        /// IFEPL5.
        /// </summary>
        public const string IFEPL5 = "IFEPL5";

        /// <summary>
        /// IFUOM1.
        /// </summary>
        public const string IFUOM1 = "IFUOM1";

        /// <summary>
        /// IFTQTY.
        /// </summary>
        public const string IFTQTY = "IFTQTY";

        /// <summary>
        /// IFHCOM.
        /// </summary>
        public const string IFHCOM = "IFHCOM";

        /// <summary>
        /// IFQTRI.
        /// </summary>
        public const string IFQTRI = "IFQTRI";

        /// <summary>
        /// IFQTRO.
        /// </summary>
        public const string IFQTRO = "IFQTRO";

        /// <summary>
        /// IFCUBE.
        /// </summary>
        public const string IFCUBE = "IFCUBE";

        /// <summary>
        /// IFRCUB.
        /// </summary>
        public const string IFRCUB = "IFRCUB";

        /// <summary>
        /// IFVUMD.
        /// </summary>
        public const string IFVUMD = "IFVUMD";

        /// <summary>
        /// IFWEIT.
        /// </summary>
        public const string IFWEIT = "IFWEIT";

        /// <summary>
        /// IFRWET.
        /// </summary>
        public const string IFRWET = "IFRWET";

        /// <summary>
        /// IFUWUM.
        /// </summary>
        public const string IFUWUM = "IFUWUM";

        /// <summary>
        /// IFRCDJ.
        /// </summary>
        public const string IFRCDJ = "IFRCDJ";

        /// <summary>
        /// IFMMEJ.
        /// </summary>
        public const string IFMMEJ = "IFMMEJ";

        /// <summary>
        /// IFDOCO.
        /// </summary>
        public const string IFDOCO = "IFDOCO";

        /// <summary>
        /// IFDCTO.
        /// </summary>
        public const string IFDCTO = "IFDCTO";

        /// <summary>
        /// IFKCOO.
        /// </summary>
        public const string IFKCOO = "IFKCOO";

        /// <summary>
        /// IFLNID.
        /// </summary>
        public const string IFLNID = "IFLNID";

        /// <summary>
        /// IFSFXO.
        /// </summary>
        public const string IFSFXO = "IFSFXO";

        /// <summary>
        /// IFNLIN.
        /// </summary>
        public const string IFNLIN = "IFNLIN";

        /// <summary>
        /// IFUSER.
        /// </summary>
        public const string IFUSER = "IFUSER";

        /// <summary>
        /// IFPID.
        /// </summary>
        public const string IFPID = "IFPID";

        /// <summary>
        /// IFJOBN.
        /// </summary>
        public const string IFJOBN = "IFJOBN";

        /// <summary>
        /// IFUPMJ.
        /// </summary>
        public const string IFUPMJ = "IFUPMJ";

        /// <summary>
        /// IFTDAY.
        /// </summary>
        public const string IFTDAY = "IFTDAY";

        /// <summary>
        /// IFUOM2.
        /// </summary>
        public const string IFUOM2 = "IFUOM2";

        /// <summary>
        /// IFDQTY.
        /// </summary>
        public const string IFDQTY = "IFDQTY";
    }

    /// <inheritdoc />
    public override string TableName => "F4602";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IFITM", "IFITM", JdeDataType.Numeric, null, true, true),
        new JdeField("IFMCU", "IFMCU", JdeDataType.String, 24, true, true),
        new JdeField("IFLOCN", "IFLOCN", JdeDataType.String, 40, true, true),
        new JdeField("IFLOTN", "IFLOTN", JdeDataType.String, 60, true, true),
        new JdeField("IFLDSQ", "IFLDSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("IFSTUN", "IFSTUN", JdeDataType.Numeric),
        new JdeField("IFUML1", "IFUML1", JdeDataType.String, 4),
        new JdeField("IFUGL1", "IFUGL1", JdeDataType.String, 4),
        new JdeField("IFEUL1", "IFEUL1", JdeDataType.String, 2),
        new JdeField("IFPPL1", "IFPPL1", JdeDataType.Numeric),
        new JdeField("IFTQL1", "IFTQL1", JdeDataType.Numeric),
        new JdeField("IFEQL1", "IFEQL1", JdeDataType.String, 10),
        new JdeField("IFHPL1", "IFHPL1", JdeDataType.Numeric),
        new JdeField("IFWPL1", "IFWPL1", JdeDataType.Numeric),
        new JdeField("IFDPL1", "IFDPL1", JdeDataType.Numeric),
        new JdeField("IFCPL1", "IFCPL1", JdeDataType.Numeric),
        new JdeField("IFEPL1", "IFEPL1", JdeDataType.Numeric),
        new JdeField("IFUML2", "IFUML2", JdeDataType.String, 4),
        new JdeField("IFUGL2", "IFUGL2", JdeDataType.String, 4),
        new JdeField("IFEUL2", "IFEUL2", JdeDataType.String, 2),
        new JdeField("IFQPL2", "IFQPL2", JdeDataType.Numeric),
        new JdeField("IFPPL2", "IFPPL2", JdeDataType.Numeric),
        new JdeField("IFTQL2", "IFTQL2", JdeDataType.Numeric),
        new JdeField("IFEQL2", "IFEQL2", JdeDataType.String, 10),
        new JdeField("IFHPL2", "IFHPL2", JdeDataType.Numeric),
        new JdeField("IFWPL2", "IFWPL2", JdeDataType.Numeric),
        new JdeField("IFDPL2", "IFDPL2", JdeDataType.Numeric),
        new JdeField("IFCPL2", "IFCPL2", JdeDataType.Numeric),
        new JdeField("IFEPL2", "IFEPL2", JdeDataType.Numeric),
        new JdeField("IFUML3", "IFUML3", JdeDataType.String, 4),
        new JdeField("IFUGL3", "IFUGL3", JdeDataType.String, 4),
        new JdeField("IFEUL3", "IFEUL3", JdeDataType.String, 2),
        new JdeField("IFQPL3", "IFQPL3", JdeDataType.Numeric),
        new JdeField("IFPPL3", "IFPPL3", JdeDataType.Numeric),
        new JdeField("IFTQL3", "IFTQL3", JdeDataType.Numeric),
        new JdeField("IFEQL3", "IFEQL3", JdeDataType.String, 10),
        new JdeField("IFHPL3", "IFHPL3", JdeDataType.Numeric),
        new JdeField("IFWPL3", "IFWPL3", JdeDataType.Numeric),
        new JdeField("IFDPL3", "IFDPL3", JdeDataType.Numeric),
        new JdeField("IFCPL3", "IFCPL3", JdeDataType.Numeric),
        new JdeField("IFEPL3", "IFEPL3", JdeDataType.Numeric),
        new JdeField("IFUML4", "IFUML4", JdeDataType.String, 4),
        new JdeField("IFUGL4", "IFUGL4", JdeDataType.String, 4),
        new JdeField("IFEUL4", "IFEUL4", JdeDataType.String, 2),
        new JdeField("IFQPL4", "IFQPL4", JdeDataType.Numeric),
        new JdeField("IFPPL4", "IFPPL4", JdeDataType.Numeric),
        new JdeField("IFTQL4", "IFTQL4", JdeDataType.Numeric),
        new JdeField("IFEQL4", "IFEQL4", JdeDataType.String, 10),
        new JdeField("IFHPL4", "IFHPL4", JdeDataType.Numeric),
        new JdeField("IFWPL4", "IFWPL4", JdeDataType.Numeric),
        new JdeField("IFDPL4", "IFDPL4", JdeDataType.Numeric),
        new JdeField("IFCPL4", "IFCPL4", JdeDataType.Numeric),
        new JdeField("IFEPL4", "IFEPL4", JdeDataType.Numeric),
        new JdeField("IFUML5", "IFUML5", JdeDataType.String, 4),
        new JdeField("IFUGL5", "IFUGL5", JdeDataType.String, 4),
        new JdeField("IFEUL5", "IFEUL5", JdeDataType.String, 2),
        new JdeField("IFQPL5", "IFQPL5", JdeDataType.Numeric),
        new JdeField("IFTQL5", "IFTQL5", JdeDataType.Numeric),
        new JdeField("IFEQL5", "IFEQL5", JdeDataType.String, 10),
        new JdeField("IFHPL5", "IFHPL5", JdeDataType.Numeric),
        new JdeField("IFWPL5", "IFWPL5", JdeDataType.Numeric),
        new JdeField("IFDPL5", "IFDPL5", JdeDataType.Numeric),
        new JdeField("IFCPL5", "IFCPL5", JdeDataType.Numeric),
        new JdeField("IFEPL5", "IFEPL5", JdeDataType.Numeric),
        new JdeField("IFUOM1", "IFUOM1", JdeDataType.String, 4),
        new JdeField("IFTQTY", "IFTQTY", JdeDataType.Numeric),
        new JdeField("IFHCOM", "IFHCOM", JdeDataType.Numeric),
        new JdeField("IFQTRI", "IFQTRI", JdeDataType.Numeric),
        new JdeField("IFQTRO", "IFQTRO", JdeDataType.Numeric),
        new JdeField("IFCUBE", "IFCUBE", JdeDataType.Numeric),
        new JdeField("IFRCUB", "IFRCUB", JdeDataType.Numeric),
        new JdeField("IFVUMD", "IFVUMD", JdeDataType.String, 4),
        new JdeField("IFWEIT", "IFWEIT", JdeDataType.Numeric),
        new JdeField("IFRWET", "IFRWET", JdeDataType.Numeric),
        new JdeField("IFUWUM", "IFUWUM", JdeDataType.String, 4),
        new JdeField("IFRCDJ", "IFRCDJ", JdeDataType.Numeric),
        new JdeField("IFMMEJ", "IFMMEJ", JdeDataType.Numeric),
        new JdeField("IFDOCO", "IFDOCO", JdeDataType.Numeric),
        new JdeField("IFDCTO", "IFDCTO", JdeDataType.String, 4),
        new JdeField("IFKCOO", "IFKCOO", JdeDataType.String, 10),
        new JdeField("IFLNID", "IFLNID", JdeDataType.Numeric),
        new JdeField("IFSFXO", "IFSFXO", JdeDataType.String, 6),
        new JdeField("IFNLIN", "IFNLIN", JdeDataType.Numeric),
        new JdeField("IFUSER", "IFUSER", JdeDataType.String, 20),
        new JdeField("IFPID", "IFPID", JdeDataType.String, 20),
        new JdeField("IFJOBN", "IFJOBN", JdeDataType.String, 20),
        new JdeField("IFUPMJ", "IFUPMJ", JdeDataType.Numeric),
        new JdeField("IFTDAY", "IFTDAY", JdeDataType.Numeric),
        new JdeField("IFUOM2", "IFUOM2", JdeDataType.String, 4),
        new JdeField("IFDQTY", "IFDQTY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4602_0", "Primary Key on IFITM, IFMCU, IFLOCN, IFLOTN, IFLDSQ", new[] { "IFITM", "IFMCU", "IFLOCN", "IFLOTN", "IFLDSQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4602_10", "Index on IFITM, IFMCU, IFUGL2", new[] { "IFITM", "IFMCU", "IFUGL2" }),
        new JdeIndex("F4602_11", "Index on IFITM, IFMCU, IFUGL3", new[] { "IFITM", "IFMCU", "IFUGL3" }),
        new JdeIndex("F4602_12", "Index on IFITM, IFMCU, IFUGL4", new[] { "IFITM", "IFMCU", "IFUGL4" }),
        new JdeIndex("F4602_13", "Index on IFITM, IFMCU, IFUGL5", new[] { "IFITM", "IFMCU", "IFUGL5" }),
        new JdeIndex("F4602_14", "Index on IFSTUN", new[] { "IFSTUN" }),
        new JdeIndex("F4602_15", "Index on IFMCU, IFLOCN, IFITM, IFUML1, IFEQL1", new[] { "IFMCU", "IFLOCN", "IFITM", "IFUML1", "IFEQL1" }),
        new JdeIndex("F4602_16", "Index on IFDOCO, IFDCTO, IFKCOO, IFSFXO, IFLNID, IFNLIN", new[] { "IFDOCO", "IFDCTO", "IFKCOO", "IFSFXO", "IFLNID", "IFNLIN" }),
        new JdeIndex("F4602_17", "Index on IFMCU, IFITM, IFSTUN, IFLOCN, IFLOTN", new[] { "IFMCU", "IFITM", "IFSTUN", "IFLOCN", "IFLOTN" }),
        new JdeIndex("F4602_2", "Index on IFMCU, IFITM, IFLOCN, IFLOTN, IFUML1", new[] { "IFMCU", "IFITM", "IFLOCN", "IFLOTN", "IFUML1" }),
        new JdeIndex("F4602_3", "Index on IFMCU, IFITM, IFLOCN, IFLOTN, IFUGL1", new[] { "IFMCU", "IFITM", "IFLOCN", "IFLOTN", "IFUGL1" }),
        new JdeIndex("F4602_4", "Index on IFITM, IFMCU, IFUML1, IFPPL1", new[] { "IFITM", "IFMCU", "IFUML1", "IFPPL1" }),
        new JdeIndex("F4602_5", "Index on IFITM, IFMCU, IFUML2, IFPPL2", new[] { "IFITM", "IFMCU", "IFUML2", "IFPPL2" }),
        new JdeIndex("F4602_6", "Index on IFITM, IFMCU, IFUML3, IFPPL3", new[] { "IFITM", "IFMCU", "IFUML3", "IFPPL3" }),
        new JdeIndex("F4602_7", "Index on IFITM, IFMCU, IFUML4, IFPPL4", new[] { "IFITM", "IFMCU", "IFUML4", "IFPPL4" }),
        new JdeIndex("F4602_8", "Index on IFITM, IFMCU, IFUML5", new[] { "IFITM", "IFMCU", "IFUML5" }),
        new JdeIndex("F4602_9", "Index on IFITM, IFMCU, IFUGL1", new[] { "IFITM", "IFMCU", "IFUGL1" })
    };
}
