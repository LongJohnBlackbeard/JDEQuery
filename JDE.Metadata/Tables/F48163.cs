using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F48163 - .
/// </summary>
public class F48163 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// KTPUKID.
        /// </summary>
        public const string KTPUKID = "KTPUKID";

        /// <summary>
        /// KTUKID.
        /// </summary>
        public const string KTUKID = "KTUKID";

        /// <summary>
        /// KTUK01.
        /// </summary>
        public const string KTUK01 = "KTUK01";

        /// <summary>
        /// KTKBTNM.
        /// </summary>
        public const string KTKBTNM = "KTKBTNM";

        /// <summary>
        /// KTUK02.
        /// </summary>
        public const string KTUK02 = "KTUK02";

        /// <summary>
        /// KTCRTU.
        /// </summary>
        public const string KTCRTU = "KTCRTU";

        /// <summary>
        /// KTUSER.
        /// </summary>
        public const string KTUSER = "KTUSER";

        /// <summary>
        /// KTJOBN.
        /// </summary>
        public const string KTJOBN = "KTJOBN";

        /// <summary>
        /// KTPID.
        /// </summary>
        public const string KTPID = "KTPID";

        /// <summary>
        /// KTUPMJ.
        /// </summary>
        public const string KTUPMJ = "KTUPMJ";

        /// <summary>
        /// KTUPMT.
        /// </summary>
        public const string KTUPMT = "KTUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F48163";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("KTPUKID", "KTPUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("KTUKID", "KTUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("KTUK01", "KTUK01", JdeDataType.Numeric),
        new JdeField("KTKBTNM", "KTKBTNM", JdeDataType.String, 30),
        new JdeField("KTUK02", "KTUK02", JdeDataType.Numeric),
        new JdeField("KTCRTU", "KTCRTU", JdeDataType.String, 20),
        new JdeField("KTUSER", "KTUSER", JdeDataType.String, 20),
        new JdeField("KTJOBN", "KTJOBN", JdeDataType.String, 20),
        new JdeField("KTPID", "KTPID", JdeDataType.String, 20),
        new JdeField("KTUPMJ", "KTUPMJ", JdeDataType.Numeric),
        new JdeField("KTUPMT", "KTUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F48163_0", "Primary Key on KTPUKID, KTUKID", new[] { "KTPUKID", "KTUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F48163_2", "Index on KTPUKID", new[] { "KTPUKID" }),
        new JdeIndex("F48163_3", "Index on SYS_NC00012$", new[] { "SYS_NC00012$" }),
        new JdeIndex("F48163_4", "Index on KTKBTNM, KTPUKID", new[] { "KTKBTNM", "KTPUKID" }),
        new JdeIndex("F48163_5", "Index on KTUK01", new[] { "KTUK01" })
    };
}
