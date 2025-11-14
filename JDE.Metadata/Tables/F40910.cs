using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40910 - .
/// </summary>
public class F40910 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// P#JOB.
        /// </summary>
        public const string P_JOB = "P#JOB";

        /// <summary>
        /// P#CTID.
        /// </summary>
        public const string P_CTID = "P#CTID";

        /// <summary>
        /// P#AID.
        /// </summary>
        public const string P_AID = "P#AID";

        /// <summary>
        /// P#SBL.
        /// </summary>
        public const string P_SBL = "P#SBL";

        /// <summary>
        /// P#SBLT.
        /// </summary>
        public const string P_SBLT = "P#SBLT";

        /// <summary>
        /// P#AA.
        /// </summary>
        public const string P_AA = "P#AA";

        /// <summary>
        /// P#AOPN.
        /// </summary>
        public const string P_AOPN = "P#AOPN";

        /// <summary>
        /// P#AAP.
        /// </summary>
        public const string P_AAP = "P#AAP";

        /// <summary>
        /// P#APYC.
        /// </summary>
        public const string P_APYC = "P#APYC";

        /// <summary>
        /// P#MCU.
        /// </summary>
        public const string P_MCU = "P#MCU";

        /// <summary>
        /// P#OBJ.
        /// </summary>
        public const string P_OBJ = "P#OBJ";

        /// <summary>
        /// P#SUB.
        /// </summary>
        public const string P_SUB = "P#SUB";

        /// <summary>
        /// P#CO.
        /// </summary>
        public const string P_CO = "P#CO";

        /// <summary>
        /// P#DL01.
        /// </summary>
        public const string P_DL01 = "P#DL01";
    }

    /// <inheritdoc />
    public override string TableName => "F40910";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("P#JOB", "P#JOB", JdeDataType.String, 16, true, true),
        new JdeField("P#CTID", "P#CTID", JdeDataType.String, 30, true, true),
        new JdeField("P#AID", "P#AID", JdeDataType.String, 16, true, true),
        new JdeField("P#SBL", "P#SBL", JdeDataType.String, 16, true, true),
        new JdeField("P#SBLT", "P#SBLT", JdeDataType.String, 2, true, true),
        new JdeField("P#AA", "P#AA", JdeDataType.Numeric),
        new JdeField("P#AOPN", "P#AOPN", JdeDataType.Numeric),
        new JdeField("P#AAP", "P#AAP", JdeDataType.Numeric),
        new JdeField("P#APYC", "P#APYC", JdeDataType.Numeric),
        new JdeField("P#MCU", "P#MCU", JdeDataType.String, 24),
        new JdeField("P#OBJ", "P#OBJ", JdeDataType.String, 12),
        new JdeField("P#SUB", "P#SUB", JdeDataType.String, 16),
        new JdeField("P#CO", "P#CO", JdeDataType.String, 10),
        new JdeField("P#DL01", "P#DL01", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40910_0", "Primary Key on P#JOB, P#CTID, P#AID, P#SBL, P#SBLT", new[] { "P#JOB", "P#CTID", "P#AID", "P#SBL", "P#SBLT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40910_2", "Index on P#JOB, P#CTID, P#CO, P#MCU, P#OBJ, P#SUB, P#SBL, P#SBLT", new[] { "P#JOB", "P#CTID", "P#CO", "P#MCU", "P#OBJ", "P#SUB", "P#SBL", "P#SBLT" }),
        new JdeIndex("F40910_3", "Index on P#JOB, P#CTID, P#CO, P#MCU, P#SUB, P#OBJ, P#SBL, P#SBLT", new[] { "P#JOB", "P#CTID", "P#CO", "P#MCU", "P#SUB", "P#OBJ", "P#SBL", "P#SBLT" })
    };
}
