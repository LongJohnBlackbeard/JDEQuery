using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CG002 - .
/// </summary>
public class F90CG002 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CCURLNAME.
        /// </summary>
        public const string CCURLNAME = "CCURLNAME";

        /// <summary>
        /// CCURLID.
        /// </summary>
        public const string CCURLID = "CCURLID";

        /// <summary>
        /// CCURLPATH.
        /// </summary>
        public const string CCURLPATH = "CCURLPATH";

        /// <summary>
        /// CCMKEY.
        /// </summary>
        public const string CCMKEY = "CCMKEY";

        /// <summary>
        /// CCJOBN.
        /// </summary>
        public const string CCJOBN = "CCJOBN";

        /// <summary>
        /// CCUDTTM.
        /// </summary>
        public const string CCUDTTM = "CCUDTTM";

        /// <summary>
        /// CCUSER.
        /// </summary>
        public const string CCUSER = "CCUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F90CG002";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CCURLNAME", "CCURLNAME", JdeDataType.String, 510),
        new JdeField("CCURLID", "CCURLID", JdeDataType.Numeric, null, true, true),
        new JdeField("CCURLPATH", "CCURLPATH", JdeDataType.String, 1000),
        new JdeField("CCMKEY", "CCMKEY", JdeDataType.String, 30),
        new JdeField("CCJOBN", "CCJOBN", JdeDataType.String, 20),
        new JdeField("CCUDTTM", "CCUDTTM", JdeDataType.Date),
        new JdeField("CCUSER", "CCUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CG002_0", "Primary Key on CCURLID", new[] { "CCURLID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F90CG002_2", "Index on CCURLNAME", new[] { "CCURLNAME" })
    };
}
