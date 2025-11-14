using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F06972 - .
/// </summary>
public class F06972 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YRRETP.
        /// </summary>
        public const string YRRETP = "YRRETP";

        /// <summary>
        /// YRPPYF.
        /// </summary>
        public const string YRPPYF = "YRPPYF";

        /// <summary>
        /// YRPPYT.
        /// </summary>
        public const string YRPPYT = "YRPPYT";

        /// <summary>
        /// YRUSER.
        /// </summary>
        public const string YRUSER = "YRUSER";

        /// <summary>
        /// YRPID.
        /// </summary>
        public const string YRPID = "YRPID";

        /// <summary>
        /// YRUPMJ.
        /// </summary>
        public const string YRUPMJ = "YRUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F06972";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YRRETP", "YRRETP", JdeDataType.Numeric, null, true, true),
        new JdeField("YRPPYF", "YRPPYF", JdeDataType.Numeric),
        new JdeField("YRPPYT", "YRPPYT", JdeDataType.Numeric, null, true, true),
        new JdeField("YRUSER", "YRUSER", JdeDataType.String, 20),
        new JdeField("YRPID", "YRPID", JdeDataType.String, 20),
        new JdeField("YRUPMJ", "YRUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F06972_0", "Primary Key on YRRETP, YRPPYT", new[] { "YRRETP", "YRPPYT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F06972_2", "Index on YRRETP, YRPPYF", new[] { "YRRETP", "YRPPYF" }),
        new JdeIndex("F06972_3", "Index on YRPPYT", new[] { "YRPPYT" })
    };
}
