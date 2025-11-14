using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F79A039T - .
/// </summary>
public class F79A039T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AT79AGESID.
        /// </summary>
        public const string AT79AGESID = "AT79AGESID";

        /// <summary>
        /// AT79AET.
        /// </summary>
        public const string AT79AET = "AT79AET";

        /// <summary>
        /// ATPID.
        /// </summary>
        public const string ATPID = "ATPID";

        /// <summary>
        /// ATUSER.
        /// </summary>
        public const string ATUSER = "ATUSER";

        /// <summary>
        /// ATJOBN.
        /// </summary>
        public const string ATJOBN = "ATJOBN";

        /// <summary>
        /// ATUPMJ.
        /// </summary>
        public const string ATUPMJ = "ATUPMJ";

        /// <summary>
        /// ATUPMT.
        /// </summary>
        public const string ATUPMT = "ATUPMT";

        /// <summary>
        /// ATACTN.
        /// </summary>
        public const string ATACTN = "ATACTN";
    }

    /// <inheritdoc />
    public override string TableName => "F79A039T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AT79AGESID", "AT79AGESID", JdeDataType.Numeric, null, true, true),
        new JdeField("AT79AET", "AT79AET", JdeDataType.String, 30),
        new JdeField("ATPID", "ATPID", JdeDataType.String, 20),
        new JdeField("ATUSER", "ATUSER", JdeDataType.String, 20),
        new JdeField("ATJOBN", "ATJOBN", JdeDataType.String, 20),
        new JdeField("ATUPMJ", "ATUPMJ", JdeDataType.Numeric, null, true, true),
        new JdeField("ATUPMT", "ATUPMT", JdeDataType.Numeric, null, true, true),
        new JdeField("ATACTN", "ATACTN", JdeDataType.String, 2, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F79A039T_0", "Primary Key on AT79AGESID, ATUPMJ, ATUPMT, ATACTN", new[] { "AT79AGESID", "ATUPMJ", "ATUPMT", "ATACTN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F79A039T_2", "Index on AT79AGESID, ATUPMJ, ATUPMT", new[] { "AT79AGESID", "ATUPMJ", "ATUPMT" })
    };
}
