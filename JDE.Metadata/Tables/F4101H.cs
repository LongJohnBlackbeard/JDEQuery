using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4101H - .
/// </summary>
public class F4101H : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IHOSTP.
        /// </summary>
        public const string IHOSTP = "IHOSTP";

        /// <summary>
        /// IHUKID.
        /// </summary>
        public const string IHUKID = "IHUKID";

        /// <summary>
        /// IHPUKID.
        /// </summary>
        public const string IHPUKID = "IHPUKID";

        /// <summary>
        /// IHOSEQ.
        /// </summary>
        public const string IHOSEQ = "IHOSEQ";

        /// <summary>
        /// IHDL01.
        /// </summary>
        public const string IHDL01 = "IHDL01";

        /// <summary>
        /// IHDTAI.
        /// </summary>
        public const string IHDTAI = "IHDTAI";

        /// <summary>
        /// IHKY.
        /// </summary>
        public const string IHKY = "IHKY";

        /// <summary>
        /// IHPID.
        /// </summary>
        public const string IHPID = "IHPID";
    }

    /// <inheritdoc />
    public override string TableName => "F4101H";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IHOSTP", "IHOSTP", JdeDataType.String, 6, true, true),
        new JdeField("IHUKID", "IHUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("IHPUKID", "IHPUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("IHOSEQ", "IHOSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("IHDL01", "IHDL01", JdeDataType.String, 60),
        new JdeField("IHDTAI", "IHDTAI", JdeDataType.String, 20),
        new JdeField("IHKY", "IHKY", JdeDataType.String, 20),
        new JdeField("IHPID", "IHPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4101H_0", "Primary Key on IHOSTP, IHPUKID, IHOSEQ, IHUKID", new[] { "IHOSTP", "IHPUKID", "IHOSEQ", "IHUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4101H_2", "Index on IHOSTP, IHUKID", new[] { "IHOSTP", "IHUKID" }),
        new JdeIndex("F4101H_3", "Index on IHDL01", new[] { "IHDL01" })
    };
}
