using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1797 - .
/// </summary>
public class F1797 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CSAN8.
        /// </summary>
        public const string CSAN8 = "CSAN8";

        /// <summary>
        /// CSITYPE.
        /// </summary>
        public const string CSITYPE = "CSITYPE";

        /// <summary>
        /// CSASN1.
        /// </summary>
        public const string CSASN1 = "CSASN1";

        /// <summary>
        /// CSASN2.
        /// </summary>
        public const string CSASN2 = "CSASN2";

        /// <summary>
        /// CSASN3.
        /// </summary>
        public const string CSASN3 = "CSASN3";

        /// <summary>
        /// CSASN4.
        /// </summary>
        public const string CSASN4 = "CSASN4";

        /// <summary>
        /// CSASN5.
        /// </summary>
        public const string CSASN5 = "CSASN5";

        /// <summary>
        /// CSANPA.
        /// </summary>
        public const string CSANPA = "CSANPA";

        /// <summary>
        /// CSAN8DL.
        /// </summary>
        public const string CSAN8DL = "CSAN8DL";

        /// <summary>
        /// CSTYPS.
        /// </summary>
        public const string CSTYPS = "CSTYPS";

        /// <summary>
        /// CSREGION.
        /// </summary>
        public const string CSREGION = "CSREGION";

        /// <summary>
        /// CSSCAC.
        /// </summary>
        public const string CSSCAC = "CSSCAC";

        /// <summary>
        /// CSSTBF.
        /// </summary>
        public const string CSSTBF = "CSSTBF";

        /// <summary>
        /// CSTIMEZONES.
        /// </summary>
        public const string CSTIMEZONES = "CSTIMEZONES";

        /// <summary>
        /// CSDSAVNAME.
        /// </summary>
        public const string CSDSAVNAME = "CSDSAVNAME";

        /// <summary>
        /// CSASAI.
        /// </summary>
        public const string CSASAI = "CSASAI";

        /// <summary>
        /// CSPH1.
        /// </summary>
        public const string CSPH1 = "CSPH1";

        /// <summary>
        /// CSMBDS.
        /// </summary>
        public const string CSMBDS = "CSMBDS";

        /// <summary>
        /// CSREM1.
        /// </summary>
        public const string CSREM1 = "CSREM1";

        /// <summary>
        /// CSHMCU.
        /// </summary>
        public const string CSHMCU = "CSHMCU";

        /// <summary>
        /// CSOBJ.
        /// </summary>
        public const string CSOBJ = "CSOBJ";

        /// <summary>
        /// CSSUB.
        /// </summary>
        public const string CSSUB = "CSSUB";

        /// <summary>
        /// CSSVGRP.
        /// </summary>
        public const string CSSVGRP = "CSSVGRP";

        /// <summary>
        /// CSJC01.
        /// </summary>
        public const string CSJC01 = "CSJC01";

        /// <summary>
        /// CSJC02.
        /// </summary>
        public const string CSJC02 = "CSJC02";

        /// <summary>
        /// CSJC03.
        /// </summary>
        public const string CSJC03 = "CSJC03";

        /// <summary>
        /// CSJC04.
        /// </summary>
        public const string CSJC04 = "CSJC04";

        /// <summary>
        /// CSJC05.
        /// </summary>
        public const string CSJC05 = "CSJC05";

        /// <summary>
        /// CSJC06.
        /// </summary>
        public const string CSJC06 = "CSJC06";

        /// <summary>
        /// CSJC07.
        /// </summary>
        public const string CSJC07 = "CSJC07";

        /// <summary>
        /// CSJC08.
        /// </summary>
        public const string CSJC08 = "CSJC08";

        /// <summary>
        /// CSJC09.
        /// </summary>
        public const string CSJC09 = "CSJC09";

        /// <summary>
        /// CSJC10.
        /// </summary>
        public const string CSJC10 = "CSJC10";

        /// <summary>
        /// CSMTHPR.
        /// </summary>
        public const string CSMTHPR = "CSMTHPR";

        /// <summary>
        /// CSPYSPM.
        /// </summary>
        public const string CSPYSPM = "CSPYSPM";

        /// <summary>
        /// CSPYPRT.
        /// </summary>
        public const string CSPYPRT = "CSPYPRT";

        /// <summary>
        /// CSMCU.
        /// </summary>
        public const string CSMCU = "CSMCU";

        /// <summary>
        /// CSURAB.
        /// </summary>
        public const string CSURAB = "CSURAB";

        /// <summary>
        /// CSURCD.
        /// </summary>
        public const string CSURCD = "CSURCD";

        /// <summary>
        /// CSURAT.
        /// </summary>
        public const string CSURAT = "CSURAT";

        /// <summary>
        /// CSURDT.
        /// </summary>
        public const string CSURDT = "CSURDT";

        /// <summary>
        /// CSURRF.
        /// </summary>
        public const string CSURRF = "CSURRF";

        /// <summary>
        /// CSCRTU.
        /// </summary>
        public const string CSCRTU = "CSCRTU";

        /// <summary>
        /// CSUSER.
        /// </summary>
        public const string CSUSER = "CSUSER";

        /// <summary>
        /// CSJOBN.
        /// </summary>
        public const string CSJOBN = "CSJOBN";

        /// <summary>
        /// CSPID.
        /// </summary>
        public const string CSPID = "CSPID";

        /// <summary>
        /// CSUPMJ.
        /// </summary>
        public const string CSUPMJ = "CSUPMJ";

        /// <summary>
        /// CSUPMT.
        /// </summary>
        public const string CSUPMT = "CSUPMT";

        /// <summary>
        /// CSRMTHD.
        /// </summary>
        public const string CSRMTHD = "CSRMTHD";

        /// <summary>
        /// CSYN01.
        /// </summary>
        public const string CSYN01 = "CSYN01";

        /// <summary>
        /// CSCO.
        /// </summary>
        public const string CSCO = "CSCO";
    }

    /// <inheritdoc />
    public override string TableName => "F1797";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CSAN8", "CSAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("CSITYPE", "CSITYPE", JdeDataType.String, 2, true, true),
        new JdeField("CSASN1", "CSASN1", JdeDataType.String, 16),
        new JdeField("CSASN2", "CSASN2", JdeDataType.String, 16),
        new JdeField("CSASN3", "CSASN3", JdeDataType.String, 16),
        new JdeField("CSASN4", "CSASN4", JdeDataType.String, 16),
        new JdeField("CSASN5", "CSASN5", JdeDataType.String, 16),
        new JdeField("CSANPA", "CSANPA", JdeDataType.Numeric),
        new JdeField("CSAN8DL", "CSAN8DL", JdeDataType.Numeric),
        new JdeField("CSTYPS", "CSTYPS", JdeDataType.String, 2),
        new JdeField("CSREGION", "CSREGION", JdeDataType.String, 6),
        new JdeField("CSSCAC", "CSSCAC", JdeDataType.String, 8),
        new JdeField("CSSTBF", "CSSTBF", JdeDataType.String, 64),
        new JdeField("CSTIMEZONES", "CSTIMEZONES", JdeDataType.String, 4),
        new JdeField("CSDSAVNAME", "CSDSAVNAME", JdeDataType.String, 20),
        new JdeField("CSASAI", "CSASAI", JdeDataType.String, 2),
        new JdeField("CSPH1", "CSPH1", JdeDataType.String, 40),
        new JdeField("CSMBDS", "CSMBDS", JdeDataType.String, 4),
        new JdeField("CSREM1", "CSREM1", JdeDataType.String, 80),
        new JdeField("CSHMCU", "CSHMCU", JdeDataType.String, 24),
        new JdeField("CSOBJ", "CSOBJ", JdeDataType.String, 12),
        new JdeField("CSSUB", "CSSUB", JdeDataType.String, 16),
        new JdeField("CSSVGRP", "CSSVGRP", JdeDataType.String, 10),
        new JdeField("CSJC01", "CSJC01", JdeDataType.String, 6),
        new JdeField("CSJC02", "CSJC02", JdeDataType.String, 6),
        new JdeField("CSJC03", "CSJC03", JdeDataType.String, 6),
        new JdeField("CSJC04", "CSJC04", JdeDataType.String, 6),
        new JdeField("CSJC05", "CSJC05", JdeDataType.String, 6),
        new JdeField("CSJC06", "CSJC06", JdeDataType.String, 6),
        new JdeField("CSJC07", "CSJC07", JdeDataType.String, 6),
        new JdeField("CSJC08", "CSJC08", JdeDataType.String, 6),
        new JdeField("CSJC09", "CSJC09", JdeDataType.String, 6),
        new JdeField("CSJC10", "CSJC10", JdeDataType.String, 6),
        new JdeField("CSMTHPR", "CSMTHPR", JdeDataType.String, 2),
        new JdeField("CSPYSPM", "CSPYSPM", JdeDataType.String, 2),
        new JdeField("CSPYPRT", "CSPYPRT", JdeDataType.String, 2),
        new JdeField("CSMCU", "CSMCU", JdeDataType.String, 24),
        new JdeField("CSURAB", "CSURAB", JdeDataType.Numeric),
        new JdeField("CSURCD", "CSURCD", JdeDataType.String, 4),
        new JdeField("CSURAT", "CSURAT", JdeDataType.Numeric),
        new JdeField("CSURDT", "CSURDT", JdeDataType.Numeric),
        new JdeField("CSURRF", "CSURRF", JdeDataType.String, 30),
        new JdeField("CSCRTU", "CSCRTU", JdeDataType.String, 20),
        new JdeField("CSUSER", "CSUSER", JdeDataType.String, 20),
        new JdeField("CSJOBN", "CSJOBN", JdeDataType.String, 20),
        new JdeField("CSPID", "CSPID", JdeDataType.String, 20),
        new JdeField("CSUPMJ", "CSUPMJ", JdeDataType.Numeric),
        new JdeField("CSUPMT", "CSUPMT", JdeDataType.Numeric),
        new JdeField("CSRMTHD", "CSRMTHD", JdeDataType.String, 2),
        new JdeField("CSYN01", "CSYN01", JdeDataType.String, 2),
        new JdeField("CSCO", "CSCO", JdeDataType.String, 10, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1797_0", "Primary Key on CSAN8, CSITYPE, CSCO", new[] { "CSAN8", "CSITYPE", "CSCO" }, isUnique: true, isPrimaryKey: true)
    };
}
