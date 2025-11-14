using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F051423 - .
/// </summary>
public class F051423 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LWSCLE.
        /// </summary>
        public const string LWSCLE = "LWSCLE";

        /// <summary>
        /// LWSCLL.
        /// </summary>
        public const string LWSCLL = "LWSCLL";

        /// <summary>
        /// LWWORDID.
        /// </summary>
        public const string LWWORDID = "LWWORDID";

        /// <summary>
        /// LWSCLH.
        /// </summary>
        public const string LWSCLH = "LWSCLH";

        /// <summary>
        /// LWORDER.
        /// </summary>
        public const string LWORDER = "LWORDER";

        /// <summary>
        /// LWUSER.
        /// </summary>
        public const string LWUSER = "LWUSER";

        /// <summary>
        /// LWPID.
        /// </summary>
        public const string LWPID = "LWPID";

        /// <summary>
        /// LWMKEY.
        /// </summary>
        public const string LWMKEY = "LWMKEY";

        /// <summary>
        /// LWUPMJ.
        /// </summary>
        public const string LWUPMJ = "LWUPMJ";

        /// <summary>
        /// LWUPMT.
        /// </summary>
        public const string LWUPMT = "LWUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F051423";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LWSCLE", "LWSCLE", JdeDataType.String, 20, true, true),
        new JdeField("LWSCLL", "LWSCLL", JdeDataType.Numeric, null, true, true),
        new JdeField("LWWORDID", "LWWORDID", JdeDataType.Numeric, null, true, true),
        new JdeField("LWSCLH", "LWSCLH", JdeDataType.Numeric),
        new JdeField("LWORDER", "LWORDER", JdeDataType.Numeric),
        new JdeField("LWUSER", "LWUSER", JdeDataType.String, 20),
        new JdeField("LWPID", "LWPID", JdeDataType.String, 20),
        new JdeField("LWMKEY", "LWMKEY", JdeDataType.String, 30),
        new JdeField("LWUPMJ", "LWUPMJ", JdeDataType.Numeric),
        new JdeField("LWUPMT", "LWUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F051423_0", "Primary Key on LWSCLE, LWSCLL, LWWORDID", new[] { "LWSCLE", "LWSCLL", "LWWORDID" }, isUnique: true, isPrimaryKey: true)
    };
}
