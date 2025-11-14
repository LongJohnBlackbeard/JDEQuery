using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4231 - .
/// </summary>
public class F4231 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EFEVNAME.
        /// </summary>
        public const string EFEVNAME = "EFEVNAME";

        /// <summary>
        /// EFMCU.
        /// </summary>
        public const string EFMCU = "EFMCU";

        /// <summary>
        /// EFDCTO.
        /// </summary>
        public const string EFDCTO = "EFDCTO";

        /// <summary>
        /// EFLTTR.
        /// </summary>
        public const string EFLTTR = "EFLTTR";

        /// <summary>
        /// EFFTSTS.
        /// </summary>
        public const string EFFTSTS = "EFFTSTS";

        /// <summary>
        /// EFRTEKEY.
        /// </summary>
        public const string EFRTEKEY = "EFRTEKEY";

        /// <summary>
        /// EFJOBN.
        /// </summary>
        public const string EFJOBN = "EFJOBN";

        /// <summary>
        /// EFUPMJ.
        /// </summary>
        public const string EFUPMJ = "EFUPMJ";

        /// <summary>
        /// EFTDAY.
        /// </summary>
        public const string EFTDAY = "EFTDAY";

        /// <summary>
        /// EFUTIME.
        /// </summary>
        public const string EFUTIME = "EFUTIME";

        /// <summary>
        /// EFUSER.
        /// </summary>
        public const string EFUSER = "EFUSER";

        /// <summary>
        /// EFPID.
        /// </summary>
        public const string EFPID = "EFPID";

        /// <summary>
        /// EFNXTR.
        /// </summary>
        public const string EFNXTR = "EFNXTR";
    }

    /// <inheritdoc />
    public override string TableName => "F4231";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EFEVNAME", "EFEVNAME", JdeDataType.String, 20),
        new JdeField("EFMCU", "EFMCU", JdeDataType.String, 24),
        new JdeField("EFDCTO", "EFDCTO", JdeDataType.String, 4),
        new JdeField("EFLTTR", "EFLTTR", JdeDataType.String, 6),
        new JdeField("EFFTSTS", "EFFTSTS", JdeDataType.String, 20),
        new JdeField("EFRTEKEY", "EFRTEKEY", JdeDataType.Numeric, null, true, true),
        new JdeField("EFJOBN", "EFJOBN", JdeDataType.String, 20),
        new JdeField("EFUPMJ", "EFUPMJ", JdeDataType.Numeric),
        new JdeField("EFTDAY", "EFTDAY", JdeDataType.Numeric),
        new JdeField("EFUTIME", "EFUTIME", JdeDataType.Date),
        new JdeField("EFUSER", "EFUSER", JdeDataType.String, 20),
        new JdeField("EFPID", "EFPID", JdeDataType.String, 20),
        new JdeField("EFNXTR", "EFNXTR", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4231_0", "Primary Key on EFRTEKEY", new[] { "EFRTEKEY" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4231_2", "Index on EFEVNAME, EFMCU, EFDCTO, EFLTTR", new[] { "EFEVNAME", "EFMCU", "EFDCTO", "EFLTTR" })
    };
}
