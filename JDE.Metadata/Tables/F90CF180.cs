using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CF180 - .
/// </summary>
public class F90CF180 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IHSCRINSID.
        /// </summary>
        public const string IHSCRINSID = "IHSCRINSID";

        /// <summary>
        /// IHTGSETID.
        /// </summary>
        public const string IHTGSETID = "IHTGSETID";

        /// <summary>
        /// IHSCRPTID.
        /// </summary>
        public const string IHSCRPTID = "IHSCRPTID";

        /// <summary>
        /// IHEFFDT.
        /// </summary>
        public const string IHEFFDT = "IHEFFDT";

        /// <summary>
        /// IHANSSCR.
        /// </summary>
        public const string IHANSSCR = "IHANSSCR";

        /// <summary>
        /// IHLANG.
        /// </summary>
        public const string IHLANG = "IHLANG";

        /// <summary>
        /// IHSCRINSTS.
        /// </summary>
        public const string IHSCRINSTS = "IHSCRINSTS";

        /// <summary>
        /// IHSCRINCMT.
        /// </summary>
        public const string IHSCRINCMT = "IHSCRINCMT";

        /// <summary>
        /// IHUSER.
        /// </summary>
        public const string IHUSER = "IHUSER";

        /// <summary>
        /// IHJOBN.
        /// </summary>
        public const string IHJOBN = "IHJOBN";

        /// <summary>
        /// IHMKEY.
        /// </summary>
        public const string IHMKEY = "IHMKEY";

        /// <summary>
        /// IHUDTTM.
        /// </summary>
        public const string IHUDTTM = "IHUDTTM";
    }

    /// <inheritdoc />
    public override string TableName => "F90CF180";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IHSCRINSID", "IHSCRINSID", JdeDataType.Numeric, null, true, true),
        new JdeField("IHTGSETID", "IHTGSETID", JdeDataType.String, 60),
        new JdeField("IHSCRPTID", "IHSCRPTID", JdeDataType.Numeric),
        new JdeField("IHEFFDT", "IHEFFDT", JdeDataType.Date),
        new JdeField("IHANSSCR", "IHANSSCR", JdeDataType.Numeric),
        new JdeField("IHLANG", "IHLANG", JdeDataType.String, 4),
        new JdeField("IHSCRINSTS", "IHSCRINSTS", JdeDataType.String, 2),
        new JdeField("IHSCRINCMT", "IHSCRINCMT", JdeDataType.String, 3000),
        new JdeField("IHUSER", "IHUSER", JdeDataType.String, 20),
        new JdeField("IHJOBN", "IHJOBN", JdeDataType.String, 20),
        new JdeField("IHMKEY", "IHMKEY", JdeDataType.String, 30),
        new JdeField("IHUDTTM", "IHUDTTM", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CF180_0", "Primary Key on IHSCRINSID", new[] { "IHSCRINSID" }, isUnique: true, isPrimaryKey: true)
    };
}
