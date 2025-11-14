using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75Z0004 - .
/// </summary>
public class F75Z0004 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Z4AN8.
        /// </summary>
        public const string Z4AN8 = "Z4AN8";

        /// <summary>
        /// Z4LEAVECD.
        /// </summary>
        public const string Z4LEAVECD = "Z4LEAVECD";

        /// <summary>
        /// Z4ANNIVDT.
        /// </summary>
        public const string Z4ANNIVDT = "Z4ANNIVDT";

        /// <summary>
        /// Z4LEAVBAL.
        /// </summary>
        public const string Z4LEAVBAL = "Z4LEAVBAL";

        /// <summary>
        /// Z4LEAVCOM.
        /// </summary>
        public const string Z4LEAVCOM = "Z4LEAVCOM";

        /// <summary>
        /// Z4AVGGER.
        /// </summary>
        public const string Z4AVGGER = "Z4AVGGER";

        /// <summary>
        /// Z4PREACCR.
        /// </summary>
        public const string Z4PREACCR = "Z4PREACCR";

        /// <summary>
        /// Z4UPMJ.
        /// </summary>
        public const string Z4UPMJ = "Z4UPMJ";

        /// <summary>
        /// Z4UPMT.
        /// </summary>
        public const string Z4UPMT = "Z4UPMT";

        /// <summary>
        /// Z4PID.
        /// </summary>
        public const string Z4PID = "Z4PID";

        /// <summary>
        /// Z4USER.
        /// </summary>
        public const string Z4USER = "Z4USER";

        /// <summary>
        /// Z4JOBN.
        /// </summary>
        public const string Z4JOBN = "Z4JOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F75Z0004";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Z4AN8", "Z4AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("Z4LEAVECD", "Z4LEAVECD", JdeDataType.Numeric, null, true, true),
        new JdeField("Z4ANNIVDT", "Z4ANNIVDT", JdeDataType.Numeric, null, true, true),
        new JdeField("Z4LEAVBAL", "Z4LEAVBAL", JdeDataType.Numeric),
        new JdeField("Z4LEAVCOM", "Z4LEAVCOM", JdeDataType.Numeric),
        new JdeField("Z4AVGGER", "Z4AVGGER", JdeDataType.Numeric),
        new JdeField("Z4PREACCR", "Z4PREACCR", JdeDataType.Numeric),
        new JdeField("Z4UPMJ", "Z4UPMJ", JdeDataType.Numeric),
        new JdeField("Z4UPMT", "Z4UPMT", JdeDataType.Numeric),
        new JdeField("Z4PID", "Z4PID", JdeDataType.String, 20),
        new JdeField("Z4USER", "Z4USER", JdeDataType.String, 20),
        new JdeField("Z4JOBN", "Z4JOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75Z0004_0", "Primary Key on Z4AN8, Z4LEAVECD, Z4ANNIVDT", new[] { "Z4AN8", "Z4LEAVECD", "Z4ANNIVDT" }, isUnique: true, isPrimaryKey: true)
    };
}
