using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F46130 - .
/// </summary>
public class F46130 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// R3KCOO.
        /// </summary>
        public const string R3KCOO = "R3KCOO";

        /// <summary>
        /// R3DOCO.
        /// </summary>
        public const string R3DOCO = "R3DOCO";

        /// <summary>
        /// R3DCTO.
        /// </summary>
        public const string R3DCTO = "R3DCTO";

        /// <summary>
        /// R3LNID.
        /// </summary>
        public const string R3LNID = "R3LNID";

        /// <summary>
        /// R3SFXO.
        /// </summary>
        public const string R3SFXO = "R3SFXO";

        /// <summary>
        /// R3SEQ.
        /// </summary>
        public const string R3SEQ = "R3SEQ";

        /// <summary>
        /// R3MCU.
        /// </summary>
        public const string R3MCU = "R3MCU";

        /// <summary>
        /// R3AN8.
        /// </summary>
        public const string R3AN8 = "R3AN8";

        /// <summary>
        /// R3ITM.
        /// </summary>
        public const string R3ITM = "R3ITM";

        /// <summary>
        /// R3LITM.
        /// </summary>
        public const string R3LITM = "R3LITM";

        /// <summary>
        /// R3AITM.
        /// </summary>
        public const string R3AITM = "R3AITM";

        /// <summary>
        /// R3LOCN.
        /// </summary>
        public const string R3LOCN = "R3LOCN";

        /// <summary>
        /// R3LOTN.
        /// </summary>
        public const string R3LOTN = "R3LOTN";

        /// <summary>
        /// R3DRQJ.
        /// </summary>
        public const string R3DRQJ = "R3DRQJ";

        /// <summary>
        /// R3UORG.
        /// </summary>
        public const string R3UORG = "R3UORG";

        /// <summary>
        /// R3UOM.
        /// </summary>
        public const string R3UOM = "R3UOM";

        /// <summary>
        /// R3UOM1.
        /// </summary>
        public const string R3UOM1 = "R3UOM1";

        /// <summary>
        /// R3TQTY.
        /// </summary>
        public const string R3TQTY = "R3TQTY";

        /// <summary>
        /// R3UML1.
        /// </summary>
        public const string R3UML1 = "R3UML1";

        /// <summary>
        /// R3UGL1.
        /// </summary>
        public const string R3UGL1 = "R3UGL1";

        /// <summary>
        /// R3EUL1.
        /// </summary>
        public const string R3EUL1 = "R3EUL1";

        /// <summary>
        /// R3PPL1.
        /// </summary>
        public const string R3PPL1 = "R3PPL1";

        /// <summary>
        /// R3TQL1.
        /// </summary>
        public const string R3TQL1 = "R3TQL1";

        /// <summary>
        /// R3EQL1.
        /// </summary>
        public const string R3EQL1 = "R3EQL1";

        /// <summary>
        /// R3HPL1.
        /// </summary>
        public const string R3HPL1 = "R3HPL1";

        /// <summary>
        /// R3WPL1.
        /// </summary>
        public const string R3WPL1 = "R3WPL1";

        /// <summary>
        /// R3DPL1.
        /// </summary>
        public const string R3DPL1 = "R3DPL1";

        /// <summary>
        /// R3CPL1.
        /// </summary>
        public const string R3CPL1 = "R3CPL1";

        /// <summary>
        /// R3EPL1.
        /// </summary>
        public const string R3EPL1 = "R3EPL1";

        /// <summary>
        /// R3UML2.
        /// </summary>
        public const string R3UML2 = "R3UML2";

        /// <summary>
        /// R3UGL2.
        /// </summary>
        public const string R3UGL2 = "R3UGL2";

        /// <summary>
        /// R3EUL2.
        /// </summary>
        public const string R3EUL2 = "R3EUL2";

        /// <summary>
        /// R3QPL2.
        /// </summary>
        public const string R3QPL2 = "R3QPL2";

        /// <summary>
        /// R3PPL2.
        /// </summary>
        public const string R3PPL2 = "R3PPL2";

        /// <summary>
        /// R3TQL2.
        /// </summary>
        public const string R3TQL2 = "R3TQL2";

        /// <summary>
        /// R3EQL2.
        /// </summary>
        public const string R3EQL2 = "R3EQL2";

        /// <summary>
        /// R3HPL2.
        /// </summary>
        public const string R3HPL2 = "R3HPL2";

        /// <summary>
        /// R3WPL2.
        /// </summary>
        public const string R3WPL2 = "R3WPL2";

        /// <summary>
        /// R3DPL2.
        /// </summary>
        public const string R3DPL2 = "R3DPL2";

        /// <summary>
        /// R3CPL2.
        /// </summary>
        public const string R3CPL2 = "R3CPL2";

        /// <summary>
        /// R3EPL2.
        /// </summary>
        public const string R3EPL2 = "R3EPL2";

        /// <summary>
        /// R3UML3.
        /// </summary>
        public const string R3UML3 = "R3UML3";

        /// <summary>
        /// R3UGL3.
        /// </summary>
        public const string R3UGL3 = "R3UGL3";

        /// <summary>
        /// R3EUL3.
        /// </summary>
        public const string R3EUL3 = "R3EUL3";

        /// <summary>
        /// R3QPL3.
        /// </summary>
        public const string R3QPL3 = "R3QPL3";

        /// <summary>
        /// R3PPL3.
        /// </summary>
        public const string R3PPL3 = "R3PPL3";

        /// <summary>
        /// R3TQL3.
        /// </summary>
        public const string R3TQL3 = "R3TQL3";

        /// <summary>
        /// R3EQL3.
        /// </summary>
        public const string R3EQL3 = "R3EQL3";

        /// <summary>
        /// R3HPL3.
        /// </summary>
        public const string R3HPL3 = "R3HPL3";

        /// <summary>
        /// R3WPL3.
        /// </summary>
        public const string R3WPL3 = "R3WPL3";

        /// <summary>
        /// R3DPL3.
        /// </summary>
        public const string R3DPL3 = "R3DPL3";

        /// <summary>
        /// R3CPL3.
        /// </summary>
        public const string R3CPL3 = "R3CPL3";

        /// <summary>
        /// R3EPL3.
        /// </summary>
        public const string R3EPL3 = "R3EPL3";

        /// <summary>
        /// R3UML4.
        /// </summary>
        public const string R3UML4 = "R3UML4";

        /// <summary>
        /// R3UGL4.
        /// </summary>
        public const string R3UGL4 = "R3UGL4";

        /// <summary>
        /// R3EUL4.
        /// </summary>
        public const string R3EUL4 = "R3EUL4";

        /// <summary>
        /// R3QPL4.
        /// </summary>
        public const string R3QPL4 = "R3QPL4";

        /// <summary>
        /// R3PPL4.
        /// </summary>
        public const string R3PPL4 = "R3PPL4";

        /// <summary>
        /// R3TQL4.
        /// </summary>
        public const string R3TQL4 = "R3TQL4";

        /// <summary>
        /// R3EQL4.
        /// </summary>
        public const string R3EQL4 = "R3EQL4";

        /// <summary>
        /// R3HPL4.
        /// </summary>
        public const string R3HPL4 = "R3HPL4";

        /// <summary>
        /// R3WPL4.
        /// </summary>
        public const string R3WPL4 = "R3WPL4";

        /// <summary>
        /// R3DPL4.
        /// </summary>
        public const string R3DPL4 = "R3DPL4";

        /// <summary>
        /// R3CPL4.
        /// </summary>
        public const string R3CPL4 = "R3CPL4";

        /// <summary>
        /// R3EPL4.
        /// </summary>
        public const string R3EPL4 = "R3EPL4";

        /// <summary>
        /// R3UML5.
        /// </summary>
        public const string R3UML5 = "R3UML5";

        /// <summary>
        /// R3UGL5.
        /// </summary>
        public const string R3UGL5 = "R3UGL5";

        /// <summary>
        /// R3EUL5.
        /// </summary>
        public const string R3EUL5 = "R3EUL5";

        /// <summary>
        /// R3QPL5.
        /// </summary>
        public const string R3QPL5 = "R3QPL5";

        /// <summary>
        /// R3TQL5.
        /// </summary>
        public const string R3TQL5 = "R3TQL5";

        /// <summary>
        /// R3EQL5.
        /// </summary>
        public const string R3EQL5 = "R3EQL5";

        /// <summary>
        /// R3HPL5.
        /// </summary>
        public const string R3HPL5 = "R3HPL5";

        /// <summary>
        /// R3WPL5.
        /// </summary>
        public const string R3WPL5 = "R3WPL5";

        /// <summary>
        /// R3DPL5.
        /// </summary>
        public const string R3DPL5 = "R3DPL5";

        /// <summary>
        /// R3CPL5.
        /// </summary>
        public const string R3CPL5 = "R3CPL5";

        /// <summary>
        /// R3EPL5.
        /// </summary>
        public const string R3EPL5 = "R3EPL5";

        /// <summary>
        /// R3RCUB.
        /// </summary>
        public const string R3RCUB = "R3RCUB";

        /// <summary>
        /// R3VUMD.
        /// </summary>
        public const string R3VUMD = "R3VUMD";

        /// <summary>
        /// R3RWET.
        /// </summary>
        public const string R3RWET = "R3RWET";

        /// <summary>
        /// R3UWUM.
        /// </summary>
        public const string R3UWUM = "R3UWUM";

        /// <summary>
        /// R3EKEY.
        /// </summary>
        public const string R3EKEY = "R3EKEY";

        /// <summary>
        /// R3PSTB.
        /// </summary>
        public const string R3PSTB = "R3PSTB";

        /// <summary>
        /// R3USER.
        /// </summary>
        public const string R3USER = "R3USER";

        /// <summary>
        /// R3PID.
        /// </summary>
        public const string R3PID = "R3PID";

        /// <summary>
        /// R3JOBN.
        /// </summary>
        public const string R3JOBN = "R3JOBN";

        /// <summary>
        /// R3UPMJ.
        /// </summary>
        public const string R3UPMJ = "R3UPMJ";

        /// <summary>
        /// R3TDAY.
        /// </summary>
        public const string R3TDAY = "R3TDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F46130";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("R3KCOO", "R3KCOO", JdeDataType.String, 10, true, true),
        new JdeField("R3DOCO", "R3DOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("R3DCTO", "R3DCTO", JdeDataType.String, 4, true, true),
        new JdeField("R3LNID", "R3LNID", JdeDataType.Numeric, null, true, true),
        new JdeField("R3SFXO", "R3SFXO", JdeDataType.String, 6),
        new JdeField("R3SEQ", "R3SEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("R3MCU", "R3MCU", JdeDataType.String, 24),
        new JdeField("R3AN8", "R3AN8", JdeDataType.Numeric),
        new JdeField("R3ITM", "R3ITM", JdeDataType.Numeric),
        new JdeField("R3LITM", "R3LITM", JdeDataType.String, 50),
        new JdeField("R3AITM", "R3AITM", JdeDataType.String, 50),
        new JdeField("R3LOCN", "R3LOCN", JdeDataType.String, 40),
        new JdeField("R3LOTN", "R3LOTN", JdeDataType.String, 60),
        new JdeField("R3DRQJ", "R3DRQJ", JdeDataType.Numeric),
        new JdeField("R3UORG", "R3UORG", JdeDataType.Numeric),
        new JdeField("R3UOM", "R3UOM", JdeDataType.String, 4),
        new JdeField("R3UOM1", "R3UOM1", JdeDataType.String, 4),
        new JdeField("R3TQTY", "R3TQTY", JdeDataType.Numeric),
        new JdeField("R3UML1", "R3UML1", JdeDataType.String, 4),
        new JdeField("R3UGL1", "R3UGL1", JdeDataType.String, 4),
        new JdeField("R3EUL1", "R3EUL1", JdeDataType.String, 2),
        new JdeField("R3PPL1", "R3PPL1", JdeDataType.Numeric),
        new JdeField("R3TQL1", "R3TQL1", JdeDataType.Numeric),
        new JdeField("R3EQL1", "R3EQL1", JdeDataType.String, 10),
        new JdeField("R3HPL1", "R3HPL1", JdeDataType.Numeric),
        new JdeField("R3WPL1", "R3WPL1", JdeDataType.Numeric),
        new JdeField("R3DPL1", "R3DPL1", JdeDataType.Numeric),
        new JdeField("R3CPL1", "R3CPL1", JdeDataType.Numeric),
        new JdeField("R3EPL1", "R3EPL1", JdeDataType.Numeric),
        new JdeField("R3UML2", "R3UML2", JdeDataType.String, 4),
        new JdeField("R3UGL2", "R3UGL2", JdeDataType.String, 4),
        new JdeField("R3EUL2", "R3EUL2", JdeDataType.String, 2),
        new JdeField("R3QPL2", "R3QPL2", JdeDataType.Numeric),
        new JdeField("R3PPL2", "R3PPL2", JdeDataType.Numeric),
        new JdeField("R3TQL2", "R3TQL2", JdeDataType.Numeric),
        new JdeField("R3EQL2", "R3EQL2", JdeDataType.String, 10),
        new JdeField("R3HPL2", "R3HPL2", JdeDataType.Numeric),
        new JdeField("R3WPL2", "R3WPL2", JdeDataType.Numeric),
        new JdeField("R3DPL2", "R3DPL2", JdeDataType.Numeric),
        new JdeField("R3CPL2", "R3CPL2", JdeDataType.Numeric),
        new JdeField("R3EPL2", "R3EPL2", JdeDataType.Numeric),
        new JdeField("R3UML3", "R3UML3", JdeDataType.String, 4),
        new JdeField("R3UGL3", "R3UGL3", JdeDataType.String, 4),
        new JdeField("R3EUL3", "R3EUL3", JdeDataType.String, 2),
        new JdeField("R3QPL3", "R3QPL3", JdeDataType.Numeric),
        new JdeField("R3PPL3", "R3PPL3", JdeDataType.Numeric),
        new JdeField("R3TQL3", "R3TQL3", JdeDataType.Numeric),
        new JdeField("R3EQL3", "R3EQL3", JdeDataType.String, 10),
        new JdeField("R3HPL3", "R3HPL3", JdeDataType.Numeric),
        new JdeField("R3WPL3", "R3WPL3", JdeDataType.Numeric),
        new JdeField("R3DPL3", "R3DPL3", JdeDataType.Numeric),
        new JdeField("R3CPL3", "R3CPL3", JdeDataType.Numeric),
        new JdeField("R3EPL3", "R3EPL3", JdeDataType.Numeric),
        new JdeField("R3UML4", "R3UML4", JdeDataType.String, 4),
        new JdeField("R3UGL4", "R3UGL4", JdeDataType.String, 4),
        new JdeField("R3EUL4", "R3EUL4", JdeDataType.String, 2),
        new JdeField("R3QPL4", "R3QPL4", JdeDataType.Numeric),
        new JdeField("R3PPL4", "R3PPL4", JdeDataType.Numeric),
        new JdeField("R3TQL4", "R3TQL4", JdeDataType.Numeric),
        new JdeField("R3EQL4", "R3EQL4", JdeDataType.String, 10),
        new JdeField("R3HPL4", "R3HPL4", JdeDataType.Numeric),
        new JdeField("R3WPL4", "R3WPL4", JdeDataType.Numeric),
        new JdeField("R3DPL4", "R3DPL4", JdeDataType.Numeric),
        new JdeField("R3CPL4", "R3CPL4", JdeDataType.Numeric),
        new JdeField("R3EPL4", "R3EPL4", JdeDataType.Numeric),
        new JdeField("R3UML5", "R3UML5", JdeDataType.String, 4),
        new JdeField("R3UGL5", "R3UGL5", JdeDataType.String, 4),
        new JdeField("R3EUL5", "R3EUL5", JdeDataType.String, 2),
        new JdeField("R3QPL5", "R3QPL5", JdeDataType.Numeric),
        new JdeField("R3TQL5", "R3TQL5", JdeDataType.Numeric),
        new JdeField("R3EQL5", "R3EQL5", JdeDataType.String, 10),
        new JdeField("R3HPL5", "R3HPL5", JdeDataType.Numeric),
        new JdeField("R3WPL5", "R3WPL5", JdeDataType.Numeric),
        new JdeField("R3DPL5", "R3DPL5", JdeDataType.Numeric),
        new JdeField("R3CPL5", "R3CPL5", JdeDataType.Numeric),
        new JdeField("R3EPL5", "R3EPL5", JdeDataType.Numeric),
        new JdeField("R3RCUB", "R3RCUB", JdeDataType.Numeric),
        new JdeField("R3VUMD", "R3VUMD", JdeDataType.String, 4),
        new JdeField("R3RWET", "R3RWET", JdeDataType.Numeric),
        new JdeField("R3UWUM", "R3UWUM", JdeDataType.String, 4),
        new JdeField("R3EKEY", "R3EKEY", JdeDataType.String, 8),
        new JdeField("R3PSTB", "R3PSTB", JdeDataType.String, 6),
        new JdeField("R3USER", "R3USER", JdeDataType.String, 20),
        new JdeField("R3PID", "R3PID", JdeDataType.String, 20),
        new JdeField("R3JOBN", "R3JOBN", JdeDataType.String, 20),
        new JdeField("R3UPMJ", "R3UPMJ", JdeDataType.Numeric),
        new JdeField("R3TDAY", "R3TDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F46130_0", "Primary Key on R3DOCO, R3DCTO, R3KCOO, R3LNID, R3SEQ", new[] { "R3DOCO", "R3DCTO", "R3KCOO", "R3LNID", "R3SEQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F46130_2", "Index on R3MCU, R3LOCN, R3ITM, R3PSTB", new[] { "R3MCU", "R3LOCN", "R3ITM", "R3PSTB" }),
        new JdeIndex("F46130_3", "Index on R3DOCO, R3DCTO, R3KCOO, R3LNID, R3PSTB, R3SEQ", new[] { "R3DOCO", "R3DCTO", "R3KCOO", "R3LNID", "R3PSTB", "R3SEQ" }),
        new JdeIndex("F46130_4", "Index on R3MCU, R3ITM, R3UOM, R3PSTB", new[] { "R3MCU", "R3ITM", "R3UOM", "R3PSTB" }),
        new JdeIndex("F46130_5", "Index on R3DOCO, R3DCTO, R3KCOO, R3LNID, R3LOCN", new[] { "R3DOCO", "R3DCTO", "R3KCOO", "R3LNID", "R3LOCN" })
    };
}
