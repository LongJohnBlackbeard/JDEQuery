using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F059062 - .
/// </summary>
public class F059062 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LDLDID.
        /// </summary>
        public const string LDLDID = "LDLDID";

        /// <summary>
        /// LDLDED.
        /// </summary>
        public const string LDLDED = "LDLDED";

        /// <summary>
        /// LDLDBD.
        /// </summary>
        public const string LDLDBD = "LDLDBD";

        /// <summary>
        /// LDLDSH.
        /// </summary>
        public const string LDLDSH = "LDLDSH";

        /// <summary>
        /// LDLDPS.
        /// </summary>
        public const string LDLDPS = "LDLDPS";

        /// <summary>
        /// LDUSER.
        /// </summary>
        public const string LDUSER = "LDUSER";

        /// <summary>
        /// LDPID.
        /// </summary>
        public const string LDPID = "LDPID";

        /// <summary>
        /// LDJOBN.
        /// </summary>
        public const string LDJOBN = "LDJOBN";

        /// <summary>
        /// LDUPMJ.
        /// </summary>
        public const string LDUPMJ = "LDUPMJ";

        /// <summary>
        /// LDUPMT.
        /// </summary>
        public const string LDUPMT = "LDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F059062";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LDLDID", "LDLDID", JdeDataType.String, 10, true, true),
        new JdeField("LDLDED", "LDLDED", JdeDataType.Numeric, null, true, true),
        new JdeField("LDLDBD", "LDLDBD", JdeDataType.Numeric),
        new JdeField("LDLDSH", "LDLDSH", JdeDataType.Numeric),
        new JdeField("LDLDPS", "LDLDPS", JdeDataType.String, 2),
        new JdeField("LDUSER", "LDUSER", JdeDataType.String, 20),
        new JdeField("LDPID", "LDPID", JdeDataType.String, 20),
        new JdeField("LDJOBN", "LDJOBN", JdeDataType.String, 20),
        new JdeField("LDUPMJ", "LDUPMJ", JdeDataType.Numeric),
        new JdeField("LDUPMT", "LDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F059062_0", "Primary Key on LDLDID, LDLDED", new[] { "LDLDID", "LDLDED" }, isUnique: true, isPrimaryKey: true)
    };
}
