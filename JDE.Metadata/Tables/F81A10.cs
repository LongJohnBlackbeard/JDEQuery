using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F81A10 - .
/// </summary>
public class F81A10 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MEPID.
        /// </summary>
        public const string MEPID = "MEPID";

        /// <summary>
        /// MELDFR.
        /// </summary>
        public const string MELDFR = "MELDFR";

        /// <summary>
        /// MEVERS.
        /// </summary>
        public const string MEVERS = "MEVERS";

        /// <summary>
        /// MEFPID.
        /// </summary>
        public const string MEFPID = "MEFPID";

        /// <summary>
        /// MEBVER.
        /// </summary>
        public const string MEBVER = "MEBVER";

        /// <summary>
        /// MESQN.
        /// </summary>
        public const string MESQN = "MESQN";

        /// <summary>
        /// MEOPT#.
        /// </summary>
        public const string MEOPT_ = "MEOPT#";

        /// <summary>
        /// MEOBNM.
        /// </summary>
        public const string MEOBNM = "MEOBNM";

        /// <summary>
        /// MELPTP.
        /// </summary>
        public const string MELPTP = "MELPTP";

        /// <summary>
        /// MELITN.
        /// </summary>
        public const string MELITN = "MELITN";

        /// <summary>
        /// MEBSQN.
        /// </summary>
        public const string MEBSQN = "MEBSQN";

        /// <summary>
        /// MELNGP.
        /// </summary>
        public const string MELNGP = "MELNGP";

        /// <summary>
        /// MEQST.
        /// </summary>
        public const string MEQST = "MEQST";

        /// <summary>
        /// MEDTAI.
        /// </summary>
        public const string MEDTAI = "MEDTAI";

        /// <summary>
        /// MEDS01.
        /// </summary>
        public const string MEDS01 = "MEDS01";

        /// <summary>
        /// MEJOB#.
        /// </summary>
        public const string MEJOB_ = "MEJOB#";

        /// <summary>
        /// MELMBN.
        /// </summary>
        public const string MELMBN = "MELMBN";

        /// <summary>
        /// MELUS.
        /// </summary>
        public const string MELUS = "MELUS";

        /// <summary>
        /// MEFPD.
        /// </summary>
        public const string MEFPD = "MEFPD";

        /// <summary>
        /// MEUPMJ.
        /// </summary>
        public const string MEUPMJ = "MEUPMJ";

        /// <summary>
        /// MEUPMT.
        /// </summary>
        public const string MEUPMT = "MEUPMT";

        /// <summary>
        /// MEJOBN.
        /// </summary>
        public const string MEJOBN = "MEJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F81A10";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MEPID", "MEPID", JdeDataType.String, 20, true, true),
        new JdeField("MELDFR", "MELDFR", JdeDataType.String, 20, true, true),
        new JdeField("MEVERS", "MEVERS", JdeDataType.String, 20, true, true),
        new JdeField("MEFPID", "MEFPID", JdeDataType.String, 20, true, true),
        new JdeField("MEBVER", "MEBVER", JdeDataType.String, 20, true, true),
        new JdeField("MESQN", "MESQN", JdeDataType.Numeric),
        new JdeField("MEOPT#", "MEOPT#", JdeDataType.Numeric, null, true, true),
        new JdeField("MEOBNM", "MEOBNM", JdeDataType.String, 20),
        new JdeField("MELPTP", "MELPTP", JdeDataType.String, 2),
        new JdeField("MELITN", "MELITN", JdeDataType.Numeric, null, true, true),
        new JdeField("MEBSQN", "MEBSQN", JdeDataType.Numeric, null, true, true),
        new JdeField("MELNGP", "MELNGP", JdeDataType.String, 4),
        new JdeField("MEQST", "MEQST", JdeDataType.String, 4),
        new JdeField("MEDTAI", "MEDTAI", JdeDataType.String, 20, true, true),
        new JdeField("MEDS01", "MEDS01", JdeDataType.String, 160),
        new JdeField("MEJOB#", "MEJOB#", JdeDataType.Numeric),
        new JdeField("MELMBN", "MELMBN", JdeDataType.Numeric, null, true, true),
        new JdeField("MELUS", "MELUS", JdeDataType.String, 20),
        new JdeField("MEFPD", "MEFPD", JdeDataType.String, 20),
        new JdeField("MEUPMJ", "MEUPMJ", JdeDataType.Numeric),
        new JdeField("MEUPMT", "MEUPMT", JdeDataType.Numeric),
        new JdeField("MEJOBN", "MEJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F81A10_0", "Primary Key on MELMBN, MELDFR, MEPID, MEVERS, MEFPID, MEBVER, MEDTAI, MEOPT#, MELITN, MEBSQN", new[] { "MELMBN", "MELDFR", "MEPID", "MEVERS", "MEFPID", "MEBVER", "MEDTAI", "MEOPT#", "MELITN", "MEBSQN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F81A10_2", "Index on MEJOB#", new[] { "MEJOB#" }),
        new JdeIndex("F81A10_3", "Index on MEOBNM, MELPTP, MELITN, MEBSQN, MELNGP", new[] { "MEOBNM", "MELPTP", "MELITN", "MEBSQN", "MELNGP" }),
        new JdeIndex("F81A10_4", "Index on MEFPID, MEBVER", new[] { "MEFPID", "MEBVER" }),
        new JdeIndex("F81A10_5", "Index on MELMBN, MEDTAI", new[] { "MELMBN", "MEDTAI" })
    };
}
