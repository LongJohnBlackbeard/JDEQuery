using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0624 - .
/// </summary>
public class F0624 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// J#PRTR.
        /// </summary>
        public const string J_PRTR = "J#PRTR";

        /// <summary>
        /// J#RCBT.
        /// </summary>
        public const string J_RCBT = "J#RCBT";

        /// <summary>
        /// J#PDBA.
        /// </summary>
        public const string J_PDBA = "J#PDBA";

        /// <summary>
        /// J#PTAX.
        /// </summary>
        public const string J_PTAX = "J#PTAX";

        /// <summary>
        /// J#FRTY.
        /// </summary>
        public const string J_FRTY = "J#FRTY";

        /// <summary>
        /// J#B2RT.
        /// </summary>
        public const string J_B2RT = "J#B2RT";

        /// <summary>
        /// J#BDA.
        /// </summary>
        public const string J_BDA = "J#BDA";

        /// <summary>
        /// J#MCU.
        /// </summary>
        public const string J_MCU = "J#MCU";

        /// <summary>
        /// J#OBJ.
        /// </summary>
        public const string J_OBJ = "J#OBJ";

        /// <summary>
        /// J#SUB.
        /// </summary>
        public const string J_SUB = "J#SUB";

        /// <summary>
        /// J#SBL.
        /// </summary>
        public const string J_SBL = "J#SBL";

        /// <summary>
        /// J#SBLT.
        /// </summary>
        public const string J_SBLT = "J#SBLT";

        /// <summary>
        /// J#BRDS.
        /// </summary>
        public const string J_BRDS = "J#BRDS";

        /// <summary>
        /// J#WR01.
        /// </summary>
        public const string J_WR01 = "J#WR01";

        /// <summary>
        /// J#PHRW.
        /// </summary>
        public const string J_PHRW = "J#PHRW";

        /// <summary>
        /// J#DEDM.
        /// </summary>
        public const string J_DEDM = "J#DEDM";

        /// <summary>
        /// J#AID.
        /// </summary>
        public const string J_AID = "J#AID";
    }

    /// <inheritdoc />
    public override string TableName => "F0624";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("J#PRTR", "J#PRTR", JdeDataType.Numeric, null, true, true),
        new JdeField("J#RCBT", "J#RCBT", JdeDataType.String, 2),
        new JdeField("J#PDBA", "J#PDBA", JdeDataType.Numeric),
        new JdeField("J#PTAX", "J#PTAX", JdeDataType.String, 4),
        new JdeField("J#FRTY", "J#FRTY", JdeDataType.String, 4),
        new JdeField("J#B2RT", "J#B2RT", JdeDataType.Numeric),
        new JdeField("J#BDA", "J#BDA", JdeDataType.Numeric),
        new JdeField("J#MCU", "J#MCU", JdeDataType.String, 24),
        new JdeField("J#OBJ", "J#OBJ", JdeDataType.String, 12),
        new JdeField("J#SUB", "J#SUB", JdeDataType.String, 16),
        new JdeField("J#SBL", "J#SBL", JdeDataType.String, 16),
        new JdeField("J#SBLT", "J#SBLT", JdeDataType.String, 2),
        new JdeField("J#BRDS", "J#BRDS", JdeDataType.String, 2),
        new JdeField("J#WR01", "J#WR01", JdeDataType.String, 8),
        new JdeField("J#PHRW", "J#PHRW", JdeDataType.Numeric),
        new JdeField("J#DEDM", "J#DEDM", JdeDataType.String, 2),
        new JdeField("J#AID", "J#AID", JdeDataType.String, 16)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0624_0", "Primary Key on J#PRTR", new[] { "J#PRTR" }, isUnique: true, isPrimaryKey: true)
    };
}
