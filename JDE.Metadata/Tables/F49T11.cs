using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49T11 - .
/// </summary>
public class F49T11 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ITORDNUMID.
        /// </summary>
        public const string ITORDNUMID = "ITORDNUMID";

        /// <summary>
        /// ITOTITEMID.
        /// </summary>
        public const string ITOTITEMID = "ITOTITEMID";

        /// <summary>
        /// ITOTPKGITM.
        /// </summary>
        public const string ITOTPKGITM = "ITOTPKGITM";

        /// <summary>
        /// ITOTITMDOM.
        /// </summary>
        public const string ITOTITMDOM = "ITOTITMDOM";

        /// <summary>
        /// ITOTTRNCOD.
        /// </summary>
        public const string ITOTTRNCOD = "ITOTTRNCOD";

        /// <summary>
        /// ITLITM.
        /// </summary>
        public const string ITLITM = "ITLITM";

        /// <summary>
        /// ITAITM.
        /// </summary>
        public const string ITAITM = "ITAITM";

        /// <summary>
        /// ITDSC1.
        /// </summary>
        public const string ITDSC1 = "ITDSC1";

        /// <summary>
        /// ITFRT1.
        /// </summary>
        public const string ITFRT1 = "ITFRT1";

        /// <summary>
        /// ITFRT2.
        /// </summary>
        public const string ITFRT2 = "ITFRT2";

        /// <summary>
        /// ITOTISHAZD.
        /// </summary>
        public const string ITOTISHAZD = "ITOTISHAZD";

        /// <summary>
        /// ITNMFC.
        /// </summary>
        public const string ITNMFC = "ITNMFC";

        /// <summary>
        /// ITNMFI.
        /// </summary>
        public const string ITNMFI = "ITNMFI";

        /// <summary>
        /// ITSTCC.
        /// </summary>
        public const string ITSTCC = "ITSTCC";

        /// <summary>
        /// ITHSCD.
        /// </summary>
        public const string ITHSCD = "ITHSCD";

        /// <summary>
        /// ITPDCG.
        /// </summary>
        public const string ITPDCG = "ITPDCG";

        /// <summary>
        /// ITDMFR.
        /// </summary>
        public const string ITDMFR = "ITDMFR";

        /// <summary>
        /// ITPFCT.
        /// </summary>
        public const string ITPFCT = "ITPFCT";

        /// <summary>
        /// ITECCN.
        /// </summary>
        public const string ITECCN = "ITECCN";

        /// <summary>
        /// ITPKIN.
        /// </summary>
        public const string ITPKIN = "ITPKIN";

        /// <summary>
        /// ITUNNA.
        /// </summary>
        public const string ITUNNA = "ITUNNA";

        /// <summary>
        /// ITHZDC.
        /// </summary>
        public const string ITHZDC = "ITHZDC";

        /// <summary>
        /// ITPKGP.
        /// </summary>
        public const string ITPKGP = "ITPKGP";

        /// <summary>
        /// ITSRSK.
        /// </summary>
        public const string ITSRSK = "ITSRSK";

        /// <summary>
        /// ITFPNT.
        /// </summary>
        public const string ITFPNT = "ITFPNT";

        /// <summary>
        /// ITSTPU.
        /// </summary>
        public const string ITSTPU = "ITSTPU";

        /// <summary>
        /// ITHZDL.
        /// </summary>
        public const string ITHZDL = "ITHZDL";

        /// <summary>
        /// ITURCD.
        /// </summary>
        public const string ITURCD = "ITURCD";

        /// <summary>
        /// ITURDT.
        /// </summary>
        public const string ITURDT = "ITURDT";

        /// <summary>
        /// ITURRF.
        /// </summary>
        public const string ITURRF = "ITURRF";

        /// <summary>
        /// ITURAT.
        /// </summary>
        public const string ITURAT = "ITURAT";

        /// <summary>
        /// ITUSER.
        /// </summary>
        public const string ITUSER = "ITUSER";

        /// <summary>
        /// ITPID.
        /// </summary>
        public const string ITPID = "ITPID";

        /// <summary>
        /// ITTORG.
        /// </summary>
        public const string ITTORG = "ITTORG";

        /// <summary>
        /// ITJOBN.
        /// </summary>
        public const string ITJOBN = "ITJOBN";

        /// <summary>
        /// ITUUPMJ.
        /// </summary>
        public const string ITUUPMJ = "ITUUPMJ";

        /// <summary>
        /// ITOTE1REF1.
        /// </summary>
        public const string ITOTE1REF1 = "ITOTE1REF1";

        /// <summary>
        /// ITOTE1REF2.
        /// </summary>
        public const string ITOTE1REF2 = "ITOTE1REF2";

        /// <summary>
        /// ITOTE1REF3.
        /// </summary>
        public const string ITOTE1REF3 = "ITOTE1REF3";

        /// <summary>
        /// ITOTCHAR1.
        /// </summary>
        public const string ITOTCHAR1 = "ITOTCHAR1";

        /// <summary>
        /// ITOTCHAR2.
        /// </summary>
        public const string ITOTCHAR2 = "ITOTCHAR2";

        /// <summary>
        /// ITOTCHAR3.
        /// </summary>
        public const string ITOTCHAR3 = "ITOTCHAR3";

        /// <summary>
        /// ITOTMATH1.
        /// </summary>
        public const string ITOTMATH1 = "ITOTMATH1";

        /// <summary>
        /// ITOTMATH2.
        /// </summary>
        public const string ITOTMATH2 = "ITOTMATH2";

        /// <summary>
        /// ITOTMATH3.
        /// </summary>
        public const string ITOTMATH3 = "ITOTMATH3";
    }

    /// <inheritdoc />
    public override string TableName => "F49T11";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ITORDNUMID", "ITORDNUMID", JdeDataType.String, 60, true, true),
        new JdeField("ITOTITEMID", "ITOTITEMID", JdeDataType.String, 100, true, true),
        new JdeField("ITOTPKGITM", "ITOTPKGITM", JdeDataType.String, 100, true, true),
        new JdeField("ITOTITMDOM", "ITOTITMDOM", JdeDataType.String, 100),
        new JdeField("ITOTTRNCOD", "ITOTTRNCOD", JdeDataType.String, 4),
        new JdeField("ITLITM", "ITLITM", JdeDataType.String, 50),
        new JdeField("ITAITM", "ITAITM", JdeDataType.String, 50),
        new JdeField("ITDSC1", "ITDSC1", JdeDataType.String, 60),
        new JdeField("ITFRT1", "ITFRT1", JdeDataType.String, 12),
        new JdeField("ITFRT2", "ITFRT2", JdeDataType.String, 12),
        new JdeField("ITOTISHAZD", "ITOTISHAZD", JdeDataType.String, 2),
        new JdeField("ITNMFC", "ITNMFC", JdeDataType.String, 8),
        new JdeField("ITNMFI", "ITNMFI", JdeDataType.String, 12),
        new JdeField("ITSTCC", "ITSTCC", JdeDataType.String, 20),
        new JdeField("ITHSCD", "ITHSCD", JdeDataType.String, 24),
        new JdeField("ITPDCG", "ITPDCG", JdeDataType.String, 8),
        new JdeField("ITDMFR", "ITDMFR", JdeDataType.String, 2),
        new JdeField("ITPFCT", "ITPFCT", JdeDataType.String, 2),
        new JdeField("ITECCN", "ITECCN", JdeDataType.String, 20),
        new JdeField("ITPKIN", "ITPKIN", JdeDataType.String, 8),
        new JdeField("ITUNNA", "ITUNNA", JdeDataType.String, 12),
        new JdeField("ITHZDC", "ITHZDC", JdeDataType.String, 6),
        new JdeField("ITPKGP", "ITPKGP", JdeDataType.String, 6),
        new JdeField("ITSRSK", "ITSRSK", JdeDataType.String, 6),
        new JdeField("ITFPNT", "ITFPNT", JdeDataType.Numeric),
        new JdeField("ITSTPU", "ITSTPU", JdeDataType.String, 2),
        new JdeField("ITHZDL", "ITHZDL", JdeDataType.String, 6),
        new JdeField("ITURCD", "ITURCD", JdeDataType.String, 4),
        new JdeField("ITURDT", "ITURDT", JdeDataType.Numeric),
        new JdeField("ITURRF", "ITURRF", JdeDataType.String, 30),
        new JdeField("ITURAT", "ITURAT", JdeDataType.Numeric),
        new JdeField("ITUSER", "ITUSER", JdeDataType.String, 20),
        new JdeField("ITPID", "ITPID", JdeDataType.String, 20),
        new JdeField("ITTORG", "ITTORG", JdeDataType.String, 20),
        new JdeField("ITJOBN", "ITJOBN", JdeDataType.String, 20),
        new JdeField("ITUUPMJ", "ITUUPMJ", JdeDataType.Date),
        new JdeField("ITOTE1REF1", "ITOTE1REF1", JdeDataType.String, 100),
        new JdeField("ITOTE1REF2", "ITOTE1REF2", JdeDataType.String, 100),
        new JdeField("ITOTE1REF3", "ITOTE1REF3", JdeDataType.String, 100),
        new JdeField("ITOTCHAR1", "ITOTCHAR1", JdeDataType.String, 2),
        new JdeField("ITOTCHAR2", "ITOTCHAR2", JdeDataType.String, 2),
        new JdeField("ITOTCHAR3", "ITOTCHAR3", JdeDataType.String, 2),
        new JdeField("ITOTMATH1", "ITOTMATH1", JdeDataType.Numeric),
        new JdeField("ITOTMATH2", "ITOTMATH2", JdeDataType.Numeric),
        new JdeField("ITOTMATH3", "ITOTMATH3", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49T11_0", "Primary Key on ITORDNUMID, ITOTITEMID, ITOTPKGITM", new[] { "ITORDNUMID", "ITOTITEMID", "ITOTPKGITM" }, isUnique: true, isPrimaryKey: true)
    };
}
