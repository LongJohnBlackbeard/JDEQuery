using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49T10 - .
/// </summary>
public class F49T10 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OROTORDRLS.
        /// </summary>
        public const string OROTORDRLS = "OROTORDRLS";

        /// <summary>
        /// OROTORDRLN.
        /// </summary>
        public const string OROTORDRLN = "OROTORDRLN";

        /// <summary>
        /// ORORDNUMID.
        /// </summary>
        public const string ORORDNUMID = "ORORDNUMID";

        /// <summary>
        /// OROTTRNCOD.
        /// </summary>
        public const string OROTTRNCOD = "OROTTRNCOD";

        /// <summary>
        /// OROTDOMAIN.
        /// </summary>
        public const string OROTDOMAIN = "OROTDOMAIN";

        /// <summary>
        /// OROTMOTDOM.
        /// </summary>
        public const string OROTMOTDOM = "OROTMOTDOM";

        /// <summary>
        /// OROTCARDOM.
        /// </summary>
        public const string OROTCARDOM = "OROTCARDOM";

        /// <summary>
        /// ORORGN.
        /// </summary>
        public const string ORORGN = "ORORGN";

        /// <summary>
        /// ORSHAN.
        /// </summary>
        public const string ORSHAN = "ORSHAN";

        /// <summary>
        /// ORAN8.
        /// </summary>
        public const string ORAN8 = "ORAN8";

        /// <summary>
        /// ORINVPTQ.
        /// </summary>
        public const string ORINVPTQ = "ORINVPTQ";

        /// <summary>
        /// OROTRFQLH1.
        /// </summary>
        public const string OROTRFQLH1 = "OROTRFQLH1";

        /// <summary>
        /// ORANBY.
        /// </summary>
        public const string ORANBY = "ORANBY";

        /// <summary>
        /// ORCARS.
        /// </summary>
        public const string ORCARS = "ORCARS";

        /// <summary>
        /// ORMOT.
        /// </summary>
        public const string ORMOT = "ORMOT";

        /// <summary>
        /// ORFRTH.
        /// </summary>
        public const string ORFRTH = "ORFRTH";

        /// <summary>
        /// ORSPHD.
        /// </summary>
        public const string ORSPHD = "ORSPHD";

        /// <summary>
        /// OROTERLDDT.
        /// </summary>
        public const string OROTERLDDT = "OROTERLDDT";

        /// <summary>
        /// OROTERLPDT.
        /// </summary>
        public const string OROTERLPDT = "OROTERLPDT";

        /// <summary>
        /// OROTLATDDT.
        /// </summary>
        public const string OROTLATDDT = "OROTLATDDT";

        /// <summary>
        /// OROTLATPDT.
        /// </summary>
        public const string OROTLATPDT = "OROTLATPDT";

        /// <summary>
        /// OROTITEMID.
        /// </summary>
        public const string OROTITEMID = "OROTITEMID";

        /// <summary>
        /// OROTPKGITM.
        /// </summary>
        public const string OROTPKGITM = "OROTPKGITM";

        /// <summary>
        /// ORSOQS.
        /// </summary>
        public const string ORSOQS = "ORSOQS";

        /// <summary>
        /// ORITVL.
        /// </summary>
        public const string ORITVL = "ORITVL";

        /// <summary>
        /// ORVLUM.
        /// </summary>
        public const string ORVLUM = "ORVLUM";

        /// <summary>
        /// ORITWT.
        /// </summary>
        public const string ORITWT = "ORITWT";

        /// <summary>
        /// ORWTUM.
        /// </summary>
        public const string ORWTUM = "ORWTUM";

        /// <summary>
        /// ORAEXP.
        /// </summary>
        public const string ORAEXP = "ORAEXP";

        /// <summary>
        /// ORCRCD.
        /// </summary>
        public const string ORCRCD = "ORCRCD";

        /// <summary>
        /// ORCNDJ.
        /// </summary>
        public const string ORCNDJ = "ORCNDJ";

        /// <summary>
        /// ORRORN.
        /// </summary>
        public const string ORRORN = "ORRORN";

        /// <summary>
        /// ORRCTO.
        /// </summary>
        public const string ORRCTO = "ORRCTO";

        /// <summary>
        /// ORRKCO.
        /// </summary>
        public const string ORRKCO = "ORRKCO";

        /// <summary>
        /// ORRLLN.
        /// </summary>
        public const string ORRLLN = "ORRLLN";

        /// <summary>
        /// ORVR01.
        /// </summary>
        public const string ORVR01 = "ORVR01";

        /// <summary>
        /// ORVR02.
        /// </summary>
        public const string ORVR02 = "ORVR02";

        /// <summary>
        /// ORVR03.
        /// </summary>
        public const string ORVR03 = "ORVR03";

        /// <summary>
        /// OROTRMQUL1.
        /// </summary>
        public const string OROTRMQUL1 = "OROTRMQUL1";

        /// <summary>
        /// ORDEL1.
        /// </summary>
        public const string ORDEL1 = "ORDEL1";

        /// <summary>
        /// ORDEL2.
        /// </summary>
        public const string ORDEL2 = "ORDEL2";

        /// <summary>
        /// OROTE1REF1.
        /// </summary>
        public const string OROTE1REF1 = "OROTE1REF1";

        /// <summary>
        /// OROTE1REF2.
        /// </summary>
        public const string OROTE1REF2 = "OROTE1REF2";

        /// <summary>
        /// OROTE1REF3.
        /// </summary>
        public const string OROTE1REF3 = "OROTE1REF3";

        /// <summary>
        /// OROTE1REF4.
        /// </summary>
        public const string OROTE1REF4 = "OROTE1REF4";

        /// <summary>
        /// OROTE1REF5.
        /// </summary>
        public const string OROTE1REF5 = "OROTE1REF5";

        /// <summary>
        /// OROTE1REF6.
        /// </summary>
        public const string OROTE1REF6 = "OROTE1REF6";

        /// <summary>
        /// OROTE1REF7.
        /// </summary>
        public const string OROTE1REF7 = "OROTE1REF7";

        /// <summary>
        /// OROTE1REF8.
        /// </summary>
        public const string OROTE1REF8 = "OROTE1REF8";

        /// <summary>
        /// OROTE1REF9.
        /// </summary>
        public const string OROTE1REF9 = "OROTE1REF9";

        /// <summary>
        /// OROTE1REF10.
        /// </summary>
        public const string OROTE1REF10 = "OROTE1REF10";

        /// <summary>
        /// OROTCHAR1.
        /// </summary>
        public const string OROTCHAR1 = "OROTCHAR1";

        /// <summary>
        /// OROTCHAR2.
        /// </summary>
        public const string OROTCHAR2 = "OROTCHAR2";

        /// <summary>
        /// OROTCHAR3.
        /// </summary>
        public const string OROTCHAR3 = "OROTCHAR3";

        /// <summary>
        /// OROTMATH1.
        /// </summary>
        public const string OROTMATH1 = "OROTMATH1";

        /// <summary>
        /// OROTMATH2.
        /// </summary>
        public const string OROTMATH2 = "OROTMATH2";

        /// <summary>
        /// OROTMATH3.
        /// </summary>
        public const string OROTMATH3 = "OROTMATH3";

        /// <summary>
        /// ORURCD.
        /// </summary>
        public const string ORURCD = "ORURCD";

        /// <summary>
        /// ORURDT.
        /// </summary>
        public const string ORURDT = "ORURDT";

        /// <summary>
        /// ORURRF.
        /// </summary>
        public const string ORURRF = "ORURRF";

        /// <summary>
        /// ORURAT.
        /// </summary>
        public const string ORURAT = "ORURAT";

        /// <summary>
        /// ORURAB.
        /// </summary>
        public const string ORURAB = "ORURAB";

        /// <summary>
        /// ORUSER.
        /// </summary>
        public const string ORUSER = "ORUSER";

        /// <summary>
        /// ORPID.
        /// </summary>
        public const string ORPID = "ORPID";

        /// <summary>
        /// ORTORG.
        /// </summary>
        public const string ORTORG = "ORTORG";

        /// <summary>
        /// ORJOBN.
        /// </summary>
        public const string ORJOBN = "ORJOBN";

        /// <summary>
        /// ORUUPMJ.
        /// </summary>
        public const string ORUUPMJ = "ORUUPMJ";

        /// <summary>
        /// ORRECLOCK.
        /// </summary>
        public const string ORRECLOCK = "ORRECLOCK";

        /// <summary>
        /// OROTXFLAG.
        /// </summary>
        public const string OROTXFLAG = "OROTXFLAG";

        /// <summary>
        /// OROTIP.
        /// </summary>
        public const string OROTIP = "OROTIP";

        /// <summary>
        /// ORRORNUMID.
        /// </summary>
        public const string ORRORNUMID = "ORRORNUMID";
    }

    /// <inheritdoc />
    public override string TableName => "F49T10";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OROTORDRLS", "OROTORDRLS", JdeDataType.String, 100, true, true),
        new JdeField("OROTORDRLN", "OROTORDRLN", JdeDataType.String, 100, true, true),
        new JdeField("ORORDNUMID", "ORORDNUMID", JdeDataType.String, 60),
        new JdeField("OROTTRNCOD", "OROTTRNCOD", JdeDataType.String, 4),
        new JdeField("OROTDOMAIN", "OROTDOMAIN", JdeDataType.String, 100),
        new JdeField("OROTMOTDOM", "OROTMOTDOM", JdeDataType.String, 100),
        new JdeField("OROTCARDOM", "OROTCARDOM", JdeDataType.String, 100),
        new JdeField("ORORGN", "ORORGN", JdeDataType.Numeric),
        new JdeField("ORSHAN", "ORSHAN", JdeDataType.Numeric),
        new JdeField("ORAN8", "ORAN8", JdeDataType.Numeric),
        new JdeField("ORINVPTQ", "ORINVPTQ", JdeDataType.String, 100),
        new JdeField("OROTRFQLH1", "OROTRFQLH1", JdeDataType.String, 100),
        new JdeField("ORANBY", "ORANBY", JdeDataType.Numeric),
        new JdeField("ORCARS", "ORCARS", JdeDataType.Numeric),
        new JdeField("ORMOT", "ORMOT", JdeDataType.String, 6),
        new JdeField("ORFRTH", "ORFRTH", JdeDataType.String, 6),
        new JdeField("ORSPHD", "ORSPHD", JdeDataType.String, 20),
        new JdeField("OROTERLDDT", "OROTERLDDT", JdeDataType.Date),
        new JdeField("OROTERLPDT", "OROTERLPDT", JdeDataType.Date),
        new JdeField("OROTLATDDT", "OROTLATDDT", JdeDataType.Date),
        new JdeField("OROTLATPDT", "OROTLATPDT", JdeDataType.Date),
        new JdeField("OROTITEMID", "OROTITEMID", JdeDataType.String, 100),
        new JdeField("OROTPKGITM", "OROTPKGITM", JdeDataType.String, 100),
        new JdeField("ORSOQS", "ORSOQS", JdeDataType.Numeric),
        new JdeField("ORITVL", "ORITVL", JdeDataType.Numeric),
        new JdeField("ORVLUM", "ORVLUM", JdeDataType.String, 4),
        new JdeField("ORITWT", "ORITWT", JdeDataType.Numeric),
        new JdeField("ORWTUM", "ORWTUM", JdeDataType.String, 4),
        new JdeField("ORAEXP", "ORAEXP", JdeDataType.Numeric),
        new JdeField("ORCRCD", "ORCRCD", JdeDataType.String, 6),
        new JdeField("ORCNDJ", "ORCNDJ", JdeDataType.Numeric),
        new JdeField("ORRORN", "ORRORN", JdeDataType.String, 16),
        new JdeField("ORRCTO", "ORRCTO", JdeDataType.String, 4),
        new JdeField("ORRKCO", "ORRKCO", JdeDataType.String, 10),
        new JdeField("ORRLLN", "ORRLLN", JdeDataType.Numeric),
        new JdeField("ORVR01", "ORVR01", JdeDataType.String, 50),
        new JdeField("ORVR02", "ORVR02", JdeDataType.String, 50),
        new JdeField("ORVR03", "ORVR03", JdeDataType.String, 50),
        new JdeField("OROTRMQUL1", "OROTRMQUL1", JdeDataType.String, 100),
        new JdeField("ORDEL1", "ORDEL1", JdeDataType.String, 60),
        new JdeField("ORDEL2", "ORDEL2", JdeDataType.String, 60),
        new JdeField("OROTE1REF1", "OROTE1REF1", JdeDataType.String, 100),
        new JdeField("OROTE1REF2", "OROTE1REF2", JdeDataType.String, 100),
        new JdeField("OROTE1REF3", "OROTE1REF3", JdeDataType.String, 100),
        new JdeField("OROTE1REF4", "OROTE1REF4", JdeDataType.String, 100),
        new JdeField("OROTE1REF5", "OROTE1REF5", JdeDataType.String, 100),
        new JdeField("OROTE1REF6", "OROTE1REF6", JdeDataType.String, 100),
        new JdeField("OROTE1REF7", "OROTE1REF7", JdeDataType.String, 100),
        new JdeField("OROTE1REF8", "OROTE1REF8", JdeDataType.String, 100),
        new JdeField("OROTE1REF9", "OROTE1REF9", JdeDataType.String, 100),
        new JdeField("OROTE1REF10", "OROTE1REF10", JdeDataType.String, 100),
        new JdeField("OROTCHAR1", "OROTCHAR1", JdeDataType.String, 2),
        new JdeField("OROTCHAR2", "OROTCHAR2", JdeDataType.String, 2),
        new JdeField("OROTCHAR3", "OROTCHAR3", JdeDataType.String, 2),
        new JdeField("OROTMATH1", "OROTMATH1", JdeDataType.Numeric),
        new JdeField("OROTMATH2", "OROTMATH2", JdeDataType.Numeric),
        new JdeField("OROTMATH3", "OROTMATH3", JdeDataType.Numeric),
        new JdeField("ORURCD", "ORURCD", JdeDataType.String, 4),
        new JdeField("ORURDT", "ORURDT", JdeDataType.Numeric),
        new JdeField("ORURRF", "ORURRF", JdeDataType.String, 30),
        new JdeField("ORURAT", "ORURAT", JdeDataType.Numeric),
        new JdeField("ORURAB", "ORURAB", JdeDataType.Numeric),
        new JdeField("ORUSER", "ORUSER", JdeDataType.String, 20),
        new JdeField("ORPID", "ORPID", JdeDataType.String, 20),
        new JdeField("ORTORG", "ORTORG", JdeDataType.String, 20),
        new JdeField("ORJOBN", "ORJOBN", JdeDataType.String, 20),
        new JdeField("ORUUPMJ", "ORUUPMJ", JdeDataType.Date),
        new JdeField("ORRECLOCK", "ORRECLOCK", JdeDataType.String, 2),
        new JdeField("OROTXFLAG", "OROTXFLAG", JdeDataType.String, 2),
        new JdeField("OROTIP", "OROTIP", JdeDataType.String, 6),
        new JdeField("ORRORNUMID", "ORRORNUMID", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49T10_0", "Primary Key on OROTORDRLS, OROTORDRLN", new[] { "OROTORDRLS", "OROTORDRLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F49T10_2", "Index on ORORDNUMID", new[] { "ORORDNUMID" })
    };
}
