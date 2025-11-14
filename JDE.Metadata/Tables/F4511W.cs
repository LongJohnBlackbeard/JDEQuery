using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4511W - .
/// </summary>
public class F4511W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// APCTID.
        /// </summary>
        public const string APCTID = "APCTID";

        /// <summary>
        /// APJOBS.
        /// </summary>
        public const string APJOBS = "APJOBS";

        /// <summary>
        /// APPEID.
        /// </summary>
        public const string APPEID = "APPEID";

        /// <summary>
        /// APTCID.
        /// </summary>
        public const string APTCID = "APTCID";

        /// <summary>
        /// APOSEQ.
        /// </summary>
        public const string APOSEQ = "APOSEQ";

        /// <summary>
        /// APAST.
        /// </summary>
        public const string APAST = "APAST";

        /// <summary>
        /// APPRGR.
        /// </summary>
        public const string APPRGR = "APPRGR";

        /// <summary>
        /// APCPGP.
        /// </summary>
        public const string APCPGP = "APCPGP";

        /// <summary>
        /// APSDGR.
        /// </summary>
        public const string APSDGR = "APSDGR";

        /// <summary>
        /// APPRFR.
        /// </summary>
        public const string APPRFR = "APPRFR";

        /// <summary>
        /// APLBT.
        /// </summary>
        public const string APLBT = "APLBT";

        /// <summary>
        /// APGLC.
        /// </summary>
        public const string APGLC = "APGLC";

        /// <summary>
        /// APSBIF.
        /// </summary>
        public const string APSBIF = "APSBIF";

        /// <summary>
        /// APACNT.
        /// </summary>
        public const string APACNT = "APACNT";

        /// <summary>
        /// APLNTY.
        /// </summary>
        public const string APLNTY = "APLNTY";

        /// <summary>
        /// APMDED.
        /// </summary>
        public const string APMDED = "APMDED";

        /// <summary>
        /// APABAS.
        /// </summary>
        public const string APABAS = "APABAS";

        /// <summary>
        /// APOLVL.
        /// </summary>
        public const string APOLVL = "APOLVL";

        /// <summary>
        /// APTXB.
        /// </summary>
        public const string APTXB = "APTXB";

        /// <summary>
        /// APPA01.
        /// </summary>
        public const string APPA01 = "APPA01";

        /// <summary>
        /// APPA02.
        /// </summary>
        public const string APPA02 = "APPA02";

        /// <summary>
        /// APPA03.
        /// </summary>
        public const string APPA03 = "APPA03";

        /// <summary>
        /// APPA04.
        /// </summary>
        public const string APPA04 = "APPA04";

        /// <summary>
        /// APPA05.
        /// </summary>
        public const string APPA05 = "APPA05";

        /// <summary>
        /// APENBM.
        /// </summary>
        public const string APENBM = "APENBM";

        /// <summary>
        /// APSRFLAG.
        /// </summary>
        public const string APSRFLAG = "APSRFLAG";

        /// <summary>
        /// APUSADJ.
        /// </summary>
        public const string APUSADJ = "APUSADJ";

        /// <summary>
        /// APATIER.
        /// </summary>
        public const string APATIER = "APATIER";

        /// <summary>
        /// APBTIER.
        /// </summary>
        public const string APBTIER = "APBTIER";

        /// <summary>
        /// APAPRP1.
        /// </summary>
        public const string APAPRP1 = "APAPRP1";

        /// <summary>
        /// APAPRP2.
        /// </summary>
        public const string APAPRP2 = "APAPRP2";

        /// <summary>
        /// APAPRP3.
        /// </summary>
        public const string APAPRP3 = "APAPRP3";

        /// <summary>
        /// APAPRP4.
        /// </summary>
        public const string APAPRP4 = "APAPRP4";

        /// <summary>
        /// APAPRP5.
        /// </summary>
        public const string APAPRP5 = "APAPRP5";

        /// <summary>
        /// APAPRP6.
        /// </summary>
        public const string APAPRP6 = "APAPRP6";

        /// <summary>
        /// APADJGRP.
        /// </summary>
        public const string APADJGRP = "APADJGRP";

        /// <summary>
        /// APMEADJ.
        /// </summary>
        public const string APMEADJ = "APMEADJ";

        /// <summary>
        /// APPDCL.
        /// </summary>
        public const string APPDCL = "APPDCL";

        /// <summary>
        /// APITM.
        /// </summary>
        public const string APITM = "APITM";

        /// <summary>
        /// APLITM.
        /// </summary>
        public const string APLITM = "APLITM";

        /// <summary>
        /// APAITM.
        /// </summary>
        public const string APAITM = "APAITM";

        /// <summary>
        /// APAN8.
        /// </summary>
        public const string APAN8 = "APAN8";

        /// <summary>
        /// APIGID.
        /// </summary>
        public const string APIGID = "APIGID";

        /// <summary>
        /// APCGID.
        /// </summary>
        public const string APCGID = "APCGID";

        /// <summary>
        /// APOGID.
        /// </summary>
        public const string APOGID = "APOGID";

        /// <summary>
        /// APCRCD.
        /// </summary>
        public const string APCRCD = "APCRCD";

        /// <summary>
        /// APMNQ.
        /// </summary>
        public const string APMNQ = "APMNQ";

        /// <summary>
        /// APUOM.
        /// </summary>
        public const string APUOM = "APUOM";

        /// <summary>
        /// APEFTJ.
        /// </summary>
        public const string APEFTJ = "APEFTJ";

        /// <summary>
        /// APEXDJ.
        /// </summary>
        public const string APEXDJ = "APEXDJ";

        /// <summary>
        /// APBSCD.
        /// </summary>
        public const string APBSCD = "APBSCD";

        /// <summary>
        /// APLEDG.
        /// </summary>
        public const string APLEDG = "APLEDG";

        /// <summary>
        /// APFRMN.
        /// </summary>
        public const string APFRMN = "APFRMN";

        /// <summary>
        /// APFVTR.
        /// </summary>
        public const string APFVTR = "APFVTR";

        /// <summary>
        /// APFGY.
        /// </summary>
        public const string APFGY = "APFGY";

        /// <summary>
        /// APATID.
        /// </summary>
        public const string APATID = "APATID";

        /// <summary>
        /// APNBRORD.
        /// </summary>
        public const string APNBRORD = "APNBRORD";

        /// <summary>
        /// APUOMVID.
        /// </summary>
        public const string APUOMVID = "APUOMVID";

        /// <summary>
        /// APFVUM.
        /// </summary>
        public const string APFVUM = "APFVUM";

        /// <summary>
        /// APPARTFG.
        /// </summary>
        public const string APPARTFG = "APPARTFG";

        /// <summary>
        /// APAPRS.
        /// </summary>
        public const string APAPRS = "APAPRS";

        /// <summary>
        /// APIGP1.
        /// </summary>
        public const string APIGP1 = "APIGP1";

        /// <summary>
        /// APIGP2.
        /// </summary>
        public const string APIGP2 = "APIGP2";

        /// <summary>
        /// APIGP3.
        /// </summary>
        public const string APIGP3 = "APIGP3";

        /// <summary>
        /// APIGP4.
        /// </summary>
        public const string APIGP4 = "APIGP4";

        /// <summary>
        /// APIGP5.
        /// </summary>
        public const string APIGP5 = "APIGP5";

        /// <summary>
        /// APIGP6.
        /// </summary>
        public const string APIGP6 = "APIGP6";

        /// <summary>
        /// APIGP7.
        /// </summary>
        public const string APIGP7 = "APIGP7";

        /// <summary>
        /// APIGP8.
        /// </summary>
        public const string APIGP8 = "APIGP8";

        /// <summary>
        /// APIGP9.
        /// </summary>
        public const string APIGP9 = "APIGP9";

        /// <summary>
        /// APIGP10.
        /// </summary>
        public const string APIGP10 = "APIGP10";

        /// <summary>
        /// APCGP1.
        /// </summary>
        public const string APCGP1 = "APCGP1";

        /// <summary>
        /// APCGP2.
        /// </summary>
        public const string APCGP2 = "APCGP2";

        /// <summary>
        /// APCGP3.
        /// </summary>
        public const string APCGP3 = "APCGP3";

        /// <summary>
        /// APCGP4.
        /// </summary>
        public const string APCGP4 = "APCGP4";

        /// <summary>
        /// APCGP5.
        /// </summary>
        public const string APCGP5 = "APCGP5";

        /// <summary>
        /// APCGP6.
        /// </summary>
        public const string APCGP6 = "APCGP6";

        /// <summary>
        /// APCGP7.
        /// </summary>
        public const string APCGP7 = "APCGP7";

        /// <summary>
        /// APCGP8.
        /// </summary>
        public const string APCGP8 = "APCGP8";

        /// <summary>
        /// APCGP9.
        /// </summary>
        public const string APCGP9 = "APCGP9";

        /// <summary>
        /// APCGP10.
        /// </summary>
        public const string APCGP10 = "APCGP10";

        /// <summary>
        /// APSDV1.
        /// </summary>
        public const string APSDV1 = "APSDV1";

        /// <summary>
        /// APSDV2.
        /// </summary>
        public const string APSDV2 = "APSDV2";

        /// <summary>
        /// APSDV3.
        /// </summary>
        public const string APSDV3 = "APSDV3";

        /// <summary>
        /// APSDV4.
        /// </summary>
        public const string APSDV4 = "APSDV4";

        /// <summary>
        /// APSDV5.
        /// </summary>
        public const string APSDV5 = "APSDV5";

        /// <summary>
        /// APSDV6.
        /// </summary>
        public const string APSDV6 = "APSDV6";

        /// <summary>
        /// APSDV7.
        /// </summary>
        public const string APSDV7 = "APSDV7";

        /// <summary>
        /// APSDV8.
        /// </summary>
        public const string APSDV8 = "APSDV8";

        /// <summary>
        /// APSDV9.
        /// </summary>
        public const string APSDV9 = "APSDV9";

        /// <summary>
        /// APSDV10.
        /// </summary>
        public const string APSDV10 = "APSDV10";

        /// <summary>
        /// APASN.
        /// </summary>
        public const string APASN = "APASN";

        /// <summary>
        /// APURCD.
        /// </summary>
        public const string APURCD = "APURCD";

        /// <summary>
        /// APURDT.
        /// </summary>
        public const string APURDT = "APURDT";

        /// <summary>
        /// APURAT.
        /// </summary>
        public const string APURAT = "APURAT";

        /// <summary>
        /// APURAB.
        /// </summary>
        public const string APURAB = "APURAB";

        /// <summary>
        /// APURRF.
        /// </summary>
        public const string APURRF = "APURRF";

        /// <summary>
        /// APMCU.
        /// </summary>
        public const string APMCU = "APMCU";

        /// <summary>
        /// APCO.
        /// </summary>
        public const string APCO = "APCO";
    }

    /// <inheritdoc />
    public override string TableName => "F4511W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("APCTID", "APCTID", JdeDataType.String, 30, true, true),
        new JdeField("APJOBS", "APJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("APPEID", "APPEID", JdeDataType.Numeric, null, true, true),
        new JdeField("APTCID", "APTCID", JdeDataType.Numeric, null, true, true),
        new JdeField("APOSEQ", "APOSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("APAST", "APAST", JdeDataType.String, 16),
        new JdeField("APPRGR", "APPRGR", JdeDataType.String, 16),
        new JdeField("APCPGP", "APCPGP", JdeDataType.String, 16),
        new JdeField("APSDGR", "APSDGR", JdeDataType.String, 16),
        new JdeField("APPRFR", "APPRFR", JdeDataType.String, 4),
        new JdeField("APLBT", "APLBT", JdeDataType.String, 2),
        new JdeField("APGLC", "APGLC", JdeDataType.String, 8),
        new JdeField("APSBIF", "APSBIF", JdeDataType.String, 2),
        new JdeField("APACNT", "APACNT", JdeDataType.String, 2),
        new JdeField("APLNTY", "APLNTY", JdeDataType.String, 4),
        new JdeField("APMDED", "APMDED", JdeDataType.String, 2),
        new JdeField("APABAS", "APABAS", JdeDataType.String, 2),
        new JdeField("APOLVL", "APOLVL", JdeDataType.String, 2),
        new JdeField("APTXB", "APTXB", JdeDataType.String, 2),
        new JdeField("APPA01", "APPA01", JdeDataType.String, 2),
        new JdeField("APPA02", "APPA02", JdeDataType.String, 2),
        new JdeField("APPA03", "APPA03", JdeDataType.String, 2),
        new JdeField("APPA04", "APPA04", JdeDataType.String, 2),
        new JdeField("APPA05", "APPA05", JdeDataType.String, 2),
        new JdeField("APENBM", "APENBM", JdeDataType.String, 2),
        new JdeField("APSRFLAG", "APSRFLAG", JdeDataType.String, 2),
        new JdeField("APUSADJ", "APUSADJ", JdeDataType.String, 2),
        new JdeField("APATIER", "APATIER", JdeDataType.Numeric),
        new JdeField("APBTIER", "APBTIER", JdeDataType.Numeric),
        new JdeField("APAPRP1", "APAPRP1", JdeDataType.String, 6),
        new JdeField("APAPRP2", "APAPRP2", JdeDataType.String, 6),
        new JdeField("APAPRP3", "APAPRP3", JdeDataType.String, 6),
        new JdeField("APAPRP4", "APAPRP4", JdeDataType.String, 12),
        new JdeField("APAPRP5", "APAPRP5", JdeDataType.String, 12),
        new JdeField("APAPRP6", "APAPRP6", JdeDataType.String, 12),
        new JdeField("APADJGRP", "APADJGRP", JdeDataType.String, 20),
        new JdeField("APMEADJ", "APMEADJ", JdeDataType.String, 2),
        new JdeField("APPDCL", "APPDCL", JdeDataType.String, 2),
        new JdeField("APITM", "APITM", JdeDataType.Numeric),
        new JdeField("APLITM", "APLITM", JdeDataType.String, 50),
        new JdeField("APAITM", "APAITM", JdeDataType.String, 50),
        new JdeField("APAN8", "APAN8", JdeDataType.Numeric),
        new JdeField("APIGID", "APIGID", JdeDataType.Numeric),
        new JdeField("APCGID", "APCGID", JdeDataType.Numeric),
        new JdeField("APOGID", "APOGID", JdeDataType.Numeric),
        new JdeField("APCRCD", "APCRCD", JdeDataType.String, 6),
        new JdeField("APMNQ", "APMNQ", JdeDataType.Numeric),
        new JdeField("APUOM", "APUOM", JdeDataType.String, 4),
        new JdeField("APEFTJ", "APEFTJ", JdeDataType.Numeric),
        new JdeField("APEXDJ", "APEXDJ", JdeDataType.Numeric),
        new JdeField("APBSCD", "APBSCD", JdeDataType.String, 2),
        new JdeField("APLEDG", "APLEDG", JdeDataType.String, 4),
        new JdeField("APFRMN", "APFRMN", JdeDataType.String, 20),
        new JdeField("APFVTR", "APFVTR", JdeDataType.Numeric),
        new JdeField("APFGY", "APFGY", JdeDataType.String, 2),
        new JdeField("APATID", "APATID", JdeDataType.Numeric),
        new JdeField("APNBRORD", "APNBRORD", JdeDataType.Numeric),
        new JdeField("APUOMVID", "APUOMVID", JdeDataType.String, 4),
        new JdeField("APFVUM", "APFVUM", JdeDataType.String, 4),
        new JdeField("APPARTFG", "APPARTFG", JdeDataType.String, 2),
        new JdeField("APAPRS", "APAPRS", JdeDataType.String, 2),
        new JdeField("APIGP1", "APIGP1", JdeDataType.String, 12),
        new JdeField("APIGP2", "APIGP2", JdeDataType.String, 12),
        new JdeField("APIGP3", "APIGP3", JdeDataType.String, 12),
        new JdeField("APIGP4", "APIGP4", JdeDataType.String, 12),
        new JdeField("APIGP5", "APIGP5", JdeDataType.String, 12),
        new JdeField("APIGP6", "APIGP6", JdeDataType.String, 12),
        new JdeField("APIGP7", "APIGP7", JdeDataType.String, 12),
        new JdeField("APIGP8", "APIGP8", JdeDataType.String, 12),
        new JdeField("APIGP9", "APIGP9", JdeDataType.String, 12),
        new JdeField("APIGP10", "APIGP10", JdeDataType.String, 12),
        new JdeField("APCGP1", "APCGP1", JdeDataType.String, 6),
        new JdeField("APCGP2", "APCGP2", JdeDataType.String, 6),
        new JdeField("APCGP3", "APCGP3", JdeDataType.String, 6),
        new JdeField("APCGP4", "APCGP4", JdeDataType.String, 6),
        new JdeField("APCGP5", "APCGP5", JdeDataType.String, 6),
        new JdeField("APCGP6", "APCGP6", JdeDataType.String, 6),
        new JdeField("APCGP7", "APCGP7", JdeDataType.String, 6),
        new JdeField("APCGP8", "APCGP8", JdeDataType.String, 6),
        new JdeField("APCGP9", "APCGP9", JdeDataType.String, 6),
        new JdeField("APCGP10", "APCGP10", JdeDataType.String, 6),
        new JdeField("APSDV1", "APSDV1", JdeDataType.String, 24),
        new JdeField("APSDV2", "APSDV2", JdeDataType.String, 24),
        new JdeField("APSDV3", "APSDV3", JdeDataType.String, 24),
        new JdeField("APSDV4", "APSDV4", JdeDataType.String, 24),
        new JdeField("APSDV5", "APSDV5", JdeDataType.String, 24),
        new JdeField("APSDV6", "APSDV6", JdeDataType.String, 24),
        new JdeField("APSDV7", "APSDV7", JdeDataType.String, 24),
        new JdeField("APSDV8", "APSDV8", JdeDataType.String, 24),
        new JdeField("APSDV9", "APSDV9", JdeDataType.String, 24),
        new JdeField("APSDV10", "APSDV10", JdeDataType.String, 24),
        new JdeField("APASN", "APASN", JdeDataType.String, 16),
        new JdeField("APURCD", "APURCD", JdeDataType.String, 4),
        new JdeField("APURDT", "APURDT", JdeDataType.Numeric),
        new JdeField("APURAT", "APURAT", JdeDataType.Numeric),
        new JdeField("APURAB", "APURAB", JdeDataType.Numeric),
        new JdeField("APURRF", "APURRF", JdeDataType.String, 30),
        new JdeField("APMCU", "APMCU", JdeDataType.String, 24),
        new JdeField("APCO", "APCO", JdeDataType.String, 10)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4511W_0", "Primary Key on APCTID, APJOBS, APPEID, APTCID, APOSEQ", new[] { "APCTID", "APJOBS", "APPEID", "APTCID", "APOSEQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4511W_2", "Index on APAN8, APAST, APCPGP, APPRGR, APSDGR, APLITM, APCRCD, APMNQ, APUOM", new[] { "APAN8", "APAST", "APCPGP", "APPRGR", "APSDGR", "APLITM", "APCRCD", "APMNQ", "APUOM" }),
        new JdeIndex("F4511W_3", "Index on APCPGP, APAST, APAN8, APPRGR, APSDGR, APLITM, APCRCD, APMNQ, APUOM", new[] { "APCPGP", "APAST", "APAN8", "APPRGR", "APSDGR", "APLITM", "APCRCD", "APMNQ", "APUOM" }),
        new JdeIndex("F4511W_4", "Index on APLITM, APAST, APPRGR, APCPGP, APSDGR, APAN8, APCRCD, APMNQ, APUOM", new[] { "APLITM", "APAST", "APPRGR", "APCPGP", "APSDGR", "APAN8", "APCRCD", "APMNQ", "APUOM" }),
        new JdeIndex("F4511W_5", "Index on APPRGR, APAST, APLITM, APCPGP, APSDGR, APAN8, APCRCD, APMNQ, APUOM", new[] { "APPRGR", "APAST", "APLITM", "APCPGP", "APSDGR", "APAN8", "APCRCD", "APMNQ", "APUOM" }),
        new JdeIndex("F4511W_6", "Index on APAST, APAN8, APLITM, APCPGP, APPRGR, APSDGR, APCRCD, APMNQ, APUOM", new[] { "APAST", "APAN8", "APLITM", "APCPGP", "APPRGR", "APSDGR", "APCRCD", "APMNQ", "APUOM" })
    };
}
