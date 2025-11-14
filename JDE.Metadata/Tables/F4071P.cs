using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4071P - .
/// </summary>
public class F4071P : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ATUKID.
        /// </summary>
        public const string ATUKID = "ATUKID";

        /// <summary>
        /// ATAST.
        /// </summary>
        public const string ATAST = "ATAST";

        /// <summary>
        /// ATPRGR.
        /// </summary>
        public const string ATPRGR = "ATPRGR";

        /// <summary>
        /// ATCPGP.
        /// </summary>
        public const string ATCPGP = "ATCPGP";

        /// <summary>
        /// ATSDGR.
        /// </summary>
        public const string ATSDGR = "ATSDGR";

        /// <summary>
        /// ATPRFR.
        /// </summary>
        public const string ATPRFR = "ATPRFR";

        /// <summary>
        /// ATLBT.
        /// </summary>
        public const string ATLBT = "ATLBT";

        /// <summary>
        /// ATGLC.
        /// </summary>
        public const string ATGLC = "ATGLC";

        /// <summary>
        /// ATSBIF.
        /// </summary>
        public const string ATSBIF = "ATSBIF";

        /// <summary>
        /// ATACNT.
        /// </summary>
        public const string ATACNT = "ATACNT";

        /// <summary>
        /// ATLNTY.
        /// </summary>
        public const string ATLNTY = "ATLNTY";

        /// <summary>
        /// ATMDED.
        /// </summary>
        public const string ATMDED = "ATMDED";

        /// <summary>
        /// ATABAS.
        /// </summary>
        public const string ATABAS = "ATABAS";

        /// <summary>
        /// ATOLVL.
        /// </summary>
        public const string ATOLVL = "ATOLVL";

        /// <summary>
        /// ATTXB.
        /// </summary>
        public const string ATTXB = "ATTXB";

        /// <summary>
        /// ATPA01.
        /// </summary>
        public const string ATPA01 = "ATPA01";

        /// <summary>
        /// ATPA02.
        /// </summary>
        public const string ATPA02 = "ATPA02";

        /// <summary>
        /// ATPA03.
        /// </summary>
        public const string ATPA03 = "ATPA03";

        /// <summary>
        /// ATPA04.
        /// </summary>
        public const string ATPA04 = "ATPA04";

        /// <summary>
        /// ATPA05.
        /// </summary>
        public const string ATPA05 = "ATPA05";

        /// <summary>
        /// ATURCD.
        /// </summary>
        public const string ATURCD = "ATURCD";

        /// <summary>
        /// ATURDT.
        /// </summary>
        public const string ATURDT = "ATURDT";

        /// <summary>
        /// ATURAT.
        /// </summary>
        public const string ATURAT = "ATURAT";

        /// <summary>
        /// ATURAB.
        /// </summary>
        public const string ATURAB = "ATURAB";

        /// <summary>
        /// ATURRF.
        /// </summary>
        public const string ATURRF = "ATURRF";

        /// <summary>
        /// ATENBM.
        /// </summary>
        public const string ATENBM = "ATENBM";

        /// <summary>
        /// ATSRFLAG.
        /// </summary>
        public const string ATSRFLAG = "ATSRFLAG";

        /// <summary>
        /// ATUSADJ.
        /// </summary>
        public const string ATUSADJ = "ATUSADJ";

        /// <summary>
        /// ATATIER.
        /// </summary>
        public const string ATATIER = "ATATIER";

        /// <summary>
        /// ATBTIER.
        /// </summary>
        public const string ATBTIER = "ATBTIER";

        /// <summary>
        /// ATBNAD.
        /// </summary>
        public const string ATBNAD = "ATBNAD";

        /// <summary>
        /// ATAPRP1.
        /// </summary>
        public const string ATAPRP1 = "ATAPRP1";

        /// <summary>
        /// ATAPRP2.
        /// </summary>
        public const string ATAPRP2 = "ATAPRP2";

        /// <summary>
        /// ATAPRP3.
        /// </summary>
        public const string ATAPRP3 = "ATAPRP3";

        /// <summary>
        /// ATAPRP4.
        /// </summary>
        public const string ATAPRP4 = "ATAPRP4";

        /// <summary>
        /// ATAPRP5.
        /// </summary>
        public const string ATAPRP5 = "ATAPRP5";

        /// <summary>
        /// ATAPRP6.
        /// </summary>
        public const string ATAPRP6 = "ATAPRP6";

        /// <summary>
        /// ATADJGRP.
        /// </summary>
        public const string ATADJGRP = "ATADJGRP";

        /// <summary>
        /// ATMEADJ.
        /// </summary>
        public const string ATMEADJ = "ATMEADJ";

        /// <summary>
        /// ATPDCL.
        /// </summary>
        public const string ATPDCL = "ATPDCL";

        /// <summary>
        /// ATUSER.
        /// </summary>
        public const string ATUSER = "ATUSER";

        /// <summary>
        /// ATPID.
        /// </summary>
        public const string ATPID = "ATPID";

        /// <summary>
        /// ATJOBN.
        /// </summary>
        public const string ATJOBN = "ATJOBN";

        /// <summary>
        /// ATUPMJ.
        /// </summary>
        public const string ATUPMJ = "ATUPMJ";

        /// <summary>
        /// ATTDAY.
        /// </summary>
        public const string ATTDAY = "ATTDAY";

        /// <summary>
        /// ATDIDP.
        /// </summary>
        public const string ATDIDP = "ATDIDP";

        /// <summary>
        /// ATPMTN.
        /// </summary>
        public const string ATPMTN = "ATPMTN";

        /// <summary>
        /// ATPHST.
        /// </summary>
        public const string ATPHST = "ATPHST";

        /// <summary>
        /// ATPA06.
        /// </summary>
        public const string ATPA06 = "ATPA06";

        /// <summary>
        /// ATPA07.
        /// </summary>
        public const string ATPA07 = "ATPA07";

        /// <summary>
        /// ATPA08.
        /// </summary>
        public const string ATPA08 = "ATPA08";

        /// <summary>
        /// ATPA09.
        /// </summary>
        public const string ATPA09 = "ATPA09";

        /// <summary>
        /// ATPA10.
        /// </summary>
        public const string ATPA10 = "ATPA10";

        /// <summary>
        /// ATEFCN.
        /// </summary>
        public const string ATEFCN = "ATEFCN";

        /// <summary>
        /// ATAPTYPE.
        /// </summary>
        public const string ATAPTYPE = "ATAPTYPE";

        /// <summary>
        /// ATMOADJ.
        /// </summary>
        public const string ATMOADJ = "ATMOADJ";

        /// <summary>
        /// ATPLGRP.
        /// </summary>
        public const string ATPLGRP = "ATPLGRP";

        /// <summary>
        /// ATEXCPL.
        /// </summary>
        public const string ATEXCPL = "ATEXCPL";

        /// <summary>
        /// ATUPMX.
        /// </summary>
        public const string ATUPMX = "ATUPMX";

        /// <summary>
        /// ATMNMXAJ.
        /// </summary>
        public const string ATMNMXAJ = "ATMNMXAJ";

        /// <summary>
        /// ATMNMXRL.
        /// </summary>
        public const string ATMNMXRL = "ATMNMXRL";

        /// <summary>
        /// ATTSTRSNM.
        /// </summary>
        public const string ATTSTRSNM = "ATTSTRSNM";

        /// <summary>
        /// ATADJQTY.
        /// </summary>
        public const string ATADJQTY = "ATADJQTY";
    }

    /// <inheritdoc />
    public override string TableName => "F4071P";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ATUKID", "ATUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("ATAST", "ATAST", JdeDataType.String, 16, true, true),
        new JdeField("ATPRGR", "ATPRGR", JdeDataType.String, 16),
        new JdeField("ATCPGP", "ATCPGP", JdeDataType.String, 16),
        new JdeField("ATSDGR", "ATSDGR", JdeDataType.String, 16),
        new JdeField("ATPRFR", "ATPRFR", JdeDataType.String, 4),
        new JdeField("ATLBT", "ATLBT", JdeDataType.String, 2),
        new JdeField("ATGLC", "ATGLC", JdeDataType.String, 8),
        new JdeField("ATSBIF", "ATSBIF", JdeDataType.String, 2),
        new JdeField("ATACNT", "ATACNT", JdeDataType.String, 2),
        new JdeField("ATLNTY", "ATLNTY", JdeDataType.String, 4),
        new JdeField("ATMDED", "ATMDED", JdeDataType.String, 2),
        new JdeField("ATABAS", "ATABAS", JdeDataType.String, 2),
        new JdeField("ATOLVL", "ATOLVL", JdeDataType.String, 2),
        new JdeField("ATTXB", "ATTXB", JdeDataType.String, 2),
        new JdeField("ATPA01", "ATPA01", JdeDataType.String, 2),
        new JdeField("ATPA02", "ATPA02", JdeDataType.String, 2),
        new JdeField("ATPA03", "ATPA03", JdeDataType.String, 2),
        new JdeField("ATPA04", "ATPA04", JdeDataType.String, 2),
        new JdeField("ATPA05", "ATPA05", JdeDataType.String, 2),
        new JdeField("ATURCD", "ATURCD", JdeDataType.String, 4),
        new JdeField("ATURDT", "ATURDT", JdeDataType.Numeric),
        new JdeField("ATURAT", "ATURAT", JdeDataType.Numeric),
        new JdeField("ATURAB", "ATURAB", JdeDataType.Numeric),
        new JdeField("ATURRF", "ATURRF", JdeDataType.String, 30),
        new JdeField("ATENBM", "ATENBM", JdeDataType.String, 2),
        new JdeField("ATSRFLAG", "ATSRFLAG", JdeDataType.String, 2),
        new JdeField("ATUSADJ", "ATUSADJ", JdeDataType.String, 2),
        new JdeField("ATATIER", "ATATIER", JdeDataType.Numeric),
        new JdeField("ATBTIER", "ATBTIER", JdeDataType.Numeric),
        new JdeField("ATBNAD", "ATBNAD", JdeDataType.Numeric),
        new JdeField("ATAPRP1", "ATAPRP1", JdeDataType.String, 6),
        new JdeField("ATAPRP2", "ATAPRP2", JdeDataType.String, 6),
        new JdeField("ATAPRP3", "ATAPRP3", JdeDataType.String, 6),
        new JdeField("ATAPRP4", "ATAPRP4", JdeDataType.String, 12),
        new JdeField("ATAPRP5", "ATAPRP5", JdeDataType.String, 12),
        new JdeField("ATAPRP6", "ATAPRP6", JdeDataType.String, 12),
        new JdeField("ATADJGRP", "ATADJGRP", JdeDataType.String, 20),
        new JdeField("ATMEADJ", "ATMEADJ", JdeDataType.String, 2),
        new JdeField("ATPDCL", "ATPDCL", JdeDataType.String, 2),
        new JdeField("ATUSER", "ATUSER", JdeDataType.String, 20),
        new JdeField("ATPID", "ATPID", JdeDataType.String, 20),
        new JdeField("ATJOBN", "ATJOBN", JdeDataType.String, 20),
        new JdeField("ATUPMJ", "ATUPMJ", JdeDataType.Numeric),
        new JdeField("ATTDAY", "ATTDAY", JdeDataType.Numeric),
        new JdeField("ATDIDP", "ATDIDP", JdeDataType.String, 24),
        new JdeField("ATPMTN", "ATPMTN", JdeDataType.String, 24),
        new JdeField("ATPHST", "ATPHST", JdeDataType.String, 2),
        new JdeField("ATPA06", "ATPA06", JdeDataType.String, 2),
        new JdeField("ATPA07", "ATPA07", JdeDataType.String, 2),
        new JdeField("ATPA08", "ATPA08", JdeDataType.String, 2),
        new JdeField("ATPA09", "ATPA09", JdeDataType.String, 2),
        new JdeField("ATPA10", "ATPA10", JdeDataType.String, 2),
        new JdeField("ATEFCN", "ATEFCN", JdeDataType.String, 2),
        new JdeField("ATAPTYPE", "ATAPTYPE", JdeDataType.String, 4),
        new JdeField("ATMOADJ", "ATMOADJ", JdeDataType.String, 2),
        new JdeField("ATPLGRP", "ATPLGRP", JdeDataType.String, 6),
        new JdeField("ATEXCPL", "ATEXCPL", JdeDataType.String, 2),
        new JdeField("ATUPMX", "ATUPMX", JdeDataType.Numeric),
        new JdeField("ATMNMXAJ", "ATMNMXAJ", JdeDataType.String, 2),
        new JdeField("ATMNMXRL", "ATMNMXRL", JdeDataType.String, 2),
        new JdeField("ATTSTRSNM", "ATTSTRSNM", JdeDataType.String, 60),
        new JdeField("ATADJQTY", "ATADJQTY", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4071P_0", "Primary Key on ATAST, ATUKID", new[] { "ATAST", "ATUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4071P_2", "Index on ATAST, ATPID", new[] { "ATAST", "ATPID" })
    };
}
