using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08996 - .
/// </summary>
public class F08996 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// J3PAN8.
        /// </summary>
        public const string J3PAN8 = "J3PAN8";

        /// <summary>
        /// J3QE1.
        /// </summary>
        public const string J3QE1 = "J3QE1";

        /// <summary>
        /// J3QD1.
        /// </summary>
        public const string J3QD1 = "J3QD1";

        /// <summary>
        /// J3QE2.
        /// </summary>
        public const string J3QE2 = "J3QE2";

        /// <summary>
        /// J3QD2.
        /// </summary>
        public const string J3QD2 = "J3QD2";

        /// <summary>
        /// J3QEOS.
        /// </summary>
        public const string J3QEOS = "J3QEOS";

        /// <summary>
        /// J3QDM1.
        /// </summary>
        public const string J3QDM1 = "J3QDM1";

        /// <summary>
        /// J3CLTRTY.
        /// </summary>
        public const string J3CLTRTY = "J3CLTRTY";

        /// <summary>
        /// J3NRCDE.
        /// </summary>
        public const string J3NRCDE = "J3NRCDE";

        /// <summary>
        /// J3AN82.
        /// </summary>
        public const string J3AN82 = "J3AN82";

        /// <summary>
        /// J3USER.
        /// </summary>
        public const string J3USER = "J3USER";

        /// <summary>
        /// J3EAP.
        /// </summary>
        public const string J3EAP = "J3EAP";

        /// <summary>
        /// J3MACH.
        /// </summary>
        public const string J3MACH = "J3MACH";

        /// <summary>
        /// J3UPMJ.
        /// </summary>
        public const string J3UPMJ = "J3UPMJ";

        /// <summary>
        /// J3UPMT.
        /// </summary>
        public const string J3UPMT = "J3UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F08996";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("J3PAN8", "J3PAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("J3QE1", "J3QE1", JdeDataType.String, 4, true, true),
        new JdeField("J3QD1", "J3QD1", JdeDataType.Numeric, null, true, true),
        new JdeField("J3QE2", "J3QE2", JdeDataType.String, 4, true, true),
        new JdeField("J3QD2", "J3QD2", JdeDataType.Numeric, null, true, true),
        new JdeField("J3QEOS", "J3QEOS", JdeDataType.String, 2, true, true),
        new JdeField("J3QDM1", "J3QDM1", JdeDataType.Numeric, null, true, true),
        new JdeField("J3CLTRTY", "J3CLTRTY", JdeDataType.String, 20, true, true),
        new JdeField("J3NRCDE", "J3NRCDE", JdeDataType.String, 4),
        new JdeField("J3AN82", "J3AN82", JdeDataType.Numeric),
        new JdeField("J3USER", "J3USER", JdeDataType.String, 20),
        new JdeField("J3EAP", "J3EAP", JdeDataType.String, 20),
        new JdeField("J3MACH", "J3MACH", JdeDataType.String, 24),
        new JdeField("J3UPMJ", "J3UPMJ", JdeDataType.Numeric),
        new JdeField("J3UPMT", "J3UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08996_0", "Primary Key on J3PAN8, J3QE1, J3QD1, J3QE2, J3QD2, J3QEOS, J3QDM1, J3CLTRTY", new[] { "J3PAN8", "J3QE1", "J3QD1", "J3QE2", "J3QD2", "J3QEOS", "J3QDM1", "J3CLTRTY" }, isUnique: true, isPrimaryKey: true)
    };
}
