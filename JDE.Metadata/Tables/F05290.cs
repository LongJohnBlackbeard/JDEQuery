using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F05290 - .
/// </summary>
public class F05290 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JRPOST.
        /// </summary>
        public const string JRPOST = "JRPOST";

        /// <summary>
        /// JRUSER.
        /// </summary>
        public const string JRUSER = "JRUSER";

        /// <summary>
        /// JRANI.
        /// </summary>
        public const string JRANI = "JRANI";

        /// <summary>
        /// JRCTRY.
        /// </summary>
        public const string JRCTRY = "JRCTRY";

        /// <summary>
        /// JRFY.
        /// </summary>
        public const string JRFY = "JRFY";

        /// <summary>
        /// JRCO.
        /// </summary>
        public const string JRCO = "JRCO";

        /// <summary>
        /// JRLT.
        /// </summary>
        public const string JRLT = "JRLT";

        /// <summary>
        /// JRSBL.
        /// </summary>
        public const string JRSBL = "JRSBL";

        /// <summary>
        /// JRAM.
        /// </summary>
        public const string JRAM = "JRAM";

        /// <summary>
        /// JRR1.
        /// </summary>
        public const string JRR1 = "JRR1";

        /// <summary>
        /// JRR2.
        /// </summary>
        public const string JRR2 = "JRR2";

        /// <summary>
        /// JRDCT.
        /// </summary>
        public const string JRDCT = "JRDCT";

        /// <summary>
        /// JRAN8.
        /// </summary>
        public const string JRAN8 = "JRAN8";

        /// <summary>
        /// JRASID.
        /// </summary>
        public const string JRASID = "JRASID";

        /// <summary>
        /// JRDGJ.
        /// </summary>
        public const string JRDGJ = "JRDGJ";

        /// <summary>
        /// JRPN.
        /// </summary>
        public const string JRPN = "JRPN";

        /// <summary>
        /// JREXA.
        /// </summary>
        public const string JREXA = "JREXA";

        /// <summary>
        /// JREXR.
        /// </summary>
        public const string JREXR = "JREXR";

        /// <summary>
        /// JRAA.
        /// </summary>
        public const string JRAA = "JRAA";

        /// <summary>
        /// JRU.
        /// </summary>
        public const string JRU = "JRU";

        /// <summary>
        /// JRJELN.
        /// </summary>
        public const string JRJELN = "JRJELN";

        /// <summary>
        /// JRMCU.
        /// </summary>
        public const string JRMCU = "JRMCU";

        /// <summary>
        /// JROBJ.
        /// </summary>
        public const string JROBJ = "JROBJ";

        /// <summary>
        /// JRSUB.
        /// </summary>
        public const string JRSUB = "JRSUB";

        /// <summary>
        /// JRSBLT.
        /// </summary>
        public const string JRSBLT = "JRSBLT";

        /// <summary>
        /// JRWR01.
        /// </summary>
        public const string JRWR01 = "JRWR01";

        /// <summary>
        /// JRJBCD.
        /// </summary>
        public const string JRJBCD = "JRJBCD";

        /// <summary>
        /// JRJBST.
        /// </summary>
        public const string JRJBST = "JRJBST";

        /// <summary>
        /// JRHMCU.
        /// </summary>
        public const string JRHMCU = "JRHMCU";

        /// <summary>
        /// JRCRCD.
        /// </summary>
        public const string JRCRCD = "JRCRCD";

        /// <summary>
        /// JRCRR.
        /// </summary>
        public const string JRCRR = "JRCRR";

        /// <summary>
        /// JRPID.
        /// </summary>
        public const string JRPID = "JRPID";

        /// <summary>
        /// JRUPMJ.
        /// </summary>
        public const string JRUPMJ = "JRUPMJ";

        /// <summary>
        /// JRKCO.
        /// </summary>
        public const string JRKCO = "JRKCO";

        /// <summary>
        /// JRICU.
        /// </summary>
        public const string JRICU = "JRICU";

        /// <summary>
        /// JROLND.
        /// </summary>
        public const string JROLND = "JROLND";

        /// <summary>
        /// JRPDBA.
        /// </summary>
        public const string JRPDBA = "JRPDBA";

        /// <summary>
        /// JRPRJE.
        /// </summary>
        public const string JRPRJE = "JRPRJE";

        /// <summary>
        /// JRACR.
        /// </summary>
        public const string JRACR = "JRACR";

        /// <summary>
        /// JRCRDC.
        /// </summary>
        public const string JRCRDC = "JRCRDC";

        /// <summary>
        /// JRCRRM.
        /// </summary>
        public const string JRCRRM = "JRCRRM";

        /// <summary>
        /// JRLDED.
        /// </summary>
        public const string JRLDED = "JRLDED";

        /// <summary>
        /// JREPGC.
        /// </summary>
        public const string JREPGC = "JREPGC";

        /// <summary>
        /// JRJPGC.
        /// </summary>
        public const string JRJPGC = "JRJPGC";

        /// <summary>
        /// JRPJRDT01.
        /// </summary>
        public const string JRPJRDT01 = "JRPJRDT01";

        /// <summary>
        /// JRPJRDT02.
        /// </summary>
        public const string JRPJRDT02 = "JRPJRDT02";

        /// <summary>
        /// JRPJRDT03.
        /// </summary>
        public const string JRPJRDT03 = "JRPJRDT03";

        /// <summary>
        /// JRPJRMN01.
        /// </summary>
        public const string JRPJRMN01 = "JRPJRMN01";

        /// <summary>
        /// JRPJRMN02.
        /// </summary>
        public const string JRPJRMN02 = "JRPJRMN02";

        /// <summary>
        /// JRPJRMN03.
        /// </summary>
        public const string JRPJRMN03 = "JRPJRMN03";

        /// <summary>
        /// JRPJRMN04.
        /// </summary>
        public const string JRPJRMN04 = "JRPJRMN04";

        /// <summary>
        /// JRPJRST01.
        /// </summary>
        public const string JRPJRST01 = "JRPJRST01";

        /// <summary>
        /// JRPJRST02.
        /// </summary>
        public const string JRPJRST02 = "JRPJRST02";

        /// <summary>
        /// JRPJRST03.
        /// </summary>
        public const string JRPJRST03 = "JRPJRST03";

        /// <summary>
        /// JRPJRST04.
        /// </summary>
        public const string JRPJRST04 = "JRPJRST04";

        /// <summary>
        /// JRPJRST05.
        /// </summary>
        public const string JRPJRST05 = "JRPJRST05";

        /// <summary>
        /// JRPJRST06.
        /// </summary>
        public const string JRPJRST06 = "JRPJRST06";

        /// <summary>
        /// JRPJRCH01.
        /// </summary>
        public const string JRPJRCH01 = "JRPJRCH01";

        /// <summary>
        /// JRPJRCH02.
        /// </summary>
        public const string JRPJRCH02 = "JRPJRCH02";

        /// <summary>
        /// JRPJRCH03.
        /// </summary>
        public const string JRPJRCH03 = "JRPJRCH03";

        /// <summary>
        /// JRPJRCH04.
        /// </summary>
        public const string JRPJRCH04 = "JRPJRCH04";

        /// <summary>
        /// JRACTB.
        /// </summary>
        public const string JRACTB = "JRACTB";

        /// <summary>
        /// JRABR1.
        /// </summary>
        public const string JRABR1 = "JRABR1";

        /// <summary>
        /// JRABR2.
        /// </summary>
        public const string JRABR2 = "JRABR2";

        /// <summary>
        /// JRABR3.
        /// </summary>
        public const string JRABR3 = "JRABR3";

        /// <summary>
        /// JRABR4.
        /// </summary>
        public const string JRABR4 = "JRABR4";

        /// <summary>
        /// JRABT1.
        /// </summary>
        public const string JRABT1 = "JRABT1";

        /// <summary>
        /// JRABT2.
        /// </summary>
        public const string JRABT2 = "JRABT2";

        /// <summary>
        /// JRABT3.
        /// </summary>
        public const string JRABT3 = "JRABT3";

        /// <summary>
        /// JRABT4.
        /// </summary>
        public const string JRABT4 = "JRABT4";
    }

    /// <inheritdoc />
    public override string TableName => "F05290";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JRPOST", "JRPOST", JdeDataType.String, 2),
        new JdeField("JRUSER", "JRUSER", JdeDataType.String, 20),
        new JdeField("JRANI", "JRANI", JdeDataType.String, 58),
        new JdeField("JRCTRY", "JRCTRY", JdeDataType.Numeric),
        new JdeField("JRFY", "JRFY", JdeDataType.Numeric),
        new JdeField("JRCO", "JRCO", JdeDataType.String, 10),
        new JdeField("JRLT", "JRLT", JdeDataType.String, 4),
        new JdeField("JRSBL", "JRSBL", JdeDataType.String, 16),
        new JdeField("JRAM", "JRAM", JdeDataType.String, 2),
        new JdeField("JRR1", "JRR1", JdeDataType.String, 16),
        new JdeField("JRR2", "JRR2", JdeDataType.String, 16),
        new JdeField("JRDCT", "JRDCT", JdeDataType.String, 4),
        new JdeField("JRAN8", "JRAN8", JdeDataType.Numeric),
        new JdeField("JRASID", "JRASID", JdeDataType.String, 50),
        new JdeField("JRDGJ", "JRDGJ", JdeDataType.Numeric),
        new JdeField("JRPN", "JRPN", JdeDataType.Numeric),
        new JdeField("JREXA", "JREXA", JdeDataType.String, 60),
        new JdeField("JREXR", "JREXR", JdeDataType.String, 60),
        new JdeField("JRAA", "JRAA", JdeDataType.Numeric),
        new JdeField("JRU", "JRU", JdeDataType.Numeric),
        new JdeField("JRJELN", "JRJELN", JdeDataType.Numeric),
        new JdeField("JRMCU", "JRMCU", JdeDataType.String, 24),
        new JdeField("JROBJ", "JROBJ", JdeDataType.String, 12),
        new JdeField("JRSUB", "JRSUB", JdeDataType.String, 16),
        new JdeField("JRSBLT", "JRSBLT", JdeDataType.String, 2),
        new JdeField("JRWR01", "JRWR01", JdeDataType.String, 8),
        new JdeField("JRJBCD", "JRJBCD", JdeDataType.String, 12),
        new JdeField("JRJBST", "JRJBST", JdeDataType.String, 8),
        new JdeField("JRHMCU", "JRHMCU", JdeDataType.String, 24),
        new JdeField("JRCRCD", "JRCRCD", JdeDataType.String, 6),
        new JdeField("JRCRR", "JRCRR", JdeDataType.Numeric),
        new JdeField("JRPID", "JRPID", JdeDataType.String, 20),
        new JdeField("JRUPMJ", "JRUPMJ", JdeDataType.Numeric),
        new JdeField("JRKCO", "JRKCO", JdeDataType.String, 10),
        new JdeField("JRICU", "JRICU", JdeDataType.Numeric, null, true, true),
        new JdeField("JROLND", "JROLND", JdeDataType.Numeric, null, true, true),
        new JdeField("JRPDBA", "JRPDBA", JdeDataType.Numeric),
        new JdeField("JRPRJE", "JRPRJE", JdeDataType.String, 4),
        new JdeField("JRACR", "JRACR", JdeDataType.Numeric),
        new JdeField("JRCRDC", "JRCRDC", JdeDataType.String, 6),
        new JdeField("JRCRRM", "JRCRRM", JdeDataType.String, 2),
        new JdeField("JRLDED", "JRLDED", JdeDataType.Numeric),
        new JdeField("JREPGC", "JREPGC", JdeDataType.String, 6),
        new JdeField("JRJPGC", "JRJPGC", JdeDataType.String, 6),
        new JdeField("JRPJRDT01", "JRPJRDT01", JdeDataType.Numeric),
        new JdeField("JRPJRDT02", "JRPJRDT02", JdeDataType.Numeric),
        new JdeField("JRPJRDT03", "JRPJRDT03", JdeDataType.Numeric),
        new JdeField("JRPJRMN01", "JRPJRMN01", JdeDataType.Numeric),
        new JdeField("JRPJRMN02", "JRPJRMN02", JdeDataType.Numeric),
        new JdeField("JRPJRMN03", "JRPJRMN03", JdeDataType.Numeric),
        new JdeField("JRPJRMN04", "JRPJRMN04", JdeDataType.Numeric),
        new JdeField("JRPJRST01", "JRPJRST01", JdeDataType.String, 20),
        new JdeField("JRPJRST02", "JRPJRST02", JdeDataType.String, 20),
        new JdeField("JRPJRST03", "JRPJRST03", JdeDataType.String, 20),
        new JdeField("JRPJRST04", "JRPJRST04", JdeDataType.String, 20),
        new JdeField("JRPJRST05", "JRPJRST05", JdeDataType.String, 40),
        new JdeField("JRPJRST06", "JRPJRST06", JdeDataType.String, 40),
        new JdeField("JRPJRCH01", "JRPJRCH01", JdeDataType.String, 2),
        new JdeField("JRPJRCH02", "JRPJRCH02", JdeDataType.String, 2),
        new JdeField("JRPJRCH03", "JRPJRCH03", JdeDataType.String, 2),
        new JdeField("JRPJRCH04", "JRPJRCH04", JdeDataType.String, 2),
        new JdeField("JRACTB", "JRACTB", JdeDataType.String, 20),
        new JdeField("JRABR1", "JRABR1", JdeDataType.String, 24),
        new JdeField("JRABR2", "JRABR2", JdeDataType.String, 24),
        new JdeField("JRABR3", "JRABR3", JdeDataType.String, 24),
        new JdeField("JRABR4", "JRABR4", JdeDataType.String, 24),
        new JdeField("JRABT1", "JRABT1", JdeDataType.String, 2),
        new JdeField("JRABT2", "JRABT2", JdeDataType.String, 2),
        new JdeField("JRABT3", "JRABT3", JdeDataType.String, 2),
        new JdeField("JRABT4", "JRABT4", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F05290_0", "Primary Key on JRICU, JROLND", new[] { "JRICU", "JROLND" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F05290_2", "Index on JRICU, JRCO, JRCTRY, JRFY, JRPN, JRDCT, JRPRJE, JROLND", new[] { "JRICU", "JRCO", "JRCTRY", "JRFY", "JRPN", "JRDCT", "JRPRJE", "JROLND" })
    };
}
