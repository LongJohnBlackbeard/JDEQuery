using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F99RDDS - .
/// </summary>
public class F99RDDS : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DSOBNM.
        /// </summary>
        public const string DSOBNM = "DSOBNM";

        /// <summary>
        /// DSTMPLTYP.
        /// </summary>
        public const string DSTMPLTYP = "DSTMPLTYP";

        /// <summary>
        /// DSTMPLNM.
        /// </summary>
        public const string DSTMPLNM = "DSTMPLNM";

        /// <summary>
        /// DSDTAI.
        /// </summary>
        public const string DSDTAI = "DSDTAI";

        /// <summary>
        /// DSMD.
        /// </summary>
        public const string DSMD = "DSMD";
    }

    /// <inheritdoc />
    public override string TableName => "F99RDDS";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DSOBNM", "DSOBNM", JdeDataType.String, 20, true, true),
        new JdeField("DSTMPLTYP", "DSTMPLTYP", JdeDataType.Numeric),
        new JdeField("DSTMPLNM", "DSTMPLNM", JdeDataType.String, 30),
        new JdeField("DSDTAI", "DSDTAI", JdeDataType.String, 20, true, true),
        new JdeField("DSMD", "DSMD", JdeDataType.String, 120)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F99RDDS_0", "Primary Key on DSOBNM, DSDTAI", new[] { "DSOBNM", "DSDTAI" }, isUnique: true, isPrimaryKey: true)
    };
}
