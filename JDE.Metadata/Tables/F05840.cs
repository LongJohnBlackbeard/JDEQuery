using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F05840 - .
/// </summary>
public class F05840 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SRAN8.
        /// </summary>
        public const string SRAN8 = "SRAN8";

        /// <summary>
        /// SRLVEL.
        /// </summary>
        public const string SRLVEL = "SRLVEL";

        /// <summary>
        /// SRCLWF.
        /// </summary>
        public const string SRCLWF = "SRCLWF";

        /// <summary>
        /// SRANPA.
        /// </summary>
        public const string SRANPA = "SRANPA";

        /// <summary>
        /// SRUSER.
        /// </summary>
        public const string SRUSER = "SRUSER";

        /// <summary>
        /// SRPID.
        /// </summary>
        public const string SRPID = "SRPID";

        /// <summary>
        /// SRUPMJ.
        /// </summary>
        public const string SRUPMJ = "SRUPMJ";

        /// <summary>
        /// SRUPMT.
        /// </summary>
        public const string SRUPMT = "SRUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F05840";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SRAN8", "SRAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("SRLVEL", "SRLVEL", JdeDataType.Numeric, null, true, true),
        new JdeField("SRCLWF", "SRCLWF", JdeDataType.String, 2, true, true),
        new JdeField("SRANPA", "SRANPA", JdeDataType.Numeric),
        new JdeField("SRUSER", "SRUSER", JdeDataType.String, 20),
        new JdeField("SRPID", "SRPID", JdeDataType.String, 20),
        new JdeField("SRUPMJ", "SRUPMJ", JdeDataType.Numeric),
        new JdeField("SRUPMT", "SRUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F05840_0", "Primary Key on SRAN8, SRLVEL, SRCLWF", new[] { "SRAN8", "SRLVEL", "SRCLWF" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F05840_2", "Index on SRAN8, SRANPA", new[] { "SRAN8", "SRANPA" }),
        new JdeIndex("F05840_3", "Index on SRAN8, SRCLWF, SYS_NC00009$", new[] { "SRAN8", "SRCLWF", "SYS_NC00009$" }),
        new JdeIndex("F05840_4", "Index on SRANPA, SRLVEL, SRAN8", new[] { "SRANPA", "SRLVEL", "SRAN8" })
    };
}
