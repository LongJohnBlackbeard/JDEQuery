using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F81A11E - .
/// </summary>
public class F81A11E : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MEFPID.
        /// </summary>
        public const string MEFPID = "MEFPID";

        /// <summary>
        /// MEBVER.
        /// </summary>
        public const string MEBVER = "MEBVER";

        /// <summary>
        /// MELITN.
        /// </summary>
        public const string MELITN = "MELITN";

        /// <summary>
        /// MEBSQN.
        /// </summary>
        public const string MEBSQN = "MEBSQN";

        /// <summary>
        /// MEBCNT.
        /// </summary>
        public const string MEBCNT = "MEBCNT";

        /// <summary>
        /// MELMBN.
        /// </summary>
        public const string MELMBN = "MELMBN";

        /// <summary>
        /// MEPID.
        /// </summary>
        public const string MEPID = "MEPID";

        /// <summary>
        /// MEVERS.
        /// </summary>
        public const string MEVERS = "MEVERS";

        /// <summary>
        /// MEOWTP.
        /// </summary>
        public const string MEOWTP = "MEOWTP";

        /// <summary>
        /// MEVL01.
        /// </summary>
        public const string MEVL01 = "MEVL01";

        /// <summary>
        /// MEDTAI.
        /// </summary>
        public const string MEDTAI = "MEDTAI";

        /// <summary>
        /// MEGENLNG.
        /// </summary>
        public const string MEGENLNG = "MEGENLNG";

        /// <summary>
        /// MEFPD.
        /// </summary>
        public const string MEFPD = "MEFPD";

        /// <summary>
        /// MEJOBN.
        /// </summary>
        public const string MEJOBN = "MEJOBN";

        /// <summary>
        /// MEUSER.
        /// </summary>
        public const string MEUSER = "MEUSER";

        /// <summary>
        /// MEUPMJ.
        /// </summary>
        public const string MEUPMJ = "MEUPMJ";

        /// <summary>
        /// METDAY.
        /// </summary>
        public const string METDAY = "METDAY";

        /// <summary>
        /// MELMEI.
        /// </summary>
        public const string MELMEI = "MELMEI";
    }

    /// <inheritdoc />
    public override string TableName => "F81A11E";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MEFPID", "MEFPID", JdeDataType.String, 20, true, true),
        new JdeField("MEBVER", "MEBVER", JdeDataType.String, 20, true, true),
        new JdeField("MELITN", "MELITN", JdeDataType.Numeric, null, true, true),
        new JdeField("MEBSQN", "MEBSQN", JdeDataType.Numeric, null, true, true),
        new JdeField("MEBCNT", "MEBCNT", JdeDataType.Numeric, null, true, true),
        new JdeField("MELMBN", "MELMBN", JdeDataType.Numeric, null, true, true),
        new JdeField("MEPID", "MEPID", JdeDataType.String, 20),
        new JdeField("MEVERS", "MEVERS", JdeDataType.String, 20),
        new JdeField("MEOWTP", "MEOWTP", JdeDataType.String, 4),
        new JdeField("MEVL01", "MEVL01", JdeDataType.String, 50),
        new JdeField("MEDTAI", "MEDTAI", JdeDataType.String, 20),
        new JdeField("MEGENLNG", "MEGENLNG", JdeDataType.Numeric),
        new JdeField("MEFPD", "MEFPD", JdeDataType.String, 20),
        new JdeField("MEJOBN", "MEJOBN", JdeDataType.String, 20),
        new JdeField("MEUSER", "MEUSER", JdeDataType.String, 20),
        new JdeField("MEUPMJ", "MEUPMJ", JdeDataType.Numeric),
        new JdeField("METDAY", "METDAY", JdeDataType.Numeric),
        new JdeField("MELMEI", "MELMEI", JdeDataType.String, 16)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F81A11E_0", "Primary Key on MEFPID, MEBVER, MELITN, MEBSQN, MEBCNT, MELMBN", new[] { "MEFPID", "MEBVER", "MELITN", "MEBSQN", "MEBCNT", "MELMBN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F81A11E_2", "Index on MELMBN, MELMEI, MEFPID, MEBVER", new[] { "MELMBN", "MELMEI", "MEFPID", "MEBVER" })
    };
}
