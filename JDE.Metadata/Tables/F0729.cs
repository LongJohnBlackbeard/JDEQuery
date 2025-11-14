using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0729 - .
/// </summary>
public class F0729 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Y9AN8.
        /// </summary>
        public const string Y9AN8 = "Y9AN8";

        /// <summary>
        /// Y9CKCN.
        /// </summary>
        public const string Y9CKCN = "Y9CKCN";

        /// <summary>
        /// Y9DLVL.
        /// </summary>
        public const string Y9DLVL = "Y9DLVL";

        /// <summary>
        /// Y9PDBA.
        /// </summary>
        public const string Y9PDBA = "Y9PDBA";

        /// <summary>
        /// Y9WANO.
        /// </summary>
        public const string Y9WANO = "Y9WANO";

        /// <summary>
        /// Y9TSKID.
        /// </summary>
        public const string Y9TSKID = "Y9TSKID";

        /// <summary>
        /// Y9PRTR.
        /// </summary>
        public const string Y9PRTR = "Y9PRTR";

        /// <summary>
        /// Y9EXA.
        /// </summary>
        public const string Y9EXA = "Y9EXA";

        /// <summary>
        /// Y9DISO.
        /// </summary>
        public const string Y9DISO = "Y9DISO";

        /// <summary>
        /// Y9DEDM.
        /// </summary>
        public const string Y9DEDM = "Y9DEDM";

        /// <summary>
        /// Y9ODDM.
        /// </summary>
        public const string Y9ODDM = "Y9ODDM";

        /// <summary>
        /// Y9DTAB.
        /// </summary>
        public const string Y9DTAB = "Y9DTAB";

        /// <summary>
        /// Y9DESQ.
        /// </summary>
        public const string Y9DESQ = "Y9DESQ";

        /// <summary>
        /// Y9SALY.
        /// </summary>
        public const string Y9SALY = "Y9SALY";

        /// <summary>
        /// Y9CMHU.
        /// </summary>
        public const string Y9CMHU = "Y9CMHU";

        /// <summary>
        /// Y9PRTX.
        /// </summary>
        public const string Y9PRTX = "Y9PRTX";

        /// <summary>
        /// Y9PB.
        /// </summary>
        public const string Y9PB = "Y9PB";

        /// <summary>
        /// Y9PAYM.
        /// </summary>
        public const string Y9PAYM = "Y9PAYM";

        /// <summary>
        /// Y9SVH.
        /// </summary>
        public const string Y9SVH = "Y9SVH";

        /// <summary>
        /// Y9DBAL.
        /// </summary>
        public const string Y9DBAL = "Y9DBAL";

        /// <summary>
        /// Y9RTAM.
        /// </summary>
        public const string Y9RTAM = "Y9RTAM";

        /// <summary>
        /// Y9ORTM.
        /// </summary>
        public const string Y9ORTM = "Y9ORTM";

        /// <summary>
        /// Y9PCUN.
        /// </summary>
        public const string Y9PCUN = "Y9PCUN";

        /// <summary>
        /// Y9PAYG.
        /// </summary>
        public const string Y9PAYG = "Y9PAYG";

        /// <summary>
        /// Y9PAYN.
        /// </summary>
        public const string Y9PAYN = "Y9PAYN";

        /// <summary>
        /// Y9PCK.
        /// </summary>
        public const string Y9PCK = "Y9PCK";

        /// <summary>
        /// Y9MV.
        /// </summary>
        public const string Y9MV = "Y9MV";

        /// <summary>
        /// Y9CALC.
        /// </summary>
        public const string Y9CALC = "Y9CALC";

        /// <summary>
        /// Y9EPRI.
        /// </summary>
        public const string Y9EPRI = "Y9EPRI";

        /// <summary>
        /// Y9NP.
        /// </summary>
        public const string Y9NP = "Y9NP";

        /// <summary>
        /// Y9PTCT.
        /// </summary>
        public const string Y9PTCT = "Y9PTCT";

        /// <summary>
        /// Y9PSDT.
        /// </summary>
        public const string Y9PSDT = "Y9PSDT";

        /// <summary>
        /// Y9PTDT.
        /// </summary>
        public const string Y9PTDT = "Y9PTDT";

        /// <summary>
        /// Y9EFTB.
        /// </summary>
        public const string Y9EFTB = "Y9EFTB";

        /// <summary>
        /// Y9EFTE.
        /// </summary>
        public const string Y9EFTE = "Y9EFTE";

        /// <summary>
        /// Y9PPRY.
        /// </summary>
        public const string Y9PPRY = "Y9PPRY";

        /// <summary>
        /// Y9PPDL.
        /// </summary>
        public const string Y9PPDL = "Y9PPDL";

        /// <summary>
        /// Y9MDL.
        /// </summary>
        public const string Y9MDL = "Y9MDL";

        /// <summary>
        /// Y9QDL.
        /// </summary>
        public const string Y9QDL = "Y9QDL";

        /// <summary>
        /// Y9ADL.
        /// </summary>
        public const string Y9ADL = "Y9ADL";

        /// <summary>
        /// Y9SADL.
        /// </summary>
        public const string Y9SADL = "Y9SADL";

        /// <summary>
        /// Y9AMTS.
        /// </summary>
        public const string Y9AMTS = "Y9AMTS";

        /// <summary>
        /// Y9PPPL.
        /// </summary>
        public const string Y9PPPL = "Y9PPPL";

        /// <summary>
        /// Y9DGRP.
        /// </summary>
        public const string Y9DGRP = "Y9DGRP";

        /// <summary>
        /// Y9HMIN.
        /// </summary>
        public const string Y9HMIN = "Y9HMIN";

        /// <summary>
        /// Y9HMAX.
        /// </summary>
        public const string Y9HMAX = "Y9HMAX";

        /// <summary>
        /// Y9ANN8.
        /// </summary>
        public const string Y9ANN8 = "Y9ANN8";

        /// <summary>
        /// Y9DPRI.
        /// </summary>
        public const string Y9DPRI = "Y9DPRI";

        /// <summary>
        /// Y9PDED.
        /// </summary>
        public const string Y9PDED = "Y9PDED";

        /// <summary>
        /// Y9ARRR.
        /// </summary>
        public const string Y9ARRR = "Y9ARRR";

        /// <summary>
        /// Y9ARRA.
        /// </summary>
        public const string Y9ARRA = "Y9ARRA";

        /// <summary>
        /// Y9DEP1.
        /// </summary>
        public const string Y9DEP1 = "Y9DEP1";

        /// <summary>
        /// Y9DEP2.
        /// </summary>
        public const string Y9DEP2 = "Y9DEP2";

        /// <summary>
        /// Y9DEP3.
        /// </summary>
        public const string Y9DEP3 = "Y9DEP3";

        /// <summary>
        /// Y9DEP4.
        /// </summary>
        public const string Y9DEP4 = "Y9DEP4";

        /// <summary>
        /// Y9DEP5.
        /// </summary>
        public const string Y9DEP5 = "Y9DEP5";

        /// <summary>
        /// Y9DEP6.
        /// </summary>
        public const string Y9DEP6 = "Y9DEP6";

        /// <summary>
        /// Y9GVCH.
        /// </summary>
        public const string Y9GVCH = "Y9GVCH";

        /// <summary>
        /// Y9ZOVR.
        /// </summary>
        public const string Y9ZOVR = "Y9ZOVR";

        /// <summary>
        /// Y9DBAS.
        /// </summary>
        public const string Y9DBAS = "Y9DBAS";

        /// <summary>
        /// Y9HMCO.
        /// </summary>
        public const string Y9HMCO = "Y9HMCO";

        /// <summary>
        /// Y9DC.
        /// </summary>
        public const string Y9DC = "Y9DC";

        /// <summary>
        /// Y9TARA.
        /// </summary>
        public const string Y9TARA = "Y9TARA";

        /// <summary>
        /// Y9TDBA.
        /// </summary>
        public const string Y9TDBA = "Y9TDBA";

        /// <summary>
        /// Y9CMAX.
        /// </summary>
        public const string Y9CMAX = "Y9CMAX";

        /// <summary>
        /// Y9SACC.
        /// </summary>
        public const string Y9SACC = "Y9SACC";

        /// <summary>
        /// Y9UDBA.
        /// </summary>
        public const string Y9UDBA = "Y9UDBA";

        /// <summary>
        /// Y9NPER.
        /// </summary>
        public const string Y9NPER = "Y9NPER";

        /// <summary>
        /// Y9UN.
        /// </summary>
        public const string Y9UN = "Y9UN";

        /// <summary>
        /// Y9MCU.
        /// </summary>
        public const string Y9MCU = "Y9MCU";

        /// <summary>
        /// Y9JBCD.
        /// </summary>
        public const string Y9JBCD = "Y9JBCD";

        /// <summary>
        /// Y9JBST.
        /// </summary>
        public const string Y9JBST = "Y9JBST";

        /// <summary>
        /// Y9TT01.
        /// </summary>
        public const string Y9TT01 = "Y9TT01";

        /// <summary>
        /// Y9TT02.
        /// </summary>
        public const string Y9TT02 = "Y9TT02";

        /// <summary>
        /// Y9TT03.
        /// </summary>
        public const string Y9TT03 = "Y9TT03";

        /// <summary>
        /// Y9TT04.
        /// </summary>
        public const string Y9TT04 = "Y9TT04";

        /// <summary>
        /// Y9TT05.
        /// </summary>
        public const string Y9TT05 = "Y9TT05";

        /// <summary>
        /// Y9TT06.
        /// </summary>
        public const string Y9TT06 = "Y9TT06";

        /// <summary>
        /// Y9TT07.
        /// </summary>
        public const string Y9TT07 = "Y9TT07";

        /// <summary>
        /// Y9TT08.
        /// </summary>
        public const string Y9TT08 = "Y9TT08";

        /// <summary>
        /// Y9TT09.
        /// </summary>
        public const string Y9TT09 = "Y9TT09";

        /// <summary>
        /// Y9TT10.
        /// </summary>
        public const string Y9TT10 = "Y9TT10";

        /// <summary>
        /// Y9TT11.
        /// </summary>
        public const string Y9TT11 = "Y9TT11";

        /// <summary>
        /// Y9TT12.
        /// </summary>
        public const string Y9TT12 = "Y9TT12";

        /// <summary>
        /// Y9TT13.
        /// </summary>
        public const string Y9TT13 = "Y9TT13";

        /// <summary>
        /// Y9TT14.
        /// </summary>
        public const string Y9TT14 = "Y9TT14";

        /// <summary>
        /// Y9TT15.
        /// </summary>
        public const string Y9TT15 = "Y9TT15";

        /// <summary>
        /// Y9UPMJ.
        /// </summary>
        public const string Y9UPMJ = "Y9UPMJ";

        /// <summary>
        /// Y9UPMT.
        /// </summary>
        public const string Y9UPMT = "Y9UPMT";

        /// <summary>
        /// Y9PID.
        /// </summary>
        public const string Y9PID = "Y9PID";

        /// <summary>
        /// Y9JOBN.
        /// </summary>
        public const string Y9JOBN = "Y9JOBN";

        /// <summary>
        /// Y9USER.
        /// </summary>
        public const string Y9USER = "Y9USER";

        /// <summary>
        /// Y9DEFR.
        /// </summary>
        public const string Y9DEFR = "Y9DEFR";
    }

    /// <inheritdoc />
    public override string TableName => "F0729";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Y9AN8", "Y9AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("Y9CKCN", "Y9CKCN", JdeDataType.Numeric, null, true, true),
        new JdeField("Y9DLVL", "Y9DLVL", JdeDataType.String, 2, true, true),
        new JdeField("Y9PDBA", "Y9PDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("Y9WANO", "Y9WANO", JdeDataType.Numeric, null, true, true),
        new JdeField("Y9TSKID", "Y9TSKID", JdeDataType.Numeric),
        new JdeField("Y9PRTR", "Y9PRTR", JdeDataType.Numeric),
        new JdeField("Y9EXA", "Y9EXA", JdeDataType.String, 60),
        new JdeField("Y9DISO", "Y9DISO", JdeDataType.String, 2),
        new JdeField("Y9DEDM", "Y9DEDM", JdeDataType.String, 2),
        new JdeField("Y9ODDM", "Y9ODDM", JdeDataType.String, 2),
        new JdeField("Y9DTAB", "Y9DTAB", JdeDataType.String, 10),
        new JdeField("Y9DESQ", "Y9DESQ", JdeDataType.String, 2),
        new JdeField("Y9SALY", "Y9SALY", JdeDataType.String, 2),
        new JdeField("Y9CMHU", "Y9CMHU", JdeDataType.String, 2),
        new JdeField("Y9PRTX", "Y9PRTX", JdeDataType.String, 6),
        new JdeField("Y9PB", "Y9PB", JdeDataType.String, 2),
        new JdeField("Y9PAYM", "Y9PAYM", JdeDataType.Numeric),
        new JdeField("Y9SVH", "Y9SVH", JdeDataType.String, 2),
        new JdeField("Y9DBAL", "Y9DBAL", JdeDataType.String, 2),
        new JdeField("Y9RTAM", "Y9RTAM", JdeDataType.Numeric),
        new JdeField("Y9ORTM", "Y9ORTM", JdeDataType.Numeric),
        new JdeField("Y9PCUN", "Y9PCUN", JdeDataType.Numeric),
        new JdeField("Y9PAYG", "Y9PAYG", JdeDataType.String, 2),
        new JdeField("Y9PAYN", "Y9PAYN", JdeDataType.String, 2),
        new JdeField("Y9PCK", "Y9PCK", JdeDataType.String, 2),
        new JdeField("Y9MV", "Y9MV", JdeDataType.String, 2),
        new JdeField("Y9CALC", "Y9CALC", JdeDataType.String, 2),
        new JdeField("Y9EPRI", "Y9EPRI", JdeDataType.String, 2),
        new JdeField("Y9NP", "Y9NP", JdeDataType.Numeric),
        new JdeField("Y9PTCT", "Y9PTCT", JdeDataType.String, 2),
        new JdeField("Y9PSDT", "Y9PSDT", JdeDataType.Numeric),
        new JdeField("Y9PTDT", "Y9PTDT", JdeDataType.Numeric),
        new JdeField("Y9EFTB", "Y9EFTB", JdeDataType.Numeric),
        new JdeField("Y9EFTE", "Y9EFTE", JdeDataType.Numeric),
        new JdeField("Y9PPRY", "Y9PPRY", JdeDataType.String, 2),
        new JdeField("Y9PPDL", "Y9PPDL", JdeDataType.Numeric),
        new JdeField("Y9MDL", "Y9MDL", JdeDataType.Numeric),
        new JdeField("Y9QDL", "Y9QDL", JdeDataType.Numeric),
        new JdeField("Y9ADL", "Y9ADL", JdeDataType.Numeric),
        new JdeField("Y9SADL", "Y9SADL", JdeDataType.Numeric),
        new JdeField("Y9AMTS", "Y9AMTS", JdeDataType.Numeric),
        new JdeField("Y9PPPL", "Y9PPPL", JdeDataType.Numeric),
        new JdeField("Y9DGRP", "Y9DGRP", JdeDataType.String, 4),
        new JdeField("Y9HMIN", "Y9HMIN", JdeDataType.Numeric),
        new JdeField("Y9HMAX", "Y9HMAX", JdeDataType.Numeric),
        new JdeField("Y9ANN8", "Y9ANN8", JdeDataType.Numeric),
        new JdeField("Y9DPRI", "Y9DPRI", JdeDataType.Numeric),
        new JdeField("Y9PDED", "Y9PDED", JdeDataType.Numeric),
        new JdeField("Y9ARRR", "Y9ARRR", JdeDataType.String, 2),
        new JdeField("Y9ARRA", "Y9ARRA", JdeDataType.Numeric),
        new JdeField("Y9DEP1", "Y9DEP1", JdeDataType.String, 2),
        new JdeField("Y9DEP2", "Y9DEP2", JdeDataType.String, 2),
        new JdeField("Y9DEP3", "Y9DEP3", JdeDataType.String, 2),
        new JdeField("Y9DEP4", "Y9DEP4", JdeDataType.String, 2),
        new JdeField("Y9DEP5", "Y9DEP5", JdeDataType.String, 2),
        new JdeField("Y9DEP6", "Y9DEP6", JdeDataType.String, 2),
        new JdeField("Y9GVCH", "Y9GVCH", JdeDataType.String, 2),
        new JdeField("Y9ZOVR", "Y9ZOVR", JdeDataType.String, 2),
        new JdeField("Y9DBAS", "Y9DBAS", JdeDataType.String, 2),
        new JdeField("Y9HMCO", "Y9HMCO", JdeDataType.String, 10),
        new JdeField("Y9DC", "Y9DC", JdeDataType.String, 80),
        new JdeField("Y9TARA", "Y9TARA", JdeDataType.String, 20),
        new JdeField("Y9TDBA", "Y9TDBA", JdeDataType.String, 2),
        new JdeField("Y9CMAX", "Y9CMAX", JdeDataType.Numeric),
        new JdeField("Y9SACC", "Y9SACC", JdeDataType.String, 6),
        new JdeField("Y9UDBA", "Y9UDBA", JdeDataType.String, 2),
        new JdeField("Y9NPER", "Y9NPER", JdeDataType.String, 2),
        new JdeField("Y9UN", "Y9UN", JdeDataType.String, 12),
        new JdeField("Y9MCU", "Y9MCU", JdeDataType.String, 24),
        new JdeField("Y9JBCD", "Y9JBCD", JdeDataType.String, 12),
        new JdeField("Y9JBST", "Y9JBST", JdeDataType.String, 8),
        new JdeField("Y9TT01", "Y9TT01", JdeDataType.String, 4),
        new JdeField("Y9TT02", "Y9TT02", JdeDataType.String, 4),
        new JdeField("Y9TT03", "Y9TT03", JdeDataType.String, 4),
        new JdeField("Y9TT04", "Y9TT04", JdeDataType.String, 4),
        new JdeField("Y9TT05", "Y9TT05", JdeDataType.String, 4),
        new JdeField("Y9TT06", "Y9TT06", JdeDataType.String, 4),
        new JdeField("Y9TT07", "Y9TT07", JdeDataType.String, 4),
        new JdeField("Y9TT08", "Y9TT08", JdeDataType.String, 4),
        new JdeField("Y9TT09", "Y9TT09", JdeDataType.String, 4),
        new JdeField("Y9TT10", "Y9TT10", JdeDataType.String, 4),
        new JdeField("Y9TT11", "Y9TT11", JdeDataType.String, 4),
        new JdeField("Y9TT12", "Y9TT12", JdeDataType.String, 4),
        new JdeField("Y9TT13", "Y9TT13", JdeDataType.String, 4),
        new JdeField("Y9TT14", "Y9TT14", JdeDataType.String, 4),
        new JdeField("Y9TT15", "Y9TT15", JdeDataType.String, 4),
        new JdeField("Y9UPMJ", "Y9UPMJ", JdeDataType.Numeric),
        new JdeField("Y9UPMT", "Y9UPMT", JdeDataType.Numeric),
        new JdeField("Y9PID", "Y9PID", JdeDataType.String, 20),
        new JdeField("Y9JOBN", "Y9JOBN", JdeDataType.String, 20),
        new JdeField("Y9USER", "Y9USER", JdeDataType.String, 20),
        new JdeField("Y9DEFR", "Y9DEFR", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0729_0", "Primary Key on Y9AN8, Y9CKCN, Y9DLVL, Y9PDBA, Y9WANO", new[] { "Y9AN8", "Y9CKCN", "Y9DLVL", "Y9PDBA", "Y9WANO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0729_3", "Index on Y9UN, Y9MCU, Y9JBCD, Y9JBST", new[] { "Y9UN", "Y9MCU", "Y9JBCD", "Y9JBST" })
    };
}
