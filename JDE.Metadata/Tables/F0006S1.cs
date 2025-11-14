using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0006S1 - .
/// </summary>
public class F0006S1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SHSEFT.
        /// </summary>
        public const string SHSEFT = "SHSEFT";

        /// <summary>
        /// SHSVER.
        /// </summary>
        public const string SHSVER = "SHSVER";

        /// <summary>
        /// SHAUPD.
        /// </summary>
        public const string SHAUPD = "SHAUPD";

        /// <summary>
        /// SHUSER.
        /// </summary>
        public const string SHUSER = "SHUSER";

        /// <summary>
        /// SHPID.
        /// </summary>
        public const string SHPID = "SHPID";

        /// <summary>
        /// SHUPMJ.
        /// </summary>
        public const string SHUPMJ = "SHUPMJ";

        /// <summary>
        /// SHJOBN.
        /// </summary>
        public const string SHJOBN = "SHJOBN";

        /// <summary>
        /// SHUPMT.
        /// </summary>
        public const string SHUPMT = "SHUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F0006S1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SHSEFT", "SHSEFT", JdeDataType.Numeric, null, true, true),
        new JdeField("SHSVER", "SHSVER", JdeDataType.String, 20, true, true),
        new JdeField("SHAUPD", "SHAUPD", JdeDataType.String, 2),
        new JdeField("SHUSER", "SHUSER", JdeDataType.String, 20),
        new JdeField("SHPID", "SHPID", JdeDataType.String, 20),
        new JdeField("SHUPMJ", "SHUPMJ", JdeDataType.Numeric),
        new JdeField("SHJOBN", "SHJOBN", JdeDataType.String, 20),
        new JdeField("SHUPMT", "SHUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0006S1_0", "Primary Key on SHSEFT, SHSVER", new[] { "SHSEFT", "SHSVER" }, isUnique: true, isPrimaryKey: true)
    };
}
