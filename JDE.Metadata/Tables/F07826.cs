using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07826 - .
/// </summary>
public class F07826 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JBIDYE.
        /// </summary>
        public const string JBIDYE = "JBIDYE";

        /// <summary>
        /// JBDTEY.
        /// </summary>
        public const string JBDTEY = "JBDTEY";

        /// <summary>
        /// JBDTAI.
        /// </summary>
        public const string JBDTAI = "JBDTAI";

        /// <summary>
        /// JBPHSD.
        /// </summary>
        public const string JBPHSD = "JBPHSD";

        /// <summary>
        /// JBUPMJ.
        /// </summary>
        public const string JBUPMJ = "JBUPMJ";

        /// <summary>
        /// JBUPMT.
        /// </summary>
        public const string JBUPMT = "JBUPMT";

        /// <summary>
        /// JBPID.
        /// </summary>
        public const string JBPID = "JBPID";

        /// <summary>
        /// JBJOBN.
        /// </summary>
        public const string JBJOBN = "JBJOBN";

        /// <summary>
        /// JBUSER.
        /// </summary>
        public const string JBUSER = "JBUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F07826";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JBIDYE", "JBIDYE", JdeDataType.String, 20, true, true),
        new JdeField("JBDTEY", "JBDTEY", JdeDataType.Numeric, null, true, true),
        new JdeField("JBDTAI", "JBDTAI", JdeDataType.String, 20, true, true),
        new JdeField("JBPHSD", "JBPHSD", JdeDataType.String, 60, true, true),
        new JdeField("JBUPMJ", "JBUPMJ", JdeDataType.Numeric),
        new JdeField("JBUPMT", "JBUPMT", JdeDataType.Numeric),
        new JdeField("JBPID", "JBPID", JdeDataType.String, 20),
        new JdeField("JBJOBN", "JBJOBN", JdeDataType.String, 20),
        new JdeField("JBUSER", "JBUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07826_0", "Primary Key on JBIDYE, JBDTEY, JBDTAI, JBPHSD", new[] { "JBIDYE", "JBDTEY", "JBDTAI", "JBPHSD" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F07826_3", "Index on JBIDYE, JBDTEY", new[] { "JBIDYE", "JBDTEY" })
    };
}
