using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08995 - .
/// </summary>
public class F08995 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// H2PAN8.
        /// </summary>
        public const string H2PAN8 = "H2PAN8";

        /// <summary>
        /// H2QE1.
        /// </summary>
        public const string H2QE1 = "H2QE1";

        /// <summary>
        /// H2QD1.
        /// </summary>
        public const string H2QD1 = "H2QD1";

        /// <summary>
        /// H2QDM1.
        /// </summary>
        public const string H2QDM1 = "H2QDM1";

        /// <summary>
        /// H2CBNTM.
        /// </summary>
        public const string H2CBNTM = "H2CBNTM";

        /// <summary>
        /// H2ADD1.
        /// </summary>
        public const string H2ADD1 = "H2ADD1";

        /// <summary>
        /// H2MATH01.
        /// </summary>
        public const string H2MATH01 = "H2MATH01";

        /// <summary>
        /// H2CHAR101.
        /// </summary>
        public const string H2CHAR101 = "H2CHAR101";

        /// <summary>
        /// H2DL01.
        /// </summary>
        public const string H2DL01 = "H2DL01";

        /// <summary>
        /// H2USER.
        /// </summary>
        public const string H2USER = "H2USER";

        /// <summary>
        /// H2PID.
        /// </summary>
        public const string H2PID = "H2PID";

        /// <summary>
        /// H2JOBN.
        /// </summary>
        public const string H2JOBN = "H2JOBN";

        /// <summary>
        /// H2UPMJ.
        /// </summary>
        public const string H2UPMJ = "H2UPMJ";

        /// <summary>
        /// H2UPMT.
        /// </summary>
        public const string H2UPMT = "H2UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F08995";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("H2PAN8", "H2PAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("H2QE1", "H2QE1", JdeDataType.String, 4, true, true),
        new JdeField("H2QD1", "H2QD1", JdeDataType.Numeric, null, true, true),
        new JdeField("H2QDM1", "H2QDM1", JdeDataType.Numeric, null, true, true),
        new JdeField("H2CBNTM", "H2CBNTM", JdeDataType.Numeric),
        new JdeField("H2ADD1", "H2ADD1", JdeDataType.String, 80),
        new JdeField("H2MATH01", "H2MATH01", JdeDataType.Numeric),
        new JdeField("H2CHAR101", "H2CHAR101", JdeDataType.String, 20),
        new JdeField("H2DL01", "H2DL01", JdeDataType.String, 60),
        new JdeField("H2USER", "H2USER", JdeDataType.String, 20),
        new JdeField("H2PID", "H2PID", JdeDataType.String, 20),
        new JdeField("H2JOBN", "H2JOBN", JdeDataType.String, 20),
        new JdeField("H2UPMJ", "H2UPMJ", JdeDataType.Numeric),
        new JdeField("H2UPMT", "H2UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08995_0", "Primary Key on H2PAN8, H2QE1, H2QD1, H2QDM1", new[] { "H2PAN8", "H2QE1", "H2QD1", "H2QDM1" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08995_2", "Index on H2PAN8, H2QE1, H2QD1", new[] { "H2PAN8", "H2QE1", "H2QD1" })
    };
}
