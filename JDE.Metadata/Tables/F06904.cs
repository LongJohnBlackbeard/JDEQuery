using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F06904 - .
/// </summary>
public class F06904 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Y#CO.
        /// </summary>
        public const string Y_CO = "Y#CO";

        /// <summary>
        /// Y#MCUH.
        /// </summary>
        public const string Y_MCUH = "Y#MCUH";

        /// <summary>
        /// Y#LBOB.
        /// </summary>
        public const string Y_LBOB = "Y#LBOB";

        /// <summary>
        /// Y#LSUB.
        /// </summary>
        public const string Y_LSUB = "Y#LSUB";

        /// <summary>
        /// Y#PDBA.
        /// </summary>
        public const string Y_PDBA = "Y#PDBA";

        /// <summary>
        /// Y#FRTY.
        /// </summary>
        public const string Y_FRTY = "Y#FRTY";

        /// <summary>
        /// Y#MCU.
        /// </summary>
        public const string Y_MCU = "Y#MCU";

        /// <summary>
        /// Y#OBJ.
        /// </summary>
        public const string Y_OBJ = "Y#OBJ";

        /// <summary>
        /// Y#SUB.
        /// </summary>
        public const string Y_SUB = "Y#SUB";

        /// <summary>
        /// Y#HMT.
        /// </summary>
        public const string Y_HMT = "Y#HMT";

        /// <summary>
        /// Y#HFLG.
        /// </summary>
        public const string Y_HFLG = "Y#HFLG";

        /// <summary>
        /// Y#JNLF.
        /// </summary>
        public const string Y_JNLF = "Y#JNLF";

        /// <summary>
        /// Y#PRJC.
        /// </summary>
        public const string Y_PRJC = "Y#PRJC";

        /// <summary>
        /// Y#SBL.
        /// </summary>
        public const string Y_SBL = "Y#SBL";

        /// <summary>
        /// Y#SBLT.
        /// </summary>
        public const string Y_SBLT = "Y#SBLT";

        /// <summary>
        /// Y#DL01.
        /// </summary>
        public const string Y_DL01 = "Y#DL01";

        /// <summary>
        /// Y#MCUO.
        /// </summary>
        public const string Y_MCUO = "Y#MCUO";

        /// <summary>
        /// Y#UN.
        /// </summary>
        public const string Y_UN = "Y#UN";

        /// <summary>
        /// Y#JBCD.
        /// </summary>
        public const string Y_JBCD = "Y#JBCD";

        /// <summary>
        /// Y#JBST.
        /// </summary>
        public const string Y_JBST = "Y#JBST";

        /// <summary>
        /// Y#UKID.
        /// </summary>
        public const string Y_UKID = "Y#UKID";
    }

    /// <inheritdoc />
    public override string TableName => "F06904";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Y#CO", "Y#CO", JdeDataType.String, 10),
        new JdeField("Y#MCUH", "Y#MCUH", JdeDataType.String, 24),
        new JdeField("Y#LBOB", "Y#LBOB", JdeDataType.String, 12),
        new JdeField("Y#LSUB", "Y#LSUB", JdeDataType.String, 16),
        new JdeField("Y#PDBA", "Y#PDBA", JdeDataType.Numeric),
        new JdeField("Y#FRTY", "Y#FRTY", JdeDataType.String, 4),
        new JdeField("Y#MCU", "Y#MCU", JdeDataType.String, 24),
        new JdeField("Y#OBJ", "Y#OBJ", JdeDataType.String, 12),
        new JdeField("Y#SUB", "Y#SUB", JdeDataType.String, 16),
        new JdeField("Y#HMT", "Y#HMT", JdeDataType.String, 2),
        new JdeField("Y#HFLG", "Y#HFLG", JdeDataType.String, 2),
        new JdeField("Y#JNLF", "Y#JNLF", JdeDataType.String, 2),
        new JdeField("Y#PRJC", "Y#PRJC", JdeDataType.String, 2),
        new JdeField("Y#SBL", "Y#SBL", JdeDataType.String, 16),
        new JdeField("Y#SBLT", "Y#SBLT", JdeDataType.String, 2),
        new JdeField("Y#DL01", "Y#DL01", JdeDataType.String, 60),
        new JdeField("Y#MCUO", "Y#MCUO", JdeDataType.String, 24),
        new JdeField("Y#UN", "Y#UN", JdeDataType.String, 12),
        new JdeField("Y#JBCD", "Y#JBCD", JdeDataType.String, 12),
        new JdeField("Y#JBST", "Y#JBST", JdeDataType.String, 8),
        new JdeField("Y#UKID", "Y#UKID", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F06904_0", "Primary Key on Y#UKID", new[] { "Y#UKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F06904_2", "Index on Y#PRJC, Y#CO, Y#MCUH, Y#PDBA, Y#FRTY", new[] { "Y#PRJC", "Y#CO", "Y#MCUH", "Y#PDBA", "Y#FRTY" }),
        new JdeIndex("F06904_3", "Index on Y#CO, Y#MCUH, Y#PDBA, Y#PRJC", new[] { "Y#CO", "Y#MCUH", "Y#PDBA", "Y#PRJC" }),
        new JdeIndex("F06904_4", "Index on Y#CO, Y#MCUH, Y#FRTY, Y#PRJC", new[] { "Y#CO", "Y#MCUH", "Y#FRTY", "Y#PRJC" }),
        new JdeIndex("F06904_5", "Index on Y#CO, Y#MCUH, Y#UN, Y#JBCD, Y#JBST, Y#PDBA, Y#FRTY, Y#PRJC", new[] { "Y#CO", "Y#MCUH", "Y#UN", "Y#JBCD", "Y#JBST", "Y#PDBA", "Y#FRTY", "Y#PRJC" }),
        new JdeIndex("F06904_6", "Index on Y#CO, Y#MCUH, Y#MCUO, Y#PDBA, Y#FRTY, Y#PRJC", new[] { "Y#CO", "Y#MCUH", "Y#MCUO", "Y#PDBA", "Y#FRTY", "Y#PRJC" }),
        new JdeIndex("F06904_7", "Index on Y#CO, Y#PRJC, Y#SBL, Y#LBOB, Y#LSUB, Y#PDBA, Y#FRTY", new[] { "Y#CO", "Y#PRJC", "Y#SBL", "Y#LBOB", "Y#LSUB", "Y#PDBA", "Y#FRTY" }),
        new JdeIndex("F06904_8", "Index on Y#CO, Y#FRTY, Y#SBL, Y#MCUH", new[] { "Y#CO", "Y#FRTY", "Y#SBL", "Y#MCUH" }),
        new JdeIndex("F06904_9", "Index on Y#CO, Y#PRJC, Y#MCUH, Y#LBOB, Y#LSUB, Y#PDBA, Y#FRTY", new[] { "Y#CO", "Y#PRJC", "Y#MCUH", "Y#LBOB", "Y#LSUB", "Y#PDBA", "Y#FRTY" })
    };
}
