using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F10909 - .
/// </summary>
public class F10909 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// G1NAM.
        /// </summary>
        public const string G1NAM = "G1NAM";

        /// <summary>
        /// G1OBJ.
        /// </summary>
        public const string G1OBJ = "G1OBJ";

        /// <summary>
        /// G1SUB.
        /// </summary>
        public const string G1SUB = "G1SUB";

        /// <summary>
        /// G1DL01.
        /// </summary>
        public const string G1DL01 = "G1DL01";

        /// <summary>
        /// G1USER.
        /// </summary>
        public const string G1USER = "G1USER";

        /// <summary>
        /// G1PID.
        /// </summary>
        public const string G1PID = "G1PID";

        /// <summary>
        /// G1UPMJ.
        /// </summary>
        public const string G1UPMJ = "G1UPMJ";

        /// <summary>
        /// G1JOBN.
        /// </summary>
        public const string G1JOBN = "G1JOBN";

        /// <summary>
        /// G1UPMT.
        /// </summary>
        public const string G1UPMT = "G1UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F10909";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("G1NAM", "G1NAM", JdeDataType.String, 24, true, true),
        new JdeField("G1OBJ", "G1OBJ", JdeDataType.String, 12, true, true),
        new JdeField("G1SUB", "G1SUB", JdeDataType.String, 16, true, true),
        new JdeField("G1DL01", "G1DL01", JdeDataType.String, 60),
        new JdeField("G1USER", "G1USER", JdeDataType.String, 20),
        new JdeField("G1PID", "G1PID", JdeDataType.String, 20),
        new JdeField("G1UPMJ", "G1UPMJ", JdeDataType.Numeric),
        new JdeField("G1JOBN", "G1JOBN", JdeDataType.String, 20),
        new JdeField("G1UPMT", "G1UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F10909_0", "Primary Key on G1NAM, G1OBJ, G1SUB", new[] { "G1NAM", "G1OBJ", "G1SUB" }, isUnique: true, isPrimaryKey: true)
    };
}
