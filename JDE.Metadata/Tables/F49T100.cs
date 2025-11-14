using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49T100 - .
/// </summary>
public class F49T100 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OBORDNUMID.
        /// </summary>
        public const string OBORDNUMID = "OBORDNUMID";

        /// <summary>
        /// OBORDDETID.
        /// </summary>
        public const string OBORDDETID = "OBORDDETID";

        /// <summary>
        /// OBOTTRNCOD.
        /// </summary>
        public const string OBOTTRNCOD = "OBOTTRNCOD";

        /// <summary>
        /// OBOTDOMAIN.
        /// </summary>
        public const string OBOTDOMAIN = "OBOTDOMAIN";

        /// <summary>
        /// OBOBRCDTYP.
        /// </summary>
        public const string OBOBRCDTYP = "OBOBRCDTYP";

        /// <summary>
        /// OBDESC.
        /// </summary>
        public const string OBDESC = "OBDESC";

        /// <summary>
        /// OBDEL1.
        /// </summary>
        public const string OBDEL1 = "OBDEL1";

        /// <summary>
        /// OBDEL2.
        /// </summary>
        public const string OBDEL2 = "OBDEL2";

        /// <summary>
        /// OBMCU.
        /// </summary>
        public const string OBMCU = "OBMCU";

        /// <summary>
        /// OBAN8.
        /// </summary>
        public const string OBAN8 = "OBAN8";

        /// <summary>
        /// OBSHAN.
        /// </summary>
        public const string OBSHAN = "OBSHAN";

        /// <summary>
        /// OBOTITMDOM.
        /// </summary>
        public const string OBOTITMDOM = "OBOTITMDOM";

        /// <summary>
        /// OBOTITEMID.
        /// </summary>
        public const string OBOTITEMID = "OBOTITEMID";

        /// <summary>
        /// OBOTPKGITM.
        /// </summary>
        public const string OBOTPKGITM = "OBOTPKGITM";

        /// <summary>
        /// OBITVL.
        /// </summary>
        public const string OBITVL = "OBITVL";

        /// <summary>
        /// OBVLUM.
        /// </summary>
        public const string OBVLUM = "OBVLUM";

        /// <summary>
        /// OBITWT.
        /// </summary>
        public const string OBITWT = "OBITWT";

        /// <summary>
        /// OBWTUM.
        /// </summary>
        public const string OBWTUM = "OBWTUM";

        /// <summary>
        /// OBUOPN.
        /// </summary>
        public const string OBUOPN = "OBUOPN";

        /// <summary>
        /// OBCRCD.
        /// </summary>
        public const string OBCRCD = "OBCRCD";

        /// <summary>
        /// OBAOPN.
        /// </summary>
        public const string OBAOPN = "OBAOPN";

        /// <summary>
        /// OBANBY.
        /// </summary>
        public const string OBANBY = "OBANBY";

        /// <summary>
        /// OBVR01.
        /// </summary>
        public const string OBVR01 = "OBVR01";

        /// <summary>
        /// OBVR02.
        /// </summary>
        public const string OBVR02 = "OBVR02";

        /// <summary>
        /// OBVR03.
        /// </summary>
        public const string OBVR03 = "OBVR03";

        /// <summary>
        /// OBVR04.
        /// </summary>
        public const string OBVR04 = "OBVR04";

        /// <summary>
        /// OBVR05.
        /// </summary>
        public const string OBVR05 = "OBVR05";

        /// <summary>
        /// OBDSC1.
        /// </summary>
        public const string OBDSC1 = "OBDSC1";

        /// <summary>
        /// OBDSC2.
        /// </summary>
        public const string OBDSC2 = "OBDSC2";

        /// <summary>
        /// OBCNDJ.
        /// </summary>
        public const string OBCNDJ = "OBCNDJ";

        /// <summary>
        /// OBOTERLDDT.
        /// </summary>
        public const string OBOTERLDDT = "OBOTERLDDT";

        /// <summary>
        /// OBOTERLPDT.
        /// </summary>
        public const string OBOTERLPDT = "OBOTERLPDT";

        /// <summary>
        /// OBOTLATDDT.
        /// </summary>
        public const string OBOTLATDDT = "OBOTLATDDT";

        /// <summary>
        /// OBOTLATPDT.
        /// </summary>
        public const string OBOTLATPDT = "OBOTLATPDT";

        /// <summary>
        /// OBOTGSOBTY.
        /// </summary>
        public const string OBOTGSOBTY = "OBOTGSOBTY";

        /// <summary>
        /// OBOTGSSTTY.
        /// </summary>
        public const string OBOTGSSTTY = "OBOTGSSTTY";

        /// <summary>
        /// OBOTSTSVAL.
        /// </summary>
        public const string OBOTSTSVAL = "OBOTSTSVAL";

        /// <summary>
        /// OBRORNUMID.
        /// </summary>
        public const string OBRORNUMID = "OBRORNUMID";

        /// <summary>
        /// OBRECLOCK.
        /// </summary>
        public const string OBRECLOCK = "OBRECLOCK";

        /// <summary>
        /// OBOTE1REF1.
        /// </summary>
        public const string OBOTE1REF1 = "OBOTE1REF1";

        /// <summary>
        /// OBOTE1REF2.
        /// </summary>
        public const string OBOTE1REF2 = "OBOTE1REF2";

        /// <summary>
        /// OBOTE1REF3.
        /// </summary>
        public const string OBOTE1REF3 = "OBOTE1REF3";

        /// <summary>
        /// OBOTE1REF4.
        /// </summary>
        public const string OBOTE1REF4 = "OBOTE1REF4";

        /// <summary>
        /// OBOTE1REF5.
        /// </summary>
        public const string OBOTE1REF5 = "OBOTE1REF5";

        /// <summary>
        /// OBOTE1REF6.
        /// </summary>
        public const string OBOTE1REF6 = "OBOTE1REF6";

        /// <summary>
        /// OBOTE1REF7.
        /// </summary>
        public const string OBOTE1REF7 = "OBOTE1REF7";

        /// <summary>
        /// OBOTE1REF8.
        /// </summary>
        public const string OBOTE1REF8 = "OBOTE1REF8";

        /// <summary>
        /// OBOTE1REF9.
        /// </summary>
        public const string OBOTE1REF9 = "OBOTE1REF9";

        /// <summary>
        /// OBOTE1REF10.
        /// </summary>
        public const string OBOTE1REF10 = "OBOTE1REF10";

        /// <summary>
        /// OBOTCHAR1.
        /// </summary>
        public const string OBOTCHAR1 = "OBOTCHAR1";

        /// <summary>
        /// OBOTCHAR2.
        /// </summary>
        public const string OBOTCHAR2 = "OBOTCHAR2";

        /// <summary>
        /// OBOTCHAR3.
        /// </summary>
        public const string OBOTCHAR3 = "OBOTCHAR3";

        /// <summary>
        /// OBOTMATH1.
        /// </summary>
        public const string OBOTMATH1 = "OBOTMATH1";

        /// <summary>
        /// OBOTMATH2.
        /// </summary>
        public const string OBOTMATH2 = "OBOTMATH2";

        /// <summary>
        /// OBOTMATH3.
        /// </summary>
        public const string OBOTMATH3 = "OBOTMATH3";

        /// <summary>
        /// OBURCD.
        /// </summary>
        public const string OBURCD = "OBURCD";

        /// <summary>
        /// OBURDT.
        /// </summary>
        public const string OBURDT = "OBURDT";

        /// <summary>
        /// OBURRF.
        /// </summary>
        public const string OBURRF = "OBURRF";

        /// <summary>
        /// OBURAT.
        /// </summary>
        public const string OBURAT = "OBURAT";

        /// <summary>
        /// OBURAB.
        /// </summary>
        public const string OBURAB = "OBURAB";

        /// <summary>
        /// OBOTMOTDOM.
        /// </summary>
        public const string OBOTMOTDOM = "OBOTMOTDOM";

        /// <summary>
        /// OBOTCARDOM.
        /// </summary>
        public const string OBOTCARDOM = "OBOTCARDOM";

        /// <summary>
        /// OBUSER.
        /// </summary>
        public const string OBUSER = "OBUSER";

        /// <summary>
        /// OBPID.
        /// </summary>
        public const string OBPID = "OBPID";

        /// <summary>
        /// OBTORG.
        /// </summary>
        public const string OBTORG = "OBTORG";

        /// <summary>
        /// OBJOBN.
        /// </summary>
        public const string OBJOBN = "OBJOBN";

        /// <summary>
        /// OBUUPMJ.
        /// </summary>
        public const string OBUUPMJ = "OBUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F49T100";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OBORDNUMID", "OBORDNUMID", JdeDataType.String, 60, true, true),
        new JdeField("OBORDDETID", "OBORDDETID", JdeDataType.String, 100, true, true),
        new JdeField("OBOTTRNCOD", "OBOTTRNCOD", JdeDataType.String, 4),
        new JdeField("OBOTDOMAIN", "OBOTDOMAIN", JdeDataType.String, 100),
        new JdeField("OBOBRCDTYP", "OBOBRCDTYP", JdeDataType.String, 2),
        new JdeField("OBDESC", "OBDESC", JdeDataType.String, 60),
        new JdeField("OBDEL1", "OBDEL1", JdeDataType.String, 60),
        new JdeField("OBDEL2", "OBDEL2", JdeDataType.String, 60),
        new JdeField("OBMCU", "OBMCU", JdeDataType.String, 24),
        new JdeField("OBAN8", "OBAN8", JdeDataType.Numeric),
        new JdeField("OBSHAN", "OBSHAN", JdeDataType.Numeric),
        new JdeField("OBOTITMDOM", "OBOTITMDOM", JdeDataType.String, 100),
        new JdeField("OBOTITEMID", "OBOTITEMID", JdeDataType.String, 100),
        new JdeField("OBOTPKGITM", "OBOTPKGITM", JdeDataType.String, 100),
        new JdeField("OBITVL", "OBITVL", JdeDataType.Numeric),
        new JdeField("OBVLUM", "OBVLUM", JdeDataType.String, 4),
        new JdeField("OBITWT", "OBITWT", JdeDataType.Numeric),
        new JdeField("OBWTUM", "OBWTUM", JdeDataType.String, 4),
        new JdeField("OBUOPN", "OBUOPN", JdeDataType.Numeric),
        new JdeField("OBCRCD", "OBCRCD", JdeDataType.String, 6),
        new JdeField("OBAOPN", "OBAOPN", JdeDataType.Numeric),
        new JdeField("OBANBY", "OBANBY", JdeDataType.Numeric),
        new JdeField("OBVR01", "OBVR01", JdeDataType.String, 50),
        new JdeField("OBVR02", "OBVR02", JdeDataType.String, 50),
        new JdeField("OBVR03", "OBVR03", JdeDataType.String, 50),
        new JdeField("OBVR04", "OBVR04", JdeDataType.String, 50),
        new JdeField("OBVR05", "OBVR05", JdeDataType.String, 50),
        new JdeField("OBDSC1", "OBDSC1", JdeDataType.String, 60),
        new JdeField("OBDSC2", "OBDSC2", JdeDataType.String, 60),
        new JdeField("OBCNDJ", "OBCNDJ", JdeDataType.Numeric),
        new JdeField("OBOTERLDDT", "OBOTERLDDT", JdeDataType.Date),
        new JdeField("OBOTERLPDT", "OBOTERLPDT", JdeDataType.Date),
        new JdeField("OBOTLATDDT", "OBOTLATDDT", JdeDataType.Date),
        new JdeField("OBOTLATPDT", "OBOTLATPDT", JdeDataType.Date),
        new JdeField("OBOTGSOBTY", "OBOTGSOBTY", JdeDataType.String, 160),
        new JdeField("OBOTGSSTTY", "OBOTGSSTTY", JdeDataType.String, 100),
        new JdeField("OBOTSTSVAL", "OBOTSTSVAL", JdeDataType.String, 100),
        new JdeField("OBRORNUMID", "OBRORNUMID", JdeDataType.String, 60),
        new JdeField("OBRECLOCK", "OBRECLOCK", JdeDataType.String, 2),
        new JdeField("OBOTE1REF1", "OBOTE1REF1", JdeDataType.String, 100),
        new JdeField("OBOTE1REF2", "OBOTE1REF2", JdeDataType.String, 100),
        new JdeField("OBOTE1REF3", "OBOTE1REF3", JdeDataType.String, 100),
        new JdeField("OBOTE1REF4", "OBOTE1REF4", JdeDataType.String, 100),
        new JdeField("OBOTE1REF5", "OBOTE1REF5", JdeDataType.String, 100),
        new JdeField("OBOTE1REF6", "OBOTE1REF6", JdeDataType.String, 100),
        new JdeField("OBOTE1REF7", "OBOTE1REF7", JdeDataType.String, 100),
        new JdeField("OBOTE1REF8", "OBOTE1REF8", JdeDataType.String, 100),
        new JdeField("OBOTE1REF9", "OBOTE1REF9", JdeDataType.String, 100),
        new JdeField("OBOTE1REF10", "OBOTE1REF10", JdeDataType.String, 100),
        new JdeField("OBOTCHAR1", "OBOTCHAR1", JdeDataType.String, 2),
        new JdeField("OBOTCHAR2", "OBOTCHAR2", JdeDataType.String, 2),
        new JdeField("OBOTCHAR3", "OBOTCHAR3", JdeDataType.String, 2),
        new JdeField("OBOTMATH1", "OBOTMATH1", JdeDataType.Numeric),
        new JdeField("OBOTMATH2", "OBOTMATH2", JdeDataType.Numeric),
        new JdeField("OBOTMATH3", "OBOTMATH3", JdeDataType.Numeric),
        new JdeField("OBURCD", "OBURCD", JdeDataType.String, 4),
        new JdeField("OBURDT", "OBURDT", JdeDataType.Numeric),
        new JdeField("OBURRF", "OBURRF", JdeDataType.String, 30),
        new JdeField("OBURAT", "OBURAT", JdeDataType.Numeric),
        new JdeField("OBURAB", "OBURAB", JdeDataType.Numeric),
        new JdeField("OBOTMOTDOM", "OBOTMOTDOM", JdeDataType.String, 100),
        new JdeField("OBOTCARDOM", "OBOTCARDOM", JdeDataType.String, 100),
        new JdeField("OBUSER", "OBUSER", JdeDataType.String, 20),
        new JdeField("OBPID", "OBPID", JdeDataType.String, 20),
        new JdeField("OBTORG", "OBTORG", JdeDataType.String, 20),
        new JdeField("OBJOBN", "OBJOBN", JdeDataType.String, 20),
        new JdeField("OBUUPMJ", "OBUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49T100_0", "Primary Key on OBORDNUMID, OBORDDETID", new[] { "OBORDNUMID", "OBORDDETID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F49T100_2", "Index on OBORDNUMID, OBOBRCDTYP", new[] { "OBORDNUMID", "OBOBRCDTYP" })
    };
}
