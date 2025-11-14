using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75IUI14 - .
/// </summary>
public class F75IUI14 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TPPYID.
        /// </summary>
        public const string TPPYID = "TPPYID";

        /// <summary>
        /// TPJOBS.
        /// </summary>
        public const string TPJOBS = "TPJOBS";

        /// <summary>
        /// TPUSER.
        /// </summary>
        public const string TPUSER = "TPUSER";

        /// <summary>
        /// TPPID.
        /// </summary>
        public const string TPPID = "TPPID";

        /// <summary>
        /// TPJOBN.
        /// </summary>
        public const string TPJOBN = "TPJOBN";

        /// <summary>
        /// TPUPMJ.
        /// </summary>
        public const string TPUPMJ = "TPUPMJ";

        /// <summary>
        /// TPUPMT.
        /// </summary>
        public const string TPUPMT = "TPUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75IUI14";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TPPYID", "TPPYID", JdeDataType.Numeric, null, true, true),
        new JdeField("TPJOBS", "TPJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("TPUSER", "TPUSER", JdeDataType.String, 20, true, true),
        new JdeField("TPPID", "TPPID", JdeDataType.String, 20),
        new JdeField("TPJOBN", "TPJOBN", JdeDataType.String, 20),
        new JdeField("TPUPMJ", "TPUPMJ", JdeDataType.Numeric),
        new JdeField("TPUPMT", "TPUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75IUI14_0", "Primary Key on TPPYID, TPJOBS, TPUSER", new[] { "TPPYID", "TPJOBS", "TPUSER" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75IUI14_2", "Index on TPJOBS, TPUSER", new[] { "TPJOBS", "TPUSER" })
    };
}
