using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW31 - .
/// </summary>
public class FCW31 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LVC9CMRL.
        /// </summary>
        public const string LVC9CMRL = "LVC9CMRL";

        /// <summary>
        /// LVSRDS.
        /// </summary>
        public const string LVSRDS = "LVSRDS";

        /// <summary>
        /// LVKCOO.
        /// </summary>
        public const string LVKCOO = "LVKCOO";

        /// <summary>
        /// LVDOCO.
        /// </summary>
        public const string LVDOCO = "LVDOCO";

        /// <summary>
        /// LVDCTO.
        /// </summary>
        public const string LVDCTO = "LVDCTO";

        /// <summary>
        /// LVLNID.
        /// </summary>
        public const string LVLNID = "LVLNID";

        /// <summary>
        /// LVLNTY.
        /// </summary>
        public const string LVLNTY = "LVLNTY";

        /// <summary>
        /// LVAN8.
        /// </summary>
        public const string LVAN8 = "LVAN8";

        /// <summary>
        /// LVC9LVNM.
        /// </summary>
        public const string LVC9LVNM = "LVC9LVNM";

        /// <summary>
        /// LVITM.
        /// </summary>
        public const string LVITM = "LVITM";

        /// <summary>
        /// LVC9COOR.
        /// </summary>
        public const string LVC9COOR = "LVC9COOR";

        /// <summary>
        /// LVMCU.
        /// </summary>
        public const string LVMCU = "LVMCU";

        /// <summary>
        /// LVLOCN.
        /// </summary>
        public const string LVLOCN = "LVLOCN";

        /// <summary>
        /// LVLOTN.
        /// </summary>
        public const string LVLOTN = "LVLOTN";

        /// <summary>
        /// LVUORG.
        /// </summary>
        public const string LVUORG = "LVUORG";

        /// <summary>
        /// LVSOQS.
        /// </summary>
        public const string LVSOQS = "LVSOQS";

        /// <summary>
        /// LVC9LN1.
        /// </summary>
        public const string LVC9LN1 = "LVC9LN1";

        /// <summary>
        /// LVC9CTHB.
        /// </summary>
        public const string LVC9CTHB = "LVC9CTHB";

        /// <summary>
        /// LVC9CDHB.
        /// </summary>
        public const string LVC9CDHB = "LVC9CDHB";

        /// <summary>
        /// LVC9LINE.
        /// </summary>
        public const string LVC9LINE = "LVC9LINE";

        /// <summary>
        /// LVC9LVL0.
        /// </summary>
        public const string LVC9LVL0 = "LVC9LVL0";

        /// <summary>
        /// LVC9LVL1.
        /// </summary>
        public const string LVC9LVL1 = "LVC9LVL1";

        /// <summary>
        /// LVC9LVL2.
        /// </summary>
        public const string LVC9LVL2 = "LVC9LVL2";

        /// <summary>
        /// LVC9LVL3.
        /// </summary>
        public const string LVC9LVL3 = "LVC9LVL3";

        /// <summary>
        /// LVC9LVL4.
        /// </summary>
        public const string LVC9LVL4 = "LVC9LVL4";

        /// <summary>
        /// LVLTTR.
        /// </summary>
        public const string LVLTTR = "LVLTTR";

        /// <summary>
        /// LVNXTR.
        /// </summary>
        public const string LVNXTR = "LVNXTR";

        /// <summary>
        /// LVOTQY.
        /// </summary>
        public const string LVOTQY = "LVOTQY";

        /// <summary>
        /// LVC9MCU.
        /// </summary>
        public const string LVC9MCU = "LVC9MCU";

        /// <summary>
        /// LVC9LTTR.
        /// </summary>
        public const string LVC9LTTR = "LVC9LTTR";

        /// <summary>
        /// LVC9NXTR.
        /// </summary>
        public const string LVC9NXTR = "LVC9NXTR";

        /// <summary>
        /// LVC9ITMP.
        /// </summary>
        public const string LVC9ITMP = "LVC9ITMP";

        /// <summary>
        /// LVUSER.
        /// </summary>
        public const string LVUSER = "LVUSER";

        /// <summary>
        /// LVCTID.
        /// </summary>
        public const string LVCTID = "LVCTID";

        /// <summary>
        /// LVPID.
        /// </summary>
        public const string LVPID = "LVPID";

        /// <summary>
        /// LVCRDJ.
        /// </summary>
        public const string LVCRDJ = "LVCRDJ";

        /// <summary>
        /// LVTDAY.
        /// </summary>
        public const string LVTDAY = "LVTDAY";

        /// <summary>
        /// LVRCD.
        /// </summary>
        public const string LVRCD = "LVRCD";

        /// <summary>
        /// LVCLLH1.
        /// </summary>
        public const string LVCLLH1 = "LVCLLH1";

        /// <summary>
        /// LVCLLH2.
        /// </summary>
        public const string LVCLLH2 = "LVCLLH2";

        /// <summary>
        /// LVC9DS01.
        /// </summary>
        public const string LVC9DS01 = "LVC9DS01";

        /// <summary>
        /// LVC9DS02.
        /// </summary>
        public const string LVC9DS02 = "LVC9DS02";

        /// <summary>
        /// LVC9DS03.
        /// </summary>
        public const string LVC9DS03 = "LVC9DS03";

        /// <summary>
        /// LVDSC1.
        /// </summary>
        public const string LVDSC1 = "LVDSC1";

        /// <summary>
        /// LVDSC2.
        /// </summary>
        public const string LVDSC2 = "LVDSC2";

        /// <summary>
        /// LVDSC3.
        /// </summary>
        public const string LVDSC3 = "LVDSC3";
    }

    /// <inheritdoc />
    public override string TableName => "FCW31";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LVC9CMRL", "LVC9CMRL", JdeDataType.String, 20, true, true),
        new JdeField("LVSRDS", "LVSRDS", JdeDataType.String, 120, true, true),
        new JdeField("LVKCOO", "LVKCOO", JdeDataType.String, 10, true, true),
        new JdeField("LVDOCO", "LVDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("LVDCTO", "LVDCTO", JdeDataType.String, 4, true, true),
        new JdeField("LVLNID", "LVLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("LVLNTY", "LVLNTY", JdeDataType.String, 4),
        new JdeField("LVAN8", "LVAN8", JdeDataType.Numeric),
        new JdeField("LVC9LVNM", "LVC9LVNM", JdeDataType.String, 100),
        new JdeField("LVITM", "LVITM", JdeDataType.Numeric),
        new JdeField("LVC9COOR", "LVC9COOR", JdeDataType.String, 120),
        new JdeField("LVMCU", "LVMCU", JdeDataType.String, 24),
        new JdeField("LVLOCN", "LVLOCN", JdeDataType.String, 40),
        new JdeField("LVLOTN", "LVLOTN", JdeDataType.String, 60),
        new JdeField("LVUORG", "LVUORG", JdeDataType.Numeric),
        new JdeField("LVSOQS", "LVSOQS", JdeDataType.Numeric),
        new JdeField("LVC9LN1", "LVC9LN1", JdeDataType.Numeric),
        new JdeField("LVC9CTHB", "LVC9CTHB", JdeDataType.String, 20),
        new JdeField("LVC9CDHB", "LVC9CDHB", JdeDataType.String, 20),
        new JdeField("LVC9LINE", "LVC9LINE", JdeDataType.Numeric),
        new JdeField("LVC9LVL0", "LVC9LVL0", JdeDataType.String, 50),
        new JdeField("LVC9LVL1", "LVC9LVL1", JdeDataType.String, 12),
        new JdeField("LVC9LVL2", "LVC9LVL2", JdeDataType.String, 12),
        new JdeField("LVC9LVL3", "LVC9LVL3", JdeDataType.String, 12),
        new JdeField("LVC9LVL4", "LVC9LVL4", JdeDataType.String, 12),
        new JdeField("LVLTTR", "LVLTTR", JdeDataType.String, 6),
        new JdeField("LVNXTR", "LVNXTR", JdeDataType.String, 6),
        new JdeField("LVOTQY", "LVOTQY", JdeDataType.String, 2),
        new JdeField("LVC9MCU", "LVC9MCU", JdeDataType.String, 24),
        new JdeField("LVC9LTTR", "LVC9LTTR", JdeDataType.String, 6),
        new JdeField("LVC9NXTR", "LVC9NXTR", JdeDataType.String, 6),
        new JdeField("LVC9ITMP", "LVC9ITMP", JdeDataType.Numeric),
        new JdeField("LVUSER", "LVUSER", JdeDataType.String, 20),
        new JdeField("LVCTID", "LVCTID", JdeDataType.String, 30),
        new JdeField("LVPID", "LVPID", JdeDataType.String, 20),
        new JdeField("LVCRDJ", "LVCRDJ", JdeDataType.Numeric),
        new JdeField("LVTDAY", "LVTDAY", JdeDataType.Numeric),
        new JdeField("LVRCD", "LVRCD", JdeDataType.String, 6),
        new JdeField("LVCLLH1", "LVCLLH1", JdeDataType.String, 24),
        new JdeField("LVCLLH2", "LVCLLH2", JdeDataType.String, 24),
        new JdeField("LVC9DS01", "LVC9DS01", JdeDataType.String, 12),
        new JdeField("LVC9DS02", "LVC9DS02", JdeDataType.String, 12),
        new JdeField("LVC9DS03", "LVC9DS03", JdeDataType.String, 12),
        new JdeField("LVDSC1", "LVDSC1", JdeDataType.String, 60),
        new JdeField("LVDSC2", "LVDSC2", JdeDataType.String, 60),
        new JdeField("LVDSC3", "LVDSC3", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW31_0", "Primary Key on LVC9CMRL, LVSRDS, LVKCOO, LVDOCO, LVDCTO, LVLNID", new[] { "LVC9CMRL", "LVSRDS", "LVKCOO", "LVDOCO", "LVDCTO", "LVLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FCW31_2", "Index on LVC9CMRL, LVC9LN1", new[] { "LVC9CMRL", "LVC9LN1" }),
        new JdeIndex("FCW31_3", "Index on LVC9CMRL, LVKCOO, LVDOCO, LVDCTO", new[] { "LVC9CMRL", "LVKCOO", "LVDOCO", "LVDCTO" }),
        new JdeIndex("FCW31_4", "Index on LVC9CMRL, LVKCOO, LVDOCO, LVDCTO, LVC9LINE, LVLNID", new[] { "LVC9CMRL", "LVKCOO", "LVDOCO", "LVDCTO", "LVC9LINE", "LVLNID" }),
        new JdeIndex("FCW31_5", "Index on LVC9CMRL, LVKCOO, LVDOCO, LVDCTO, LVLNID", new[] { "LVC9CMRL", "LVKCOO", "LVDOCO", "LVDCTO", "LVLNID" })
    };
}
