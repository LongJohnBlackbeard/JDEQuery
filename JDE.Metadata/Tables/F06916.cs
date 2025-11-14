using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F06916 - .
/// </summary>
public class F06916 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JJITM.
        /// </summary>
        public const string JJITM = "JJITM";

        /// <summary>
        /// JJDL01.
        /// </summary>
        public const string JJDL01 = "JJDL01";

        /// <summary>
        /// JJUM.
        /// </summary>
        public const string JJUM = "JJUM";

        /// <summary>
        /// JJITMP.
        /// </summary>
        public const string JJITMP = "JJITMP";

        /// <summary>
        /// JJRTCD.
        /// </summary>
        public const string JJRTCD = "JJRTCD";

        /// <summary>
        /// JJIG01.
        /// </summary>
        public const string JJIG01 = "JJIG01";

        /// <summary>
        /// JJP022.
        /// </summary>
        public const string JJP022 = "JJP022";

        /// <summary>
        /// JJCNVF.
        /// </summary>
        public const string JJCNVF = "JJCNVF";

        /// <summary>
        /// JJP023.
        /// </summary>
        public const string JJP023 = "JJP023";

        /// <summary>
        /// JJCNV8.
        /// </summary>
        public const string JJCNV8 = "JJCNV8";

        /// <summary>
        /// JJP024.
        /// </summary>
        public const string JJP024 = "JJP024";

        /// <summary>
        /// JJCNV9.
        /// </summary>
        public const string JJCNV9 = "JJCNV9";

        /// <summary>
        /// JJEPCU.
        /// </summary>
        public const string JJEPCU = "JJEPCU";

        /// <summary>
        /// JJPCCD.
        /// </summary>
        public const string JJPCCD = "JJPCCD";
    }

    /// <inheritdoc />
    public override string TableName => "F06916";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JJITM", "JJITM", JdeDataType.Numeric, null, true, true),
        new JdeField("JJDL01", "JJDL01", JdeDataType.String, 60),
        new JdeField("JJUM", "JJUM", JdeDataType.String, 4, true, true),
        new JdeField("JJITMP", "JJITMP", JdeDataType.String, 50),
        new JdeField("JJRTCD", "JJRTCD", JdeDataType.String, 2),
        new JdeField("JJIG01", "JJIG01", JdeDataType.String, 6),
        new JdeField("JJP022", "JJP022", JdeDataType.String, 4),
        new JdeField("JJCNVF", "JJCNVF", JdeDataType.Numeric),
        new JdeField("JJP023", "JJP023", JdeDataType.String, 4),
        new JdeField("JJCNV8", "JJCNV8", JdeDataType.Numeric),
        new JdeField("JJP024", "JJP024", JdeDataType.String, 4),
        new JdeField("JJCNV9", "JJCNV9", JdeDataType.Numeric),
        new JdeField("JJEPCU", "JJEPCU", JdeDataType.Numeric),
        new JdeField("JJPCCD", "JJPCCD", JdeDataType.String, 10)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F06916_0", "Primary Key on JJITM, JJUM", new[] { "JJITM", "JJUM" }, isUnique: true, isPrimaryKey: true)
    };
}
