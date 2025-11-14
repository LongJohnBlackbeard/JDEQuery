using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F54R031 - .
/// </summary>
public class F54R031 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LDLNTY.
        /// </summary>
        public const string LDLNTY = "LDLNTY";

        /// <summary>
        /// LDMCU.
        /// </summary>
        public const string LDMCU = "LDMCU";

        /// <summary>
        /// LDAN8.
        /// </summary>
        public const string LDAN8 = "LDAN8";

        /// <summary>
        /// LD54RANT.
        /// </summary>
        public const string LD54RANT = "LD54RANT";

        /// <summary>
        /// LD54RAN.
        /// </summary>
        public const string LD54RAN = "LD54RAN";

        /// <summary>
        /// LDUSER.
        /// </summary>
        public const string LDUSER = "LDUSER";

        /// <summary>
        /// LDPID.
        /// </summary>
        public const string LDPID = "LDPID";

        /// <summary>
        /// LDUPMJ.
        /// </summary>
        public const string LDUPMJ = "LDUPMJ";

        /// <summary>
        /// LDUPMT.
        /// </summary>
        public const string LDUPMT = "LDUPMT";

        /// <summary>
        /// LDJOBN.
        /// </summary>
        public const string LDJOBN = "LDJOBN";

        /// <summary>
        /// LDMKEY.
        /// </summary>
        public const string LDMKEY = "LDMKEY";

        /// <summary>
        /// LDURCD.
        /// </summary>
        public const string LDURCD = "LDURCD";

        /// <summary>
        /// LDURDT.
        /// </summary>
        public const string LDURDT = "LDURDT";

        /// <summary>
        /// LDURAT.
        /// </summary>
        public const string LDURAT = "LDURAT";

        /// <summary>
        /// LDURAB.
        /// </summary>
        public const string LDURAB = "LDURAB";

        /// <summary>
        /// LDURRF.
        /// </summary>
        public const string LDURRF = "LDURRF";

        /// <summary>
        /// LDENTJ.
        /// </summary>
        public const string LDENTJ = "LDENTJ";

        /// <summary>
        /// LDTORG.
        /// </summary>
        public const string LDTORG = "LDTORG";

        /// <summary>
        /// LDTENT.
        /// </summary>
        public const string LDTENT = "LDTENT";
    }

    /// <inheritdoc />
    public override string TableName => "F54R031";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LDLNTY", "LDLNTY", JdeDataType.String, 4, true, true),
        new JdeField("LDMCU", "LDMCU", JdeDataType.String, 24, true, true),
        new JdeField("LDAN8", "LDAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("LD54RANT", "LD54RANT", JdeDataType.String, 2, true, true),
        new JdeField("LD54RAN", "LD54RAN", JdeDataType.Numeric, null, true, true),
        new JdeField("LDUSER", "LDUSER", JdeDataType.String, 20),
        new JdeField("LDPID", "LDPID", JdeDataType.String, 20),
        new JdeField("LDUPMJ", "LDUPMJ", JdeDataType.Numeric),
        new JdeField("LDUPMT", "LDUPMT", JdeDataType.Numeric),
        new JdeField("LDJOBN", "LDJOBN", JdeDataType.String, 20),
        new JdeField("LDMKEY", "LDMKEY", JdeDataType.String, 30),
        new JdeField("LDURCD", "LDURCD", JdeDataType.String, 4),
        new JdeField("LDURDT", "LDURDT", JdeDataType.Numeric),
        new JdeField("LDURAT", "LDURAT", JdeDataType.Numeric),
        new JdeField("LDURAB", "LDURAB", JdeDataType.Numeric),
        new JdeField("LDURRF", "LDURRF", JdeDataType.String, 30),
        new JdeField("LDENTJ", "LDENTJ", JdeDataType.Numeric),
        new JdeField("LDTORG", "LDTORG", JdeDataType.String, 20),
        new JdeField("LDTENT", "LDTENT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F54R031_0", "Primary Key on LDLNTY, LDMCU, LDAN8, LD54RANT, LD54RAN", new[] { "LDLNTY", "LDMCU", "LDAN8", "LD54RANT", "LD54RAN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F54R031_2", "Index on LDLNTY, LDMCU, LDAN8, LD54RANT", new[] { "LDLNTY", "LDMCU", "LDAN8", "LD54RANT" })
    };
}
