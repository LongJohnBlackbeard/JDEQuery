using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F7607A - .
/// </summary>
public class F7607A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// V4AN8.
        /// </summary>
        public const string V4AN8 = "V4AN8";

        /// <summary>
        /// V4DCT.
        /// </summary>
        public const string V4DCT = "V4DCT";

        /// <summary>
        /// V4EFTJ.
        /// </summary>
        public const string V4EFTJ = "V4EFTJ";

        /// <summary>
        /// V4APR1.
        /// </summary>
        public const string V4APR1 = "V4APR1";

        /// <summary>
        /// V4EFDJ.
        /// </summary>
        public const string V4EFDJ = "V4EFDJ";

        /// <summary>
        /// V4ABD.
        /// </summary>
        public const string V4ABD = "V4ABD";

        /// <summary>
        /// V4PID.
        /// </summary>
        public const string V4PID = "V4PID";

        /// <summary>
        /// V4USER.
        /// </summary>
        public const string V4USER = "V4USER";

        /// <summary>
        /// V4JOBN.
        /// </summary>
        public const string V4JOBN = "V4JOBN";

        /// <summary>
        /// V4UPMJ.
        /// </summary>
        public const string V4UPMJ = "V4UPMJ";

        /// <summary>
        /// V4TDAY.
        /// </summary>
        public const string V4TDAY = "V4TDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F7607A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("V4AN8", "V4AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("V4DCT", "V4DCT", JdeDataType.String, 4, true, true),
        new JdeField("V4EFTJ", "V4EFTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("V4APR1", "V4APR1", JdeDataType.Numeric),
        new JdeField("V4EFDJ", "V4EFDJ", JdeDataType.Numeric),
        new JdeField("V4ABD", "V4ABD", JdeDataType.Numeric),
        new JdeField("V4PID", "V4PID", JdeDataType.String, 20),
        new JdeField("V4USER", "V4USER", JdeDataType.String, 20),
        new JdeField("V4JOBN", "V4JOBN", JdeDataType.String, 20),
        new JdeField("V4UPMJ", "V4UPMJ", JdeDataType.Numeric),
        new JdeField("V4TDAY", "V4TDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F7607A_0", "Primary Key on V4AN8, V4DCT, V4EFTJ", new[] { "V4AN8", "V4DCT", "V4EFTJ" }, isUnique: true, isPrimaryKey: true)
    };
}
