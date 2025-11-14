using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4092 - .
/// </summary>
public class F4092 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GPGPTY.
        /// </summary>
        public const string GPGPTY = "GPGPTY";

        /// <summary>
        /// GPGPC.
        /// </summary>
        public const string GPGPC = "GPGPC";

        /// <summary>
        /// GPDL01.
        /// </summary>
        public const string GPDL01 = "GPDL01";

        /// <summary>
        /// GPGPK1.
        /// </summary>
        public const string GPGPK1 = "GPGPK1";

        /// <summary>
        /// GPGPK2.
        /// </summary>
        public const string GPGPK2 = "GPGPK2";

        /// <summary>
        /// GPGPK3.
        /// </summary>
        public const string GPGPK3 = "GPGPK3";

        /// <summary>
        /// GPGPK4.
        /// </summary>
        public const string GPGPK4 = "GPGPK4";

        /// <summary>
        /// GPGPK5.
        /// </summary>
        public const string GPGPK5 = "GPGPK5";

        /// <summary>
        /// GPGPK6.
        /// </summary>
        public const string GPGPK6 = "GPGPK6";

        /// <summary>
        /// GPGPK7.
        /// </summary>
        public const string GPGPK7 = "GPGPK7";

        /// <summary>
        /// GPGPK8.
        /// </summary>
        public const string GPGPK8 = "GPGPK8";

        /// <summary>
        /// GPGPK9.
        /// </summary>
        public const string GPGPK9 = "GPGPK9";

        /// <summary>
        /// GPGPK10.
        /// </summary>
        public const string GPGPK10 = "GPGPK10";
    }

    /// <inheritdoc />
    public override string TableName => "F4092";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GPGPTY", "GPGPTY", JdeDataType.String, 2, true, true),
        new JdeField("GPGPC", "GPGPC", JdeDataType.String, 16, true, true),
        new JdeField("GPDL01", "GPDL01", JdeDataType.String, 60),
        new JdeField("GPGPK1", "GPGPK1", JdeDataType.String, 20),
        new JdeField("GPGPK2", "GPGPK2", JdeDataType.String, 20),
        new JdeField("GPGPK3", "GPGPK3", JdeDataType.String, 20),
        new JdeField("GPGPK4", "GPGPK4", JdeDataType.String, 20),
        new JdeField("GPGPK5", "GPGPK5", JdeDataType.String, 20),
        new JdeField("GPGPK6", "GPGPK6", JdeDataType.String, 20),
        new JdeField("GPGPK7", "GPGPK7", JdeDataType.String, 20),
        new JdeField("GPGPK8", "GPGPK8", JdeDataType.String, 20),
        new JdeField("GPGPK9", "GPGPK9", JdeDataType.String, 20),
        new JdeField("GPGPK10", "GPGPK10", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4092_0", "Primary Key on GPGPTY, GPGPC", new[] { "GPGPTY", "GPGPC" }, isUnique: true, isPrimaryKey: true)
    };
}
