using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F5212 - .
/// </summary>
public class F5212 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// G5DOCO.
        /// </summary>
        public const string G5DOCO = "G5DOCO";

        /// <summary>
        /// G5DCTO.
        /// </summary>
        public const string G5DCTO = "G5DCTO";

        /// <summary>
        /// G5KCOO.
        /// </summary>
        public const string G5KCOO = "G5KCOO";

        /// <summary>
        /// G5COCH.
        /// </summary>
        public const string G5COCH = "G5COCH";

        /// <summary>
        /// G5LNID.
        /// </summary>
        public const string G5LNID = "G5LNID";

        /// <summary>
        /// G5LIN.
        /// </summary>
        public const string G5LIN = "G5LIN";

        /// <summary>
        /// G5OPIM.
        /// </summary>
        public const string G5OPIM = "G5OPIM";

        /// <summary>
        /// G5MCU.
        /// </summary>
        public const string G5MCU = "G5MCU";

        /// <summary>
        /// G5SUB.
        /// </summary>
        public const string G5SUB = "G5SUB";

        /// <summary>
        /// G5OBJ.
        /// </summary>
        public const string G5OBJ = "G5OBJ";

        /// <summary>
        /// G5SBL.
        /// </summary>
        public const string G5SBL = "G5SBL";

        /// <summary>
        /// G5SBLT.
        /// </summary>
        public const string G5SBLT = "G5SBLT";

        /// <summary>
        /// G5JBCD.
        /// </summary>
        public const string G5JBCD = "G5JBCD";

        /// <summary>
        /// G5JBST.
        /// </summary>
        public const string G5JBST = "G5JBST";

        /// <summary>
        /// G5PDBA.
        /// </summary>
        public const string G5PDBA = "G5PDBA";

        /// <summary>
        /// G5AN8.
        /// </summary>
        public const string G5AN8 = "G5AN8";

        /// <summary>
        /// G5ACL0.
        /// </summary>
        public const string G5ACL0 = "G5ACL0";

        /// <summary>
        /// G5EQCG.
        /// </summary>
        public const string G5EQCG = "G5EQCG";

        /// <summary>
        /// G5HMCU.
        /// </summary>
        public const string G5HMCU = "G5HMCU";

        /// <summary>
        /// G5RP12.
        /// </summary>
        public const string G5RP12 = "G5RP12";

        /// <summary>
        /// G5BBF.
        /// </summary>
        public const string G5BBF = "G5BBF";

        /// <summary>
        /// G5ITM.
        /// </summary>
        public const string G5ITM = "G5ITM";

        /// <summary>
        /// G5PRGR.
        /// </summary>
        public const string G5PRGR = "G5PRGR";

        /// <summary>
        /// G5CPGP.
        /// </summary>
        public const string G5CPGP = "G5CPGP";

        /// <summary>
        /// G5PID.
        /// </summary>
        public const string G5PID = "G5PID";

        /// <summary>
        /// G5USER.
        /// </summary>
        public const string G5USER = "G5USER";

        /// <summary>
        /// G5JOBN.
        /// </summary>
        public const string G5JOBN = "G5JOBN";

        /// <summary>
        /// G5UPMJ.
        /// </summary>
        public const string G5UPMJ = "G5UPMJ";

        /// <summary>
        /// G5UPMT.
        /// </summary>
        public const string G5UPMT = "G5UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F5212";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("G5DOCO", "G5DOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("G5DCTO", "G5DCTO", JdeDataType.String, 4, true, true),
        new JdeField("G5KCOO", "G5KCOO", JdeDataType.String, 10, true, true),
        new JdeField("G5COCH", "G5COCH", JdeDataType.String, 6, true, true),
        new JdeField("G5LNID", "G5LNID", JdeDataType.Numeric, null, true, true),
        new JdeField("G5LIN", "G5LIN", JdeDataType.Numeric, null, true, true),
        new JdeField("G5OPIM", "G5OPIM", JdeDataType.String, 30),
        new JdeField("G5MCU", "G5MCU", JdeDataType.String, 24),
        new JdeField("G5SUB", "G5SUB", JdeDataType.String, 16),
        new JdeField("G5OBJ", "G5OBJ", JdeDataType.String, 12),
        new JdeField("G5SBL", "G5SBL", JdeDataType.String, 16),
        new JdeField("G5SBLT", "G5SBLT", JdeDataType.String, 2),
        new JdeField("G5JBCD", "G5JBCD", JdeDataType.String, 12),
        new JdeField("G5JBST", "G5JBST", JdeDataType.String, 8),
        new JdeField("G5PDBA", "G5PDBA", JdeDataType.Numeric),
        new JdeField("G5AN8", "G5AN8", JdeDataType.Numeric),
        new JdeField("G5ACL0", "G5ACL0", JdeDataType.String, 6),
        new JdeField("G5EQCG", "G5EQCG", JdeDataType.String, 18),
        new JdeField("G5HMCU", "G5HMCU", JdeDataType.String, 24),
        new JdeField("G5RP12", "G5RP12", JdeDataType.String, 6),
        new JdeField("G5BBF", "G5BBF", JdeDataType.String, 2),
        new JdeField("G5ITM", "G5ITM", JdeDataType.Numeric),
        new JdeField("G5PRGR", "G5PRGR", JdeDataType.String, 16),
        new JdeField("G5CPGP", "G5CPGP", JdeDataType.String, 16),
        new JdeField("G5PID", "G5PID", JdeDataType.String, 20),
        new JdeField("G5USER", "G5USER", JdeDataType.String, 20),
        new JdeField("G5JOBN", "G5JOBN", JdeDataType.String, 20),
        new JdeField("G5UPMJ", "G5UPMJ", JdeDataType.Numeric),
        new JdeField("G5UPMT", "G5UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F5212_0", "Primary Key on G5DOCO, G5DCTO, G5KCOO, G5COCH, G5LNID, G5LIN", new[] { "G5DOCO", "G5DCTO", "G5KCOO", "G5COCH", "G5LNID", "G5LIN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F5212_10", "Index on G5MCU, G5JBST, G5AN8, G5HMCU, G5RP12, SYS_NC00030$, SYS_NC00031$, SYS_NC00032$, SYS_NC00033$, SYS_NC00034$", new[] { "G5MCU", "G5JBST", "G5AN8", "G5HMCU", "G5RP12", "SYS_NC00030$", "SYS_NC00031$", "SYS_NC00032$", "SYS_NC00033$", "SYS_NC00034$" }),
        new JdeIndex("F5212_11", "Index on G5DOCO, G5DCTO, G5KCOO", new[] { "G5DOCO", "G5DCTO", "G5KCOO" }),
        new JdeIndex("F5212_2", "Index on G5DOCO, G5DCTO, G5KCOO, G5COCH, G5OPIM, G5LIN", new[] { "G5DOCO", "G5DCTO", "G5KCOO", "G5COCH", "G5OPIM", "G5LIN" }),
        new JdeIndex("F5212_3", "Index on G5MCU, G5JBCD, G5JBST, G5PDBA, G5AN8, G5HMCU, G5RP12, G5SUB, G5OBJ, G5SBL, G5SBLT", new[] { "G5MCU", "G5JBCD", "G5JBST", "G5PDBA", "G5AN8", "G5HMCU", "G5RP12", "G5SUB", "G5OBJ", "G5SBL", "G5SBLT" }),
        new JdeIndex("F5212_4", "Index on G5MCU, G5ACL0, G5EQCG, G5HMCU, G5RP12, G5SUB, G5OBJ, G5SBL, G5SBLT", new[] { "G5MCU", "G5ACL0", "G5EQCG", "G5HMCU", "G5RP12", "G5SUB", "G5OBJ", "G5SBL", "G5SBLT" }),
        new JdeIndex("F5212_5", "Index on G5MCU, G5JBST, G5AN8, G5HMCU, G5RP12, G5SUB, G5OBJ, G5SBL, G5SBLT", new[] { "G5MCU", "G5JBST", "G5AN8", "G5HMCU", "G5RP12", "G5SUB", "G5OBJ", "G5SBL", "G5SBLT" }),
        new JdeIndex("F5212_6", "Index on G5DOCO, G5DCTO, G5KCOO, G5COCH, G5LNID, G5MCU", new[] { "G5DOCO", "G5DCTO", "G5KCOO", "G5COCH", "G5LNID", "G5MCU" }),
        new JdeIndex("F5212_7", "Index on G5MCU, G5JBCD, G5JBST, G5PDBA, G5AN8, G5HMCU, G5RP12, SYS_NC00030$, SYS_NC00031$, SYS_NC00032$, SYS_NC00033$", new[] { "G5MCU", "G5JBCD", "G5JBST", "G5PDBA", "G5AN8", "G5HMCU", "G5RP12", "SYS_NC00030$", "SYS_NC00031$", "SYS_NC00032$", "SYS_NC00033$" }),
        new JdeIndex("F5212_9", "Index on G5MCU, G5ACL0, G5EQCG, G5HMCU, G5RP12, SYS_NC00030$, SYS_NC00031$, SYS_NC00032$, SYS_NC00033$", new[] { "G5MCU", "G5ACL0", "G5EQCG", "G5HMCU", "G5RP12", "SYS_NC00030$", "SYS_NC00031$", "SYS_NC00032$", "SYS_NC00033$" })
    };
}
