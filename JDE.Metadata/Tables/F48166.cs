using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F48166 - .
/// </summary>
public class F48166 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// KPKNLT1.
        /// </summary>
        public const string KPKNLT1 = "KPKNLT1";

        /// <summary>
        /// KPUK01.
        /// </summary>
        public const string KPUK01 = "KPUK01";

        /// <summary>
        /// KPKNLT2.
        /// </summary>
        public const string KPKNLT2 = "KPKNLT2";

        /// <summary>
        /// KPUK02.
        /// </summary>
        public const string KPUK02 = "KPUK02";

        /// <summary>
        /// KPCNTF.
        /// </summary>
        public const string KPCNTF = "KPCNTF";

        /// <summary>
        /// KPCRTU.
        /// </summary>
        public const string KPCRTU = "KPCRTU";

        /// <summary>
        /// KPCADT.
        /// </summary>
        public const string KPCADT = "KPCADT";

        /// <summary>
        /// KPUSER.
        /// </summary>
        public const string KPUSER = "KPUSER";

        /// <summary>
        /// KPJOBN.
        /// </summary>
        public const string KPJOBN = "KPJOBN";

        /// <summary>
        /// KPPID.
        /// </summary>
        public const string KPPID = "KPPID";

        /// <summary>
        /// KPUPMJ.
        /// </summary>
        public const string KPUPMJ = "KPUPMJ";

        /// <summary>
        /// KPUPMT.
        /// </summary>
        public const string KPUPMT = "KPUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F48166";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("KPKNLT1", "KPKNLT1", JdeDataType.String, 2, true, true),
        new JdeField("KPUK01", "KPUK01", JdeDataType.Numeric, null, true, true),
        new JdeField("KPKNLT2", "KPKNLT2", JdeDataType.String, 2, true, true),
        new JdeField("KPUK02", "KPUK02", JdeDataType.Numeric, null, true, true),
        new JdeField("KPCNTF", "KPCNTF", JdeDataType.Numeric),
        new JdeField("KPCRTU", "KPCRTU", JdeDataType.String, 20),
        new JdeField("KPCADT", "KPCADT", JdeDataType.Numeric),
        new JdeField("KPUSER", "KPUSER", JdeDataType.String, 20),
        new JdeField("KPJOBN", "KPJOBN", JdeDataType.String, 20),
        new JdeField("KPPID", "KPPID", JdeDataType.String, 20),
        new JdeField("KPUPMJ", "KPUPMJ", JdeDataType.Numeric),
        new JdeField("KPUPMT", "KPUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F48166_0", "Primary Key on KPKNLT1, KPUK01, KPKNLT2, KPUK02", new[] { "KPKNLT1", "KPUK01", "KPKNLT2", "KPUK02" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F48166_2", "Index on KPKNLT1, KPUK01, KPKNLT2", new[] { "KPKNLT1", "KPUK01", "KPKNLT2" }),
        new JdeIndex("F48166_3", "Index on KPKNLT1, KPUK01, KPKNLT2, SYS_NC00013$, KPUK02", new[] { "KPKNLT1", "KPUK01", "KPKNLT2", "SYS_NC00013$", "KPUK02" })
    };
}
