using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F069106 - .
/// </summary>
public class F069106 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Y1UN.
        /// </summary>
        public const string Y1UN = "Y1UN";

        /// <summary>
        /// Y1JBCD.
        /// </summary>
        public const string Y1JBCD = "Y1JBCD";

        /// <summary>
        /// Y1JBST.
        /// </summary>
        public const string Y1JBST = "Y1JBST";

        /// <summary>
        /// Y1EXR.
        /// </summary>
        public const string Y1EXR = "Y1EXR";

        /// <summary>
        /// Y1PDBA.
        /// </summary>
        public const string Y1PDBA = "Y1PDBA";

        /// <summary>
        /// Y1DISO.
        /// </summary>
        public const string Y1DISO = "Y1DISO";

        /// <summary>
        /// Y1PGRP.
        /// </summary>
        public const string Y1PGRP = "Y1PGRP";

        /// <summary>
        /// Y1PSDT.
        /// </summary>
        public const string Y1PSDT = "Y1PSDT";

        /// <summary>
        /// Y1PTDT.
        /// </summary>
        public const string Y1PTDT = "Y1PTDT";

        /// <summary>
        /// Y1SFLG.
        /// </summary>
        public const string Y1SFLG = "Y1SFLG";

        /// <summary>
        /// Y1DTAB.
        /// </summary>
        public const string Y1DTAB = "Y1DTAB";

        /// <summary>
        /// Y1DESQ.
        /// </summary>
        public const string Y1DESQ = "Y1DESQ";

        /// <summary>
        /// Y1SBL.
        /// </summary>
        public const string Y1SBL = "Y1SBL";

        /// <summary>
        /// Y1LT.
        /// </summary>
        public const string Y1LT = "Y1LT";

        /// <summary>
        /// Y1RTAM.
        /// </summary>
        public const string Y1RTAM = "Y1RTAM";

        /// <summary>
        /// Y1GPA.
        /// </summary>
        public const string Y1GPA = "Y1GPA";

        /// <summary>
        /// Y1PPDL.
        /// </summary>
        public const string Y1PPDL = "Y1PPDL";

        /// <summary>
        /// Y1MDL.
        /// </summary>
        public const string Y1MDL = "Y1MDL";

        /// <summary>
        /// Y1ADL.
        /// </summary>
        public const string Y1ADL = "Y1ADL";

        /// <summary>
        /// Y1PPPL.
        /// </summary>
        public const string Y1PPPL = "Y1PPPL";

        /// <summary>
        /// Y1NP.
        /// </summary>
        public const string Y1NP = "Y1NP";

        /// <summary>
        /// Y1AD.
        /// </summary>
        public const string Y1AD = "Y1AD";

        /// <summary>
        /// Y1HMIN.
        /// </summary>
        public const string Y1HMIN = "Y1HMIN";

        /// <summary>
        /// Y1HMAX.
        /// </summary>
        public const string Y1HMAX = "Y1HMAX";

        /// <summary>
        /// Y1SEC$.
        /// </summary>
        public const string Y1SEC_ = "Y1SEC$";

        /// <summary>
        /// Y1ANN8.
        /// </summary>
        public const string Y1ANN8 = "Y1ANN8";

        /// <summary>
        /// Y1DEP1.
        /// </summary>
        public const string Y1DEP1 = "Y1DEP1";

        /// <summary>
        /// Y1DEP2.
        /// </summary>
        public const string Y1DEP2 = "Y1DEP2";

        /// <summary>
        /// Y1DEP3.
        /// </summary>
        public const string Y1DEP3 = "Y1DEP3";

        /// <summary>
        /// Y1DEP4.
        /// </summary>
        public const string Y1DEP4 = "Y1DEP4";

        /// <summary>
        /// Y1DEP5.
        /// </summary>
        public const string Y1DEP5 = "Y1DEP5";

        /// <summary>
        /// Y1DEP6.
        /// </summary>
        public const string Y1DEP6 = "Y1DEP6";

        /// <summary>
        /// Y1PDED.
        /// </summary>
        public const string Y1PDED = "Y1PDED";

        /// <summary>
        /// Y1DGRP.
        /// </summary>
        public const string Y1DGRP = "Y1DGRP";

        /// <summary>
        /// Y1DPRI.
        /// </summary>
        public const string Y1DPRI = "Y1DPRI";

        /// <summary>
        /// Y1ARRR.
        /// </summary>
        public const string Y1ARRR = "Y1ARRR";

        /// <summary>
        /// Y1QDL.
        /// </summary>
        public const string Y1QDL = "Y1QDL";

        /// <summary>
        /// Y1ACEQ.
        /// </summary>
        public const string Y1ACEQ = "Y1ACEQ";

        /// <summary>
        /// Y1AMTS.
        /// </summary>
        public const string Y1AMTS = "Y1AMTS";

        /// <summary>
        /// Y1SADL.
        /// </summary>
        public const string Y1SADL = "Y1SADL";

        /// <summary>
        /// Y1CMAX.
        /// </summary>
        public const string Y1CMAX = "Y1CMAX";

        /// <summary>
        /// Y1AR1Y.
        /// </summary>
        public const string Y1AR1Y = "Y1AR1Y";

        /// <summary>
        /// Y1ARSY.
        /// </summary>
        public const string Y1ARSY = "Y1ARSY";

        /// <summary>
        /// Y1RTAB.
        /// </summary>
        public const string Y1RTAB = "Y1RTAB";

        /// <summary>
        /// Y1CTAB.
        /// </summary>
        public const string Y1CTAB = "Y1CTAB";

        /// <summary>
        /// Y1MCU.
        /// </summary>
        public const string Y1MCU = "Y1MCU";

        /// <summary>
        /// Y1ODBA.
        /// </summary>
        public const string Y1ODBA = "Y1ODBA";

        /// <summary>
        /// Y1ZOVR.
        /// </summary>
        public const string Y1ZOVR = "Y1ZOVR";

        /// <summary>
        /// Y1USER.
        /// </summary>
        public const string Y1USER = "Y1USER";

        /// <summary>
        /// Y1PID.
        /// </summary>
        public const string Y1PID = "Y1PID";

        /// <summary>
        /// Y1UPMJ.
        /// </summary>
        public const string Y1UPMJ = "Y1UPMJ";

        /// <summary>
        /// Y1GVCH.
        /// </summary>
        public const string Y1GVCH = "Y1GVCH";

        /// <summary>
        /// Y1DEFR.
        /// </summary>
        public const string Y1DEFR = "Y1DEFR";
    }

    /// <inheritdoc />
    public override string TableName => "F069106";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Y1UN", "Y1UN", JdeDataType.String, 12, true, true),
        new JdeField("Y1JBCD", "Y1JBCD", JdeDataType.String, 12, true, true),
        new JdeField("Y1JBST", "Y1JBST", JdeDataType.String, 8, true, true),
        new JdeField("Y1EXR", "Y1EXR", JdeDataType.String, 60),
        new JdeField("Y1PDBA", "Y1PDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("Y1DISO", "Y1DISO", JdeDataType.String, 2, true, true),
        new JdeField("Y1PGRP", "Y1PGRP", JdeDataType.String, 4),
        new JdeField("Y1PSDT", "Y1PSDT", JdeDataType.Numeric, null, true, true),
        new JdeField("Y1PTDT", "Y1PTDT", JdeDataType.Numeric),
        new JdeField("Y1SFLG", "Y1SFLG", JdeDataType.String, 2),
        new JdeField("Y1DTAB", "Y1DTAB", JdeDataType.String, 10),
        new JdeField("Y1DESQ", "Y1DESQ", JdeDataType.String, 2),
        new JdeField("Y1SBL", "Y1SBL", JdeDataType.String, 16),
        new JdeField("Y1LT", "Y1LT", JdeDataType.String, 4),
        new JdeField("Y1RTAM", "Y1RTAM", JdeDataType.Numeric),
        new JdeField("Y1GPA", "Y1GPA", JdeDataType.Numeric),
        new JdeField("Y1PPDL", "Y1PPDL", JdeDataType.Numeric),
        new JdeField("Y1MDL", "Y1MDL", JdeDataType.Numeric),
        new JdeField("Y1ADL", "Y1ADL", JdeDataType.Numeric),
        new JdeField("Y1PPPL", "Y1PPPL", JdeDataType.Numeric),
        new JdeField("Y1NP", "Y1NP", JdeDataType.Numeric),
        new JdeField("Y1AD", "Y1AD", JdeDataType.Numeric),
        new JdeField("Y1HMIN", "Y1HMIN", JdeDataType.Numeric),
        new JdeField("Y1HMAX", "Y1HMAX", JdeDataType.Numeric),
        new JdeField("Y1SEC$", "Y1SEC$", JdeDataType.String, 2),
        new JdeField("Y1ANN8", "Y1ANN8", JdeDataType.Numeric),
        new JdeField("Y1DEP1", "Y1DEP1", JdeDataType.String, 2),
        new JdeField("Y1DEP2", "Y1DEP2", JdeDataType.String, 2),
        new JdeField("Y1DEP3", "Y1DEP3", JdeDataType.String, 2),
        new JdeField("Y1DEP4", "Y1DEP4", JdeDataType.String, 2),
        new JdeField("Y1DEP5", "Y1DEP5", JdeDataType.String, 2),
        new JdeField("Y1DEP6", "Y1DEP6", JdeDataType.String, 2),
        new JdeField("Y1PDED", "Y1PDED", JdeDataType.Numeric),
        new JdeField("Y1DGRP", "Y1DGRP", JdeDataType.String, 4),
        new JdeField("Y1DPRI", "Y1DPRI", JdeDataType.Numeric),
        new JdeField("Y1ARRR", "Y1ARRR", JdeDataType.String, 2),
        new JdeField("Y1QDL", "Y1QDL", JdeDataType.Numeric),
        new JdeField("Y1ACEQ", "Y1ACEQ", JdeDataType.Numeric),
        new JdeField("Y1AMTS", "Y1AMTS", JdeDataType.Numeric),
        new JdeField("Y1SADL", "Y1SADL", JdeDataType.Numeric),
        new JdeField("Y1CMAX", "Y1CMAX", JdeDataType.Numeric),
        new JdeField("Y1AR1Y", "Y1AR1Y", JdeDataType.String, 2),
        new JdeField("Y1ARSY", "Y1ARSY", JdeDataType.String, 2),
        new JdeField("Y1RTAB", "Y1RTAB", JdeDataType.String, 10),
        new JdeField("Y1CTAB", "Y1CTAB", JdeDataType.String, 10),
        new JdeField("Y1MCU", "Y1MCU", JdeDataType.String, 24, true, true),
        new JdeField("Y1ODBA", "Y1ODBA", JdeDataType.String, 2),
        new JdeField("Y1ZOVR", "Y1ZOVR", JdeDataType.String, 2),
        new JdeField("Y1USER", "Y1USER", JdeDataType.String, 20),
        new JdeField("Y1PID", "Y1PID", JdeDataType.String, 20),
        new JdeField("Y1UPMJ", "Y1UPMJ", JdeDataType.Numeric),
        new JdeField("Y1GVCH", "Y1GVCH", JdeDataType.String, 2),
        new JdeField("Y1DEFR", "Y1DEFR", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F069106_0", "Primary Key on Y1UN, Y1MCU, Y1JBCD, Y1JBST, Y1PSDT, Y1PDBA, Y1DISO", new[] { "Y1UN", "Y1MCU", "Y1JBCD", "Y1JBST", "Y1PSDT", "Y1PDBA", "Y1DISO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F069106_2", "Index on Y1UN, Y1MCU, Y1JBCD, Y1JBST, Y1DESQ, Y1PSDT, Y1PDBA, Y1DISO", new[] { "Y1UN", "Y1MCU", "Y1JBCD", "Y1JBST", "Y1DESQ", "Y1PSDT", "Y1PDBA", "Y1DISO" }),
        new JdeIndex("F069106_3", "Index on Y1UN, Y1MCU, Y1JBCD, Y1JBST, Y1PDBA, Y1PSDT", new[] { "Y1UN", "Y1MCU", "Y1JBCD", "Y1JBST", "Y1PDBA", "Y1PSDT" }),
        new JdeIndex("F069106_4", "Index on Y1PDBA", new[] { "Y1PDBA" })
    };
}
