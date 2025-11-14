using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F06491 - .
/// </summary>
public class F06491 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// J6PRID.
        /// </summary>
        public const string J6PRID = "J6PRID";

        /// <summary>
        /// J6ICU.
        /// </summary>
        public const string J6ICU = "J6ICU";

        /// <summary>
        /// J6ANN8.
        /// </summary>
        public const string J6ANN8 = "J6ANN8";

        /// <summary>
        /// J6APTF.
        /// </summary>
        public const string J6APTF = "J6APTF";

        /// <summary>
        /// J6CTL2.
        /// </summary>
        public const string J6CTL2 = "J6CTL2";

        /// <summary>
        /// J6ANI.
        /// </summary>
        public const string J6ANI = "J6ANI";

        /// <summary>
        /// J6GLBA.
        /// </summary>
        public const string J6GLBA = "J6GLBA";

        /// <summary>
        /// J6RMK.
        /// </summary>
        public const string J6RMK = "J6RMK";

        /// <summary>
        /// J6AG.
        /// </summary>
        public const string J6AG = "J6AG";

        /// <summary>
        /// J6DDJ.
        /// </summary>
        public const string J6DDJ = "J6DDJ";

        /// <summary>
        /// J6CO.
        /// </summary>
        public const string J6CO = "J6CO";

        /// <summary>
        /// J6MCU.
        /// </summary>
        public const string J6MCU = "J6MCU";

        /// <summary>
        /// J6OBJ.
        /// </summary>
        public const string J6OBJ = "J6OBJ";

        /// <summary>
        /// J6SUB.
        /// </summary>
        public const string J6SUB = "J6SUB";

        /// <summary>
        /// J6SBL.
        /// </summary>
        public const string J6SBL = "J6SBL";

        /// <summary>
        /// J6SBLT.
        /// </summary>
        public const string J6SBLT = "J6SBLT";

        /// <summary>
        /// J6GLC.
        /// </summary>
        public const string J6GLC = "J6GLC";

        /// <summary>
        /// J6CKDT.
        /// </summary>
        public const string J6CKDT = "J6CKDT";

        /// <summary>
        /// J6SFX.
        /// </summary>
        public const string J6SFX = "J6SFX";

        /// <summary>
        /// J6WANO.
        /// </summary>
        public const string J6WANO = "J6WANO";
    }

    /// <inheritdoc />
    public override string TableName => "F06491";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("J6PRID", "J6PRID", JdeDataType.Numeric, null, true, true),
        new JdeField("J6ICU", "J6ICU", JdeDataType.Numeric, null, true, true),
        new JdeField("J6ANN8", "J6ANN8", JdeDataType.Numeric, null, true, true),
        new JdeField("J6APTF", "J6APTF", JdeDataType.String, 2, true, true),
        new JdeField("J6CTL2", "J6CTL2", JdeDataType.String, 62, true, true),
        new JdeField("J6ANI", "J6ANI", JdeDataType.String, 58, true, true),
        new JdeField("J6GLBA", "J6GLBA", JdeDataType.String, 16),
        new JdeField("J6RMK", "J6RMK", JdeDataType.String, 60),
        new JdeField("J6AG", "J6AG", JdeDataType.Numeric),
        new JdeField("J6DDJ", "J6DDJ", JdeDataType.Numeric),
        new JdeField("J6CO", "J6CO", JdeDataType.String, 10, true, true),
        new JdeField("J6MCU", "J6MCU", JdeDataType.String, 24),
        new JdeField("J6OBJ", "J6OBJ", JdeDataType.String, 12),
        new JdeField("J6SUB", "J6SUB", JdeDataType.String, 16),
        new JdeField("J6SBL", "J6SBL", JdeDataType.String, 16),
        new JdeField("J6SBLT", "J6SBLT", JdeDataType.String, 2),
        new JdeField("J6GLC", "J6GLC", JdeDataType.String, 8),
        new JdeField("J6CKDT", "J6CKDT", JdeDataType.Numeric),
        new JdeField("J6SFX", "J6SFX", JdeDataType.String, 6),
        new JdeField("J6WANO", "J6WANO", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F06491_0", "Primary Key on J6PRID, J6ICU, J6ANN8, J6APTF, J6CTL2, J6CO, J6ANI", new[] { "J6PRID", "J6ICU", "J6ANN8", "J6APTF", "J6CTL2", "J6CO", "J6ANI" }, isUnique: true, isPrimaryKey: true)
    };
}
