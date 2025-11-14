using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FH99PPOM - .
/// </summary>
public class FH99PPOM : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PMOMWPRJID.
        /// </summary>
        public const string PMOMWPRJID = "PMOMWPRJID";

        /// <summary>
        /// PMOMWUSER.
        /// </summary>
        public const string PMOMWUSER = "PMOMWUSER";

        /// <summary>
        /// PMSY.
        /// </summary>
        public const string PMSY = "PMSY";

        /// <summary>
        /// PMOMWOBJID.
        /// </summary>
        public const string PMOMWOBJID = "PMOMWOBJID";

        /// <summary>
        /// PMOMWOT.
        /// </summary>
        public const string PMOMWOT = "PMOMWOT";

        /// <summary>
        /// PMPATHCD.
        /// </summary>
        public const string PMPATHCD = "PMPATHCD";

        /// <summary>
        /// PMNRDMDJ.
        /// </summary>
        public const string PMNRDMDJ = "PMNRDMDJ";

        /// <summary>
        /// PMNRSDMDJ.
        /// </summary>
        public const string PMNRSDMDJ = "PMNRSDMDJ";

        /// <summary>
        /// PMPRCODJ.
        /// </summary>
        public const string PMPRCODJ = "PMPRCODJ";

        /// <summary>
        /// PMNRPCHDJ.
        /// </summary>
        public const string PMNRPCHDJ = "PMNRPCHDJ";

        /// <summary>
        /// PMLDPRJID.
        /// </summary>
        public const string PMLDPRJID = "PMLDPRJID";

        /// <summary>
        /// PMLDTDJ.
        /// </summary>
        public const string PMLDTDJ = "PMLDTDJ";

        /// <summary>
        /// PMNROCR.
        /// </summary>
        public const string PMNROCR = "PMNROCR";

        /// <summary>
        /// PMSRCRLS.
        /// </summary>
        public const string PMSRCRLS = "PMSRCRLS";

        /// <summary>
        /// PMCOMMENTS.
        /// </summary>
        public const string PMCOMMENTS = "PMCOMMENTS";

        /// <summary>
        /// PMPID.
        /// </summary>
        public const string PMPID = "PMPID";

        /// <summary>
        /// PMJOBS.
        /// </summary>
        public const string PMJOBS = "PMJOBS";

        /// <summary>
        /// PMUSER.
        /// </summary>
        public const string PMUSER = "PMUSER";

        /// <summary>
        /// PMUPMJ.
        /// </summary>
        public const string PMUPMJ = "PMUPMJ";

        /// <summary>
        /// PMUPMT.
        /// </summary>
        public const string PMUPMT = "PMUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "FH99PPOM";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PMOMWPRJID", "PMOMWPRJID", JdeDataType.String, 60),
        new JdeField("PMOMWUSER", "PMOMWUSER", JdeDataType.String, 20),
        new JdeField("PMSY", "PMSY", JdeDataType.String, 8),
        new JdeField("PMOMWOBJID", "PMOMWOBJID", JdeDataType.String, 400, true, true),
        new JdeField("PMOMWOT", "PMOMWOT", JdeDataType.String, 20, true, true),
        new JdeField("PMPATHCD", "PMPATHCD", JdeDataType.String, 20),
        new JdeField("PMNRDMDJ", "PMNRDMDJ", JdeDataType.Numeric),
        new JdeField("PMNRSDMDJ", "PMNRSDMDJ", JdeDataType.Numeric),
        new JdeField("PMPRCODJ", "PMPRCODJ", JdeDataType.Numeric),
        new JdeField("PMNRPCHDJ", "PMNRPCHDJ", JdeDataType.Numeric),
        new JdeField("PMLDPRJID", "PMLDPRJID", JdeDataType.String, 60),
        new JdeField("PMLDTDJ", "PMLDTDJ", JdeDataType.Numeric),
        new JdeField("PMNROCR", "PMNROCR", JdeDataType.String, 20),
        new JdeField("PMSRCRLS", "PMSRCRLS", JdeDataType.String, 20),
        new JdeField("PMCOMMENTS", "PMCOMMENTS", JdeDataType.String, 512),
        new JdeField("PMPID", "PMPID", JdeDataType.String, 20),
        new JdeField("PMJOBS", "PMJOBS", JdeDataType.Numeric),
        new JdeField("PMUSER", "PMUSER", JdeDataType.String, 20),
        new JdeField("PMUPMJ", "PMUPMJ", JdeDataType.Numeric),
        new JdeField("PMUPMT", "PMUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FH99PPOM_0", "Primary Key on PMOMWOT, PMOMWOBJID", new[] { "PMOMWOT", "PMOMWOBJID" }, isUnique: true, isPrimaryKey: true)
    };
}
